using System;
using System.Windows.Forms;
/**************文件说明**********************
基本收发
事件:
btnSend_Click
textBox4_TextChanged
tmrSendUser_Tick
cbxAutoSend_CheckedChanged
函数:
Base_Text_Receive
Tab0_Text_Send
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        /*发送按钮*/
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            switch (((Button)sender).Name)
            {
                case "btnSend1": Tab0_Text_Send(tbxTx1, cbxHexSend1); break;
                case "btnSend2": Tab0_Text_Send(tbxTx2, cbxHexSend2); break;
                case "btnSend3": Tab0_Text_Send(tbxTx3, cbxHexSend3); break;
                default: break;
            }
        }
        private void Base_Text_Receive()
        {
            if (!cbxHexRcv.Checked)  //字符串方式读
            {
                try
                {
                    string str = serialPort1.ReadExisting();
                    tbxRx.AppendText(str);
                    RxCount += str.Length;
                }
                catch (Exception)
                {
                    SerialPort1_Close();
                };
            }
            else  //16进制方式读
            {
                string str = "";
                byte temp;
                int remain = 0;
                do
                {
                    try
                    {
                        temp = (byte)serialPort1.ReadByte();  //使用string方式读的ASCII值是7位的,所有超过0x3F的值都以0x3F显示
                        remain = serialPort1.BytesToRead;
                        if (temp <= 0x0F)
                            str += "0" + Convert.ToString(temp, 16).ToUpper() + " ";
                        else
                            str += Convert.ToString(temp, 16).ToUpper() + " ";
                        RxCount++;
                    }
                    catch (Exception)
                    {
                        SerialPort1_Close();
                    };
                } while (remain > 0);
                tbxRx.AppendText(str);
            }
            labelRxCnt.Text = $"Rx:{RxCount}";
        }
        /*串口发送数据*/
        private void Tab0_Text_Send(TextBox box, CheckBox cbxHex)
        {
            if (!serialPort1.IsOpen) return;
            string text = box.Text;
            if (text == "") return;
            if (!cbxHex.Checked)  //字符串方式发送
            {
                try
                {
                    serialPort1.Write(text);
                    TxCount += text.Length;
                }
                catch (Exception)
                {
                    SerialPort1_Close();
                }
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
                catch (FormatException) { }  //存在十六进制外的字符串
                catch (Exception)
                {
                    SerialPort1_Close();
                }
            }
            labelTxCnt.Text = $"Tx:{TxCount}";
        }
        /*定时发送复选框*/
        private void tbxInterval_TextChanged(object sender, EventArgs e)
        {
            cbxAutoSend.Checked = false;
        }
        /*定时发送*/
        private void tmrSendUser_Tick(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                Tab0_Text_Send(tbxTx1, cbxHexSend1);
            else
                cbxAutoSend.Checked = false;
        }
        /*发送间隔设置文本框*/
        private void cbxAutoSend_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAutoSend.Checked)
            {
                tmrSendUser.Enabled = true;
                try
                {
                    tmrSendUser.Interval = Convert.ToInt32(tbxInterval.Text);
                }
                catch (Exception) { }
            }
            else
                tmrSendUser.Enabled = false;
        }
    }
}
