using System;
using System.Windows.Forms;
using System.Drawing;
/**************文件说明**********************
标签1:飞行控制
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        byte[] CtrlByte = new byte[12];  //发送给下位机的有效数据
        byte[] RcvByte = new byte[12];  //来自下位机的有效数据
        byte ErrCnt = 0;
        byte KeyState = 0, GlobalStat = 0;
        //GlobalStat状态定义
        //BIT4:已解锁
        //BIT0:按下解锁按钮
        /***********************
        对从串口收到的数据进行预处理并将有效数据保存至RcvByte
        **********************/
        private void Tab1_Text_Receive()
        {
            byte RxData, RxState = 0, sum = 0, i = 0, FcnWord = 0, LenWord = 0;
            byte RcvFrame = 0;
            do
            {
                RxData = (byte)serialPort1.ReadByte();
                switch (RxState)
                {
                    case 0:
                        if (RxData == '>')
                        {
                            sum = RxData;
                            RxState = 1;
                        }
                        break;
                    case 1:
                        sum += RxData;
                        FcnWord = RxData;
                        RxState = 2;
                        break;
                    case 2:
                        if (RxState <= 12)
                        {
                            sum += RxData;
                            LenWord = RxData;
                            RxState = 3;
                        }
                        else
                        {
                            sum = 0;
                            RxState = 0;
                        }
                        break;
                    case 3:  //临时保存待用数据
                        sum += RxData;
                        RcvByte[i++] = RxData;
                        if (i >= LenWord)
                            RxState = 4;
                        break;
                    case 4:  //匹配校验和
                        RxState = 0;
                        i = 0;
                        if (sum == RxData)
                            RcvFrame = 1;
                        else
                            lblCtrl.Text = "失控";
                        break;
                    default: break;
                }
                RxCount++;
                if (RcvFrame == 1)  //收到了正确的数据帧
                {
                    Data_Receive_Precess(FcnWord);
                    lblCtrl.Text = "控制中";
                    lblCtrl.ForeColor = Color.Black;
                    ErrCnt = 0;
                    RcvFrame = 0;
                }
            } while (serialPort1.BytesToRead > 0);
            labelRxCnt.Text = $"Rx:{RxCount}";
        }
        /***********************
        根据功能字进一步处理
        **********************/
        private void Data_Receive_Precess(byte fcn)
        {
            switch (fcn)
            {
                case 0x01:
                    if ((RcvByte[0] & 0x01) == 0x01)
                        GlobalStat |= 0x10;
                    else
                        GlobalStat &= 0xEF;
                    double voltage = RcvByte[1] * 2 / 100.0;
                    lblVoltage.Text = voltage.ToString("#0.00");
                    break;
                case 0x02:  //注意RcvByte为有符号16位整型
                    short rol0 = (short)((RcvByte[0] << 8) | RcvByte[1]);
                    short pit0 = (short)((RcvByte[2] << 8) | RcvByte[3]);
                    short yaw0 = (short)((RcvByte[4] << 8) | RcvByte[5]);
                    int rol1 = rol0 / 100; byte rol2 = (byte)(rol0 % 100);
                    int pit1 = pit0 / 100; byte pit2 = (byte)(pit0 % 100);
                    int yaw1 = yaw0 / 100; byte yaw2 = (byte)(yaw0 % 100);
                    lblRoll.Text = rol1.ToString() + "." + rol2.ToString();
                    lblPitch.Text = pit1.ToString() + "." + pit2.ToString();
                    lblYaw.Text = yaw1.ToString() + "." + yaw2.ToString();
                    break;
                case 0x04:
                    short accx = (short)((RcvByte[0] << 8) | RcvByte[1]);
                    short accy = (short)((RcvByte[2] << 8) | RcvByte[3]);
                    short accz = (short)((RcvByte[4] << 8) | RcvByte[5]);
                    short gyrox = (short)((RcvByte[6] << 8) | RcvByte[7]);
                    short gyroy = (short)((RcvByte[8] << 8) | RcvByte[9]);
                    short gyroz = (short)((RcvByte[10] << 8) | RcvByte[11]);
                    lblAccx.Text = accx.ToString();
                    lblAccy.Text = accy.ToString();
                    lblAccz.Text = accz.ToString();
                    lblGyrox.Text = gyrox.ToString();
                    lblGyroy.Text = gyroy.ToString();
                    lblGyroz.Text = gyroz.ToString();
                    break;
                case 0x08:
                    int RCrol = ((RcvByte[0] << 8) | RcvByte[1]) / 10;
                    int RCpit = ((RcvByte[2] << 8) | RcvByte[3]) / 10;
                    int RCthr = ((RcvByte[4] << 8) | RcvByte[5]) / 10;
                    int RCyaw = ((RcvByte[6] << 8) | RcvByte[7]) / 10;
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
                    short motor1=(short)((RcvByte[0]<<8)|RcvByte[1]);
                    short motor2=(short)((RcvByte[2]<<8)|RcvByte[3]);
                    short motor3=(short)((RcvByte[4]<<8)|RcvByte[5]);
                    short motor4=(short)((RcvByte[6]<<8)|RcvByte[7]);
                    lblM1.Text=motor1.ToString();
                    lblM2.Text=motor2.ToString();
                    lblM3.Text=motor3.ToString();
                    lblM4.Text=motor4.ToString();
                    break;
                default: break;
            }
        }
        /***********************
        100ms定时发送任务
        **********************/
        private void tmrCtrl_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
                return;
            int[] CtrlChannel = new int[4];  //4个控制通道
            ErrCnt++;
            if (ErrCnt >= 20)
            {
                lblCtrl.Text = "失控";
                lblCtrl.ForeColor = Color.Red;
            }
            if ((GlobalStat & 0x10) == 0x10)
            {
                btnLock.Text = "锁定";
                lblLock.Text = "解锁";
                lblLock.ForeColor = Color.Black;
            }
            else
            {
                btnLock.Text = "解锁";
                lblLock.Text = "锁定";
                lblLock.ForeColor = Color.Red;
            }
            CtrlChannel[0] = (short)(100 - hScrollRol.Value);
            CtrlChannel[1] = (short)(100 - vScrollPit.Value);
            CtrlChannel[2] = (short)(100 - vScrollThr.Value);
            CtrlChannel[3] = (short)(100 - hScrollYaw.Value);
            if (((KeyState & 0x01) == 0x01) && (CtrlChannel[0] < 100))
                CtrlChannel[0]++;
            if (((KeyState & 0x02) == 0x02) && (CtrlChannel[0] > 0))
                CtrlChannel[0]--;
            if (((KeyState & 0x04) == 0x04) && (CtrlChannel[1] < 100))
                CtrlChannel[1]++;
            if (((KeyState & 0x08) == 0x08) && (CtrlChannel[1] > 0))
                CtrlChannel[1]--;
            if (((KeyState & 0x10) == 0x10) && (CtrlChannel[2] < 100))
                CtrlChannel[2]++;
            if (((KeyState & 0x20) == 0x20) && (CtrlChannel[2] > 0))
                CtrlChannel[2]--;
            if (((KeyState & 0x40) == 0x40) && (CtrlChannel[3] < 100))
                CtrlChannel[3]++;
            if (((KeyState & 0x80) == 0x80) && (CtrlChannel[3] > 0))
                CtrlChannel[3]--;
            CtrlChannel[0] *= 10;
            CtrlChannel[1] *= 10;
            CtrlChannel[2] *= 10;
            CtrlChannel[3] *= 10;
            if ((GlobalStat & 0x01) == 0x01)
            {
                XDAA_Send_Cmd(0x48);
                serialPort1.Write(CtrlByte, 0, 6);
                GlobalStat &= 0xFE;
            }
            else
            {
                XDAA_Send_RCdata(CtrlChannel);
                serialPort1.Write(CtrlByte, 0, 12);
            }
            labelTxCnt.Text = $"Tx:{TxCount}";
        }
        //
        private void btnCtrl_Click(object sender, EventArgs e)
        {
            if (tmrCtrl.Enabled)
            {
                btnCtrl.Image = Properties.Resources.ledoff;
                btnCtrl.Text = "建立控制链路";
                tmrCtrl.Enabled = false;
                btnLock.Text = "解锁";
                lblCtrl.Text = "失控";
                lblCtrl.ForeColor = Color.Red;
            }
            else if (serialPort1.IsOpen)
            {
                btnCtrl.Image = Properties.Resources.ledon;
                btnCtrl.Text = "断开控制链路";
                tmrCtrl.Enabled = true;
            }
        }
        //此按钮只发送锁定/解锁命令,按钮名称的更改在定时任务中
        private void btnLock_Click(object sender, EventArgs e)
        {
            if (!tmrCtrl.Enabled)
                return;
            GlobalStat |= 0x01;
        }
        /***********************
        发送解锁帧
        **********************/
        private void XDAA_Send_Cmd(byte password)
        {
            byte sum = 0x3F;
            byte state;
            if ((GlobalStat & 0x10) == 0x10)  //解锁状态下发送锁定命令
                state = 0;
            else
                state = 0x01;
            CtrlByte[0] = 0x3C;
            CtrlByte[1] = 0x01;
            CtrlByte[2] = 0x02;
            CtrlByte[3] = state;
            CtrlByte[4] = password;
            sum += state;
            sum += password;
            CtrlByte[5] = sum;
            TxCount += 6;
        }
        private void XDAA_Send_RCdata(int[] rc)
        {
            byte sum = 0;
            CtrlByte[0] = 0x3C;
            CtrlByte[1] = 0x08;
            CtrlByte[2] = 0x08;
            CtrlByte[3] = (byte)(rc[0] / 256);
            CtrlByte[4] = (byte)(rc[0] % 256);
            CtrlByte[5] = (byte)(rc[1] / 256);
            CtrlByte[6] = (byte)(rc[1] % 256);
            CtrlByte[7] = (byte)(rc[2] / 256);
            CtrlByte[8] = (byte)(rc[2] % 256);
            CtrlByte[9] = (byte)(rc[3] / 256);
            CtrlByte[10] = (byte)(rc[3] % 256);
            for (int i = 0; i < 11; i++)
                sum += CtrlByte[i];
            CtrlByte[11] = sum;
            TxCount += 12;
        }
        private void tabControl1_KeyUp(object sender, KeyEventArgs e)
        {
            Keys CtrlKey = e.KeyCode;
            if (CtrlKey == Keys.J)
                KeyState &= 0xFE;
            if (CtrlKey == Keys.L)
                KeyState &= 0xFD;
            if (CtrlKey == Keys.I)
                KeyState &= 0xFB;
            if (CtrlKey == Keys.K)
                KeyState &= 0xF7;
            if (CtrlKey == Keys.W)
                KeyState &= 0xEF;
            if (CtrlKey == Keys.S)
                KeyState &= 0xDF;
            if (CtrlKey == Keys.A)
                KeyState &= 0xBF;
            if (CtrlKey == Keys.D)
                KeyState &= 0x7F;
        }
        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys CtrlKey = e.KeyCode;
            if (CtrlKey == Keys.J)
                KeyState |= 0x01;
            if (CtrlKey == Keys.L)
                KeyState |= 0x02;
            if (CtrlKey == Keys.I)
                KeyState |= 0x04;
            if (CtrlKey == Keys.K)
                KeyState |= 0x08;
            if (CtrlKey == Keys.W)
                KeyState |= 0x10;
            if (CtrlKey == Keys.S)
                KeyState |= 0x20;
            if (CtrlKey == Keys.A)
                KeyState |= 0x40;
            if (CtrlKey == Keys.D)
                KeyState |= 0x80;
        }
    }
}
