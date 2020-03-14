using System;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;

namespace GroundStation
{
    public partial class Form1 : Form
    {
        string[] LastPorts = { };
        const string version = "V0.01";
        int TxCount = 0, RxCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Text = "115200";
            label4.Text = "Ground Station " + version;
        }
        #region 串口开闭相关函数
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
                timer3.Enabled = true;
            }
            catch (Exception)
            {
                label4.Text = "串口打开失败!";  //已选端口被占用
            }
        }
        /*定时每秒检测端口状况*/
        private void timer1_Tick(object sender, EventArgs e)
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
            btnOpen.Image = Properties.Resources.ledoff;
            btnOpen.Text = "打开连接";
            cbxPort.Enabled = true;
            comboBox2.Enabled = true;
            timer3.Enabled = false;
        }
        #endregion

        #region 串口收发相关函数
        /*发送按钮*/
        private void btnSend1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                my_SerialPort_Send(textBox1, rbtnSend1CHR);
        }
        private void btnSend2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                my_SerialPort_Send(textBox2, rbtnSend2CHR);
        }
        /*定时1ms处理串口接收缓冲RxStr*/
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
                return;
            if (serialPort1.BytesToRead == 0)
                return;
            if (rbtnRcvCHR.Checked)  //字符串方式读
            {
                string str = serialPort1.ReadExisting();
                tbxRx.AppendText(str);
            }
            else  //16进制方式读
            {
                string str = "";
                do
                {
                    byte temp = (byte)serialPort1.ReadByte();
                    if (temp <= 0x0F)
                        str += "0" + Convert.ToString(temp, 16).ToUpper() + " ";
                    else
                        str += Convert.ToString(temp, 16).ToUpper() + " ";
                    RxCount++;
                } while (serialPort1.BytesToRead > 0);
                tbxRx.AppendText(str);
                labelRxCnt.Text = $"Rx:{RxCount}";
            }
        }
        /*串口发送数据*/
        private void my_SerialPort_Send(TextBox box, RadioButton btnChr)
        {
            string text = box.Text;
            if (text == "")
                return;
            TxCount += text.Length;
            labelTxCnt.Text = $"Tx:{TxCount}";
            if (btnChr.Checked)  //字符串方式发送
                serialPort1.Write(text);
            else  //16进制方式发送
            {
                string HexText = text.Replace(" ", "");
                int BufferSize = HexText.Length / 2;
                byte[] HexData = new byte[BufferSize];
                try
                {
                    for (int i = 0; i < BufferSize; i++)
                        HexData[i] = Convert.ToByte(HexText.Substring(2 * i, 2), 16);
                    serialPort1.Write(HexData, 0, BufferSize);
                }
                catch (Exception) { }  //存在十六进制外的字符串
            }
        }
        #endregion

        #region 定时发送相关函数
        /*定时发送复选框*/
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }
        /*定时发送*/
        private void timer2_Tick(object sender, EventArgs e)
        {
            my_SerialPort_Send(textBox1, rbtnSend1CHR);
        }
        /*发送间隔设置文本框*/
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer2.Enabled = true;
                timer2.Interval = Convert.ToInt32(tbxInterval.Text);
            }
            else
                timer2.Enabled = false;
        }
        #endregion

        private void btnClearBuf_Click(object sender, EventArgs e)
        {
            tbxRx.Text = "";
        }

        private void btnCnt_Click(object sender, EventArgs e)
        {
            TxCount = 0;
            RxCount = 0;
            labelTxCnt.Text = "Tx:0";
            labelRxCnt.Text = "Rx:0";
        }
    }
}
