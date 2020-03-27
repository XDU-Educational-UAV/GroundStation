using System;
using System.Windows.Forms;
/**************文件说明**********************
标签0:基本收发
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        /*发送按钮*/
        private void btnSend1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                Tab0_Text_Send(tbxTx1, rbtnSend1CHR);
        }
        private void btnSend2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                Tab0_Text_Send(tbxTx2, rbtnSend2CHR);
        }
        private void btnSend3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                Tab0_Text_Send(tbxTx3, rbtnSend3CHR);
        }
        private void Tab0_Text_Receive()
        {
            if (rbtnRcvCHR.Checked)  //字符串方式读
            {
                string str = serialPort1.ReadExisting();
                tbxRx.AppendText(str);
                RxCount += str.Length;
            }
            else  //16进制方式读
            {
                string str = "";
                byte temp;
                do
                {
                    temp = (byte)serialPort1.ReadByte();  //使用string方式读的ASCII值是7位的,所有超过0x3F的值都以0x3F显示
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
        private void Tab0_Text_Send(TextBox box, RadioButton btnChr)
        {
            string text = box.Text;
            if (text == "")
                return;
            if (btnChr.Checked)  //字符串方式发送
            {
                serialPort1.Write(text);
                TxCount += text.Length;
            }
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
                    TxCount += BufferSize;
                }
                catch (Exception) { }  //存在十六进制外的字符串
            }
            labelTxCnt.Text = $"Tx:{TxCount}";
        }
        /*定时发送复选框*/
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }
        /*定时发送*/
        private void tmrSendUser_Tick(object sender, EventArgs e)
        {
            Tab0_Text_Send(tbxTx1, rbtnSend1CHR);
        }
        /*发送间隔设置文本框*/
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tmrSendUser.Enabled = true;
                tmrSendUser.Interval = Convert.ToInt32(tbxInterval.Text);
            }
            else
                tmrSendUser.Enabled = false;
        }
    }
}
