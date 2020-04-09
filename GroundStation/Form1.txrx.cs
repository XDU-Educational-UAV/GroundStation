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
        /***********************
         为串口发送加上异常处理
         **********************/
        private void SerialPort_Send(byte[] buffer,int count)
        {
            try
            {
            serialPort1.Write(buffer, 0, count);
            }
            catch (Exception) { };
        }
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
            byte success=1, DataAdd = 0;
            int remain=0;
            do  //可能会一次收到大量数据
            {
                try
                {
                    success = ptcl.Byte_Receive((byte)serialPort1.ReadByte());
                    remain = serialPort1.BytesToRead;
                }
                catch (Exception) { };
                DataAdd++;
                if (success == 0)
                    Data_Receive_Precess();
                else if (success == 2)
                {
                    lblCtrl.Text = "失控";
                    lblCtrl.ForeColor = Color.Red;
                }
            } while (remain > 0);
            RxCount += DataAdd;
            labelRxCnt.Text = $"Rx:{RxCount}";
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
        /***********************
         根据功能字进一步处理
         **********************/
        private void Data_Receive_Precess()
        {
            ErrCnt = 0;
            stat.inCtrl = true;
            byte[] RxTemp = ptcl.DataReceived;
            double[] ddata = new double[4];
            int[] idata = new int[4];
            short[] sdata = new short[6];
            switch (ptcl.FcnWord)
            {
                case FunctionByte.stat:
                    if ((RxTemp[0] & 0x01) == 0x01)
                        stat.isUnlock = true;
                    else
                        stat.isUnlock = false;
                    double voltage = RxTemp[1] * 2 / 100.0;
                    lblVoltage.Text = voltage.ToString("#0.00");
                    break;
                case FunctionByte.atti:  //注意RxTemp为有符号16位整型
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
                case FunctionByte.sensor:
                    sdata[0] = (short)((RxTemp[0] << 8) | RxTemp[1]);
                    sdata[1] = (short)((RxTemp[2] << 8) | RxTemp[3]);
                    sdata[2] = (short)((RxTemp[4] << 8) | RxTemp[5]);
                    sdata[3] = (short)((RxTemp[6] << 8) | RxTemp[7]);
                    sdata[4] = (short)((RxTemp[8] << 8) | RxTemp[9]);
                    sdata[5] = (short)((RxTemp[10] << 8) | RxTemp[11]);
                    lblAccx.Text = sdata[0].ToString("#0.00");
                    lblAccy.Text = sdata[1].ToString("#0.00");
                    lblAccz.Text = sdata[2].ToString("#0.00");
                    lblGyrox.Text = sdata[3].ToString("#0.00");
                    lblGyroy.Text = sdata[4].ToString("#0.00");
                    lblGyroz.Text = sdata[5].ToString("#0.00");
                    break;
                case FunctionByte.rc:
                    idata[0] = ((RxTemp[0] << 8) | RxTemp[1]) / 10;
                    idata[1] = ((RxTemp[2] << 8) | RxTemp[3]) / 10;
                    idata[2] = ((RxTemp[4] << 8) | RxTemp[5]) / 10;
                    idata[3] = ((RxTemp[6] << 8) | RxTemp[7]) / 10;
                    lblRCrol.Text = idata[0].ToString();
                    lblRCpit.Text = idata[1].ToString();
                    lblRCthr.Text = idata[2].ToString();
                    lblRCyaw.Text = idata[3].ToString();
                    break;
                case FunctionByte.motor:
                    idata[0] = (RxTemp[0] << 8) | RxTemp[1];
                    idata[1] = (RxTemp[2] << 8) | RxTemp[3];
                    idata[2] = (RxTemp[4] << 8) | RxTemp[5];
                    idata[3] = (RxTemp[6] << 8) | RxTemp[7];
                    lblM1.Text = idata[0].ToString();
                    lblM2.Text = idata[1].ToString();
                    lblM3.Text = idata[2].ToString();
                    lblM4.Text = idata[3].ToString();
                    break;
                case FunctionByte.rolCtrl:
                    idata[0] = (RxTemp[0] << 8) | RxTemp[1];
                    idata[1] = (RxTemp[2] << 8) | RxTemp[3];
                    idata[2] = (RxTemp[4] << 8) | RxTemp[5];
                    idata[3] = (RxTemp[6] << 8) | RxTemp[7];
                    if (stat.TextSave)
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
                        lblRolParam1.Text = ddata[0].ToString("#0.000");
                        lblRolParam2.Text = ddata[1].ToString("#0.000");
                        lblRolParam3.Text = ddata[2].ToString("#0.000");
                        lblRolParam4.Text = ddata[3].ToString("#0.000");
                    }
                    break;
                case FunctionByte.pitCtrl:
                    idata[0] = (RxTemp[0] << 8) | RxTemp[1];
                    idata[1] = (RxTemp[2] << 8) | RxTemp[3];
                    idata[2] = (RxTemp[4] << 8) | RxTemp[5];
                    idata[3] = (RxTemp[6] << 8) | RxTemp[7];
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
                case FunctionByte.rolStat:
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
                case FunctionByte.pitStat:
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
