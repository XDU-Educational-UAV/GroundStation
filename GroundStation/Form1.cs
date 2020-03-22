using System;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
/**************文件说明**********************
主窗体生成,串口开闭与收发,所有标签的公共部分
********************************************/

namespace GroundStation
{
    public partial class Form1 : Form
    {
        string[] LastPorts = { };
        const string version = "V0.03";
        long TxCount = 0, RxCount = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Text = "115200";
            label4.Text = "Ground Station " + version;
            tabControl1.SelectedIndex = 1;
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
            tmrCtrl.Enabled = false;
            btnLock.Text = "解锁";
        }
        /*定时10ms处理串口接收缓冲RxStr*/
        private void tmrPortRcv_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
                return;
            if (serialPort1.BytesToRead == 0)
                return;
            switch (tabControl1.SelectedIndex)  //根据选中的标签判断接收到的数据用于何处
            {
                case 0: Tab0_Text_Receive(); break;
                case 1: Tab1_Text_Receive(); break;
                default: break;
            }
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
    }
}
