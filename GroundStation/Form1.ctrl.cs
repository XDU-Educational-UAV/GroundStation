using System;
using System.Drawing;
/**************文件说明**********************
飞行控制,包括接收并处理下位机消息,向下位机发送指令
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        private byte ErrCnt = 0, GlobalStat = 0;
        //GlobalStat状态定义
        //BIT7:建立控制链路
        //BIT6:已解锁
        //BIT1:控制器参数保存至文本框
        //BIT0:发送请求解锁或锁定命令

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
                    break;
                case 0xA4:
                    sdata[0] = (short)((RxTemp[0] << 8) | RxTemp[1]);
                    sdata[1] = (short)((RxTemp[2] << 8) | RxTemp[3]);
                    sdata[2] = (short)((RxTemp[4] << 8) | RxTemp[5]);
                    ddata[0] = sdata[0] / 100.0;
                    ddata[1] = sdata[1] / 100.0;
                    ddata[2] = sdata[2] / 100.0;
                    lblPitSt1.Text = ddata[0].ToString("#0.00");
                    lblPitSt2.Text = ddata[1].ToString("#0.00");
                    lblPitSt3.Text = ddata[2].ToString("#0.00");
                    break;
                default: break;
            }
        }
        /***********************
        100ms定时任务
        **********************/
        private void tmrCtrl_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) return;
            if (tabControl1.SelectedIndex == 2)
                Status_Display();
            if (tabControl1.SelectedIndex != 1) return;
            Key_Change();  //按键检测
            if ((GlobalStat & 0x80) != 0x80)
                return;  //没有与下位机建立通信
            ErrCnt++;
            byte DataAdd = 0, password = 0;
            if (ErrCnt >= 20)
            {
                lblCtrl.Text = "失控";
                lblCtrl.ForeColor = Color.Red;
            }
            if ((GlobalStat & 0x01) == 0x01)
            {
                if (tbxPassword.Text == "") return;
                try
                {
                    Convert.ToByte(tbxPassword.Text, 16);
                }
                catch (Exception) { }
                if ((GlobalStat & 0x040) == 0x40)
                    DataAdd = ptcl.Send_Cmd(password, 0);
                else
                    DataAdd = ptcl.Send_Cmd(password, 0x01);
                serialPort1.Write(ptcl.DataToSend, 0, DataAdd);
                GlobalStat &= 0xFE;
                TxCount += DataAdd;
            }
            else
            {
                int[] RCdata = new int[4];
                RCdata[0] = 10 * (100 - hScrollRol.Value);
                RCdata[1] = 10 * (100 - vScrollPit.Value);
                RCdata[2] = 10 * (100 - vScrollThr.Value);
                RCdata[3] = 10 * (100 - hScrollYaw.Value);
                DataAdd = ptcl.Send_S16_Data(RCdata, 4, 0x08);
                serialPort1.Write(ptcl.DataToSend, 0, DataAdd);
                GlobalStat &= 0xFD;
                TxCount += DataAdd;
            }
            labelTxCnt.Text = $"Tx:{TxCount}";
        }
        /*建立控制链路按钮,按下后开始发送数据*/
        private void btnCtrl_Click(object sender, EventArgs e)
        {
            if ((GlobalStat & 0x80) == 0x80)
            {
                GlobalStat &= 0x7F;
                btnCtrl.Image = Properties.Resources.ledoff;
                btnCtrl.Text = "建立控制链路";
                lblCtrl.Text = "失控";
                lblCtrl.ForeColor = Color.Red;
            }
            else if (serialPort1.IsOpen)
            {
                GlobalStat |= 0x80;
                btnCtrl.Image = Properties.Resources.ledon;
                btnCtrl.Text = "断开控制链路";
            }
        }
        /*此按钮只发送锁定/解锁命令,按钮名称的更改在定时任务中*/
        private void btnLock_Click(object sender, EventArgs e)
        {
            if ((GlobalStat & 0x80) != 0x80)
                return;
            GlobalStat |= 0x01;
        }
    }
}
