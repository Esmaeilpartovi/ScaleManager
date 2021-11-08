namespace ScaleManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pinger8 = new ScaleManager.Pinger();
            this.pinger7 = new ScaleManager.Pinger();
            this.pinger6 = new ScaleManager.Pinger();
            this.pinger5 = new ScaleManager.Pinger();
            this.pinger4 = new ScaleManager.Pinger();
            this.pinger2 = new ScaleManager.Pinger();
            this.pinger1 = new ScaleManager.Pinger();
            this.pinger3 = new ScaleManager.Pinger();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pinger27 = new ScaleManager.Pinger();
            this.pinger26 = new ScaleManager.Pinger();
            this.pinger25 = new ScaleManager.Pinger();
            this.pinger24 = new ScaleManager.Pinger();
            this.pinger23 = new ScaleManager.Pinger();
            this.pinger22 = new ScaleManager.Pinger();
            this.pinger21 = new ScaleManager.Pinger();
            this.pinger20 = new ScaleManager.Pinger();
            this.pinger19 = new ScaleManager.Pinger();
            this.pinger18 = new ScaleManager.Pinger();
            this.pinger17 = new ScaleManager.Pinger();
            this.pinger16 = new ScaleManager.Pinger();
            this.pinger15 = new ScaleManager.Pinger();
            this.pinger14 = new ScaleManager.Pinger();
            this.pinger13 = new ScaleManager.Pinger();
            this.pinger12 = new ScaleManager.Pinger();
            this.pinger11 = new ScaleManager.Pinger();
            this.pinger10 = new ScaleManager.Pinger();
            this.pinger9 = new ScaleManager.Pinger();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStart.Location = new System.Drawing.Point(1024, 560);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "شروع";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.BackColor = System.Drawing.Color.LightCoral;
            this.btnStop.Location = new System.Drawing.Point(1024, 518);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 28);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "توقف";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pinger8
            // 
            this.pinger8.addressToGet = "http://6.201.167.243:8228/api/check";
            this.pinger8.ipToPing = null;
            this.pinger8.Location = new System.Drawing.Point(703, 29);
            this.pinger8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger8.Name = "pinger8";
            this.pinger8.Size = new System.Drawing.Size(131, 165);
            this.pinger8.TabIndex = 10;
            this.pinger8.Title = "Boostan Server";
            // 
            // pinger7
            // 
            this.pinger7.addressToGet = "http://6.201.167.243:8228/api/check";
            this.pinger7.ipToPing = null;
            this.pinger7.Location = new System.Drawing.Point(838, 29);
            this.pinger7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger7.Name = "pinger7";
            this.pinger7.Size = new System.Drawing.Size(131, 165);
            this.pinger7.TabIndex = 9;
            this.pinger7.Title = "Boostan Server";
            // 
            // pinger6
            // 
            this.pinger6.addressToGet = "http://6.201.167.243:8228/api/check";
            this.pinger6.ipToPing = null;
            this.pinger6.Location = new System.Drawing.Point(545, 184);
            this.pinger6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger6.Name = "pinger6";
            this.pinger6.Size = new System.Drawing.Size(131, 165);
            this.pinger6.TabIndex = 8;
            this.pinger6.Title = "Boostan Server";
            // 
            // pinger5
            // 
            this.pinger5.addressToGet = "http://186.51.203.79:20888/api/check";
            this.pinger5.ipToPing = null;
            this.pinger5.Location = new System.Drawing.Point(696, 184);
            this.pinger5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger5.Name = "pinger5";
            this.pinger5.Size = new System.Drawing.Size(131, 164);
            this.pinger5.TabIndex = 7;
            this.pinger5.Title = "Main Site";
            // 
            // pinger4
            // 
            this.pinger4.addressToGet = "http://www.google.com";
            this.pinger4.ipToPing = null;
            this.pinger4.Location = new System.Drawing.Point(389, 17);
            this.pinger4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger4.Name = "pinger4";
            this.pinger4.Size = new System.Drawing.Size(130, 163);
            this.pinger4.TabIndex = 6;
            this.pinger4.Title = "Google";
            // 
            // pinger2
            // 
            this.pinger2.addressToGet = null;
            this.pinger2.ipToPing = "192.168.1.2";
            this.pinger2.Location = new System.Drawing.Point(697, 17);
            this.pinger2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger2.Name = "pinger2";
            this.pinger2.Size = new System.Drawing.Size(130, 163);
            this.pinger2.TabIndex = 5;
            this.pinger2.Title = "AccessPoint";
            // 
            // pinger1
            // 
            this.pinger1.addressToGet = null;
            this.pinger1.ipToPing = "192.168.1.1";
            this.pinger1.Location = new System.Drawing.Point(841, 17);
            this.pinger1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger1.Name = "pinger1";
            this.pinger1.Size = new System.Drawing.Size(130, 163);
            this.pinger1.TabIndex = 4;
            this.pinger1.Title = "Modem Ping";
            // 
            // pinger3
            // 
            this.pinger3.addressToGet = null;
            this.pinger3.ipToPing = "4.2.2.4";
            this.pinger3.Location = new System.Drawing.Point(545, 17);
            this.pinger3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger3.Name = "pinger3";
            this.pinger3.Size = new System.Drawing.Size(134, 163);
            this.pinger3.TabIndex = 3;
            this.pinger3.Title = "Internet Pinger";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 7);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1003, 609);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage1.Controls.Add(this.pinger1);
            this.tabPage1.Controls.Add(this.pinger2);
            this.tabPage1.Controls.Add(this.pinger3);
            this.tabPage1.Controls.Add(this.pinger6);
            this.tabPage1.Controls.Add(this.pinger4);
            this.tabPage1.Controls.Add(this.pinger5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(995, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ارتباطات";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SandyBrown;
            this.tabPage2.Controls.Add(this.pinger27);
            this.tabPage2.Controls.Add(this.pinger26);
            this.tabPage2.Controls.Add(this.pinger25);
            this.tabPage2.Controls.Add(this.pinger24);
            this.tabPage2.Controls.Add(this.pinger23);
            this.tabPage2.Controls.Add(this.pinger22);
            this.tabPage2.Controls.Add(this.pinger21);
            this.tabPage2.Controls.Add(this.pinger20);
            this.tabPage2.Controls.Add(this.pinger19);
            this.tabPage2.Controls.Add(this.pinger18);
            this.tabPage2.Controls.Add(this.pinger17);
            this.tabPage2.Controls.Add(this.pinger16);
            this.tabPage2.Controls.Add(this.pinger15);
            this.tabPage2.Controls.Add(this.pinger14);
            this.tabPage2.Controls.Add(this.pinger13);
            this.tabPage2.Controls.Add(this.pinger12);
            this.tabPage2.Controls.Add(this.pinger11);
            this.tabPage2.Controls.Add(this.pinger10);
            this.tabPage2.Controls.Add(this.pinger9);
            this.tabPage2.Controls.Add(this.pinger7);
            this.tabPage2.Controls.Add(this.pinger8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(995, 583);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ترازوها";
            // 
            // pinger27
            // 
            this.pinger27.addressToGet = null;
            this.pinger27.ipToPing = null;
            this.pinger27.Location = new System.Drawing.Point(24, 345);
            this.pinger27.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger27.Name = "pinger27";
            this.pinger27.Size = new System.Drawing.Size(131, 144);
            this.pinger27.TabIndex = 29;
            this.pinger27.Title = "Title";
            // 
            // pinger26
            // 
            this.pinger26.addressToGet = null;
            this.pinger26.ipToPing = null;
            this.pinger26.Location = new System.Drawing.Point(159, 345);
            this.pinger26.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger26.Name = "pinger26";
            this.pinger26.Size = new System.Drawing.Size(131, 144);
            this.pinger26.TabIndex = 28;
            this.pinger26.Title = "Title";
            // 
            // pinger25
            // 
            this.pinger25.addressToGet = null;
            this.pinger25.ipToPing = null;
            this.pinger25.Location = new System.Drawing.Point(294, 345);
            this.pinger25.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger25.Name = "pinger25";
            this.pinger25.Size = new System.Drawing.Size(131, 144);
            this.pinger25.TabIndex = 27;
            this.pinger25.Title = "Title";
            // 
            // pinger24
            // 
            this.pinger24.addressToGet = null;
            this.pinger24.ipToPing = null;
            this.pinger24.Location = new System.Drawing.Point(430, 345);
            this.pinger24.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger24.Name = "pinger24";
            this.pinger24.Size = new System.Drawing.Size(131, 144);
            this.pinger24.TabIndex = 26;
            this.pinger24.Title = "Title";
            // 
            // pinger23
            // 
            this.pinger23.addressToGet = null;
            this.pinger23.ipToPing = null;
            this.pinger23.Location = new System.Drawing.Point(567, 345);
            this.pinger23.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger23.Name = "pinger23";
            this.pinger23.Size = new System.Drawing.Size(131, 144);
            this.pinger23.TabIndex = 25;
            this.pinger23.Title = "Title";
            // 
            // pinger22
            // 
            this.pinger22.addressToGet = null;
            this.pinger22.ipToPing = null;
            this.pinger22.Location = new System.Drawing.Point(702, 345);
            this.pinger22.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger22.Name = "pinger22";
            this.pinger22.Size = new System.Drawing.Size(131, 144);
            this.pinger22.TabIndex = 24;
            this.pinger22.Title = "Title";
            // 
            // pinger21
            // 
            this.pinger21.addressToGet = null;
            this.pinger21.ipToPing = null;
            this.pinger21.Location = new System.Drawing.Point(838, 345);
            this.pinger21.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger21.Name = "pinger21";
            this.pinger21.Size = new System.Drawing.Size(131, 144);
            this.pinger21.TabIndex = 23;
            this.pinger21.Title = "Title";
            // 
            // pinger20
            // 
            this.pinger20.addressToGet = null;
            this.pinger20.ipToPing = null;
            this.pinger20.Location = new System.Drawing.Point(24, 184);
            this.pinger20.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger20.Name = "pinger20";
            this.pinger20.Size = new System.Drawing.Size(131, 144);
            this.pinger20.TabIndex = 22;
            this.pinger20.Title = "Title";
            // 
            // pinger19
            // 
            this.pinger19.addressToGet = null;
            this.pinger19.ipToPing = null;
            this.pinger19.Location = new System.Drawing.Point(159, 184);
            this.pinger19.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger19.Name = "pinger19";
            this.pinger19.Size = new System.Drawing.Size(131, 144);
            this.pinger19.TabIndex = 21;
            this.pinger19.Title = "Title";
            // 
            // pinger18
            // 
            this.pinger18.addressToGet = null;
            this.pinger18.ipToPing = null;
            this.pinger18.Location = new System.Drawing.Point(295, 184);
            this.pinger18.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger18.Name = "pinger18";
            this.pinger18.Size = new System.Drawing.Size(131, 144);
            this.pinger18.TabIndex = 20;
            this.pinger18.Title = "Title";
            // 
            // pinger17
            // 
            this.pinger17.addressToGet = null;
            this.pinger17.ipToPing = null;
            this.pinger17.Location = new System.Drawing.Point(433, 184);
            this.pinger17.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger17.Name = "pinger17";
            this.pinger17.Size = new System.Drawing.Size(131, 144);
            this.pinger17.TabIndex = 19;
            this.pinger17.Title = "Title";
            // 
            // pinger16
            // 
            this.pinger16.addressToGet = null;
            this.pinger16.ipToPing = null;
            this.pinger16.Location = new System.Drawing.Point(568, 184);
            this.pinger16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger16.Name = "pinger16";
            this.pinger16.Size = new System.Drawing.Size(131, 144);
            this.pinger16.TabIndex = 18;
            this.pinger16.Title = "Title";
            // 
            // pinger15
            // 
            this.pinger15.addressToGet = null;
            this.pinger15.ipToPing = null;
            this.pinger15.Location = new System.Drawing.Point(702, 184);
            this.pinger15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger15.Name = "pinger15";
            this.pinger15.Size = new System.Drawing.Size(131, 144);
            this.pinger15.TabIndex = 17;
            this.pinger15.Title = "Title";
            // 
            // pinger14
            // 
            this.pinger14.addressToGet = null;
            this.pinger14.ipToPing = null;
            this.pinger14.Location = new System.Drawing.Point(838, 184);
            this.pinger14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger14.Name = "pinger14";
            this.pinger14.Size = new System.Drawing.Size(131, 144);
            this.pinger14.TabIndex = 16;
            this.pinger14.Title = "Title";
            // 
            // pinger13
            // 
            this.pinger13.addressToGet = null;
            this.pinger13.ipToPing = null;
            this.pinger13.Location = new System.Drawing.Point(24, 31);
            this.pinger13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger13.Name = "pinger13";
            this.pinger13.Size = new System.Drawing.Size(131, 144);
            this.pinger13.TabIndex = 15;
            this.pinger13.Title = "Title";
            // 
            // pinger12
            // 
            this.pinger12.addressToGet = null;
            this.pinger12.ipToPing = null;
            this.pinger12.Location = new System.Drawing.Point(159, 31);
            this.pinger12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger12.Name = "pinger12";
            this.pinger12.Size = new System.Drawing.Size(131, 144);
            this.pinger12.TabIndex = 14;
            this.pinger12.Title = "Title";
            // 
            // pinger11
            // 
            this.pinger11.addressToGet = null;
            this.pinger11.ipToPing = null;
            this.pinger11.Location = new System.Drawing.Point(295, 32);
            this.pinger11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger11.Name = "pinger11";
            this.pinger11.Size = new System.Drawing.Size(131, 144);
            this.pinger11.TabIndex = 13;
            this.pinger11.Title = "Title";
            // 
            // pinger10
            // 
            this.pinger10.addressToGet = null;
            this.pinger10.ipToPing = null;
            this.pinger10.Location = new System.Drawing.Point(433, 31);
            this.pinger10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger10.Name = "pinger10";
            this.pinger10.Size = new System.Drawing.Size(131, 144);
            this.pinger10.TabIndex = 12;
            this.pinger10.Title = "Title";
            // 
            // pinger9
            // 
            this.pinger9.addressToGet = null;
            this.pinger9.ipToPing = null;
            this.pinger9.Location = new System.Drawing.Point(568, 31);
            this.pinger9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinger9.Name = "pinger9";
            this.pinger9.Size = new System.Drawing.Size(131, 144);
            this.pinger9.TabIndex = 11;
            this.pinger9.Title = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 611);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "---";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private Pinger pinger3;
        private Pinger pinger1;
        private Pinger pinger2;
        private Pinger pinger4;
        private Pinger pinger5;
        private Pinger pinger6;
        private Pinger pinger7;
        private Pinger pinger8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Pinger pinger27;
        private Pinger pinger26;
        private Pinger pinger25;
        private Pinger pinger24;
        private Pinger pinger23;
        private Pinger pinger22;
        private Pinger pinger21;
        private Pinger pinger20;
        private Pinger pinger19;
        private Pinger pinger18;
        private Pinger pinger17;
        private Pinger pinger16;
        private Pinger pinger15;
        private Pinger pinger14;
        private Pinger pinger13;
        private Pinger pinger12;
        private Pinger pinger11;
        private Pinger pinger10;
        private Pinger pinger9;
    }
}

