using System;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;
/**************文件说明**********************
主窗体生成,串口开闭与收发,所有标签的公共部分
********************************************/

namespace GroundStation
{
    public partial class Form1 : Form
    {
        string[] LastPorts = { };
        const string version = "V0.08";
        long TxCount = 0, RxCount = 0;
        Protocol ptcl = new Protocol();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "Ground Station " + version;
            tabControl1.SelectedIndex = 1;
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
                my_SerialPort_Close();
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
                label4.Text = "Ground Station " + version;
                tmrPortRcv.Enabled = true;
            }
            catch (Exception)
            {
                label4.Text = "串口打开失败!";  //已选端口被占用
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
                my_SerialPort_Close();  //原因是端口意外断开
                cbxPort.Items.Clear();
                LastPorts = ports;
            }
            else  //有可用端口
            {
                if (Enumerable.SequenceEqual(ports, LastPorts))  //可用端口没有变化
                {
                    if (serialPort1.IsOpen == false)  //端口短时间内断开重连
                        my_SerialPort_Close();
                    return;
                }
                if (LastPorts.Length != 0)  //可用端口改变
                {
                    my_SerialPort_Close();
                    cbxPort.Items.Clear();
                }
                foreach (string port in ports)  //扫描并添加可用端口
                    cbxPort.Items.Add(port);
                LastPorts = ports;
                cbxPort.Text = ports[0];  //默认选择第一个可用端口
            }
        }
        /*关闭串口后需要完成的一系列操作*/
        private void my_SerialPort_Close()
        {
            cbxPort.Enabled = true;
            comboBox2.Enabled = true;
            btnOpen.Image = Properties.Resources.ledoff;
            btnOpen.Text = "打开连接";
            tmrPortRcv.Enabled = false;
            //tab1
            btnCtrl.Image = Properties.Resources.ledoff;
            btnCtrl.Text = "建立控制链路";
            lblCtrl.Text = "失控";
            lblCtrl.ForeColor = Color.Red;
            GlobalStat &= 0x7F;
        }
        /*定时10ms处理串口接收缓冲RxStr*/
        private void tmrPortRcv_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) return;
            if (serialPort1.BytesToRead == 0) return;
            if (tabControl1.SelectedIndex == 0)
            {
                Base_Text_Receive();
                return;
            }
            byte success, DataAdd = 0;
            do  //可能会一次发送大量数据
            {
                success = ptcl.Text_Receive((byte)serialPort1.ReadByte());
                DataAdd++;
                if (success == 0)
                    Data_Receive_Precess();
                if (success == 2)
                {
                    lblCtrl.Text = "失控";
                    lblCtrl.ForeColor = Color.Red;
                }
            } while (serialPort1.BytesToRead > 0);
            RxCount += DataAdd;
            labelRxCnt.Text = $"Rx:{RxCount}";
        }
        private void btnClearBuf_Click(object sender, EventArgs e)
        {
            tbxRx.Text = "";
        }
        private void btnReCnt_Click(object sender, EventArgs e)
        {
            TxCount = 0;
            RxCount = 0;
            labelTxCnt.Text = "Tx:0";
            labelRxCnt.Text = "Rx:0";
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.tbxTx1Str = tbxTx1.Text;
            Properties.Settings.Default.tbxTx2Str = tbxTx2.Text;
            Properties.Settings.Default.tbxTx3Str = tbxTx3.Text;
            Properties.Settings.Default.cbx2Str = comboBox2.Text;
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
