using System;
using System.Drawing;
/**************文件说明**********************
窗口收发
事件:
tmrPortRcv_Tick
tmrCtrl_Tick
函数
Data_Receive_Precess
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        /*定时10ms处理串口接收缓冲RxStr*/
        private void tmrPortRcv_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            if (serialPort1.BytesToRead == 0) return;
            if (tabControl1.SelectedIndex == 0)
            {
                Base_Text_Receive();
                return;
            }
            byte success, DataAdd = 0;
            do  //可能会一次发送大量数据
            {
                success = ptcl.Byte_Receive((byte)serialPort1.ReadByte());
                DataAdd++;
                if (success == 0)
                    Data_Receive_Precess();
                else if (success == 2)
                {
                    lblCtrl.Text = "失控";
                    lblCtrl.ForeColor = Color.Red;
                }
            } while (serialPort1.BytesToRead > 0);
            RxCount += DataAdd;
            labelRxCnt.Text = $"Rx:{RxCount}";
        }
        /*定时100ms发送任务*/
        private void tmrCtrl_Tick(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    CtrlMsg_Send();
                    break;
                case 2:
                    Status_Display();
                    break;
                case 3:
                    Chart_Display();
                    break;
                default: break;
            }
        }
        /***********************
         根据功能字进一步处理
         **********************/
        private void Data_Receive_Precess()
        {
            if ((GlobalStat & 0x80) == 0x80)
            {
                lblCtrl.Text = "控制中";
                lblCtrl.ForeColor = Color.Black;
            }
            ErrCnt = 0;
            byte[] RxTemp = ptcl.DataReceived;
            double[] ddata = new double[4];
            int[] idata = new int[4];
            short[] sdata = new short[6];
            switch (ptcl.FcnWord)
            {
                case 0x01:
                    if ((RxTemp[0] & 0x01) == 0x01)
                    {
                        btnLock.Text = "锁定";
                        lblLock.Text = "解锁";
                        lblLock.ForeColor = Color.Black;
                        GlobalStat |= 0x40;
                    }
                    else
                    {
                        btnLock.Text = "解锁";
                        lblLock.Text = "锁定";
                        lblLock.ForeColor = Color.Red;
                        GlobalStat &= 0xBF;
                        vScrollThr.Value = 100;
                    }
                    double voltage = RxTemp[1] * 2 / 100.0;
                    lblVoltage.Text = voltage.ToString("#0.00");
                    break;
                case 0x02:  //注意RxTemp为有符号16位整型
                    sdata[0] = (short)((RxTemp[0] << 8) | RxTemp[1]);
                    sdata[1] = (short)((RxTemp[2] << 8) | RxTemp[3]);
                    sdata[2] = (short)((RxTemp[4] << 8) | RxTemp[5]);
                    ddata[0] = sdata[0] / 100.0;
                    ddata[1] = sdata[1] / 100.0;
                    ddata[2] = sdata[2] / 100.0;
                    lblRoll.Text = ddata[0].ToString("#0.00");
                    lblPitch.Text = ddata[1].ToString("#0.00");
                    lblYaw.Text = ddata[2].ToString("#0.00");
                    break;
                case 0x04:
                    sdata[0] = (short)((RxTemp[0] << 8) | RxTemp[1]);
                    sdata[1] = (short)((RxTemp[2] << 8) | RxTemp[3]);
                    sdata[2] = (short)((RxTemp[4] << 8) | RxTemp[5]);
                    sdata[3] = (short)((RxTemp[6] << 8) | RxTemp[7]);
                    sdata[4] = (short)((RxTemp[8] << 8) | RxTemp[9]);
                    sdata[5] = (short)((RxTemp[10] << 8) | RxTemp[11]);
                    lblAccx.Text = sdata[0].ToString();
                    lblAccy.Text = sdata[1].ToString();
                    lblAccz.Text = sdata[2].ToString();
                    lblGyrox.Text = sdata[3].ToString();
                    lblGyroy.Text = sdata[4].ToString();
                    lblGyroz.Text = sdata[5].ToString();
                    break;
                case 0x08:
                    idata[0] = ((RxTemp[0] << 8) | RxTemp[1]) / 10;
                    idata[1] = ((RxTemp[2] << 8) | RxTemp[3]) / 10;
                    idata[2] = ((RxTemp[4] << 8) | RxTemp[5]) / 10;
                    idata[3] = ((RxTemp[6] << 8) | RxTemp[7]) / 10;
                    lblRCrol.Text = idata[0].ToString();
                    lblRCpit.Text = idata[1].ToString();
                    lblRCthr.Text = idata[2].ToString();
                    lblRCyaw.Text = idata[3].ToString();
                    break;
                case 0x10:
                    idata[0] = (RxTemp[0] << 8) | RxTemp[1];
                    idata[1] = (RxTemp[2] << 8) | RxTemp[3];
                    idata[2] = (RxTemp[4] << 8) | RxTemp[5];
                    idata[3] = (RxTemp[6] << 8) | RxTemp[7];
                    lblM1.Text = idata[0].ToString();
                    lblM2.Text = idata[1].ToString();
                    lblM3.Text = idata[2].ToString();
                    lblM4.Text = idata[3].ToString();
                    break;
                case 0xA1:
                    idata[0] = (RxTemp[0] << 8) | RxTemp[1];
                    idata[1] = (RxTemp[2] << 8) | RxTemp[3];
                    idata[2] = (RxTemp[4] << 8) | RxTemp[5];
                    idata[3] = (RxTemp[6] << 8) | RxTemp[7];
                    if ((GlobalStat & 0x02) == 0x02)
                    {
                        tbxRolParam1.Text = idata[0].ToString();
                        tbxRolParam2.Text = idata[1].ToString();
                        tbxRolParam3.Text = idata[2].ToString();
                        tbxRolParam4.Text = idata[3].ToString();
                    }
                    else
                    {
                        ddata[0] = idata[0] / 1000.0;
                        ddata[1] = idata[1] / 1000.0;
                        ddata[2] = idata[2] / 1000.0;
                        ddata[3] = idata[3] / 1000.0;
                        lblRolParam1.Text = ddata[0].ToString("#0.00");
                        lblRolParam2.Text = ddata[1].ToString("#0.00");
                        lblRolParam3.Text = ddata[2].ToString("#0.00");
                        lblRolParam4.Text = ddata[3].ToString("#0.00");
                    }
                    break;
                case 0xA3:
                    idata[0] = (RxTemp[0] << 8) | RxTemp[1];
                    idata[1] = (RxTemp[2] << 8) | RxTemp[3];
                    idata[2] = (RxTemp[4] << 8) | RxTemp[5];
                    idata[3] = (RxTemp[6] << 8) | RxTemp[7];
                    if ((GlobalStat & 0x02) == 0x02)
                    {
                        tbxPitParam1.Text = idata[0].ToString();
                        tbxPitParam2.Text = idata[1].ToString();
                        tbxPitParam3.Text = idata[2].ToString();
                        tbxPitParam4.Text = idata[3].ToString();
                    }
                    else
                    {
                        ddata[0] = idata[0] / 1000.0;
                        ddata[1] = idata[1] / 1000.0;
                        ddata[3] = idata[3] / 1000.0;
                        ddata[2] = idata[2] / 1000.0;
                        lblPitParam1.Text = ddata[0].ToString("#0.00");
                        lblPitParam2.Text = ddata[1].ToString("#0.00");
                        lblPitParam3.Text = ddata[2].ToString("#0.00");
                        lblPitParam4.Text = ddata[3].ToString("#0.00");
                    }
                    break;
                case 0xA2:
                    sdata[0] = (short)((RxTemp[0] << 8) | RxTemp[1]);
                    sdata[1] = (short)((RxTemp[2] << 8) | RxTemp[3]);
                    sdata[2] = (short)((RxTemp[4] << 8) | RxTemp[5]);
                    sdata[3] = (short)((RxTemp[6] << 8) | RxTemp[7]);
                    ddata[0] = sdata[0] / 100.0;
                    ddata[1] = sdata[1] / 100.0;
                    ddata[2] = sdata[2] / 10.0;
                    ddata[3] = sdata[3] / 100.0;
                    lblRolSt1.Text = ddata[0].ToString("#0.00");
                    lblRolSt2.Text = ddata[1].ToString("#0.00");
                    lblRolSt3.Text = ddata[2].ToString("#0.00");
                    lblRolSt4.Text = ddata[3].ToString("#0.00");
                    for (int i = 0; i < 4; i++)
                        if (cbxData[i].Checked)
                            Chart_Update(ddata[i], i);
                    break;
                case 0xA4:
                    sdata[0] = (short)((RxTemp[0] << 8) | RxTemp[1]);
                    sdata[1] = (short)((RxTemp[2] << 8) | RxTemp[3]);
                    sdata[2] = (short)((RxTemp[4] << 8) | RxTemp[5]);
                    sdata[3] = (short)((RxTemp[6] << 8) | RxTemp[7]);
                    ddata[0] = sdata[0] / 100.0;
                    ddata[1] = sdata[1] / 100.0;
                    ddata[2] = sdata[2] / 100.0;
                    ddata[3] = sdata[3] / 100.0;
                    lblPitSt1.Text = ddata[0].ToString("#0.00");
                    lblPitSt2.Text = ddata[1].ToString("#0.00");
                    lblPitSt3.Text = ddata[2].ToString("#0.00");
                    lblPitSt4.Text = ddata[3].ToString("#0.00");
                    for (int i = 4; i < 8; i++)
                        if (cbxData[i].Checked)
                            Chart_Update(ddata[i], i);
                    break;
                default: break;
            }
        }
    }
}
