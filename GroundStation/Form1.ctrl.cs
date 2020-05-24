using System;
using System.Drawing;
using System.Windows.Forms;
/**************文件说明**********************
飞行控制,包括接收并处理下位机消息,向下位机发送指令
事件:
btnCtrl_Click
btnPassword_Click
函数:
CtrlPanel_Update
CtrlMsg_Send
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        private byte ErrCnt = 20, ErrRcvCnt = 0;
        GlobalStatus stat;
        private int[] RCdata = { 500, 500, 0, 500 };

        /*发送遥控信号按钮,按下后开始发送控制信号*/
        private void btnCtrl_Click(object sender, EventArgs e)
        {
            if (stat.RmCtrl)  //正在发送遥控信号,按下后停止发送
            {
                stat.RmCtrl = false;
                btnCtrl.Image = Properties.Resources.ledoff;
                btnCtrl.Text = "开始发送";
            }
            else if (serialPort1.IsOpen)  //如果串口打开就开始发送
            {
                stat.RmCtrl = true;
                btnCtrl.Image = Properties.Resources.ledon;
                btnCtrl.Text = "停止发送";
            }
        }

        /*飞行模式相关按钮:锁定解锁,模式切换*/
        private void btnFlightMode_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btnUnLock":
                    if (stat.RmCtrl)
                        TxCount += ptcl1.Send_Cmd(0x01, SerialPort1_Send);
                    break;
                case "btnLock": TxCount += ptcl1.Send_Cmd(0, SerialPort1_Send); break;
                case "btnSpeedMode": TxCount += ptcl1.Send_Cmd(0x80, SerialPort1_Send); break;
                case "btnAttiMode": TxCount += ptcl1.Send_Cmd(0x40, SerialPort1_Send); break;
                case "btnGyroCali": TxCount += ptcl1.Send_Req(0xC2, 0x80, SerialPort1_Send); break;
                case "btnAccCali": TxCount += ptcl1.Send_Req(0xC2, 0x40, SerialPort1_Send); break;
                default: break;
            }
            labelTxCnt.Text = $"Tx:{TxCount}";
        }

        /*定时更新界面*/
        private void CtrlPanel_Update()
        {
            if (ErrCnt < 20)
                stat.inCtrl = true;
            else
            {
                stat.inCtrl = false;
                ErrCnt--;
            }
            ErrCnt++;
            if (ErrRcvCnt < 10)
                stat.CtrlRcving = true;
            else
            {
                stat.CtrlRcving = false;
                ErrRcvCnt--;
            }
            ErrRcvCnt++;
            if (stat.inCtrl)
            {
                lblCtrl.Text = "控制中";
                lblCtrl.ForeColor = Color.Black;
            }
            else
            {
                lblCtrl.Text = "失控";
                lblCtrl.ForeColor = Color.Red;
            }
            if (stat.CtrlRcving)
            {
                hScrollRol.Value = 100 - RCdata[0] / 10;
                vScrollPit.Value = 100 - RCdata[1] / 10;
                vScrollThr.Value = 100 - RCdata[2] / 10;
                hScrollYaw.Value = 100 - RCdata[3] / 10;
                lblCtrlRol.Text = RCdata[0].ToString();
                lblCtrlPit.Text = RCdata[1].ToString();
                lblCtrlThr.Text = RCdata[2].ToString();
                lblCtrlYaw.Text = RCdata[3].ToString();
            }
            else
            {
                RCdata[0] = 10 * (100 - hScrollRol.Value);
                RCdata[1] = 10 * vScrollPit.Value;
                RCdata[2] = 10 * (100 - vScrollThr.Value);
                RCdata[3] = 10 * (100 - hScrollYaw.Value);
                lblCtrlRol.Text = (10 * (100 - hScrollRol.Value)).ToString();
                lblCtrlPit.Text = (10 * (100 - vScrollPit.Value)).ToString();
                lblCtrlThr.Text = (10 * (100 - vScrollThr.Value)).ToString();
                lblCtrlYaw.Text = (10 * (100 - hScrollYaw.Value)).ToString();
            }
        }

        /*定时发送任务*/
        private void CtrlMsg_Send()
        {
            Key_Change();  //控制按键检测
            if (!serialPort1.IsOpen) return;
            //显示下位机状态信息
            byte SendByte = 0;
            if (cbxStat.Checked)
                SendByte |= FuncByte.stat;
            if (cbxAtti.Checked)
                SendByte |= FuncByte.atti;
            if (cbxSensor.Checked)
                SendByte |= FuncByte.sensor;
            if (cbxRC.Checked)
                SendByte |= FuncByte.rc;
            if (cbxMotor.Checked)
                SendByte |= FuncByte.motor;
            if (cbxQuaternion.Checked)
                SendByte |= FuncByte.quaternion;
            if (SendByte != 0)
            {
                TxCount += ptcl1.Send_Req(0xC1, SendByte, SerialPort1_Send);
                labelTxCnt.Text = $"Tx:{TxCount}";
            }
            //向下位机发送控制指令
            if (stat.RmCtrl)
            {
                TxCount += ptcl1.Send_S16_Data(RCdata, 4, 0x08, SerialPort1_Send);
                labelTxCnt.Text = $"Tx:{TxCount}";
            }
        }
    }
}
