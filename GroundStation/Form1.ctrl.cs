using System;
using System.Drawing;
/**************文件说明**********************
飞行控制,包括接收并处理下位机消息,向下位机发送指令
事件:
btnCtrl_Click
btnLock_Click
cbxSpeedMode_CheckedChanged
函数:
CtrlPanel_Update
CtrlMsg_Send
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        private byte ErrCnt = 0;
        GlobalStatus stat;

        /*建立控制链路按钮,按下后开始发送控制信号*/
        private void btnCtrl_Click(object sender, EventArgs e)
        {
            if (stat.CtrlLink)  //正在发送控制信号,按下后停止发送
            {
                stat.CtrlLink = false;
                btnCtrl.Image = Properties.Resources.ledoff;
                btnCtrl.Text = "建立控制链路";
                lblCtrl.Text = "失控";
                lblCtrl.ForeColor = Color.Red;
            }
            else if (serialPort1.IsOpen)  //如果串口打开就开始发送
            {
                stat.CtrlLink = true;
                btnCtrl.Image = Properties.Resources.ledon;
                btnCtrl.Text = "断开控制链路";
            }
        }
        /*此按钮只发送锁定/解锁命令,按钮名称的更改在定时任务中*/
        private void btnLock_Click(object sender, EventArgs e)
        {
            if (!stat.CtrlLink) return;
            stat.LockCmdOn = true;
        }
        /*更改飞行模式*/
        private void cbxSpeedMode_CheckedChanged(object sender, EventArgs e)
        {
            stat.SendModeChange = true;
        }
        /***********************
         定时更新界面
          **********************/
        private void CtrlPanel_Update()
        {
            ErrCnt++;
            if (ErrCnt >= 20)
                stat.inCtrl = false;
            if (stat.isUnlock)
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
                vScrollThr.Value = 100;
            }
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
        }
        /***********************
        定时发送任务
         **********************/
        private void CtrlMsg_Send()
        {
            Key_Change();  //控制按键检测
            if (!serialPort1.IsOpen) return;
            byte password = 0;
            //按下了锁定/解锁按钮
            if (stat.LockCmdOn)
            {
                stat.LockCmdOn = false;
                if (tbxPassword.Text == "") return;
                try
                {
                    password = Convert.ToByte(tbxPassword.Text, 16);
                    if (stat.isUnlock)
                        TxCount += ptcl.Send_Cmd(password, 0, SerialPort_Send);
                    else
                        TxCount += ptcl.Send_Cmd(password, 0x01, SerialPort_Send);
                    labelTxCnt.Text = $"Tx:{TxCount}";
                }
                catch (Exception) { }
                return;
            }
            if(stat.SendModeChange)
            {
                stat.SendModeChange = false;
                if (cbxSpeedMode.Checked)
                    TxCount += ptcl.Send_Req(0x80, 0, SerialPort_Send);
                else
                    TxCount += ptcl.Send_Req(0x40, 0, SerialPort_Send);
            }
            //显示下位机状态信息
            byte SendByte = 0;
            if (cbxStat.Checked)
                SendByte |= 0x01;
            if (cbxAtti.Checked)
                SendByte |= 0x02;
            if (cbxSensor.Checked)
                SendByte |= 0x04;
            if (cbxRC.Checked)
                SendByte |= 0x08;
            if (cbxMotor.Checked)
                SendByte |= 0x10;
            if ((SendByte != 0) && (stat.SendEn))
            {
                TxCount += ptcl.Send_Req(SendByte, 0, SerialPort_Send);
                labelTxCnt.Text = $"Tx:{TxCount}";
            }
            //向下位机发送控制指令
            else if ((stat.CtrlLink) && (!stat.SendEn))
            {
                int[] RCdata = new int[4];
                RCdata[0] = 10 * (100 - hScrollRol.Value);
                RCdata[1] = 10 * (100 - vScrollPit.Value);
                RCdata[2] = 10 * (100 - vScrollThr.Value);
                RCdata[3] = 10 * (100 - hScrollYaw.Value);
                TxCount += ptcl.Send_S16_Data(RCdata, 4, 0x08, SerialPort_Send);
                labelTxCnt.Text = $"Tx:{TxCount}";
            }
            stat.SendEn = !stat.SendEn;
        }
    }
}
