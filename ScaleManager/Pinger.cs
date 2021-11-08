using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Http;

namespace ScaleManager
{
    public partial class Pinger : UserControl
    {
        public Pinger()
        {
            InitializeComponent();
        }

        private void Pinger_Load(object sender, EventArgs e)
        {


        }

        public async void  start()
        {
            this.timer1.Enabled = true;
            this.timer1.Start();

           await runConnectionCheckingAsync();
        }

        public void stop()
        {
            this.timer1.Stop();
            this.timer1.Enabled = false;
            this.lblCenterState.Text = "Stop";
            this.lblCenterState.BackColor = Color.LightPink;
        }

        public string addressToGet { get; set; }

        public string ipToPing { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;

            var thisTimer = (System.Windows.Forms.Timer)sender;

            thisTimer.Enabled = false;

            _ = runConnectionCheckingAsync();


            btnRefresh.Enabled = true;

            thisTimer.Enabled = true;
        }


        private async Task runConnectionCheckingAsync()
        {

            try
            {
                if (addressToGet != null && addressToGet.Trim() != string.Empty)
                {
                    using (var client = new HttpClient())
                    {
                        var responseMessage = await client.GetAsync(addressToGet);

                        if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            SayOk();
                        }
                        else
                        {
                            NoOk();
                        }
                    }
                }
            }
            catch (Exception)
            {
                NoOk();
            }


            try
            {
                if (ipToPing != null && ipToPing.Trim() != string.Empty)
                {
                    using (var p = new Ping())
                    {
                        var pingReply = await p.SendPingAsync(ipToPing, 1000);

                        if (pingReply.Status == IPStatus.Success) SayOk(); else NoOk();
                    }
                }
            }
            catch (Exception)
            {
                NoOk();
            }

        }

        private void SayOk()
        {
            lblCenterState.Text = "Connected";
            lblCenterState.BackColor = Color.LightGreen;
        }

        private void NoOk()
        {
            lblCenterState.Text = "D.C.";
            lblCenterState.BackColor = Color.LightPink;
        }

        public string Title
        {
            get {return lblTitle.Text; }
            set {lblTitle.Text = value; }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void lblCenterState_Click(object sender, EventArgs e)
        {

        }
    }
}
