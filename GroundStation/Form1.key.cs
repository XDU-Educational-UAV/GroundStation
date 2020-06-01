using System.Windows.Forms;
/**************文件说明**********************
飞行控制界面的相关键盘控制
事件:
Form1_KeyUp
Form1_KeyDown
函数:
Key_Change
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        private byte KeyState = 0;
        /***********************
        根据控制按键状态做出相应的更改
        **********************/
        private void Key_Change()
        {
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