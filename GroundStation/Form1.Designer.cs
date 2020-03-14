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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbxRx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnSend1CHR = new System.Windows.Forms.RadioButton();
            this.rbtnSend1HEX = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxInterval = new System.Windows.Forms.TextBox();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnSend2CHR = new System.Windows.Forms.RadioButton();
            this.rbtnSend2HEX = new System.Windows.Forms.RadioButton();
            this.btnOpen = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtnRcvCHR = new System.Windows.Forms.RadioButton();
            this.rbtnRcvHEX = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.labelTxCnt = new System.Windows.Forms.Label();
            this.labelRxCnt = new System.Windows.Forms.Label();
            this.btnClearBuf = new System.Windows.Forms.Button();
            this.btnCnt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(627, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(597, 329);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(627, 379);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(597, 203);
            this.textBox2.TabIndex = 7;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnSend1CHR);
            this.panel1.Controls.Add(this.rbtnSend1HEX);
            this.panel1.Location = new System.Drawing.Point(627, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 27);
            this.panel1.TabIndex = 8;
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
            // btnSend2
            // 
            this.btnSend2.Location = new System.Drawing.Point(1050, 584);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(174, 32);
            this.btnSend2.TabIndex = 11;
            this.btnSend2.Text = "发送";
            this.btnSend2.UseVisualStyleBackColor = true;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnSend2CHR);
            this.panel2.Controls.Add(this.rbtnSend2HEX);
            this.panel2.Location = new System.Drawing.Point(627, 588);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 28);
            this.panel2.TabIndex = 8;
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnSend1);
            this.tabPage1.Controls.Add(this.btnSend2);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.tbxInterval);
            this.tabPage1.Controls.Add(this.tbxRx);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1230, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本收发";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtnRcvCHR);
            this.panel3.Controls.Add(this.rbtnRcvHEX);
            this.panel3.Location = new System.Drawing.Point(6, 588);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 28);
            this.panel3.TabIndex = 8;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1230, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "波形显示";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
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
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
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
            // btnCnt
            // 
            this.btnCnt.Location = new System.Drawing.Point(491, 669);
            this.btnCnt.Name = "btnCnt";
            this.btnCnt.Size = new System.Drawing.Size(101, 40);
            this.btnCnt.TabIndex = 15;
            this.btnCnt.Text = "重新计数";
            this.btnCnt.UseVisualStyleBackColor = true;
            this.btnCnt.Click += new System.EventHandler(this.btnCnt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.btnCnt);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbxRx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnSend1CHR;
        private System.Windows.Forms.RadioButton rbtnSend1HEX;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxInterval;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnSend2CHR;
        private System.Windows.Forms.RadioButton rbtnSend2HEX;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtnRcvCHR;
        private System.Windows.Forms.RadioButton rbtnRcvHEX;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label labelTxCnt;
        private System.Windows.Forms.Label labelRxCnt;
        private System.Windows.Forms.Button btnClearBuf;
        private System.Windows.Forms.Button btnCnt;
    }
}

