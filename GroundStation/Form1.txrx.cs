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
        /***********************
         为串口发送加上异常处理
         **********************/
        private void SerialPort1_Send(byte[] buffer, int count)
        {
            try
            {
                serialPort1.Write(buffer, 0, count);
            }
            catch (Exception)
            {
                SerialPort1_Close();
            };
        }
        /*定时100ms发送任务*/
        private void tmrCtrl_Tick(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    CtrlPanel_Update();
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
                    Data_Receive_Precess(ptcl1);
                else if (state == 2)
                {
                    lblCtrl.Text = "失控";
                    lblCtrl.ForeColor = Color.Red;
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
                    state = ptcl2.Byte_Receive((byte)serialPort1.ReadByte());
                    remain = serialPort2.BytesToRead;
                    lblVersion.Text = version;
                }
                catch (Exception ex)
                {
                    lblVersion.Text = ex.Message;
                }
                DataAdd2++;
                if (state == 0)
                    Data_Receive_Precess(ptcl2);
            }
            RxCount += DataAdd2;
            labelRxCnt.Text = $"Rx:{RxCount}";
        }
        /***********************
         根据功能字进一步处理
         **********************/
        private void Data_Receive_Precess(Protocol pt)
        {
            if (pt.FcnWord == FuncByte.ctrlOut)
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
            int[] idata = new int[4];
            idata[0] = ((RxTemp[0] << 8) | RxTemp[1]);
            idata[1] = ((RxTemp[2] << 8) | RxTemp[3]);
            idata[2] = ((RxTemp[4] << 8) | RxTemp[5]);
            idata[3] = ((RxTemp[6] << 8) | RxTemp[7]);
            double[] ddata = new double[4];
            switch (pt.FcnWord)
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
                    lblRCrol.Text = idata[0].ToString();
                    lblRCpit.Text = idata[1].ToString();
                    lblRCthr.Text = idata[2].ToString();
                    lblRCyaw.Text = idata[3].ToString();
                    break;
                case FuncByte.motor:
                    lblM1.Text = idata[0].ToString();
                    lblM2.Text = idata[1].ToString();
                    lblM3.Text = idata[2].ToString();
                    lblM4.Text = idata[3].ToString();
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
                    if (stat.TextSave)
                    {
                        tbxRolParam1.Text = idata[0].ToString();
                        tbxRolParam2.Text = idata[1].ToString();
                        tbxRolParam3.Text = idata[2].ToString();
                        tbxRolParam4.Text = sdata[3].ToString();
                    }
                    else
                    {
                        ddata[0] = idata[0] / 1000.0;
                        ddata[1] = idata[1] / 1000.0;
                        ddata[2] = idata[2] / 1000.0;
                        ddata[3] = sdata[3] / 100.0;
                        lblRolParam1.Text = ddata[0].ToString("#0.000");
                        lblRolParam2.Text = ddata[1].ToString("#0.000");
                        lblRolParam3.Text = ddata[2].ToString("#0.000");
                        lblRolParam4.Text = ddata[3].ToString("#0.00");
                    }
                    break;
                case FuncByte.pitCtrl:
                    if (stat.TextSave)
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
                        lblPitParam1.Text = ddata[0].ToString("#0.000");
                        lblPitParam2.Text = ddata[1].ToString("#0.000");
                        lblPitParam3.Text = ddata[2].ToString("#0.000");
                        lblPitParam4.Text = ddata[3].ToString("#0.000");
                    }
                    break;
                case FuncByte.rolStat:
                    ddata[0] = sdata[0] / 100.0;
                    ddata[1] = sdata[1] / 100.0;
                    ddata[2] = sdata[2] / 100.0;
                    ddata[3] = sdata[3] / 100.0;
                    lblRolSt1.Text = ddata[0].ToString("#0.000");
                    lblRolSt2.Text = ddata[1].ToString("#0.000");
                    lblRolSt3.Text = ddata[2].ToString("#0.000");
                    lblRolSt4.Text = ddata[3].ToString("#0.000");
                    for (int i = 0; i < 4; i++)
                        if (cbxData[i].Checked)
                            Chart_Update(ddata[i], i);
                    break;
                case FuncByte.pitStat:
                    ddata[0] = sdata[0] / 100.0;
                    ddata[1] = sdata[1] / 100.0;
                    ddata[2] = sdata[2] / 100.0;
                    ddata[3] = sdata[3] / 100.0;
                    lblPitSt1.Text = ddata[0].ToString("#0.000");
                    lblPitSt2.Text = ddata[1].ToString("#0.000");
                    lblPitSt3.Text = ddata[2].ToString("#0.000");
                    lblPitSt4.Text = ddata[3].ToString("#0.000");
                    for (int i = 4; i < 8; i++)
                        if (cbxData[i].Checked)
                            Chart_Update(ddata[i - 4], i);
                    break;
                case FuncByte.ctrlOut:
                    RCdata[0] = Limit(idata[0], 0, 1000);
                    RCdata[1] = Limit(idata[1], 0, 1000);
                    RCdata[2] = Limit(idata[2], 0, 1000);
                    RCdata[3] = Limit(idata[3], 0, 1000);
                    break;
                default: break;
            }
        }
        private int Limit(int num, int min, int max)
        {
            return num <= min ? (min) : (num >= max ? max : num);
        }
    }
}
