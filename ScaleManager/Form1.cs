using NewDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleScale.Data;
using Arvin.Net;
using Arvin.Model;

namespace ScaleManager
{
    public partial class Form1 : Form
    {

        List<scaleConfig> scaleConfig;
        List<Pinger> controlList;
        int activeControlCount;

        public Model db = new Model();

        public NewMahakScale mahakScale;

        netReceiptHeader lastReceiptHeader;

        IList<netReceiptDetail> lastReceiptDetails;
        int lastReceipt_No;

        public Form1()
        {
            InitializeComponent();

            #region mahak

            mahakScale = new NewMahakScale(true, "192.168.1.108", 20777, "", 0, true, true, true, true);

            if (!mahakScale.mahakScales[1].isPortOpen)
            {
                mahakScale = new NewMahakScale(true, "192.168.1.108", 20777, "", 0, true, true, true, true);
            }

            mahakScale.ReceiveSalePacketEvent += AppendSale_ReceiveHandler;
            mahakScale.FindScaleEvent += this.FindScale_ReceiveHandler;
            mahakScale.FindIPEvent += this.FindIP_ReceiveHandler;

            #endregion

            #region radin
            CommandResult result = CommandResult.ListEmpty;
            var m_obWorkstation = new Workstation();
            result = m_obWorkstation.Start("192.168.1.108", 20777, false);

            #endregion

            scaleConfig = new List<scaleConfig>();
            controlList = new List<Pinger>();

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"sites.txt");

            controlsLoad();

            scaleConfig = new List<scaleConfig>();
            string line;

            this.Text = file.ReadLine();

            while ((line = file.ReadLine()) != null)
            {
                if (line.Length < 4) break;
                var newConf = new scaleConfig();

                newConf.id = Int32.Parse(line.Split(';')[0]);

                newConf.Title = line.Split(';')[1];

                newConf.IP = line.Split(';')[2];

                newConf.httpAdress = line.Split(';')[3];

                scaleConfig.Add(newConf);

            };

            file.Close();

            activeControlCount = Math.Min(controlList.Count, scaleConfig.Count);

            for (int counter = 0; counter < controlList.Count; counter++)
            {
                if (counter < activeControlCount)
                {
                    var scale = scaleConfig.FirstOrDefault(c => c.id == counter + 1);
                    controlList[counter].Title = scale.Title;
                    controlList[counter].ipToPing = scale.IP;
                    controlList[counter].addressToGet = scale.httpAdress;
                }
                else
                {
                    controlList[counter].Visible = false;
                }
            };





        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //radin
        public delegate void OnInvoiceReceived(netReceiptHeader header, IList<netReceiptDetail> receiptDetail, int lastReceiptNo);

        //radin
        private void m_obWorkstation_InvoiceReceived(Workstation ws, netReceiptHeader header, IList<netReceiptDetail> receiptDetail, int lastReceiptNo)
        {
            lastReceiptHeader = header;
            lastReceiptDetails = receiptDetail;
            lastReceipt_No = lastReceiptNo;
            Invoke(new EventHandler(Ws_Data_RecieveFunction), ws);

        }
        //radin
        private void Ws_Data_RecieveFunction(object sender, EventArgs e)
        {
            Workstation wsread = sender as Workstation;
            var newSaleSend = new SaleSend();
            newSaleSend.date = wsread.LastReceiptHeader.Receipt_time;
            newSaleSend.factorNo = wsread.LastReceiptHeader.Receipt_no.ToString();
            newSaleSend.workStationNumber = wsread.LastReceiptHeader.Workstation_number;
            newSaleSend.ip = wsread.IPAddress;
            newSaleSend.serialNo = wsread.LastReceiptHeader.Serial_no;
            newSaleSend.totalDiscount_factor = wsread.LastReceiptHeader.Discount_supercharge;
            newSaleSend.totalPrice_factor = wsread.LastReceiptHeader.Total_amounts;
            newSaleSend.totalTax_factor = wsread.LastReceiptHeader.Total_tax;

            var SaleSend = db.saleSends.FirstOrDefault(c => c.date == newSaleSend.date
                                       && c.factorNo == newSaleSend.factorNo
                                       && c.ip == newSaleSend.ip);
            if (SaleSend == null)
            {
                db.saleSends.Add(newSaleSend);
                db.SaveChanges();
            }
            else
            {
                return;
            }

            foreach (var item in wsread.LastReceiptDetails)
            {
                var newSaleDetail = new SaleSendDetail();
                newSaleDetail.saleSendId = newSaleSend.id;
                newSaleDetail.memory = item.Product_id;
                newSaleDetail.serialNo = item.Serial_no;//??
                newSaleDetail.unitPrice = item.Price;
                newSaleDetail.totalPrice = item.Total_price;
                newSaleDetail.unitTax = item.Plu_tax;
                newSaleDetail.totalTax = item.Total_detail_tax;
                newSaleDetail.unitDiscount = item.Discount;
                newSaleDetail.totalDiscount = item.Total_discount;
                newSaleDetail.vazniOrTedadi = item.Unit == 87 ? (item.Unit == 81 ? 1 : 65) : 65;//??byte
                newSaleDetail.weight = item.Weight_quantity;
                newSaleDetail.count = item.Weight_quantity;
                newSaleDetail.itemNo = item.Receipt_no;//??

                db.saleSendDetails.Add(newSaleDetail);
                db.SaveChanges();
            }
        }
        //mahak
        private delegate void FindScaleDelegate(Object result, Int32 Id);
        //mahak
        private void FindScale_ReceiveHandler(Object result, Int32 Id)
        {
            //insert to db

        }
        //mahak
        private delegate void FindIPDelegate(Object result);

        //mahak
        private void FindIP_ReceiveHandler(Object result)
        {
            if (mahakScale.isActiveEventIP)
            {
                for (int i = 0; i < mahakScale.IPs.Length; i++)
                {
                    if (mahakScale.IPs[i] != null)
                    {
                        //insert to grid
                        //AppendComboIPs(mahakScale.IPs[i]);
                    }
                }
                mahakScale.isActiveEventIP = false;
            }
        }
        //mahak
        private delegate void AppendSaleDelegate(ref List<Object[]> result);

        //mahak
        private static bool AppendSale_ReceiveHandler(List<Object[]> result)
        {
            Model db = new Model();
            bool flag = false;
            for (int i = 0; i < result.Count; i++)
            {

                DateTime date = (DateTime)result[i][0];
                DateTime time = (DateTime)result[i][1];//Time

                var newSaleSend = new SaleSend();
                newSaleSend.date = new DateTime(date.Year, date.Month, date.Day,
                                                time.Hour, time.Minute, time.Second);

                newSaleSend.ip = (string)result[i][2];
                newSaleSend.factorNo = (string)result[i][4];
                newSaleSend.serialNo = (Int32)result[i][12];
                newSaleSend.scaleId = (Int32)result[i][9];
                var SaleSend = db.saleSends.FirstOrDefault(c => c.date == newSaleSend.date
                                       && c.factorNo == newSaleSend.factorNo
                                       && c.ip == newSaleSend.ip);
                if (SaleSend == null)
                {
                    db.saleSends.Add(newSaleSend);
                    db.SaveChanges();
                }
                else
                {
                    newSaleSend = SaleSend;
                }
                //result[i][13];//BsdNew
                //result[i][14];//Vazni

                var newSaleDetail = new SaleSendDetail();
                newSaleDetail.saleSendId = newSaleSend.id;
                newSaleDetail.memory = (Int32)result[i][3];
                newSaleDetail.vazniOrTedadi = (int)result[i][5];
                newSaleDetail.unitPrice = (double)result[i][6];
                newSaleDetail.weight = (double)result[i][7];
                newSaleDetail.totalPrice = (double)result[i][8];
                newSaleDetail.count = (Int32)result[i][10];
                newSaleDetail.itemNo = (Int32)result[i][11];

                db.saleSendDetails.Add(newSaleDetail);
                try
                {
                    db.SaveChanges();
                    result.RemoveAt(i);
                    flag = true;
                }
                catch (Exception)
                {

                }

            }

            return flag;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Visible = !btnStop.Visible;
            btnStart.Visible = !btnStart.Visible;

            foreach (var item in controlList)
            {
                item.start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Visible = !btnStop.Visible;
            btnStart.Visible = !btnStart.Visible;
            this.Close();

        }


        private void controlsLoad()
        {
            controlList.Add(pinger1);
            controlList.Add(pinger2);
            controlList.Add(pinger3);
            controlList.Add(pinger4);
            controlList.Add(pinger5);
            controlList.Add(pinger6);
            controlList.Add(pinger7);
            controlList.Add(pinger8);
            controlList.Add(pinger9);
            controlList.Add(pinger10);
            controlList.Add(pinger11);
            controlList.Add(pinger12);
            controlList.Add(pinger13);
            controlList.Add(pinger14);
            controlList.Add(pinger15);
            controlList.Add(pinger16);
            controlList.Add(pinger17);
            controlList.Add(pinger18);
            controlList.Add(pinger19);
            controlList.Add(pinger20);
            controlList.Add(pinger21);
            controlList.Add(pinger22);
            controlList.Add(pinger23);
            controlList.Add(pinger24);
            controlList.Add(pinger25);
            controlList.Add(pinger26);
            controlList.Add(pinger27);
        }

        ~Form1()
        {
            mahakScale.mahakScales[1].CloseConnection();

            mahakScale.Dispose();

            return;
        }

    }
}
