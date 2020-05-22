using System;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
/**************文件说明**********************
主窗体生成与关闭,串口开闭
事件:
Form1
Form1_Load
btnOpen1_Click
btnOpen2_Click
tmrPortChk_Tick
tabControl1_SelectedIndexChanged
btnClearBuf_Click
btnReCnt_Click
函数:
SerialPort1_Open
SerialPort2_Open
SerialPort1_Close
SerialPort2_Close
********************************************/

namespace GroundStation
{
    public partial class Form1 : Form
    {
        string[] LastPorts = { };
        const string version = "Ground Station V1.01";
        long TxCount = 0, RxCount = 0;
        Protocol ptcl1 = new Protocol();
        Protocol ptcl2 = new Protocol();
        bool sp1Open, sp2Open;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblVersion.Text = version;
            ChartInit();
            Form1_Init();
        }
        /*开闭主串口按钮*/
        private void btnOpen1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                SerialPort1_Close();
                return;
            }
            try
            {
                if (cbxPort1.Text == "") return;
                if (cbxBaudRate1.Text == "") return;
                serialPort1.PortName = cbxPort1.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbxBaudRate1.Text);
                serialPort1.Open();
                SerialPort1_Open();
            }
            catch (Exception ex)
            {
                lblVersion.Text = "串口打开失败!  " + ex.Message;
            }
        }
        /*开闭外部输入串口按钮*/
        private void btnOpen2_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Close();
                SerialPort2_Close();
                return;
            }
            try
            {
                if (cbxPort2.Text == "") return;
                if (cbxBaudRate2.Text == "") return;
                serialPort2.PortName = cbxPort2.Text;
                serialPort2.BaudRate = Convert.ToInt32(cbxBaudRate2.Text);
                serialPort2.Open();
                SerialPort2_Open();
            }
            catch (Exception ex)
            {
                lblVersion.Text = "串口打开失败!  " + ex.Message;
            }
        }
        /*定时每秒检测端口状况*/
        private void tmrPortChk_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length == 0)  //没有可用端口
            {
                if (LastPorts.Length == 0) return;  //原因是一直没有可用端口                    
                SerialPort1_Close();  //原因是端口意外断开
                SerialPort2_Close();
                cbxPort1.Items.Clear();
                cbxPort2.Items.Clear();
                LastPorts = ports;
            }
            else  //有可用端口
            {
                if (Enumerable.SequenceEqual(ports, LastPorts))  //可用端口没有变化
                {
                    if ((serialPort1.IsOpen == false) && (sp1Open))  //端口短时间内断开重连
                        SerialPort1_Close();
                    if ((serialPort2.IsOpen == false) && (sp2Open))
                        SerialPort2_Close();
                    if ((serialPort1.IsOpen == true) && (!sp1Open))  //未知原因
                        SerialPort1_Open();
                    if ((serialPort2.IsOpen == true) && (!sp2Open))
                        SerialPort2_Open();
                    return;
                }
                if (LastPorts.Length != 0)  //可用端口改变
                {
                    cbxPort1.Items.Clear();
                    cbxPort2.Items.Clear();
                }
                foreach (string port in ports)  //扫描并添加可用端口
                {
                    cbxPort1.Items.Add(port);
                    cbxPort2.Items.Add(port);
                }
                LastPorts = ports;
                cbxPort1.Text = cbxPort2.Text = ports[0];  //默认选择第一个可用端口
            }
        }
        /***********************
         打开主串口后需要完成的一系列操作
         **********************/
        private void SerialPort1_Open()
        {
            btnOpen1.Image = Properties.Resources.ledon;
            btnOpen1.Text = "断开连接";
            cbxPort1.Enabled = false;
            cbxBaudRate1.Enabled = false;
            lblVersion.Text = version;
            tmrPortRcv.Enabled = true;
            sp1Open = true;
        }
        /***********************
         打开外部输入串口后需要完成的一系列操作
         **********************/
        private void SerialPort2_Open()
        {
            btnOpen2.Image = Properties.Resources.ledon;
            btnOpen2.Text = "断开连接";
            cbxPort2.Enabled = false;
            cbxBaudRate2.Enabled = false;
            lblVersion.Text = version;
            tmrPortRcv.Enabled = true;
            sp2Open = true;
        }
        /***********************
         关闭主串口后需要完成的一系列操作
         **********************/
        private void SerialPort1_Close()
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
            cbxPort1.Enabled = true;
            cbxBaudRate1.Enabled = true;
            btnOpen1.Image = Properties.Resources.ledoff;
            btnOpen1.Text = "打开连接";
            tmrPortRcv.Enabled = false;
            sp1Open = false;
            //tab1
            btnCtrl.Image = Properties.Resources.ledoff;
            btnCtrl.Text = "开始发送";
            stat.RmCtrl = false;
            stat.inCtrl = false;
        }
        /***********************
         关闭外部输入串口后需要完成的一系列操作
         **********************/
        private void SerialPort2_Close()
        {
            if (serialPort2.IsOpen)
                serialPort2.Close();
            cbxPort2.Enabled = true;
            cbxBaudRate2.Enabled = true;
            btnOpen2.Image = Properties.Resources.ledoff;
            btnOpen2.Text = "打开连接";
            tmrPortRcv.Enabled = false;
            sp2Open = false;
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
    }
}
