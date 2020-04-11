using System;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;
/**************文件说明**********************
主窗体生成与关闭,串口开闭
事件:
Form1
Form1_Load
btnOpen_Click
tmrPortChk_Tick
btnClearBuf_Click
btnReCnt_Click
Form1_FormClosing
函数:
SerialPort_Close
********************************************/

namespace GroundStation
{
    public partial class Form1 : Form
    {
        string[] LastPorts = { };
        const string version = "Ground Station V0.12";
        long TxCount = 0, RxCount = 0;
        Protocol ptcl = new Protocol();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblVersion.Text = version;
            ChartInit();
            tabControl1.SelectedIndex = Properties.Settings.Default.TabIndexInt;
            comboBox2.Text = Properties.Settings.Default.cbx2Str;
            tbxTx1.Text = Properties.Settings.Default.tbxTx1Str;
            tbxTx2.Text = Properties.Settings.Default.tbxTx2Str;
            tbxTx3.Text = Properties.Settings.Default.tbxTx3Str;
            tbxRolCName1.Text = Properties.Settings.Default.tbxRolCName1Str;
            tbxRolCName2.Text = Properties.Settings.Default.tbxRolCName2Str;
            tbxRolCName3.Text = Properties.Settings.Default.tbxRolCName3Str;
            tbxRolCName4.Text = Properties.Settings.Default.tbxRolCName4Str;
            tbxRolCName1.Text = Properties.Settings.Default.tbxRolSName1Str;
            tbxRolCName2.Text = Properties.Settings.Default.tbxRolSName2Str;
            tbxRolCName3.Text = Properties.Settings.Default.tbxRolSName3Str;
            tbxRolCName4.Text = Properties.Settings.Default.tbxRolSName4Str;
            tbxPitCName1.Text = Properties.Settings.Default.tbxPitCName1Str;
            tbxPitCName2.Text = Properties.Settings.Default.tbxPitCName2Str;
            tbxPitCName3.Text = Properties.Settings.Default.tbxPitCName3Str;
            tbxPitCName4.Text = Properties.Settings.Default.tbxPitCName4Str;
            tbxPitCName1.Text = Properties.Settings.Default.tbxPitSName1Str;
            tbxPitCName2.Text = Properties.Settings.Default.tbxPitSName2Str;
            tbxPitCName3.Text = Properties.Settings.Default.tbxPitSName3Str;
            tbxPitCName4.Text = Properties.Settings.Default.tbxPitSName4Str;
        }
        /*开闭串口按钮*/
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                SerialPort_Close();
                return;
            }
            try
            {
                if (cbxPort.Text == "")
                    return;
                serialPort1.PortName = cbxPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                serialPort1.Open();
                btnOpen.Image = Properties.Resources.ledon;
                btnOpen.Text = "断开连接";
                cbxPort.Enabled = false;
                comboBox2.Enabled = false;
                lblVersion.Text = version;
                tmrPortRcv.Enabled = true;
            }
            catch (Exception)
            {
                lblVersion.Text = "串口打开失败!";  //已选端口被占用
            }
        }
        /*定时每秒检测端口状况*/
        private void tmrPortChk_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length == 0)  //没有可用端口
            {
                if (LastPorts.Length == 0)  //原因是一直没有可用端口
                    return;
                SerialPort_Close();  //原因是端口意外断开
                cbxPort.Items.Clear();
                LastPorts = ports;
            }
            else  //有可用端口
            {
                if (Enumerable.SequenceEqual(ports, LastPorts))  //可用端口没有变化
                {
                    if (serialPort1.IsOpen == false)  //端口短时间内断开重连
                        SerialPort_Close();
                    return;
                }
                if (serialPort1.IsOpen == true) return;  //端口打开时有了新的可用端口
                if (LastPorts.Length != 0)  //可用端口改变
                {
                    SerialPort_Close();
                    cbxPort.Items.Clear();
                }
                foreach (string port in ports)  //扫描并添加可用端口
                    cbxPort.Items.Add(port);
                LastPorts = ports;
                cbxPort.Text = ports[0];  //默认选择第一个可用端口
            }
        }
        /***********************
        关闭串口后需要完成的一系列操作
         **********************/
        private void SerialPort_Close()
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
            cbxPort.Enabled = true;
            comboBox2.Enabled = true;
            btnOpen.Image = Properties.Resources.ledoff;
            btnOpen.Text = "打开连接";
            tmrPortRcv.Enabled = false;
            //tab1
            btnCtrl.Image = Properties.Resources.ledoff;
            btnCtrl.Text = "建立控制链路";
            stat.CtrlLink = false;
            stat.inCtrl = false;
        }
        /*清除缓存*/
        private void btnClearBuf_Click(object sender, EventArgs e)
        {
            tbxRx.Text = "";
            Chart_Clear();
        }
        /*重新计数*/
        private void btnReCnt_Click(object sender, EventArgs e)
        {
            TxCount = 0;
            RxCount = 0;
            labelTxCnt.Text = "Tx:0";
            labelRxCnt.Text = "Rx:0";
        }
        /*窗口关闭保存软件设置*/
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.tbxTx1Str = tbxTx1.Text;
            Properties.Settings.Default.tbxTx2Str = tbxTx2.Text;
            Properties.Settings.Default.tbxTx3Str = tbxTx3.Text;
            Properties.Settings.Default.cbx2Str = comboBox2.Text;
            Properties.Settings.Default.TabIndexInt = tabControl1.SelectedIndex;
            Properties.Settings.Default.tbxIntervalStr = tbxInterval.Text;
            Properties.Settings.Default.tbxRolCName1Str = tbxRolCName1.Text;
            Properties.Settings.Default.tbxRolCName2Str = tbxRolCName2.Text;
            Properties.Settings.Default.tbxRolCName3Str = tbxRolCName3.Text;
            Properties.Settings.Default.tbxRolCName4Str = tbxRolCName4.Text;
            Properties.Settings.Default.tbxRolSName1Str = tbxRolCName1.Text;
            Properties.Settings.Default.tbxRolSName2Str = tbxRolCName2.Text;
            Properties.Settings.Default.tbxRolSName3Str = tbxRolCName3.Text;
            Properties.Settings.Default.tbxRolSName4Str = tbxRolCName4.Text;
            Properties.Settings.Default.tbxPitCName1Str = tbxPitCName1.Text;
            Properties.Settings.Default.tbxPitCName2Str = tbxPitCName2.Text;
            Properties.Settings.Default.tbxPitCName3Str = tbxPitCName3.Text;
            Properties.Settings.Default.tbxPitCName4Str = tbxPitCName4.Text;
            Properties.Settings.Default.tbxPitSName1Str = tbxPitCName1.Text;
            Properties.Settings.Default.tbxPitSName2Str = tbxPitCName2.Text;
            Properties.Settings.Default.tbxPitSName3Str = tbxPitCName3.Text;
            Properties.Settings.Default.tbxPitSName4Str = tbxPitCName4.Text;
            Properties.Settings.Default.Save();
        }
    }
}
