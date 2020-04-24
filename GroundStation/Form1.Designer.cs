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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cbxPort1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxBaudRate1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTx1 = new System.Windows.Forms.TextBox();
            this.tbxTx2 = new System.Windows.Forms.TextBox();
            this.tbxRx = new System.Windows.Forms.TextBox();
            this.cbxAutoSend = new System.Windows.Forms.CheckBox();
            this.tbxInterval = new System.Windows.Forms.TextBox();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.btnSend3 = new System.Windows.Forms.Button();
            this.tmrPortChk = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbxHexRcv = new System.Windows.Forms.CheckBox();
            this.cbxHexSend3 = new System.Windows.Forms.CheckBox();
            this.cbxHexSend2 = new System.Windows.Forms.CheckBox();
            this.cbxHexSend1 = new System.Windows.Forms.CheckBox();
            this.tbxTx3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblCtrlThr = new System.Windows.Forms.Label();
            this.lblCtrlPit = new System.Windows.Forms.Label();
            this.lblCtrlRol = new System.Windows.Forms.Label();
            this.lblCtrlYaw = new System.Windows.Forms.Label();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.cbxMotor = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxBaudRate2 = new System.Windows.Forms.ComboBox();
            this.cbxRC = new System.Windows.Forms.CheckBox();
            this.cbxSensor = new System.Windows.Forms.CheckBox();
            this.cbxPort2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxStat = new System.Windows.Forms.CheckBox();
            this.cbxQuaternion = new System.Windows.Forms.CheckBox();
            this.cbxAtti = new System.Windows.Forms.CheckBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblVoltage = new System.Windows.Forms.Label();
            this.btnAttiMode = new System.Windows.Forms.Button();
            this.btnSpeedMode = new System.Windows.Forms.Button();
            this.btnUnLock = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.lblCtrl = new System.Windows.Forms.Label();
            this.lblLock = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblM4 = new System.Windows.Forms.Label();
            this.lblM3 = new System.Windows.Forms.Label();
            this.lblM2 = new System.Windows.Forms.Label();
            this.lblM1 = new System.Windows.Forms.Label();
            this.lblQ3 = new System.Windows.Forms.Label();
            this.lblRCyaw = new System.Windows.Forms.Label();
            this.lblQ2 = new System.Windows.Forms.Label();
            this.lblRCthr = new System.Windows.Forms.Label();
            this.lblQ1 = new System.Windows.Forms.Label();
            this.lblRCpit = new System.Windows.Forms.Label();
            this.lblQ0 = new System.Windows.Forms.Label();
            this.lblRCrol = new System.Windows.Forms.Label();
            this.lblGyroz = new System.Windows.Forms.Label();
            this.lblGyroy = new System.Windows.Forms.Label();
            this.lblGyrox = new System.Windows.Forms.Label();
            this.lblAccz = new System.Windows.Forms.Label();
            this.lblAccy = new System.Windows.Forms.Label();
            this.lblAccx = new System.Windows.Forms.Label();
            this.lblYaw = new System.Windows.Forms.Label();
            this.lblPitch = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vScrollPit = new System.Windows.Forms.VScrollBar();
            this.vScrollThr = new System.Windows.Forms.VScrollBar();
            this.hScrollRol = new System.Windows.Forms.HScrollBar();
            this.hScrollYaw = new System.Windows.Forms.HScrollBar();
            this.btnCtrl = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPitCName4 = new System.Windows.Forms.TextBox();
            this.tbxPitSName4 = new System.Windows.Forms.TextBox();
            this.tbxRolSName4 = new System.Windows.Forms.TextBox();
            this.tbxRolCName4 = new System.Windows.Forms.TextBox();
            this.tbxPitCName2 = new System.Windows.Forms.TextBox();
            this.tbxPitSName2 = new System.Windows.Forms.TextBox();
            this.tbxRolSName2 = new System.Windows.Forms.TextBox();
            this.tbxPitSName3 = new System.Windows.Forms.TextBox();
            this.tbxRolCName2 = new System.Windows.Forms.TextBox();
            this.tbxRolSName3 = new System.Windows.Forms.TextBox();
            this.tbxPitCName3 = new System.Windows.Forms.TextBox();
            this.tbxPitSName1 = new System.Windows.Forms.TextBox();
            this.tbxRolCName3 = new System.Windows.Forms.TextBox();
            this.tbxRolSName1 = new System.Windows.Forms.TextBox();
            this.tbxPitCName1 = new System.Windows.Forms.TextBox();
            this.tbxRolCName1 = new System.Windows.Forms.TextBox();
            this.cbxPitDisp = new System.Windows.Forms.CheckBox();
            this.cbxRolDisp = new System.Windows.Forms.CheckBox();
            this.btnReadPit = new System.Windows.Forms.Button();
            this.btnReadRol = new System.Windows.Forms.Button();
            this.btnAccCali = new System.Windows.Forms.Button();
            this.btnGyroCali = new System.Windows.Forms.Button();
            this.btnWritePit = new System.Windows.Forms.Button();
            this.btnWriteRol = new System.Windows.Forms.Button();
            this.tbxPitParam2 = new System.Windows.Forms.TextBox();
            this.tbxPitParam4 = new System.Windows.Forms.TextBox();
            this.tbxPitParam3 = new System.Windows.Forms.TextBox();
            this.tbxRolParam2 = new System.Windows.Forms.TextBox();
            this.tbxPitParam1 = new System.Windows.Forms.TextBox();
            this.tbxRolParam4 = new System.Windows.Forms.TextBox();
            this.tbxRolParam3 = new System.Windows.Forms.TextBox();
            this.lblPitParam4 = new System.Windows.Forms.Label();
            this.lblPitParam3 = new System.Windows.Forms.Label();
            this.tbxRolParam1 = new System.Windows.Forms.TextBox();
            this.lblPitParam2 = new System.Windows.Forms.Label();
            this.lblPitSt4 = new System.Windows.Forms.Label();
            this.lblPitSt3 = new System.Windows.Forms.Label();
            this.lblRolSt4 = new System.Windows.Forms.Label();
            this.lblRolSt3 = new System.Windows.Forms.Label();
            this.lblPitSt2 = new System.Windows.Forms.Label();
            this.lblRolParam4 = new System.Windows.Forms.Label();
            this.lblRolParam3 = new System.Windows.Forms.Label();
            this.lblRolSt2 = new System.Windows.Forms.Label();
            this.lblPitSt1 = new System.Windows.Forms.Label();
            this.lblPitParam1 = new System.Windows.Forms.Label();
            this.lblRolSt1 = new System.Windows.Forms.Label();
            this.lblRolParam2 = new System.Windows.Forms.Label();
            this.lblRolParam1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cbxDisp = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tmrSendUser = new System.Windows.Forms.Timer(this.components);
            this.lblVersion = new System.Windows.Forms.Label();
            this.labelTxCnt = new System.Windows.Forms.Label();
            this.labelRxCnt = new System.Windows.Forms.Label();
            this.btnClearBuf = new System.Windows.Forms.Button();
            this.btnReCnt = new System.Windows.Forms.Button();
            this.tmrCtrl = new System.Windows.Forms.Timer(this.components);
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.tmrPortRcv = new System.Windows.Forms.Timer(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ReadBufferSize = 1024;
            this.serialPort1.WriteBufferSize = 128;
            // 
            // cbxPort1
            // 
            this.cbxPort1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPort1.FormattingEnabled = true;
            this.cbxPort1.Location = new System.Drawing.Point(1129, 679);
            this.cbxPort1.Name = "cbxPort1";
            this.cbxPort1.Size = new System.Drawing.Size(121, 23);
            this.cbxPort1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1086, 682);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "端口";
            // 
            // cbxBaudRate1
            // 
            this.cbxBaudRate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaudRate1.FormattingEnabled = true;
            this.cbxBaudRate1.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.cbxBaudRate1.Location = new System.Drawing.Point(959, 679);
            this.cbxBaudRate1.Name = "cbxBaudRate1";
            this.cbxBaudRate1.Size = new System.Drawing.Size(121, 23);
            this.cbxBaudRate1.TabIndex = 1;
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
            // cbxAutoSend
            // 
            this.cbxAutoSend.AutoSize = true;
            this.cbxAutoSend.Location = new System.Drawing.Point(760, 348);
            this.cbxAutoSend.Name = "cbxAutoSend";
            this.cbxAutoSend.Size = new System.Drawing.Size(89, 19);
            this.cbxAutoSend.TabIndex = 9;
            this.cbxAutoSend.Text = "自动发送";
            this.cbxAutoSend.UseVisualStyleBackColor = true;
            this.cbxAutoSend.CheckedChanged += new System.EventHandler(this.cbxAutoSend_CheckedChanged);
            // 
            // tbxInterval
            // 
            this.tbxInterval.Location = new System.Drawing.Point(960, 342);
            this.tbxInterval.Name = "tbxInterval";
            this.tbxInterval.Size = new System.Drawing.Size(92, 25);
            this.tbxInterval.TabIndex = 7;
            this.tbxInterval.Text = "1000";
            this.tbxInterval.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnSend1
            // 
            this.btnSend1.Location = new System.Drawing.Point(1058, 341);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(166, 32);
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
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1238, 651);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbxHexRcv);
            this.tabPage1.Controls.Add(this.cbxHexSend3);
            this.tabPage1.Controls.Add(this.cbxHexSend2);
            this.tabPage1.Controls.Add(this.cbxHexSend1);
            this.tabPage1.Controls.Add(this.tbxTx3);
            this.tabPage1.Controls.Add(this.tbxTx1);
            this.tabPage1.Controls.Add(this.cbxAutoSend);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnSend1);
            this.tabPage1.Controls.Add(this.btnSend2);
            this.tabPage1.Controls.Add(this.btnSend3);
            this.tabPage1.Controls.Add(this.tbxTx2);
            this.tabPage1.Controls.Add(this.tbxInterval);
            this.tabPage1.Controls.Add(this.tbxRx);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1230, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本收发";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbxHexRcv
            // 
            this.cbxHexRcv.AutoSize = true;
            this.cbxHexRcv.Checked = true;
            this.cbxHexRcv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxHexRcv.Location = new System.Drawing.Point(6, 592);
            this.cbxHexRcv.Name = "cbxHexRcv";
            this.cbxHexRcv.Size = new System.Drawing.Size(83, 19);
            this.cbxHexRcv.TabIndex = 13;
            this.cbxHexRcv.Text = "HEX显示";
            this.cbxHexRcv.UseVisualStyleBackColor = true;
            // 
            // cbxHexSend3
            // 
            this.cbxHexSend3.AutoSize = true;
            this.cbxHexSend3.Checked = true;
            this.cbxHexSend3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxHexSend3.Location = new System.Drawing.Point(627, 592);
            this.cbxHexSend3.Name = "cbxHexSend3";
            this.cbxHexSend3.Size = new System.Drawing.Size(83, 19);
            this.cbxHexSend3.TabIndex = 13;
            this.cbxHexSend3.Text = "HEX发送";
            this.cbxHexSend3.UseVisualStyleBackColor = true;
            // 
            // cbxHexSend2
            // 
            this.cbxHexSend2.AutoSize = true;
            this.cbxHexSend2.Checked = true;
            this.cbxHexSend2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxHexSend2.Location = new System.Drawing.Point(627, 527);
            this.cbxHexSend2.Name = "cbxHexSend2";
            this.cbxHexSend2.Size = new System.Drawing.Size(83, 19);
            this.cbxHexSend2.TabIndex = 13;
            this.cbxHexSend2.Text = "HEX发送";
            this.cbxHexSend2.UseVisualStyleBackColor = true;
            // 
            // cbxHexSend1
            // 
            this.cbxHexSend1.AutoSize = true;
            this.cbxHexSend1.Checked = true;
            this.cbxHexSend1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxHexSend1.Location = new System.Drawing.Point(628, 348);
            this.cbxHexSend1.Name = "cbxHexSend1";
            this.cbxHexSend1.Size = new System.Drawing.Size(83, 19);
            this.cbxHexSend1.TabIndex = 13;
            this.cbxHexSend1.Text = "HEX发送";
            this.cbxHexSend1.UseVisualStyleBackColor = true;
            // 
            // tbxTx3
            // 
            this.tbxTx3.Location = new System.Drawing.Point(627, 557);
            this.tbxTx3.Name = "tbxTx3";
            this.tbxTx3.Size = new System.Drawing.Size(597, 25);
            this.tbxTx3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(855, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "发送间隔(ms)";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblMode);
            this.tabPage2.Controls.Add(this.lblCtrlThr);
            this.tabPage2.Controls.Add(this.lblCtrlPit);
            this.tabPage2.Controls.Add(this.lblCtrlRol);
            this.tabPage2.Controls.Add(this.lblCtrlYaw);
            this.tabPage2.Controls.Add(this.btnOpen2);
            this.tabPage2.Controls.Add(this.cbxMotor);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.cbxBaudRate2);
            this.tabPage2.Controls.Add(this.cbxRC);
            this.tabPage2.Controls.Add(this.cbxSensor);
            this.tabPage2.Controls.Add(this.cbxPort2);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.cbxStat);
            this.tabPage2.Controls.Add(this.cbxQuaternion);
            this.tabPage2.Controls.Add(this.cbxAtti);
            this.tabPage2.Controls.Add(this.tbxPassword);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.lblVoltage);
            this.tabPage2.Controls.Add(this.btnAttiMode);
            this.tabPage2.Controls.Add(this.btnSpeedMode);
            this.tabPage2.Controls.Add(this.btnUnLock);
            this.tabPage2.Controls.Add(this.btnLock);
            this.tabPage2.Controls.Add(this.lblCtrl);
            this.tabPage2.Controls.Add(this.lblLock);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lblM4);
            this.tabPage2.Controls.Add(this.lblM3);
            this.tabPage2.Controls.Add(this.lblM2);
            this.tabPage2.Controls.Add(this.lblM1);
            this.tabPage2.Controls.Add(this.lblQ3);
            this.tabPage2.Controls.Add(this.lblRCyaw);
            this.tabPage2.Controls.Add(this.lblQ2);
            this.tabPage2.Controls.Add(this.lblRCthr);
            this.tabPage2.Controls.Add(this.lblQ1);
            this.tabPage2.Controls.Add(this.lblRCpit);
            this.tabPage2.Controls.Add(this.lblQ0);
            this.tabPage2.Controls.Add(this.lblRCrol);
            this.tabPage2.Controls.Add(this.lblGyroz);
            this.tabPage2.Controls.Add(this.lblGyroy);
            this.tabPage2.Controls.Add(this.lblGyrox);
            this.tabPage2.Controls.Add(this.lblAccz);
            this.tabPage2.Controls.Add(this.lblAccy);
            this.tabPage2.Controls.Add(this.lblAccx);
            this.tabPage2.Controls.Add(this.lblYaw);
            this.tabPage2.Controls.Add(this.lblPitch);
            this.tabPage2.Controls.Add(this.lblRoll);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.vScrollPit);
            this.tabPage2.Controls.Add(this.vScrollThr);
            this.tabPage2.Controls.Add(this.hScrollRol);
            this.tabPage2.Controls.Add(this.hScrollYaw);
            this.tabPage2.Controls.Add(this.btnCtrl);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1230, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "飞行控制";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMode.Location = new System.Drawing.Point(6, 112);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(106, 24);
            this.lblMode.TabIndex = 23;
            this.lblMode.Text = "姿态模式";
            // 
            // lblCtrlThr
            // 
            this.lblCtrlThr.AutoSize = true;
            this.lblCtrlThr.Location = new System.Drawing.Point(243, 280);
            this.lblCtrlThr.Name = "lblCtrlThr";
            this.lblCtrlThr.Size = new System.Drawing.Size(15, 15);
            this.lblCtrlThr.TabIndex = 21;
            this.lblCtrlThr.Text = "0";
            // 
            // lblCtrlPit
            // 
            this.lblCtrlPit.AutoSize = true;
            this.lblCtrlPit.Location = new System.Drawing.Point(848, 280);
            this.lblCtrlPit.Name = "lblCtrlPit";
            this.lblCtrlPit.Size = new System.Drawing.Size(31, 15);
            this.lblCtrlPit.TabIndex = 21;
            this.lblCtrlPit.Text = "500";
            // 
            // lblCtrlRol
            // 
            this.lblCtrlRol.AutoSize = true;
            this.lblCtrlRol.Location = new System.Drawing.Point(1070, 552);
            this.lblCtrlRol.Name = "lblCtrlRol";
            this.lblCtrlRol.Size = new System.Drawing.Size(31, 15);
            this.lblCtrlRol.TabIndex = 21;
            this.lblCtrlRol.Text = "500";
            // 
            // lblCtrlYaw
            // 
            this.lblCtrlYaw.AutoSize = true;
            this.lblCtrlYaw.Location = new System.Drawing.Point(406, 552);
            this.lblCtrlYaw.Name = "lblCtrlYaw";
            this.lblCtrlYaw.Size = new System.Drawing.Size(31, 15);
            this.lblCtrlYaw.TabIndex = 21;
            this.lblCtrlYaw.Text = "500";
            // 
            // btnOpen2
            // 
            this.btnOpen2.Image = global::GroundStation.Properties.Resources.ledoff;
            this.btnOpen2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen2.Location = new System.Drawing.Point(1065, 174);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(140, 40);
            this.btnOpen2.TabIndex = 2;
            this.btnOpen2.Text = "打开连接";
            this.btnOpen2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen2.UseVisualStyleBackColor = true;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
            // 
            // cbxMotor
            // 
            this.cbxMotor.AutoSize = true;
            this.cbxMotor.Location = new System.Drawing.Point(154, 448);
            this.cbxMotor.Name = "cbxMotor";
            this.cbxMotor.Size = new System.Drawing.Size(89, 19);
            this.cbxMotor.TabIndex = 20;
            this.cbxMotor.Text = "油门显示";
            this.cbxMotor.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1012, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "波特率";
            // 
            // cbxBaudRate2
            // 
            this.cbxBaudRate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaudRate2.FormattingEnabled = true;
            this.cbxBaudRate2.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.cbxBaudRate2.Location = new System.Drawing.Point(1084, 129);
            this.cbxBaudRate2.Name = "cbxBaudRate2";
            this.cbxBaudRate2.Size = new System.Drawing.Size(121, 23);
            this.cbxBaudRate2.TabIndex = 1;
            // 
            // cbxRC
            // 
            this.cbxRC.AutoSize = true;
            this.cbxRC.Location = new System.Drawing.Point(154, 364);
            this.cbxRC.Name = "cbxRC";
            this.cbxRC.Size = new System.Drawing.Size(119, 19);
            this.cbxRC.TabIndex = 20;
            this.cbxRC.Text = "遥控信号显示";
            this.cbxRC.UseVisualStyleBackColor = true;
            // 
            // cbxSensor
            // 
            this.cbxSensor.AutoSize = true;
            this.cbxSensor.Location = new System.Drawing.Point(154, 258);
            this.cbxSensor.Name = "cbxSensor";
            this.cbxSensor.Size = new System.Drawing.Size(104, 19);
            this.cbxSensor.TabIndex = 20;
            this.cbxSensor.Text = "传感器显示";
            this.cbxSensor.UseVisualStyleBackColor = true;
            // 
            // cbxPort2
            // 
            this.cbxPort2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPort2.FormattingEnabled = true;
            this.cbxPort2.Location = new System.Drawing.Point(1084, 91);
            this.cbxPort2.Name = "cbxPort2";
            this.cbxPort2.Size = new System.Drawing.Size(121, 23);
            this.cbxPort2.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1053, -375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "端口";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1027, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "端口";
            // 
            // cbxStat
            // 
            this.cbxStat.AutoSize = true;
            this.cbxStat.Checked = true;
            this.cbxStat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxStat.Location = new System.Drawing.Point(154, 12);
            this.cbxStat.Name = "cbxStat";
            this.cbxStat.Size = new System.Drawing.Size(89, 19);
            this.cbxStat.TabIndex = 20;
            this.cbxStat.Text = "状态显示";
            this.cbxStat.UseVisualStyleBackColor = true;
            // 
            // cbxQuaternion
            // 
            this.cbxQuaternion.AutoSize = true;
            this.cbxQuaternion.Location = new System.Drawing.Point(154, 526);
            this.cbxQuaternion.Name = "cbxQuaternion";
            this.cbxQuaternion.Size = new System.Drawing.Size(104, 19);
            this.cbxQuaternion.TabIndex = 20;
            this.cbxQuaternion.Text = "四元数显示";
            this.cbxQuaternion.UseVisualStyleBackColor = true;
            // 
            // cbxAtti
            // 
            this.cbxAtti.AutoSize = true;
            this.cbxAtti.Location = new System.Drawing.Point(154, 184);
            this.cbxAtti.Name = "cbxAtti";
            this.cbxAtti.Size = new System.Drawing.Size(89, 19);
            this.cbxAtti.TabIndex = 20;
            this.cbxAtti.Text = "姿态显示";
            this.cbxAtti.UseVisualStyleBackColor = true;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(772, 429);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(100, 25);
            this.tbxPassword.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(699, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "解锁密码";
            // 
            // lblVoltage
            // 
            this.lblVoltage.AutoSize = true;
            this.lblVoltage.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblVoltage.ForeColor = System.Drawing.Color.Black;
            this.lblVoltage.Location = new System.Drawing.Point(150, 112);
            this.lblVoltage.Name = "lblVoltage";
            this.lblVoltage.Size = new System.Drawing.Size(34, 24);
            this.lblVoltage.TabIndex = 17;
            this.lblVoltage.Text = "0V";
            // 
            // btnAttiMode
            // 
            this.btnAttiMode.Location = new System.Drawing.Point(666, 522);
            this.btnAttiMode.Name = "btnAttiMode";
            this.btnAttiMode.Size = new System.Drawing.Size(100, 43);
            this.btnAttiMode.TabIndex = 16;
            this.btnAttiMode.Text = "姿态模式";
            this.btnAttiMode.UseVisualStyleBackColor = true;
            this.btnAttiMode.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnSpeedMode
            // 
            this.btnSpeedMode.Location = new System.Drawing.Point(772, 522);
            this.btnSpeedMode.Name = "btnSpeedMode";
            this.btnSpeedMode.Size = new System.Drawing.Size(100, 43);
            this.btnSpeedMode.TabIndex = 16;
            this.btnSpeedMode.Text = "速度模式";
            this.btnSpeedMode.UseVisualStyleBackColor = true;
            this.btnSpeedMode.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnUnLock
            // 
            this.btnUnLock.Location = new System.Drawing.Point(772, 473);
            this.btnUnLock.Name = "btnUnLock";
            this.btnUnLock.Size = new System.Drawing.Size(100, 43);
            this.btnUnLock.TabIndex = 16;
            this.btnUnLock.Text = "解锁";
            this.btnUnLock.UseVisualStyleBackColor = true;
            this.btnUnLock.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(666, 473);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(100, 43);
            this.btnLock.TabIndex = 16;
            this.btnLock.Text = "锁定";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // lblCtrl
            // 
            this.lblCtrl.AutoSize = true;
            this.lblCtrl.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCtrl.ForeColor = System.Drawing.Color.Red;
            this.lblCtrl.Location = new System.Drawing.Point(150, 55);
            this.lblCtrl.Name = "lblCtrl";
            this.lblCtrl.Size = new System.Drawing.Size(58, 24);
            this.lblCtrl.TabIndex = 15;
            this.lblCtrl.Text = "失控";
            // 
            // lblLock
            // 
            this.lblLock.AutoSize = true;
            this.lblLock.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLock.ForeColor = System.Drawing.Color.Red;
            this.lblLock.Location = new System.Drawing.Point(8, 55);
            this.lblLock.Name = "lblLock";
            this.lblLock.Size = new System.Drawing.Size(58, 24);
            this.lblLock.TabIndex = 14;
            this.lblLock.Text = "锁定";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(969, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "外部遥控信号输入";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "飞行状态";
            // 
            // lblM4
            // 
            this.lblM4.AutoSize = true;
            this.lblM4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblM4.Location = new System.Drawing.Point(73, 468);
            this.lblM4.Name = "lblM4";
            this.lblM4.Size = new System.Drawing.Size(15, 15);
            this.lblM4.TabIndex = 9;
            this.lblM4.Text = "0";
            this.lblM4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblM3
            // 
            this.lblM3.AutoSize = true;
            this.lblM3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblM3.Location = new System.Drawing.Point(73, 454);
            this.lblM3.Name = "lblM3";
            this.lblM3.Size = new System.Drawing.Size(15, 15);
            this.lblM3.TabIndex = 9;
            this.lblM3.Text = "0";
            this.lblM3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblM2
            // 
            this.lblM2.AutoSize = true;
            this.lblM2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblM2.Location = new System.Drawing.Point(73, 439);
            this.lblM2.Name = "lblM2";
            this.lblM2.Size = new System.Drawing.Size(15, 15);
            this.lblM2.TabIndex = 9;
            this.lblM2.Text = "0";
            this.lblM2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblM1
            // 
            this.lblM1.AutoSize = true;
            this.lblM1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblM1.Location = new System.Drawing.Point(73, 424);
            this.lblM1.Name = "lblM1";
            this.lblM1.Size = new System.Drawing.Size(15, 15);
            this.lblM1.TabIndex = 9;
            this.lblM1.Text = "0";
            this.lblM1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblQ3
            // 
            this.lblQ3.AutoSize = true;
            this.lblQ3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQ3.Location = new System.Drawing.Point(73, 545);
            this.lblQ3.Name = "lblQ3";
            this.lblQ3.Size = new System.Drawing.Size(15, 15);
            this.lblQ3.TabIndex = 9;
            this.lblQ3.Text = "0";
            this.lblQ3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRCyaw
            // 
            this.lblRCyaw.AutoSize = true;
            this.lblRCyaw.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRCyaw.Location = new System.Drawing.Point(73, 394);
            this.lblRCyaw.Name = "lblRCyaw";
            this.lblRCyaw.Size = new System.Drawing.Size(15, 15);
            this.lblRCyaw.TabIndex = 9;
            this.lblRCyaw.Text = "0";
            this.lblRCyaw.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblQ2
            // 
            this.lblQ2.AutoSize = true;
            this.lblQ2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQ2.Location = new System.Drawing.Point(73, 530);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Size = new System.Drawing.Size(15, 15);
            this.lblQ2.TabIndex = 9;
            this.lblQ2.Text = "0";
            this.lblQ2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRCthr
            // 
            this.lblRCthr.AutoSize = true;
            this.lblRCthr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRCthr.Location = new System.Drawing.Point(73, 379);
            this.lblRCthr.Name = "lblRCthr";
            this.lblRCthr.Size = new System.Drawing.Size(15, 15);
            this.lblRCthr.TabIndex = 9;
            this.lblRCthr.Text = "0";
            this.lblRCthr.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblQ1
            // 
            this.lblQ1.AutoSize = true;
            this.lblQ1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQ1.Location = new System.Drawing.Point(73, 515);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Size = new System.Drawing.Size(15, 15);
            this.lblQ1.TabIndex = 9;
            this.lblQ1.Text = "0";
            this.lblQ1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRCpit
            // 
            this.lblRCpit.AutoSize = true;
            this.lblRCpit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRCpit.Location = new System.Drawing.Point(73, 364);
            this.lblRCpit.Name = "lblRCpit";
            this.lblRCpit.Size = new System.Drawing.Size(15, 15);
            this.lblRCpit.TabIndex = 9;
            this.lblRCpit.Text = "0";
            this.lblRCpit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblQ0
            // 
            this.lblQ0.AutoSize = true;
            this.lblQ0.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQ0.Location = new System.Drawing.Point(73, 500);
            this.lblQ0.Name = "lblQ0";
            this.lblQ0.Size = new System.Drawing.Size(15, 15);
            this.lblQ0.TabIndex = 9;
            this.lblQ0.Text = "0";
            this.lblQ0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRCrol
            // 
            this.lblRCrol.AutoSize = true;
            this.lblRCrol.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRCrol.Location = new System.Drawing.Point(73, 349);
            this.lblRCrol.Name = "lblRCrol";
            this.lblRCrol.Size = new System.Drawing.Size(15, 15);
            this.lblRCrol.TabIndex = 9;
            this.lblRCrol.Text = "0";
            this.lblRCrol.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGyroz
            // 
            this.lblGyroz.AutoSize = true;
            this.lblGyroz.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGyroz.Location = new System.Drawing.Point(73, 320);
            this.lblGyroz.Name = "lblGyroz";
            this.lblGyroz.Size = new System.Drawing.Size(15, 15);
            this.lblGyroz.TabIndex = 9;
            this.lblGyroz.Text = "0";
            this.lblGyroz.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGyroy
            // 
            this.lblGyroy.AutoSize = true;
            this.lblGyroy.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGyroy.Location = new System.Drawing.Point(73, 305);
            this.lblGyroy.Name = "lblGyroy";
            this.lblGyroy.Size = new System.Drawing.Size(15, 15);
            this.lblGyroy.TabIndex = 10;
            this.lblGyroy.Text = "0";
            this.lblGyroy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGyrox
            // 
            this.lblGyrox.AutoSize = true;
            this.lblGyrox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGyrox.Location = new System.Drawing.Point(73, 290);
            this.lblGyrox.Name = "lblGyrox";
            this.lblGyrox.Size = new System.Drawing.Size(15, 15);
            this.lblGyrox.TabIndex = 11;
            this.lblGyrox.Text = "0";
            this.lblGyrox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAccz
            // 
            this.lblAccz.AutoSize = true;
            this.lblAccz.Font = new System.Drawing.Font("宋体", 9F);
            this.lblAccz.Location = new System.Drawing.Point(73, 259);
            this.lblAccz.Name = "lblAccz";
            this.lblAccz.Size = new System.Drawing.Size(15, 15);
            this.lblAccz.TabIndex = 6;
            this.lblAccz.Text = "0";
            this.lblAccz.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAccy
            // 
            this.lblAccy.AutoSize = true;
            this.lblAccy.Location = new System.Drawing.Point(73, 244);
            this.lblAccy.Name = "lblAccy";
            this.lblAccy.Size = new System.Drawing.Size(15, 15);
            this.lblAccy.TabIndex = 7;
            this.lblAccy.Text = "0";
            this.lblAccy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAccx
            // 
            this.lblAccx.AutoSize = true;
            this.lblAccx.Font = new System.Drawing.Font("宋体", 9F);
            this.lblAccx.Location = new System.Drawing.Point(73, 229);
            this.lblAccx.Name = "lblAccx";
            this.lblAccx.Size = new System.Drawing.Size(15, 15);
            this.lblAccx.TabIndex = 8;
            this.lblAccx.Text = "0";
            this.lblAccx.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblYaw
            // 
            this.lblYaw.AutoSize = true;
            this.lblYaw.Font = new System.Drawing.Font("宋体", 9F);
            this.lblYaw.Location = new System.Drawing.Point(73, 199);
            this.lblYaw.Name = "lblYaw";
            this.lblYaw.Size = new System.Drawing.Size(15, 15);
            this.lblYaw.TabIndex = 5;
            this.lblYaw.Text = "0";
            this.lblYaw.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.Font = new System.Drawing.Font("宋体", 9F);
            this.lblPitch.Location = new System.Drawing.Point(73, 184);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(15, 15);
            this.lblPitch.TabIndex = 5;
            this.lblPitch.Text = "0";
            this.lblPitch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Font = new System.Drawing.Font("宋体", 9F);
            this.lblRoll.Location = new System.Drawing.Point(73, 169);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(15, 15);
            this.lblRoll.TabIndex = 5;
            this.lblRoll.Text = "0";
            this.lblRoll.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.Location = new System.Drawing.Point(8, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 390);
            this.label5.TabIndex = 4;
            this.label5.Text = "Roll\r\nPitch\r\nYaw\r\n\r\naccx\r\naccy\r\naccz\r\n\r\ngyrox\r\ngyroy\r\ngyroz\r\n\r\nRCrol\r\nRCpit\r\nRCth" +
    "r\r\nRCyaw\r\n\r\nMOTOR1\r\nMOTOR2\r\nMOTOR3\r\nMOTOR4\r\n\r\nq0\r\nq1\r\nq2\r\nq3";
            // 
            // vScrollPit
            // 
            this.vScrollPit.LargeChange = 1;
            this.vScrollPit.Location = new System.Drawing.Point(903, 3);
            this.vScrollPit.Name = "vScrollPit";
            this.vScrollPit.Size = new System.Drawing.Size(49, 567);
            this.vScrollPit.TabIndex = 3;
            this.vScrollPit.Value = 50;
            // 
            // vScrollThr
            // 
            this.vScrollThr.LargeChange = 1;
            this.vScrollThr.Location = new System.Drawing.Point(279, 3);
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
            // btnCtrl
            // 
            this.btnCtrl.Image = global::GroundStation.Properties.Resources.ledoff;
            this.btnCtrl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCtrl.Location = new System.Drawing.Point(397, 473);
            this.btnCtrl.Name = "btnCtrl";
            this.btnCtrl.Size = new System.Drawing.Size(179, 43);
            this.btnCtrl.TabIndex = 12;
            this.btnCtrl.Text = "建立控制链路";
            this.btnCtrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCtrl.UseVisualStyleBackColor = true;
            this.btnCtrl.Click += new System.EventHandler(this.btnCtrl_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.tbxPitCName4);
            this.tabPage3.Controls.Add(this.tbxPitSName4);
            this.tabPage3.Controls.Add(this.tbxRolSName4);
            this.tabPage3.Controls.Add(this.tbxRolCName4);
            this.tabPage3.Controls.Add(this.tbxPitCName2);
            this.tabPage3.Controls.Add(this.tbxPitSName2);
            this.tabPage3.Controls.Add(this.tbxRolSName2);
            this.tabPage3.Controls.Add(this.tbxPitSName3);
            this.tabPage3.Controls.Add(this.tbxRolCName2);
            this.tabPage3.Controls.Add(this.tbxRolSName3);
            this.tabPage3.Controls.Add(this.tbxPitCName3);
            this.tabPage3.Controls.Add(this.tbxPitSName1);
            this.tabPage3.Controls.Add(this.tbxRolCName3);
            this.tabPage3.Controls.Add(this.tbxRolSName1);
            this.tabPage3.Controls.Add(this.tbxPitCName1);
            this.tabPage3.Controls.Add(this.tbxRolCName1);
            this.tabPage3.Controls.Add(this.cbxPitDisp);
            this.tabPage3.Controls.Add(this.cbxRolDisp);
            this.tabPage3.Controls.Add(this.btnReadPit);
            this.tabPage3.Controls.Add(this.btnReadRol);
            this.tabPage3.Controls.Add(this.btnAccCali);
            this.tabPage3.Controls.Add(this.btnGyroCali);
            this.tabPage3.Controls.Add(this.btnWritePit);
            this.tabPage3.Controls.Add(this.btnWriteRol);
            this.tabPage3.Controls.Add(this.tbxPitParam2);
            this.tabPage3.Controls.Add(this.tbxPitParam4);
            this.tabPage3.Controls.Add(this.tbxPitParam3);
            this.tabPage3.Controls.Add(this.tbxRolParam2);
            this.tabPage3.Controls.Add(this.tbxPitParam1);
            this.tabPage3.Controls.Add(this.tbxRolParam4);
            this.tabPage3.Controls.Add(this.tbxRolParam3);
            this.tabPage3.Controls.Add(this.lblPitParam4);
            this.tabPage3.Controls.Add(this.lblPitParam3);
            this.tabPage3.Controls.Add(this.tbxRolParam1);
            this.tabPage3.Controls.Add(this.lblPitParam2);
            this.tabPage3.Controls.Add(this.lblPitSt4);
            this.tabPage3.Controls.Add(this.lblPitSt3);
            this.tabPage3.Controls.Add(this.lblRolSt4);
            this.tabPage3.Controls.Add(this.lblRolSt3);
            this.tabPage3.Controls.Add(this.lblPitSt2);
            this.tabPage3.Controls.Add(this.lblRolParam4);
            this.tabPage3.Controls.Add(this.lblRolParam3);
            this.tabPage3.Controls.Add(this.lblRolSt2);
            this.tabPage3.Controls.Add(this.lblPitSt1);
            this.tabPage3.Controls.Add(this.lblPitParam1);
            this.tabPage3.Controls.Add(this.lblRolSt1);
            this.tabPage3.Controls.Add(this.lblRolParam2);
            this.tabPage3.Controls.Add(this.lblRolParam1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1230, 622);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "参数设置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(506, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "状态参数";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "控制参数";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(507, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "参数名称        参数真实值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "参数名称      参数传输值    参数真实值";
            // 
            // tbxPitCName4
            // 
            this.tbxPitCName4.Location = new System.Drawing.Point(3, 320);
            this.tbxPitCName4.Name = "tbxPitCName4";
            this.tbxPitCName4.Size = new System.Drawing.Size(100, 25);
            this.tbxPitCName4.TabIndex = 7;
            // 
            // tbxPitSName4
            // 
            this.tbxPitSName4.Location = new System.Drawing.Point(510, 320);
            this.tbxPitSName4.Name = "tbxPitSName4";
            this.tbxPitSName4.Size = new System.Drawing.Size(100, 25);
            this.tbxPitSName4.TabIndex = 11;
            // 
            // tbxRolSName4
            // 
            this.tbxRolSName4.Location = new System.Drawing.Point(510, 157);
            this.tbxRolSName4.Name = "tbxRolSName4";
            this.tbxRolSName4.Size = new System.Drawing.Size(100, 25);
            this.tbxRolSName4.TabIndex = 11;
            // 
            // tbxRolCName4
            // 
            this.tbxRolCName4.Location = new System.Drawing.Point(3, 157);
            this.tbxRolCName4.Name = "tbxRolCName4";
            this.tbxRolCName4.Size = new System.Drawing.Size(100, 25);
            this.tbxRolCName4.TabIndex = 3;
            // 
            // tbxPitCName2
            // 
            this.tbxPitCName2.Location = new System.Drawing.Point(3, 258);
            this.tbxPitCName2.Name = "tbxPitCName2";
            this.tbxPitCName2.Size = new System.Drawing.Size(100, 25);
            this.tbxPitCName2.TabIndex = 5;
            // 
            // tbxPitSName2
            // 
            this.tbxPitSName2.Location = new System.Drawing.Point(510, 258);
            this.tbxPitSName2.Name = "tbxPitSName2";
            this.tbxPitSName2.Size = new System.Drawing.Size(100, 25);
            this.tbxPitSName2.TabIndex = 11;
            // 
            // tbxRolSName2
            // 
            this.tbxRolSName2.Location = new System.Drawing.Point(510, 95);
            this.tbxRolSName2.Name = "tbxRolSName2";
            this.tbxRolSName2.Size = new System.Drawing.Size(100, 25);
            this.tbxRolSName2.TabIndex = 11;
            // 
            // tbxPitSName3
            // 
            this.tbxPitSName3.Location = new System.Drawing.Point(510, 289);
            this.tbxPitSName3.Name = "tbxPitSName3";
            this.tbxPitSName3.Size = new System.Drawing.Size(100, 25);
            this.tbxPitSName3.TabIndex = 11;
            // 
            // tbxRolCName2
            // 
            this.tbxRolCName2.Location = new System.Drawing.Point(3, 95);
            this.tbxRolCName2.Name = "tbxRolCName2";
            this.tbxRolCName2.Size = new System.Drawing.Size(100, 25);
            this.tbxRolCName2.TabIndex = 1;
            // 
            // tbxRolSName3
            // 
            this.tbxRolSName3.Location = new System.Drawing.Point(510, 126);
            this.tbxRolSName3.Name = "tbxRolSName3";
            this.tbxRolSName3.Size = new System.Drawing.Size(100, 25);
            this.tbxRolSName3.TabIndex = 11;
            // 
            // tbxPitCName3
            // 
            this.tbxPitCName3.Location = new System.Drawing.Point(3, 289);
            this.tbxPitCName3.Name = "tbxPitCName3";
            this.tbxPitCName3.Size = new System.Drawing.Size(100, 25);
            this.tbxPitCName3.TabIndex = 6;
            // 
            // tbxPitSName1
            // 
            this.tbxPitSName1.Location = new System.Drawing.Point(510, 227);
            this.tbxPitSName1.Name = "tbxPitSName1";
            this.tbxPitSName1.Size = new System.Drawing.Size(100, 25);
            this.tbxPitSName1.TabIndex = 11;
            // 
            // tbxRolCName3
            // 
            this.tbxRolCName3.Location = new System.Drawing.Point(3, 126);
            this.tbxRolCName3.Name = "tbxRolCName3";
            this.tbxRolCName3.Size = new System.Drawing.Size(100, 25);
            this.tbxRolCName3.TabIndex = 2;
            // 
            // tbxRolSName1
            // 
            this.tbxRolSName1.Location = new System.Drawing.Point(510, 64);
            this.tbxRolSName1.Name = "tbxRolSName1";
            this.tbxRolSName1.Size = new System.Drawing.Size(100, 25);
            this.tbxRolSName1.TabIndex = 11;
            // 
            // tbxPitCName1
            // 
            this.tbxPitCName1.Location = new System.Drawing.Point(3, 227);
            this.tbxPitCName1.Name = "tbxPitCName1";
            this.tbxPitCName1.Size = new System.Drawing.Size(100, 25);
            this.tbxPitCName1.TabIndex = 4;
            // 
            // tbxRolCName1
            // 
            this.tbxRolCName1.Location = new System.Drawing.Point(3, 64);
            this.tbxRolCName1.Name = "tbxRolCName1";
            this.tbxRolCName1.Size = new System.Drawing.Size(100, 25);
            this.tbxRolCName1.TabIndex = 0;
            // 
            // cbxPitDisp
            // 
            this.cbxPitDisp.AutoSize = true;
            this.cbxPitDisp.Location = new System.Drawing.Point(743, 207);
            this.cbxPitDisp.Name = "cbxPitDisp";
            this.cbxPitDisp.Size = new System.Drawing.Size(59, 19);
            this.cbxPitDisp.TabIndex = 10;
            this.cbxPitDisp.Text = "显示";
            this.cbxPitDisp.UseVisualStyleBackColor = true;
            // 
            // cbxRolDisp
            // 
            this.cbxRolDisp.AutoSize = true;
            this.cbxRolDisp.Location = new System.Drawing.Point(743, 42);
            this.cbxRolDisp.Name = "cbxRolDisp";
            this.cbxRolDisp.Size = new System.Drawing.Size(59, 19);
            this.cbxRolDisp.TabIndex = 10;
            this.cbxRolDisp.Text = "显示";
            this.cbxRolDisp.UseVisualStyleBackColor = true;
            // 
            // btnReadPit
            // 
            this.btnReadPit.Location = new System.Drawing.Point(308, 227);
            this.btnReadPit.Name = "btnReadPit";
            this.btnReadPit.Size = new System.Drawing.Size(123, 41);
            this.btnReadPit.TabIndex = 9;
            this.btnReadPit.Text = "读取参数";
            this.btnReadPit.UseVisualStyleBackColor = true;
            this.btnReadPit.Click += new System.EventHandler(this.btnReadPit_Click);
            // 
            // btnReadRol
            // 
            this.btnReadRol.Location = new System.Drawing.Point(308, 64);
            this.btnReadRol.Name = "btnReadRol";
            this.btnReadRol.Size = new System.Drawing.Size(123, 41);
            this.btnReadRol.TabIndex = 7;
            this.btnReadRol.Text = "读取参数";
            this.btnReadRol.UseVisualStyleBackColor = true;
            this.btnReadRol.Click += new System.EventHandler(this.btnReadRol_Click);
            // 
            // btnAccCali
            // 
            this.btnAccCali.Location = new System.Drawing.Point(132, 578);
            this.btnAccCali.Name = "btnAccCali";
            this.btnAccCali.Size = new System.Drawing.Size(123, 41);
            this.btnAccCali.TabIndex = 8;
            this.btnAccCali.Text = "加速度计校准";
            this.btnAccCali.UseVisualStyleBackColor = true;
            this.btnAccCali.Click += new System.EventHandler(this.btnAccCali_Click);
            // 
            // btnGyroCali
            // 
            this.btnGyroCali.Location = new System.Drawing.Point(3, 578);
            this.btnGyroCali.Name = "btnGyroCali";
            this.btnGyroCali.Size = new System.Drawing.Size(123, 41);
            this.btnGyroCali.TabIndex = 8;
            this.btnGyroCali.Text = "陀螺仪校准";
            this.btnGyroCali.UseVisualStyleBackColor = true;
            this.btnGyroCali.Click += new System.EventHandler(this.btnGyroCali_Click);
            // 
            // btnWritePit
            // 
            this.btnWritePit.Location = new System.Drawing.Point(308, 274);
            this.btnWritePit.Name = "btnWritePit";
            this.btnWritePit.Size = new System.Drawing.Size(123, 41);
            this.btnWritePit.TabIndex = 8;
            this.btnWritePit.Text = "写入参数";
            this.btnWritePit.UseVisualStyleBackColor = true;
            this.btnWritePit.Click += new System.EventHandler(this.btnWritePit_Click);
            // 
            // btnWriteRol
            // 
            this.btnWriteRol.Location = new System.Drawing.Point(308, 111);
            this.btnWriteRol.Name = "btnWriteRol";
            this.btnWriteRol.Size = new System.Drawing.Size(123, 41);
            this.btnWriteRol.TabIndex = 6;
            this.btnWriteRol.Text = "写入参数";
            this.btnWriteRol.UseVisualStyleBackColor = true;
            this.btnWriteRol.Click += new System.EventHandler(this.btnWriteRol_Click);
            // 
            // tbxPitParam2
            // 
            this.tbxPitParam2.Location = new System.Drawing.Point(109, 258);
            this.tbxPitParam2.Name = "tbxPitParam2";
            this.tbxPitParam2.Size = new System.Drawing.Size(100, 25);
            this.tbxPitParam2.TabIndex = 5;
            // 
            // tbxPitParam4
            // 
            this.tbxPitParam4.Location = new System.Drawing.Point(109, 320);
            this.tbxPitParam4.Name = "tbxPitParam4";
            this.tbxPitParam4.Size = new System.Drawing.Size(100, 25);
            this.tbxPitParam4.TabIndex = 7;
            // 
            // tbxPitParam3
            // 
            this.tbxPitParam3.Location = new System.Drawing.Point(109, 289);
            this.tbxPitParam3.Name = "tbxPitParam3";
            this.tbxPitParam3.Size = new System.Drawing.Size(100, 25);
            this.tbxPitParam3.TabIndex = 6;
            // 
            // tbxRolParam2
            // 
            this.tbxRolParam2.Location = new System.Drawing.Point(109, 95);
            this.tbxRolParam2.Name = "tbxRolParam2";
            this.tbxRolParam2.Size = new System.Drawing.Size(100, 25);
            this.tbxRolParam2.TabIndex = 1;
            // 
            // tbxPitParam1
            // 
            this.tbxPitParam1.Location = new System.Drawing.Point(109, 227);
            this.tbxPitParam1.Name = "tbxPitParam1";
            this.tbxPitParam1.Size = new System.Drawing.Size(100, 25);
            this.tbxPitParam1.TabIndex = 4;
            // 
            // tbxRolParam4
            // 
            this.tbxRolParam4.Location = new System.Drawing.Point(109, 157);
            this.tbxRolParam4.Name = "tbxRolParam4";
            this.tbxRolParam4.Size = new System.Drawing.Size(100, 25);
            this.tbxRolParam4.TabIndex = 3;
            // 
            // tbxRolParam3
            // 
            this.tbxRolParam3.Location = new System.Drawing.Point(109, 126);
            this.tbxRolParam3.Name = "tbxRolParam3";
            this.tbxRolParam3.Size = new System.Drawing.Size(100, 25);
            this.tbxRolParam3.TabIndex = 2;
            // 
            // lblPitParam4
            // 
            this.lblPitParam4.AutoSize = true;
            this.lblPitParam4.Location = new System.Drawing.Point(215, 323);
            this.lblPitParam4.Name = "lblPitParam4";
            this.lblPitParam4.Size = new System.Drawing.Size(15, 15);
            this.lblPitParam4.TabIndex = 0;
            this.lblPitParam4.Text = "0";
            // 
            // lblPitParam3
            // 
            this.lblPitParam3.AutoSize = true;
            this.lblPitParam3.Location = new System.Drawing.Point(215, 292);
            this.lblPitParam3.Name = "lblPitParam3";
            this.lblPitParam3.Size = new System.Drawing.Size(15, 15);
            this.lblPitParam3.TabIndex = 0;
            this.lblPitParam3.Text = "0";
            // 
            // tbxRolParam1
            // 
            this.tbxRolParam1.Location = new System.Drawing.Point(109, 64);
            this.tbxRolParam1.Name = "tbxRolParam1";
            this.tbxRolParam1.Size = new System.Drawing.Size(100, 25);
            this.tbxRolParam1.TabIndex = 0;
            // 
            // lblPitParam2
            // 
            this.lblPitParam2.AutoSize = true;
            this.lblPitParam2.Location = new System.Drawing.Point(215, 261);
            this.lblPitParam2.Name = "lblPitParam2";
            this.lblPitParam2.Size = new System.Drawing.Size(15, 15);
            this.lblPitParam2.TabIndex = 0;
            this.lblPitParam2.Text = "0";
            // 
            // lblPitSt4
            // 
            this.lblPitSt4.AutoSize = true;
            this.lblPitSt4.Location = new System.Drawing.Point(658, 325);
            this.lblPitSt4.Name = "lblPitSt4";
            this.lblPitSt4.Size = new System.Drawing.Size(15, 15);
            this.lblPitSt4.TabIndex = 0;
            this.lblPitSt4.Text = "0";
            // 
            // lblPitSt3
            // 
            this.lblPitSt3.AutoSize = true;
            this.lblPitSt3.Location = new System.Drawing.Point(658, 294);
            this.lblPitSt3.Name = "lblPitSt3";
            this.lblPitSt3.Size = new System.Drawing.Size(15, 15);
            this.lblPitSt3.TabIndex = 0;
            this.lblPitSt3.Text = "0";
            // 
            // lblRolSt4
            // 
            this.lblRolSt4.AutoSize = true;
            this.lblRolSt4.Location = new System.Drawing.Point(658, 162);
            this.lblRolSt4.Name = "lblRolSt4";
            this.lblRolSt4.Size = new System.Drawing.Size(15, 15);
            this.lblRolSt4.TabIndex = 0;
            this.lblRolSt4.Text = "0";
            // 
            // lblRolSt3
            // 
            this.lblRolSt3.AutoSize = true;
            this.lblRolSt3.Location = new System.Drawing.Point(658, 130);
            this.lblRolSt3.Name = "lblRolSt3";
            this.lblRolSt3.Size = new System.Drawing.Size(15, 15);
            this.lblRolSt3.TabIndex = 0;
            this.lblRolSt3.Text = "0";
            // 
            // lblPitSt2
            // 
            this.lblPitSt2.AutoSize = true;
            this.lblPitSt2.Location = new System.Drawing.Point(658, 263);
            this.lblPitSt2.Name = "lblPitSt2";
            this.lblPitSt2.Size = new System.Drawing.Size(15, 15);
            this.lblPitSt2.TabIndex = 0;
            this.lblPitSt2.Text = "0";
            // 
            // lblRolParam4
            // 
            this.lblRolParam4.AutoSize = true;
            this.lblRolParam4.Location = new System.Drawing.Point(215, 160);
            this.lblRolParam4.Name = "lblRolParam4";
            this.lblRolParam4.Size = new System.Drawing.Size(15, 15);
            this.lblRolParam4.TabIndex = 0;
            this.lblRolParam4.Text = "0";
            // 
            // lblRolParam3
            // 
            this.lblRolParam3.AutoSize = true;
            this.lblRolParam3.Location = new System.Drawing.Point(215, 129);
            this.lblRolParam3.Name = "lblRolParam3";
            this.lblRolParam3.Size = new System.Drawing.Size(15, 15);
            this.lblRolParam3.TabIndex = 0;
            this.lblRolParam3.Text = "0";
            // 
            // lblRolSt2
            // 
            this.lblRolSt2.AutoSize = true;
            this.lblRolSt2.Location = new System.Drawing.Point(658, 100);
            this.lblRolSt2.Name = "lblRolSt2";
            this.lblRolSt2.Size = new System.Drawing.Size(15, 15);
            this.lblRolSt2.TabIndex = 0;
            this.lblRolSt2.Text = "0";
            // 
            // lblPitSt1
            // 
            this.lblPitSt1.AutoSize = true;
            this.lblPitSt1.Location = new System.Drawing.Point(658, 232);
            this.lblPitSt1.Name = "lblPitSt1";
            this.lblPitSt1.Size = new System.Drawing.Size(15, 15);
            this.lblPitSt1.TabIndex = 0;
            this.lblPitSt1.Text = "0";
            // 
            // lblPitParam1
            // 
            this.lblPitParam1.AutoSize = true;
            this.lblPitParam1.Location = new System.Drawing.Point(215, 230);
            this.lblPitParam1.Name = "lblPitParam1";
            this.lblPitParam1.Size = new System.Drawing.Size(15, 15);
            this.lblPitParam1.TabIndex = 0;
            this.lblPitParam1.Text = "0";
            // 
            // lblRolSt1
            // 
            this.lblRolSt1.AutoSize = true;
            this.lblRolSt1.Location = new System.Drawing.Point(658, 66);
            this.lblRolSt1.Name = "lblRolSt1";
            this.lblRolSt1.Size = new System.Drawing.Size(15, 15);
            this.lblRolSt1.TabIndex = 0;
            this.lblRolSt1.Text = "0";
            // 
            // lblRolParam2
            // 
            this.lblRolParam2.AutoSize = true;
            this.lblRolParam2.Location = new System.Drawing.Point(215, 98);
            this.lblRolParam2.Name = "lblRolParam2";
            this.lblRolParam2.Size = new System.Drawing.Size(15, 15);
            this.lblRolParam2.TabIndex = 0;
            this.lblRolParam2.Text = "0";
            // 
            // lblRolParam1
            // 
            this.lblRolParam1.AutoSize = true;
            this.lblRolParam1.Location = new System.Drawing.Point(215, 67);
            this.lblRolParam1.Name = "lblRolParam1";
            this.lblRolParam1.Size = new System.Drawing.Size(15, 15);
            this.lblRolParam1.TabIndex = 0;
            this.lblRolParam1.Text = "0";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cbxDisp);
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1230, 622);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "波形显示";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cbxDisp
            // 
            this.cbxDisp.AutoSize = true;
            this.cbxDisp.Location = new System.Drawing.Point(1138, 600);
            this.cbxDisp.Name = "cbxDisp";
            this.cbxDisp.Size = new System.Drawing.Size(89, 19);
            this.cbxDisp.TabIndex = 1;
            this.cbxDisp.Text = "开始显示";
            this.cbxDisp.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-60, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1513, 591);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tmrSendUser
            // 
            this.tmrSendUser.Tick += new System.EventHandler(this.tmrSendUser_Tick);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 682);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(111, 15);
            this.lblVersion.TabIndex = 13;
            this.lblVersion.Text = "GroundStation";
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
            this.btnClearBuf.TabIndex = 3;
            this.btnClearBuf.Text = "清除缓存";
            this.btnClearBuf.UseVisualStyleBackColor = true;
            this.btnClearBuf.Click += new System.EventHandler(this.btnClearBuf_Click);
            // 
            // btnReCnt
            // 
            this.btnReCnt.Location = new System.Drawing.Point(491, 669);
            this.btnReCnt.Name = "btnReCnt";
            this.btnReCnt.Size = new System.Drawing.Size(101, 40);
            this.btnReCnt.TabIndex = 4;
            this.btnReCnt.Text = "重新计数";
            this.btnReCnt.UseVisualStyleBackColor = true;
            this.btnReCnt.Click += new System.EventHandler(this.btnReCnt_Click);
            // 
            // tmrCtrl
            // 
            this.tmrCtrl.Enabled = true;
            this.tmrCtrl.Tick += new System.EventHandler(this.tmrCtrl_Tick);
            // 
            // btnOpen1
            // 
            this.btnOpen1.Image = global::GroundStation.Properties.Resources.ledoff;
            this.btnOpen1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen1.Location = new System.Drawing.Point(755, 669);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(140, 40);
            this.btnOpen1.TabIndex = 2;
            this.btnOpen1.Text = "打开连接";
            this.btnOpen1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen1.UseVisualStyleBackColor = true;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // tmrPortRcv
            // 
            this.tmrPortRcv.Interval = 10;
            this.tmrPortRcv.Tick += new System.EventHandler(this.tmrPortRcv_Tick);
            // 
            // serialPort2
            // 
            this.serialPort2.ReadBufferSize = 128;
            this.serialPort2.WriteBufferSize = 1;
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
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOpen1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxBaudRate1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPort1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "地面站";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cbxPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxBaudRate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.TextBox tbxTx1;
        private System.Windows.Forms.TextBox tbxTx2;
        private System.Windows.Forms.TextBox tbxRx;
        private System.Windows.Forms.CheckBox cbxAutoSend;
        private System.Windows.Forms.TextBox tbxInterval;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.Button btnSend3;
        private System.Windows.Forms.Timer tmrPortChk;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer tmrSendUser;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelTxCnt;
        private System.Windows.Forms.Label labelRxCnt;
        private System.Windows.Forms.Button btnClearBuf;
        private System.Windows.Forms.Button btnReCnt;
        private System.Windows.Forms.Timer tmrCtrl;
        private System.Windows.Forms.TextBox tbxTx3;
        private System.Windows.Forms.Button btnSend2;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCtrl;
        private System.Windows.Forms.Label lblLock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCtrl;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Label lblVoltage;
        private System.Windows.Forms.Label lblRCyaw;
        private System.Windows.Forms.Label lblRCthr;
        private System.Windows.Forms.Label lblRCpit;
        private System.Windows.Forms.Label lblRCrol;
        private System.Windows.Forms.Label lblM4;
        private System.Windows.Forms.Label lblM3;
        private System.Windows.Forms.Label lblM2;
        private System.Windows.Forms.Label lblM1;
        private System.Windows.Forms.TextBox tbxRolParam1;
        private System.Windows.Forms.Label lblRolParam1;
        private System.Windows.Forms.Button btnReadRol;
        private System.Windows.Forms.Button btnWriteRol;
        private System.Windows.Forms.TextBox tbxRolParam2;
        private System.Windows.Forms.TextBox tbxRolParam3;
        private System.Windows.Forms.Label lblRolParam3;
        private System.Windows.Forms.Label lblRolParam2;
        private System.Windows.Forms.TextBox tbxPitParam2;
        private System.Windows.Forms.TextBox tbxPitParam3;
        private System.Windows.Forms.TextBox tbxPitParam1;
        private System.Windows.Forms.Label lblPitParam3;
        private System.Windows.Forms.Label lblPitParam2;
        private System.Windows.Forms.Label lblPitParam1;
        private System.Windows.Forms.Button btnReadPit;
        private System.Windows.Forms.Button btnWritePit;
        private System.Windows.Forms.Label lblPitSt3;
        private System.Windows.Forms.Label lblRolSt3;
        private System.Windows.Forms.Label lblPitSt2;
        private System.Windows.Forms.Label lblRolSt2;
        private System.Windows.Forms.Label lblPitSt1;
        private System.Windows.Forms.Label lblRolSt1;
        private System.Windows.Forms.CheckBox cbxPitDisp;
        private System.Windows.Forms.CheckBox cbxRolDisp;
        private System.Windows.Forms.Label lblRolSt4;
        private System.Windows.Forms.TextBox tbxRolParam4;
        private System.Windows.Forms.Label lblRolParam4;
        private System.Windows.Forms.TextBox tbxPitParam4;
        private System.Windows.Forms.Label lblPitParam4;
        private System.Windows.Forms.TextBox tbxRolCName1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxPitCName4;
        private System.Windows.Forms.TextBox tbxRolCName4;
        private System.Windows.Forms.TextBox tbxPitCName2;
        private System.Windows.Forms.TextBox tbxRolCName2;
        private System.Windows.Forms.TextBox tbxPitCName3;
        private System.Windows.Forms.TextBox tbxRolCName3;
        private System.Windows.Forms.TextBox tbxPitCName1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxPitSName4;
        private System.Windows.Forms.TextBox tbxRolSName4;
        private System.Windows.Forms.TextBox tbxPitSName2;
        private System.Windows.Forms.TextBox tbxRolSName2;
        private System.Windows.Forms.TextBox tbxPitSName3;
        private System.Windows.Forms.TextBox tbxRolSName3;
        private System.Windows.Forms.TextBox tbxPitSName1;
        private System.Windows.Forms.TextBox tbxRolSName1;
        private System.Windows.Forms.Label lblPitSt4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox cbxHexRcv;
        private System.Windows.Forms.CheckBox cbxHexSend3;
        private System.Windows.Forms.CheckBox cbxHexSend2;
        private System.Windows.Forms.CheckBox cbxHexSend1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbxDisp;
        private System.Windows.Forms.CheckBox cbxMotor;
        private System.Windows.Forms.CheckBox cbxRC;
        private System.Windows.Forms.CheckBox cbxSensor;
        private System.Windows.Forms.CheckBox cbxAtti;
        private System.Windows.Forms.CheckBox cbxStat;
        private System.Windows.Forms.Label lblCtrlThr;
        private System.Windows.Forms.Label lblCtrlPit;
        private System.Windows.Forms.Label lblCtrlRol;
        private System.Windows.Forms.Label lblCtrlYaw;
        private System.Windows.Forms.Button btnAccCali;
        private System.Windows.Forms.Button btnGyroCali;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.CheckBox cbxQuaternion;
        private System.Windows.Forms.Label lblQ3;
        private System.Windows.Forms.Label lblQ2;
        private System.Windows.Forms.Label lblQ1;
        private System.Windows.Forms.Label lblQ0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxBaudRate2;
        private System.Windows.Forms.ComboBox cbxPort2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer tmrPortRcv;
        private System.Windows.Forms.Button btnSpeedMode;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button btnAttiMode;
        private System.Windows.Forms.Button btnUnLock;
    }
}

