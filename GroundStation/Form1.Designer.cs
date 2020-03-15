namespace GroundStation
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cbxPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTx1 = new System.Windows.Forms.TextBox();
            this.tbxTx2 = new System.Windows.Forms.TextBox();
            this.tbxRx = new System.Windows.Forms.TextBox();
            this.panelTx1 = new System.Windows.Forms.Panel();
            this.rbtnSend1CHR = new System.Windows.Forms.RadioButton();
            this.rbtnSend1HEX = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxInterval = new System.Windows.Forms.TextBox();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.btnSend3 = new System.Windows.Forms.Button();
            this.panelTx2 = new System.Windows.Forms.Panel();
            this.rbtnSend2CHR = new System.Windows.Forms.RadioButton();
            this.rbtnSend2HEX = new System.Windows.Forms.RadioButton();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tmrPortChk = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbxTx3 = new System.Windows.Forms.TextBox();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.panelRx = new System.Windows.Forms.Panel();
            this.rbtnRcvCHR = new System.Windows.Forms.RadioButton();
            this.rbtnRcvHEX = new System.Windows.Forms.RadioButton();
            this.panelTx3 = new System.Windows.Forms.Panel();
            this.rbtnSend3CHR = new System.Windows.Forms.RadioButton();
            this.rbtnSend3HEX = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblGyroz = new System.Windows.Forms.Label();
            this.lblGyroy = new System.Windows.Forms.Label();
            this.lblGyrox = new System.Windows.Forms.Label();
            this.lblAccz = new System.Windows.Forms.Label();
            this.lblAccy = new System.Windows.Forms.Label();
            this.lblAccx = new System.Windows.Forms.Label();
            this.lblYaw = new System.Windows.Forms.Label();
            this.lblPitch = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.vScrollPit = new System.Windows.Forms.VScrollBar();
            this.vScrollThr = new System.Windows.Forms.VScrollBar();
            this.hScrollRol = new System.Windows.Forms.HScrollBar();
            this.hScrollYaw = new System.Windows.Forms.HScrollBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tmrSendUser = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tmrPortRcv = new System.Windows.Forms.Timer(this.components);
            this.labelTxCnt = new System.Windows.Forms.Label();
            this.labelRxCnt = new System.Windows.Forms.Label();
            this.btnClearBuf = new System.Windows.Forms.Button();
            this.btnReCnt = new System.Windows.Forms.Button();
            this.tmrCtrl = new System.Windows.Forms.Timer(this.components);
            this.panelTx1.SuspendLayout();
            this.panelTx2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelRx.SuspendLayout();
            this.panelTx3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxPort
            // 
            this.cbxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPort.FormattingEnabled = true;
            this.cbxPort.Location = new System.Drawing.Point(1129, 679);
            this.cbxPort.Name = "cbxPort";
            this.cbxPort.Size = new System.Drawing.Size(121, 23);
            this.cbxPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1086, 682);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(959, 679);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(901, 682);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            // 
            // tbxTx1
            // 
            this.tbxTx1.Location = new System.Drawing.Point(627, 6);
            this.tbxTx1.Multiline = true;
            this.tbxTx1.Name = "tbxTx1";
            this.tbxTx1.Size = new System.Drawing.Size(597, 329);
            this.tbxTx1.TabIndex = 7;
            // 
            // tbxTx2
            // 
            this.tbxTx2.Location = new System.Drawing.Point(627, 379);
            this.tbxTx2.Multiline = true;
            this.tbxTx2.Name = "tbxTx2";
            this.tbxTx2.Size = new System.Drawing.Size(597, 138);
            this.tbxTx2.TabIndex = 7;
            // 
            // tbxRx
            // 
            this.tbxRx.Location = new System.Drawing.Point(6, 6);
            this.tbxRx.Multiline = true;
            this.tbxRx.Name = "tbxRx";
            this.tbxRx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxRx.Size = new System.Drawing.Size(615, 576);
            this.tbxRx.TabIndex = 7;
            // 
            // panelTx1
            // 
            this.panelTx1.Controls.Add(this.rbtnSend1CHR);
            this.panelTx1.Controls.Add(this.rbtnSend1HEX);
            this.panelTx1.Location = new System.Drawing.Point(627, 345);
            this.panelTx1.Name = "panelTx1";
            this.panelTx1.Size = new System.Drawing.Size(119, 27);
            this.panelTx1.TabIndex = 8;
            // 
            // rbtnSend1CHR
            // 
            this.rbtnSend1CHR.AutoSize = true;
            this.rbtnSend1CHR.Location = new System.Drawing.Point(61, 3);
            this.rbtnSend1CHR.Name = "rbtnSend1CHR";
            this.rbtnSend1CHR.Size = new System.Drawing.Size(52, 19);
            this.rbtnSend1CHR.TabIndex = 0;
            this.rbtnSend1CHR.Text = "CHR";
            this.rbtnSend1CHR.UseVisualStyleBackColor = true;
            // 
            // rbtnSend1HEX
            // 
            this.rbtnSend1HEX.AutoSize = true;
            this.rbtnSend1HEX.Checked = true;
            this.rbtnSend1HEX.Location = new System.Drawing.Point(3, 3);
            this.rbtnSend1HEX.Name = "rbtnSend1HEX";
            this.rbtnSend1HEX.Size = new System.Drawing.Size(52, 19);
            this.rbtnSend1HEX.TabIndex = 0;
            this.rbtnSend1HEX.TabStop = true;
            this.rbtnSend1HEX.Text = "HEX";
            this.rbtnSend1HEX.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(752, 349);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "自动发送";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(847, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "发送间隔(ms)";
            // 
            // tbxInterval
            // 
            this.tbxInterval.Location = new System.Drawing.Point(952, 347);
            this.tbxInterval.Name = "tbxInterval";
            this.tbxInterval.Size = new System.Drawing.Size(92, 25);
            this.tbxInterval.TabIndex = 7;
            this.tbxInterval.Text = "1000";
            this.tbxInterval.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnSend1
            // 
            this.btnSend1.Location = new System.Drawing.Point(1050, 341);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(174, 32);
            this.btnSend1.TabIndex = 11;
            this.btnSend1.Text = "发送";
            this.btnSend1.UseVisualStyleBackColor = true;
            this.btnSend1.Click += new System.EventHandler(this.btnSend1_Click);
            // 
            // btnSend3
            // 
            this.btnSend3.Location = new System.Drawing.Point(1050, 584);
            this.btnSend3.Name = "btnSend3";
            this.btnSend3.Size = new System.Drawing.Size(174, 32);
            this.btnSend3.TabIndex = 11;
            this.btnSend3.Text = "发送";
            this.btnSend3.UseVisualStyleBackColor = true;
            this.btnSend3.Click += new System.EventHandler(this.btnSend3_Click);
            // 
            // panelTx2
            // 
            this.panelTx2.Controls.Add(this.rbtnSend2CHR);
            this.panelTx2.Controls.Add(this.rbtnSend2HEX);
            this.panelTx2.Location = new System.Drawing.Point(627, 523);
            this.panelTx2.Name = "panelTx2";
            this.panelTx2.Size = new System.Drawing.Size(119, 28);
            this.panelTx2.TabIndex = 8;
            // 
            // rbtnSend2CHR
            // 
            this.rbtnSend2CHR.AutoSize = true;
            this.rbtnSend2CHR.Location = new System.Drawing.Point(61, 3);
            this.rbtnSend2CHR.Name = "rbtnSend2CHR";
            this.rbtnSend2CHR.Size = new System.Drawing.Size(52, 19);
            this.rbtnSend2CHR.TabIndex = 0;
            this.rbtnSend2CHR.Text = "CHR";
            this.rbtnSend2CHR.UseVisualStyleBackColor = true;
            // 
            // rbtnSend2HEX
            // 
            this.rbtnSend2HEX.AutoSize = true;
            this.rbtnSend2HEX.Checked = true;
            this.rbtnSend2HEX.Location = new System.Drawing.Point(3, 3);
            this.rbtnSend2HEX.Name = "rbtnSend2HEX";
            this.rbtnSend2HEX.Size = new System.Drawing.Size(52, 19);
            this.rbtnSend2HEX.TabIndex = 0;
            this.rbtnSend2HEX.TabStop = true;
            this.rbtnSend2HEX.Text = "HEX";
            this.rbtnSend2HEX.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::GroundStation.Properties.Resources.ledoff;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(755, 669);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(140, 40);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "打开连接";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tmrPortChk
            // 
            this.tmrPortChk.Enabled = true;
            this.tmrPortChk.Interval = 1000;
            this.tmrPortChk.Tick += new System.EventHandler(this.tmrPortChk_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1238, 651);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbxTx3);
            this.tabPage1.Controls.Add(this.tbxTx1);
            this.tabPage1.Controls.Add(this.panelTx1);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnSend1);
            this.tabPage1.Controls.Add(this.btnSend2);
            this.tabPage1.Controls.Add(this.btnSend3);
            this.tabPage1.Controls.Add(this.tbxTx2);
            this.tabPage1.Controls.Add(this.tbxInterval);
            this.tabPage1.Controls.Add(this.tbxRx);
            this.tabPage1.Controls.Add(this.panelRx);
            this.tabPage1.Controls.Add(this.panelTx3);
            this.tabPage1.Controls.Add(this.panelTx2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1230, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本收发";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbxTx3
            // 
            this.tbxTx3.Location = new System.Drawing.Point(627, 557);
            this.tbxTx3.Name = "tbxTx3";
            this.tbxTx3.Size = new System.Drawing.Size(597, 25);
            this.tbxTx3.TabIndex = 12;
            // 
            // btnSend2
            // 
            this.btnSend2.Location = new System.Drawing.Point(1050, 519);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(174, 32);
            this.btnSend2.TabIndex = 11;
            this.btnSend2.Text = "发送";
            this.btnSend2.UseVisualStyleBackColor = true;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // panelRx
            // 
            this.panelRx.Controls.Add(this.rbtnRcvCHR);
            this.panelRx.Controls.Add(this.rbtnRcvHEX);
            this.panelRx.Location = new System.Drawing.Point(6, 588);
            this.panelRx.Name = "panelRx";
            this.panelRx.Size = new System.Drawing.Size(119, 28);
            this.panelRx.TabIndex = 8;
            // 
            // rbtnRcvCHR
            // 
            this.rbtnRcvCHR.AutoSize = true;
            this.rbtnRcvCHR.Location = new System.Drawing.Point(61, 3);
            this.rbtnRcvCHR.Name = "rbtnRcvCHR";
            this.rbtnRcvCHR.Size = new System.Drawing.Size(52, 19);
            this.rbtnRcvCHR.TabIndex = 0;
            this.rbtnRcvCHR.Text = "CHR";
            this.rbtnRcvCHR.UseVisualStyleBackColor = true;
            // 
            // rbtnRcvHEX
            // 
            this.rbtnRcvHEX.AutoSize = true;
            this.rbtnRcvHEX.Checked = true;
            this.rbtnRcvHEX.Location = new System.Drawing.Point(3, 3);
            this.rbtnRcvHEX.Name = "rbtnRcvHEX";
            this.rbtnRcvHEX.Size = new System.Drawing.Size(52, 19);
            this.rbtnRcvHEX.TabIndex = 0;
            this.rbtnRcvHEX.TabStop = true;
            this.rbtnRcvHEX.Text = "HEX";
            this.rbtnRcvHEX.UseVisualStyleBackColor = true;
            // 
            // panelTx3
            // 
            this.panelTx3.Controls.Add(this.rbtnSend3CHR);
            this.panelTx3.Controls.Add(this.rbtnSend3HEX);
            this.panelTx3.Location = new System.Drawing.Point(627, 588);
            this.panelTx3.Name = "panelTx3";
            this.panelTx3.Size = new System.Drawing.Size(119, 28);
            this.panelTx3.TabIndex = 8;
            // 
            // rbtnSend3CHR
            // 
            this.rbtnSend3CHR.AutoSize = true;
            this.rbtnSend3CHR.Location = new System.Drawing.Point(61, 3);
            this.rbtnSend3CHR.Name = "rbtnSend3CHR";
            this.rbtnSend3CHR.Size = new System.Drawing.Size(52, 19);
            this.rbtnSend3CHR.TabIndex = 0;
            this.rbtnSend3CHR.Text = "CHR";
            this.rbtnSend3CHR.UseVisualStyleBackColor = true;
            // 
            // rbtnSend3HEX
            // 
            this.rbtnSend3HEX.AutoSize = true;
            this.rbtnSend3HEX.Checked = true;
            this.rbtnSend3HEX.Location = new System.Drawing.Point(3, 3);
            this.rbtnSend3HEX.Name = "rbtnSend3HEX";
            this.rbtnSend3HEX.Size = new System.Drawing.Size(52, 19);
            this.rbtnSend3HEX.TabIndex = 0;
            this.rbtnSend3HEX.TabStop = true;
            this.rbtnSend3HEX.Text = "HEX";
            this.rbtnSend3HEX.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblGyroz);
            this.tabPage2.Controls.Add(this.lblGyroy);
            this.tabPage2.Controls.Add(this.lblGyrox);
            this.tabPage2.Controls.Add(this.lblAccz);
            this.tabPage2.Controls.Add(this.lblAccy);
            this.tabPage2.Controls.Add(this.lblAccx);
            this.tabPage2.Controls.Add(this.lblYaw);
            this.tabPage2.Controls.Add(this.lblPitch);
            this.tabPage2.Controls.Add(this.lblRoll);
            this.tabPage2.Controls.Add(this.lblPosition);
            this.tabPage2.Controls.Add(this.vScrollPit);
            this.tabPage2.Controls.Add(this.vScrollThr);
            this.tabPage2.Controls.Add(this.hScrollRol);
            this.tabPage2.Controls.Add(this.hScrollYaw);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1230, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "飞行控制";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblGyroz
            // 
            this.lblGyroz.AutoSize = true;
            this.lblGyroz.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGyroz.Location = new System.Drawing.Point(633, 484);
            this.lblGyroz.Name = "lblGyroz";
            this.lblGyroz.Size = new System.Drawing.Size(22, 24);
            this.lblGyroz.TabIndex = 9;
            this.lblGyroz.Text = "0";
            // 
            // lblGyroy
            // 
            this.lblGyroy.AutoSize = true;
            this.lblGyroy.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGyroy.Location = new System.Drawing.Point(633, 437);
            this.lblGyroy.Name = "lblGyroy";
            this.lblGyroy.Size = new System.Drawing.Size(22, 24);
            this.lblGyroy.TabIndex = 10;
            this.lblGyroy.Text = "0";
            // 
            // lblGyrox
            // 
            this.lblGyrox.AutoSize = true;
            this.lblGyrox.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGyrox.Location = new System.Drawing.Point(633, 386);
            this.lblGyrox.Name = "lblGyrox";
            this.lblGyrox.Size = new System.Drawing.Size(22, 24);
            this.lblGyrox.TabIndex = 11;
            this.lblGyrox.Text = "0";
            // 
            // lblAccz
            // 
            this.lblAccz.AutoSize = true;
            this.lblAccz.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAccz.Location = new System.Drawing.Point(633, 316);
            this.lblAccz.Name = "lblAccz";
            this.lblAccz.Size = new System.Drawing.Size(22, 24);
            this.lblAccz.TabIndex = 6;
            this.lblAccz.Text = "0";
            // 
            // lblAccy
            // 
            this.lblAccy.AutoSize = true;
            this.lblAccy.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAccy.Location = new System.Drawing.Point(633, 269);
            this.lblAccy.Name = "lblAccy";
            this.lblAccy.Size = new System.Drawing.Size(22, 24);
            this.lblAccy.TabIndex = 7;
            this.lblAccy.Text = "0";
            // 
            // lblAccx
            // 
            this.lblAccx.AutoSize = true;
            this.lblAccx.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAccx.Location = new System.Drawing.Point(633, 218);
            this.lblAccx.Name = "lblAccx";
            this.lblAccx.Size = new System.Drawing.Size(22, 24);
            this.lblAccx.TabIndex = 8;
            this.lblAccx.Text = "0";
            // 
            // lblYaw
            // 
            this.lblYaw.AutoSize = true;
            this.lblYaw.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblYaw.Location = new System.Drawing.Point(633, 147);
            this.lblYaw.Name = "lblYaw";
            this.lblYaw.Size = new System.Drawing.Size(22, 24);
            this.lblYaw.TabIndex = 5;
            this.lblYaw.Text = "0";
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPitch.Location = new System.Drawing.Point(633, 100);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(22, 24);
            this.lblPitch.TabIndex = 5;
            this.lblPitch.Text = "0";
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoll.Location = new System.Drawing.Point(633, 49);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(22, 24);
            this.lblRoll.TabIndex = 5;
            this.lblRoll.Text = "0";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPosition.Location = new System.Drawing.Point(472, 49);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(70, 456);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "Roll\r\n\r\nPitch\r\n\r\nYaw\r\n\r\n\r\naccx\r\n\r\naccy\r\n\r\naccz\r\n\r\n\r\ngyrox\r\n\r\ngyroy\r\n\r\ngyroz";
            // 
            // vScrollPit
            // 
            this.vScrollPit.LargeChange = 1;
            this.vScrollPit.Location = new System.Drawing.Point(943, 3);
            this.vScrollPit.Name = "vScrollPit";
            this.vScrollPit.Size = new System.Drawing.Size(49, 567);
            this.vScrollPit.TabIndex = 3;
            this.vScrollPit.Value = 50;
            // 
            // vScrollThr
            // 
            this.vScrollThr.LargeChange = 1;
            this.vScrollThr.Location = new System.Drawing.Point(253, 3);
            this.vScrollThr.Name = "vScrollThr";
            this.vScrollThr.Size = new System.Drawing.Size(49, 567);
            this.vScrollThr.TabIndex = 3;
            this.vScrollThr.Value = 100;
            // 
            // hScrollRol
            // 
            this.hScrollRol.LargeChange = 1;
            this.hScrollRol.Location = new System.Drawing.Point(627, 570);
            this.hScrollRol.Name = "hScrollRol";
            this.hScrollRol.Size = new System.Drawing.Size(600, 49);
            this.hScrollRol.TabIndex = 2;
            this.hScrollRol.Value = 50;
            // 
            // hScrollYaw
            // 
            this.hScrollYaw.LargeChange = 1;
            this.hScrollYaw.Location = new System.Drawing.Point(3, 570);
            this.hScrollYaw.Name = "hScrollYaw";
            this.hScrollYaw.Size = new System.Drawing.Size(600, 49);
            this.hScrollYaw.TabIndex = 2;
            this.hScrollYaw.Value = 50;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1230, 622);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "参数设置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tmrSendUser
            // 
            this.tmrSendUser.Tick += new System.EventHandler(this.tmrSendUser_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 682);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ground Station";
            // 
            // tmrPortRcv
            // 
            this.tmrPortRcv.Interval = 10;
            this.tmrPortRcv.Tick += new System.EventHandler(this.tmrPortRcv_Tick);
            // 
            // labelTxCnt
            // 
            this.labelTxCnt.AutoSize = true;
            this.labelTxCnt.Location = new System.Drawing.Point(598, 669);
            this.labelTxCnt.Name = "labelTxCnt";
            this.labelTxCnt.Size = new System.Drawing.Size(39, 15);
            this.labelTxCnt.TabIndex = 14;
            this.labelTxCnt.Text = "Tx:0";
            // 
            // labelRxCnt
            // 
            this.labelRxCnt.AutoSize = true;
            this.labelRxCnt.Location = new System.Drawing.Point(598, 694);
            this.labelRxCnt.Name = "labelRxCnt";
            this.labelRxCnt.Size = new System.Drawing.Size(39, 15);
            this.labelRxCnt.TabIndex = 14;
            this.labelRxCnt.Text = "Rx:0";
            // 
            // btnClearBuf
            // 
            this.btnClearBuf.Location = new System.Drawing.Point(370, 669);
            this.btnClearBuf.Name = "btnClearBuf";
            this.btnClearBuf.Size = new System.Drawing.Size(115, 40);
            this.btnClearBuf.TabIndex = 15;
            this.btnClearBuf.Text = "清除缓存";
            this.btnClearBuf.UseVisualStyleBackColor = true;
            this.btnClearBuf.Click += new System.EventHandler(this.btnClearBuf_Click);
            // 
            // btnReCnt
            // 
            this.btnReCnt.Location = new System.Drawing.Point(491, 669);
            this.btnReCnt.Name = "btnReCnt";
            this.btnReCnt.Size = new System.Drawing.Size(101, 40);
            this.btnReCnt.TabIndex = 15;
            this.btnReCnt.Text = "重新计数";
            this.btnReCnt.UseVisualStyleBackColor = true;
            this.btnReCnt.Click += new System.EventHandler(this.btnReCnt_Click);
            // 
            // tmrCtrl
            // 
            this.tmrCtrl.Tick += new System.EventHandler(this.tmrCtrl_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.btnReCnt);
            this.Controls.Add(this.btnClearBuf);
            this.Controls.Add(this.labelRxCnt);
            this.Controls.Add(this.labelTxCnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "地面站";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTx1.ResumeLayout(false);
            this.panelTx1.PerformLayout();
            this.panelTx2.ResumeLayout(false);
            this.panelTx2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelRx.ResumeLayout(false);
            this.panelRx.PerformLayout();
            this.panelTx3.ResumeLayout(false);
            this.panelTx3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cbxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tbxTx1;
        private System.Windows.Forms.TextBox tbxTx2;
        private System.Windows.Forms.TextBox tbxRx;
        private System.Windows.Forms.Panel panelTx1;
        private System.Windows.Forms.RadioButton rbtnSend1CHR;
        private System.Windows.Forms.RadioButton rbtnSend1HEX;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxInterval;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.Button btnSend3;
        private System.Windows.Forms.Panel panelTx2;
        private System.Windows.Forms.RadioButton rbtnSend2CHR;
        private System.Windows.Forms.RadioButton rbtnSend2HEX;
        private System.Windows.Forms.Timer tmrPortChk;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer tmrSendUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelRx;
        private System.Windows.Forms.RadioButton rbtnRcvCHR;
        private System.Windows.Forms.RadioButton rbtnRcvHEX;
        private System.Windows.Forms.Timer tmrPortRcv;
        private System.Windows.Forms.Label labelTxCnt;
        private System.Windows.Forms.Label labelRxCnt;
        private System.Windows.Forms.Button btnClearBuf;
        private System.Windows.Forms.Button btnReCnt;
        private System.Windows.Forms.Timer tmrCtrl;
        private System.Windows.Forms.TextBox tbxTx3;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.Panel panelTx3;
        private System.Windows.Forms.RadioButton rbtnSend3CHR;
        private System.Windows.Forms.RadioButton rbtnSend3HEX;
        private System.Windows.Forms.HScrollBar hScrollRol;
        private System.Windows.Forms.HScrollBar hScrollYaw;
        private System.Windows.Forms.VScrollBar vScrollPit;
        private System.Windows.Forms.VScrollBar vScrollThr;
        private System.Windows.Forms.Label lblGyroz;
        private System.Windows.Forms.Label lblGyroy;
        private System.Windows.Forms.Label lblGyrox;
        private System.Windows.Forms.Label lblAccz;
        private System.Windows.Forms.Label lblAccy;
        private System.Windows.Forms.Label lblAccx;
        private System.Windows.Forms.Label lblYaw;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label lblPosition;
    }
}

