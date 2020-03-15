using System;
using System.Windows.Forms;
using System.Collections.Generic;
/**************文件说明**********************
标签1:飞行控制
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        List<short> CtrlChannel = new List<short> { 0, 0, 0, 0 };
        byte[] CtrlByte = new byte[12];
        byte KeyState = 0;
        private void tmrCtrl_Tick(object sender, EventArgs e)
        {
            CtrlChannel[0] = (short)((100 - hScrollRol.Value) * 10);
            CtrlChannel[1] = (short)((100 - vScrollPit.Value) * 10);
            CtrlChannel[2] = (short)((100 - vScrollThr.Value) * 10);
            CtrlChannel[3] = (short)((100 - hScrollYaw.Value) * 10);
            CtrlByte[0] = 0x3C;
            CtrlByte[1] = 0x02;
            CtrlByte[2] = 0x08;
            CtrlByte[3] = (byte)(CtrlChannel[0] / 256);
            CtrlByte[4] = (byte)(CtrlChannel[0] % 256);
            CtrlByte[5] = (byte)(CtrlChannel[1] / 256);
            CtrlByte[6] = (byte)(CtrlChannel[1] % 256);
            CtrlByte[7] = (byte)(CtrlChannel[2] / 256);
            CtrlByte[8] = (byte)(CtrlChannel[2] % 256);
            CtrlByte[9] = (byte)(CtrlChannel[3] / 256);
            CtrlByte[10] = (byte)(CtrlChannel[3] % 256);
            for (int i = 0; i < 11; i++)
            {
                CtrlByte[11] += CtrlByte[i];
            }
            serialPort1.Write(CtrlByte, 0, 12);
            CtrlByte[11] = 0;
            TxCount += 12;
            if (((KeyState & 0x01) == 0x01) && (hScrollRol.Value > 0))
                hScrollRol.Value--;
            if (((KeyState & 0x02) == 0x02) && (hScrollRol.Value < 100))
                hScrollRol.Value++;
            if (((KeyState & 0x04) == 0x04) && (vScrollPit.Value > 0))
                vScrollPit.Value--;
            if (((KeyState & 0x08) == 0x08) && (vScrollPit.Value < 100))
                vScrollPit.Value++;
            if (((KeyState & 0x10) == 0x10) && (vScrollThr.Value > 0))
                vScrollThr.Value--;
            if (((KeyState & 0x20) == 0x20) && (vScrollThr.Value < 100))
                vScrollThr.Value++;
            if (((KeyState & 0x40) == 0x40) && (hScrollYaw.Value > 0))
                hScrollYaw.Value--;
            if (((KeyState & 0x80) == 0x80) && (hScrollYaw.Value < 100))
                hScrollYaw.Value++;
        }
        private void btnCtrl_Click(object sender, EventArgs e)
        {
            if (tmrCtrl.Enabled)
            {
                btnCtrl.Image = Properties.Resources.ledoff;
                btnCtrl.Text = "打开控制链路";
                tmrCtrl.Enabled = false;
            }
            else if (serialPort1.IsOpen)
            {
                btnCtrl.Image = Properties.Resources.ledon;
                btnCtrl.Text = "断开控制链路";
                tmrCtrl.Enabled = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
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
        private void Form1_KeyDown(object sender, KeyEventArgs e)
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
