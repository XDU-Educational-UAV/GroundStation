using System;
using System.Drawing;
/**************文件说明**********************
窗口收发
事件:
tmrCtrl_Tick
mrPortRcv_Tick
函数
SerialPort1_Send
Data_Receive_Precess
Limit
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        private readonly Filter[] rc = new Filter[4];
        /*为串口发送加上异常处理*/
        private void SerialPort1_Send(byte[] buffer, int count)
        {
            try
            {
                serialPort1.Write(buffer, 0, count);
            }
            catch (Exception ex)
            {
                SerialPort1_Close();
                lblVersion.Text = "串口发送失败!" + ex.Message;
            }
        }
        /*定时100ms更新与发送任务*/
        private void tmrCtrl_Tick(object sender, EventArgs e)
        {
            Key_Change();  //控制按键检测
            CtrlPanel_Update();
            CtrlMsg_Send();
            Chart_Update();
        }
        /*定时10ms处理串口接收缓冲RxStr*/
        private void tmrPortRcv_Tick(object sender, EventArgs e)
        {
            int DataAdd1 = 0, DataAdd2 = 0;
            if (serialPort1.IsOpen)
                DataAdd1 = serialPort1.BytesToRead;
            if (serialPort2.IsOpen)
                DataAdd2 = serialPort2.BytesToRead;
            if ((DataAdd1 + DataAdd2) == 0) return;
            if ((tabControl1.SelectedIndex == 0) && (DataAdd1 != 0))
            {
                Base_Text_Receive();
                return;
            }
            byte state = 1;
            int remain = DataAdd1;
            DataAdd1 = 0;
            while (remain > 0)  //可能会一次收到大量数据
            {
                try
                {
                    state = ptcl1.Byte_Receive((byte)serialPort1.ReadByte());
                    remain = serialPort1.BytesToRead;
                    lblVersion.Text = version;
                }
                catch (Exception ex)
                {
                    lblVersion.Text = ex.Message;
                }
                DataAdd1++;
                if (state == 0)
                {
                    Data_Receive_Precess(ptcl1);
                    imgBitErr.Image = Properties.Resources.correct;
                }
                else if (state == 2)
                {
                    lblCtrl.Text = "失控";
                    lblCtrl.ForeColor = Color.Red;
                    imgBitErr.Image = Properties.Resources.error;
                }
            }
            RxCount += DataAdd1;
            state = 1;
            remain = DataAdd2;
            DataAdd2 = 0;
            while (remain > 0)
            {
                try
                {
                    state = ptcl2.Byte_Receive((byte)serialPort2.ReadByte());
                    remain = serialPort2.BytesToRead;
                    lblVersion.Text = version;
                }
                catch (Exception ex)
                {
                    lblVersion.Text = ex.Message;
                }
                DataAdd2++;
                if (state == 0)
                {
                    Data_Receive_Precess(ptcl2);
                    imgBitErr.Image = Properties.Resources.correct;
                }
                else if (state == 2)
                    imgBitErr.Image = Properties.Resources.error;
            }
            RxCount += DataAdd2;
            labelRxCnt.Text = $"Rx:{RxCount}";
        }
        /*根据功能字进一步处理*/
        private void Data_Receive_Precess(Protocol pt)
        {
            if (pt.FcnByte == FuncByte.ctrlOut)
                ErrRcvCnt = 0;
            else
                ErrCnt = 0;
            byte[] RxTemp = pt.DataReceived;
            short[] sdata = new short[6];
            sdata[0] = (short)((RxTemp[0] << 8) | RxTemp[1]);
            sdata[1] = (short)((RxTemp[2] << 8) | RxTemp[3]);
            sdata[2] = (short)((RxTemp[4] << 8) | RxTemp[5]);
            sdata[3] = (short)((RxTemp[6] << 8) | RxTemp[7]);
            sdata[4] = (short)((RxTemp[8] << 8) | RxTemp[9]);
            sdata[5] = (short)((RxTemp[10] << 8) | RxTemp[11]);
            double[] ddata = new double[4];
            switch (pt.FcnByte)
            {
                case FuncByte.stat:
                    if ((RxTemp[0] & 0x01) == 0x01)
                    {
                        lblLock.Text = "解锁";
                        lblLock.ForeColor = Color.Black;
                    }
                    else
                    {
                        lblLock.Text = "锁定";
                        lblLock.ForeColor = Color.Red;
                    }
                    if ((RxTemp[0] & 0x20) == 0x20)
                        lblMode.Text = "速度模式";
                    else
                        lblMode.Text = "姿态模式";
                    double voltage = ((RxTemp[1] << 8) | RxTemp[2]) / 1000.0;
                    lblVoltage.Text = voltage.ToString("#0.000") + "V";
                    break;
                case FuncByte.atti:  //注意RxTemp为有符号16位整型
                    ddata[0] = sdata[0] / 100.0;
                    ddata[1] = sdata[1] / 100.0;
                    ddata[2] = sdata[2] / 100.0;
                    lblRoll.Text = ddata[0].ToString("#0.00");
                    lblPitch.Text = ddata[1].ToString("#0.00");
                    lblYaw.Text = ddata[2].ToString("#0.00");
                    break;
                case FuncByte.sensor:
                    lblAccx.Text = sdata[0].ToString();
                    lblAccy.Text = sdata[1].ToString();
                    lblAccz.Text = sdata[2].ToString();
                    lblGyrox.Text = sdata[3].ToString();
                    lblGyroy.Text = sdata[4].ToString();
                    lblGyroz.Text = sdata[5].ToString();
                    break;
                case FuncByte.rc:
                    lblRCrol.Text = sdata[0].ToString();
                    lblRCpit.Text = sdata[1].ToString();
                    lblRCthr.Text = sdata[2].ToString();
                    lblRCyaw.Text = sdata[3].ToString();
                    break;
                case FuncByte.motor:
                    lblM1.Text = sdata[0].ToString();
                    lblM2.Text = sdata[1].ToString();
                    lblM3.Text = sdata[2].ToString();
                    lblM4.Text = sdata[3].ToString();
                    break;
                case FuncByte.quaternion:
                    ddata[0] = sdata[0] / 10000.0;
                    ddata[1] = sdata[1] / 10000.0;
                    ddata[2] = sdata[2] / 10000.0;
                    ddata[3] = sdata[3] / 10000.0;
                    lblQ0.Text = ddata[0].ToString("#0.0000");
                    lblQ1.Text = ddata[1].ToString("#0.0000");
                    lblQ2.Text = ddata[2].ToString("#0.0000");
                    lblQ3.Text = ddata[3].ToString("#0.0000");
                    break;
                case FuncByte.rolCtrl:
                    tbxRolParam1.Text = sdata[0].ToString();
                    tbxRolParam2.Text = sdata[1].ToString();
                    tbxRolParam3.Text = sdata[2].ToString();
                    tbxRolParam4.Text = sdata[3].ToString();
                    break;
                case FuncByte.pitCtrl:
                    tbxPitParam1.Text = sdata[0].ToString();
                    tbxPitParam2.Text = sdata[1].ToString();
                    tbxPitParam3.Text = sdata[2].ToString();
                    tbxPitParam4.Text = sdata[3].ToString();
                    break;
                case FuncByte.yawCtrl:
                    tbxYawParam1.Text = sdata[0].ToString();
                    tbxYawParam2.Text = sdata[1].ToString();
                    tbxYawParam3.Text = sdata[2].ToString();
                    tbxYawParam4.Text = sdata[3].ToString();
                    break;
                case FuncByte.chart1:
                    ddata[0] = sdata[0] / 100.0;
                    ddata[1] = sdata[1] / 100.0;
                    ddata[2] = sdata[2] / 100.0;
                    ddata[3] = sdata[3] / 100.0;
                    for (int i = 0; i < 4; i++)
                        if (cbxChart[i].Checked)
                            Chart_AddPoints(ddata[i], i);
                    break;
                case FuncByte.chart2:
                    ddata[0] = sdata[0] / 100.0;
                    ddata[1] = sdata[1] / 100.0;
                    ddata[2] = sdata[2] / 100.0;
                    ddata[3] = sdata[3] / 100.0;
                    for (int i = 4; i < 8; i++)
                        if (cbxChart[i].Checked)
                            Chart_AddPoints(ddata[i - 4], i);
                    break;
                case FuncByte.ctrlOut:
                    RCdata[0] = Limit((int)rc[0].OneOrder_Filter(sdata[0]), 0, 1000);
                    RCdata[1] = Limit((int)rc[1].OneOrder_Filter(sdata[1]), 0, 1000);
                    RCdata[2] = Limit((int)rc[2].OneOrder_Filter(sdata[2]), 0, 1000);
                    RCdata[3] = Limit((int)rc[3].OneOrder_Filter(sdata[3]), 0, 1000);
                    break;
                case FuncByte.highspeed:
                    ddata[0] = sdata[0] * 0.0076293945;
                    ddata[1] = sdata[1] * 0.0076293945;
                    if (dataFile != null)
                        dataFile.Write_Double_Pair_Data(ddata[0], ddata[1]);
                    break;
                default: break;
            }
        }
        private static int Limit(int num, int min, int max)
        {
            return num <= min ? (min) : (num >= max ? max : num);
        }
    }
}
