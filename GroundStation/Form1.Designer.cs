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
            this.lblVoltage = new System.Windows.Forms.Label();
            this.btnLock = new System.Windows.Forms.Button();
            this.lblCtrl = new System.Windows.Forms.Label();
            this.lblLock = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCtrl = new System.Windows.Forms.Button();
            this.lblRCyaw = new System.Windows.Forms.Label();
            this.lblRCthr = new System.Windows.Forms.Label();
            this.lblRCpit = new System.Windows.Forms.Label();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tmrSendUser = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tmrPortRcv = new System.Windows.Forms.Timer(this.components);
            this.labelTxCnt = new System.Windows.Forms.Label();
            this.labelRxCnt = new System.Windows.Forms.Label();
            this.btnClearBuf = new System.Windows.Forms.Button();
            this.btnReCnt = new System.Windows.Forms.Button();
            this.tmrCtrl = new System.Windows.Forms.Timer(this.components);
            this.lblM1 = new System.Windows.Forms.Label();
            this.lblM3 = new System.Windows.Forms.Label();
            this.lblM4 = new System.Windows.Forms.Label();
            this.lblM2 = new System.Windows.Forms.Label();
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
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            this.tabControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyUp);
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
            this.tabPage2.Controls.Add(this.lblVoltage);
            this.tabPage2.Controls.Add(this.btnLock);
            this.tabPage2.Controls.Add(this.lblCtrl);
            this.tabPage2.Controls.Add(this.lblLock);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnCtrl);
            this.tabPage2.Controls.Add(this.lblM4);
            this.tabPage2.Controls.Add(this.lblM3);
            this.tabPage2.Controls.Add(this.lblM2);
            this.tabPage2.Controls.Add(this.lblM1);
            this.tabPage2.Controls.Add(this.lblRCyaw);
            this.tabPage2.Controls.Add(this.lblRCthr);
            this.tabPage2.Controls.Add(this.lblRCpit);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1230, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "飞行控制";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(763, 507);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 43);
            this.btnLock.TabIndex = 16;
            this.btnLock.Text = "解锁";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "飞行状态：";
            // 
            // btnCtrl
            // 
            this.btnCtrl.Image = global::GroundStation.Properties.Resources.ledoff;
            this.btnCtrl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCtrl.Location = new System.Drawing.Point(505, 507);
            this.btnCtrl.Name = "btnCtrl";
            this.btnCtrl.Size = new System.Drawing.Size(179, 43);
            this.btnCtrl.TabIndex = 12;
            this.btnCtrl.Text = "建立控制链路";
            this.btnCtrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCtrl.UseVisualStyleBackColor = true;
            this.btnCtrl.Click += new System.EventHandler(this.btnCtrl_Click);
            // 
            // lblRCyaw
            // 
            this.lblRCyaw.AutoSize = true;
            this.lblRCyaw.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRCyaw.Location = new System.Drawing.Point(73, 406);
            this.lblRCyaw.Name = "lblRCyaw";
            this.lblRCyaw.Size = new System.Drawing.Size(15, 15);
            this.lblRCyaw.TabIndex = 9;
            this.lblRCyaw.Text = "0";
            this.lblRCyaw.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRCthr
            // 
            this.lblRCthr.AutoSize = true;
            this.lblRCthr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRCthr.Location = new System.Drawing.Point(73, 391);
            this.lblRCthr.Name = "lblRCthr";
            this.lblRCthr.Size = new System.Drawing.Size(15, 15);
            this.lblRCthr.TabIndex = 9;
            this.lblRCthr.Text = "0";
            this.lblRCthr.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRCpit
            // 
            this.lblRCpit.AutoSize = true;
            this.lblRCpit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRCpit.Location = new System.Drawing.Point(73, 376);
            this.lblRCpit.Name = "lblRCpit";
            this.lblRCpit.Size = new System.Drawing.Size(15, 15);
            this.lblRCpit.TabIndex = 9;
            this.lblRCpit.Text = "0";
            this.lblRCpit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRCrol
            // 
            this.lblRCrol.AutoSize = true;
            this.lblRCrol.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRCrol.Location = new System.Drawing.Point(73, 361);
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
            this.lblGyroz.Location = new System.Drawing.Point(73, 332);
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
            this.lblGyroy.Location = new System.Drawing.Point(73, 317);
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
            this.lblGyrox.Location = new System.Drawing.Point(73, 302);
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
            this.lblAccz.Location = new System.Drawing.Point(73, 271);
            this.lblAccz.Name = "lblAccz";
            this.lblAccz.Size = new System.Drawing.Size(15, 15);
            this.lblAccz.TabIndex = 6;
            this.lblAccz.Text = "0";
            this.lblAccz.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAccy
            // 
            this.lblAccy.AutoSize = true;
            this.lblAccy.Location = new System.Drawing.Point(73, 256);
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
            this.lblAccx.Location = new System.Drawing.Point(73, 241);
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
            this.lblYaw.Location = new System.Drawing.Point(73, 211);
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
            this.lblPitch.Location = new System.Drawing.Point(73, 196);
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
            this.lblRoll.Location = new System.Drawing.Point(73, 181);
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
            this.label5.Location = new System.Drawing.Point(8, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 315);
            this.label5.TabIndex = 4;
            this.label5.Text = "Roll\r\nPitch\r\nYaw\r\n\r\naccx\r\naccy\r\naccz\r\n\r\ngyrox\r\ngyroy\r\ngyroz\r\n\r\nRCrol\r\nRCpit\r\nRCth" +
    "r\r\nRCyaw\r\n\r\nMOTOR1\r\nMOTOR2\r\nMOTOR3\r\nMOTOR4";
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
            // lblM1
            // 
            this.lblM1.AutoSize = true;
            this.lblM1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblM1.Location = new System.Drawing.Point(73, 436);
            this.lblM1.Name = "lblM1";
            this.lblM1.Size = new System.Drawing.Size(15, 15);
            this.lblM1.TabIndex = 9;
            this.lblM1.Text = "0";
            this.lblM1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblM3
            // 
            this.lblM3.AutoSize = true;
            this.lblM3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblM3.Location = new System.Drawing.Point(73, 466);
            this.lblM3.Name = "lblM3";
            this.lblM3.Size = new System.Drawing.Size(15, 15);
            this.lblM3.TabIndex = 9;
            this.lblM3.Text = "0";
            this.lblM3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblM4
            // 
            this.lblM4.AutoSize = true;
            this.lblM4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblM4.Location = new System.Drawing.Point(73, 480);
            this.lblM4.Name = "lblM4";
            this.lblM4.Size = new System.Drawing.Size(15, 15);
            this.lblM4.TabIndex = 9;
            this.lblM4.Text = "0";
            this.lblM4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblM2
            // 
            this.lblM2.AutoSize = true;
            this.lblM2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblM2.Location = new System.Drawing.Point(73, 451);
            this.lblM2.Name = "lblM2";
            this.lblM2.Size = new System.Drawing.Size(15, 15);
            this.lblM2.TabIndex = 9;
            this.lblM2.Text = "0";
            this.lblM2.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.KeyPreview = true;
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
    }
}

