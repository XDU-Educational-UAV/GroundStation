using System;
using System.Windows.Forms;
using System.Collections.Generic;
/**************文件说明**********************
标签1:基本收发
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        List<short> CtrlChannel = new List<short> { 0, 0, 0, 0 };
        byte[] CtrlByte = new byte[12];
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
        }
    }
}
