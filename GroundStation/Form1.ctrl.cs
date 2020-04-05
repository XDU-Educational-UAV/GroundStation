using System;
using System.Drawing;
/**************文件说明**********************
飞行控制,包括接收并处理下位机消息,向下位机发送指令
事件:
btnCtrl_Click
btnLock_Click
函数:
CtrlMsg_Send
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
        private void CtrlMsg_Send()
        {
            Key_Change();  //控制按键检测
            lblCtrlRol.Text = (10 * (100 - hScrollRol.Value)).ToString();
            lblCtrlPit.Text = (10 * (100 - vScrollPit.Value)).ToString();
            lblCtrlThr.Text = (10 * (100 - vScrollThr.Value)).ToString();
            lblCtrlYaw.Text = (10 * (100 - hScrollYaw.Value)).ToString();
            if (!serialPort1.IsOpen) return;
            if ((GlobalStat & 0x80) != 0x80) return;  //没有与下位机建立通信
            ErrCnt++;
            byte DataAdd = 0, password = 0, SendByte = 0;
            int[] RCdata = new int[4];
            if (ErrCnt >= 20)
            {
                lblCtrl.Text = "失控";
                lblCtrl.ForeColor = Color.Red;
            }
            if ((GlobalStat & 0x01) == 0x01)  //发送请求解锁或锁定命令
            {
                if (tbxPassword.Text == "") return;
                try
                {
                    password = Convert.ToByte(tbxPassword.Text, 16);
                }
                catch (Exception) { }
                if ((GlobalStat & 0x040) == 0x40)
                    DataAdd = ptcl.Send_Cmd(password, 0,serialPort1.Write);
                else
                    DataAdd = ptcl.Send_Cmd(password, 0x01, serialPort1.Write);
                GlobalStat &= 0xFE;
                TxCount += DataAdd;
                labelTxCnt.Text = $"Tx:{TxCount}";
                return;
            }
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
            if (SendByte != 0)
            {
                DataAdd = ptcl.Send_Req(SendByte, 0, serialPort1.Write);
                TxCount += DataAdd;
                labelTxCnt.Text = $"Tx:{TxCount}";
                return;
            }
            RCdata[0] = 10 * (100 - hScrollRol.Value);
            RCdata[1] = 10 * (100 - vScrollPit.Value);
            RCdata[2] = 10 * (100 - vScrollThr.Value);
            RCdata[3] = 10 * (100 - hScrollYaw.Value);
            DataAdd = ptcl.Send_S16_Data(RCdata, 4, 0x08, serialPort1.Write);
            GlobalStat &= 0xFD;
            TxCount += DataAdd;
            labelTxCnt.Text = $"Tx:{TxCount}";
        }
    }
}
