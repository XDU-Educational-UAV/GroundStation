using System;
using System.Windows.Forms;
/**************文件说明**********************
控制器参数读写
事件:
btnRead_Click
btnWrite_Click
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        private FileWrite dataFile;
        /*读取控制器参数*/
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            switch (((Button)sender).Name)
            {
                case "btnReadRol": TxCount += ptcl1.Send_Req(0xC2, 0x01, SerialPort1_Send); break;
                case "btnReadPit": TxCount += ptcl1.Send_Req(0xC2, 0x02, SerialPort1_Send); break;
                case "btnReadYaw": TxCount += ptcl1.Send_Req(0xC2, 0x04, SerialPort1_Send); break;
                default: break;
            }
            labelTxCnt.Text = $"Tx:{TxCount}";
        }
        /*写入控制器参数*/
        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            int[] idata = new int[4];
            try
            {
                switch (((Button)sender).Name)
                {
                    case "btnWriteRol":
                        idata[0] = Convert.ToInt32(tbxRolParam1.Text);
                        idata[1] = Convert.ToInt32(tbxRolParam2.Text);
                        idata[2] = Convert.ToInt32(tbxRolParam3.Text);
                        idata[3] = Convert.ToInt32(tbxRolParam4.Text);
                        TxCount += ptcl1.Send_S16_Data(idata, 4, 0xA1, SerialPort1_Send);
                        break;
                    case "btnWritePit":
                        idata[0] = Convert.ToInt32(tbxPitParam1.Text);
                        idata[1] = Convert.ToInt32(tbxPitParam2.Text);
                        idata[2] = Convert.ToInt32(tbxPitParam3.Text);
                        idata[3] = Convert.ToInt32(tbxPitParam4.Text);
                        TxCount += ptcl1.Send_S16_Data(idata, 4, 0xA2, SerialPort1_Send);
                        break;
                    case "btnWriteYaw":
                        idata[0] = Convert.ToInt32(tbxYawParam1.Text);
                        idata[1] = Convert.ToInt32(tbxYawParam2.Text);
                        idata[2] = Convert.ToInt32(tbxYawParam3.Text);
                        idata[3] = Convert.ToInt32(tbxYawParam4.Text);
                        TxCount += ptcl1.Send_S16_Data(idata, 4, 0xA3, SerialPort1_Send);
                        break;
                    default: break;
                }
                labelTxCnt.Text = $"Tx:{TxCount}";
            }
            catch (Exception) { }
        }
        private void cbxFileWrite_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFileWrite.Checked)
            {
                dataFile = new FileWrite();
                TxCount += ptcl1.Send_Req(0xC4, 0x03, SerialPort1_Send);
            }
            else
            {
                TxCount += ptcl1.Send_Req(0xC4, 0, SerialPort1_Send);
                dataFile.Write_File();
            }
            labelTxCnt.Text = $"Tx:{TxCount}";
        }
    }
}
