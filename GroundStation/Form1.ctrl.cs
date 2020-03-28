using System;
using System.Drawing;
/**************文件说明**********************
飞行控制,包括接收并处理下位机消息,向下位机发送指令
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        byte[] CtrlByte = new byte[12];  //发送给下位机的有效数据
        byte ErrCnt = 0;
        byte GlobalStat = 0;
        //GlobalStat状态定义
        //BIT7:建立控制链路
        //BIT6:已解锁
        //BIT1:控制器参数保存至文本框
        //BIT0:发送请求解锁或锁定命令
        int[] RolParam = new int[3];
        int[] PitParam = new int[3];

        /***********************
        根据功能字进一步处理
        **********************/
        private void Data_Receive_Precess(byte fcn)
        {
            if ((GlobalStat & 0x80) == 0x80)
            {
                lblCtrl.Text = "控制中";
                lblCtrl.ForeColor = Color.Black;
            }
            ErrCnt = 0;
            double[] ddata = new double[3];
            //int[] idata = new int[4];
            short[] sdata = new short[6];
            switch (fcn)
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
                    }
                    double voltage = RxTemp[1] * 2 / 100.0;
                    lblVoltage.Text = voltage.ToString("#0.00");
                    break;
                case 0x02:  //注意RxTemp为有符号16位整型
                    sdata[0] = (short)((RxTemp[0] << 8) | RxTemp[1]);
                    sdata[1] = (short)((RxTemp[2] << 8) | RxTemp[3]);
                    sdata[2] = (short)((RxTemp[4] << 8) | RxTemp[5]);
                    ddata[0]=sdata[0]/100.0;
                    ddata[1]=sdata[1]/100.0;
                    ddata[2] = sdata[2] / 100.0;
                    lblRoll.Text = ddata[0].ToString("#0.00");
                    lblPitch.Text = ddata[1].ToString("#0.00");
                    lblYaw.Text = ddata[2].ToString("#0.00");
                    break;
                case 0x04:
                    sdata[0]= (short)((RxTemp[0] << 8) | RxTemp[1]);
                    sdata[1]= (short)((RxTemp[2] << 8) | RxTemp[3]);
                    sdata[2]= (short)((RxTemp[4] << 8) | RxTemp[5]);
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
                    int RCrol = ((RxTemp[0] << 8) | RxTemp[1]) / 10;
                    int RCpit = ((RxTemp[2] << 8) | RxTemp[3]) / 10;
                    int RCthr = ((RxTemp[4] << 8) | RxTemp[5]) / 10;
                    int RCyaw = ((RxTemp[6] << 8) | RxTemp[7]) / 10;
                    hScrollRol.Value = 100 - RCrol;
                    vScrollPit.Value = 100 - RCpit;
                    vScrollThr.Value = 100 - RCthr;
                    hScrollYaw.Value = 100 - RCyaw;
                    lblRCrol.Text = RCrol.ToString();
                    lblRCpit.Text = RCpit.ToString();
                    lblRCthr.Text = RCthr.ToString();
                    lblRCyaw.Text = RCyaw.ToString();
                    break;
                case 0x10:
                    sdata[0] = (short)((RxTemp[0] << 8) | RxTemp[1]);
                    sdata[1] = (short)((RxTemp[2] << 8) | RxTemp[3]);
                    sdata[2] = (short)((RxTemp[4] << 8) | RxTemp[5]);
                    sdata[3] = (short)((RxTemp[6] << 8) | RxTemp[7]);
                    lblM1.Text = sdata[0].ToString();
                    lblM2.Text = sdata[1].ToString();
                    lblM3.Text = sdata[2].ToString();
                    lblM4.Text = sdata[3].ToString();
                    break;
                case 0xA1:
                    RolParam[0] = (RxTemp[0] << 8) | RxTemp[1];
                    RolParam[1] = (RxTemp[2] << 8) | RxTemp[3];
                    RolParam[2] = (RxTemp[4] << 8) | RxTemp[5];
                    if ((GlobalStat & 0x02) == 0x02)
                    {
                        tbxRolParam1.Text = RolParam[0].ToString();
                        tbxRolParam2.Text = RolParam[1].ToString();
                        tbxRolParam3.Text = RolParam[2].ToString();
                    }
                    else
                    {
                        ddata[0] = RolParam[0] / 1000.0;
                        ddata[1] = RolParam[1] / 1000.0;
                        ddata[2] = RolParam[2] / 1000.0;
                        lblRolParam1.Text = ddata[0].ToString("#0.00");
                        lblRolParam2.Text = ddata[1].ToString("#0.00");
                        lblRolParam3.Text = ddata[2].ToString("#0.00");
                    }
                    break;
                case 0xA3:
                    PitParam[0] = (RxTemp[0] << 8) | RxTemp[1];
                    PitParam[1] = (RxTemp[2] << 8) | RxTemp[3];
                    PitParam[2] = (RxTemp[4] << 8) | RxTemp[5];
                    if ((GlobalStat & 0x02) == 0x02)
                    {
                        tbxPitParam1.Text = PitParam[0].ToString();
                        tbxPitParam2.Text = PitParam[1].ToString();
                        tbxPitParam3.Text = PitParam[2].ToString();
                    }
                    else
                    {
                        ddata[0] = PitParam[0] / 1000.0;
                        ddata[1] = PitParam[1] / 1000.0;
                        ddata[2] = PitParam[2] / 1000.0;
                        lblPitParam1.Text = ddata[0].ToString("#0.00");
                        lblPitParam2.Text = ddata[1].ToString("#0.00");
                        lblPitParam3.Text = ddata[2].ToString("#0.00");
                    }
                    break;
                case 0xA2:
                    sdata[0] = (short)((RxTemp[0] << 8) | RxTemp[1]);
                    sdata[1] = (short)((RxTemp[2] << 8) | RxTemp[3]);
                    sdata[2] = (short)((RxTemp[4] << 8) | RxTemp[5]);
                    ddata[0] = sdata[0] / 100.0;
                    ddata[1] = sdata[1] / 100.0;
                    ddata[2] = sdata[2] / 100.0;
                    lblRolG.Text = ddata[0].ToString("#0.00");
                    lblRolGe.Text = ddata[1].ToString("#0.00");
                    lblRolAe.Text = ddata[2].ToString("#0.00");
                    break;
                case 0xA4:
                    sdata[0] = (short)((RxTemp[0] << 8) | RxTemp[1]);
                    sdata[1] = (short)((RxTemp[2] << 8) | RxTemp[3]);
                    sdata[2] = (short)((RxTemp[4] << 8) | RxTemp[5]);
                    ddata[0] = sdata[0] / 100.0;
                    ddata[1] = sdata[1] / 100.0;
                    ddata[2] = sdata[2] / 100.0;
                    lblPitG.Text = ddata[0].ToString("#0.00");
                    lblPitGe.Text = ddata[1].ToString("#0.00");
                    lblPitAe.Text = ddata[2].ToString("#0.00");
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
            if (ErrCnt >= 20)
            {
                lblCtrl.Text = "失控";
                lblCtrl.ForeColor = Color.Red;
            }
            if ((GlobalStat & 0x01) == 0x01)
            {
                XDAA_Send_Cmd(0x48);
                serialPort1.Write(CtrlByte, 0, 6);
                GlobalStat &= 0xFE;
            }
            else
            {
                XDAA_Send_RCdata();
                serialPort1.Write(CtrlByte, 0, 12);
                GlobalStat &= 0xFD;
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
