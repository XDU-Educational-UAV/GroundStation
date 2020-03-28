using System;
/**************文件说明**********************
控制器参数读写
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        /*写入roll控制器参数*/
        private void btnWriteRol_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) return;
            GlobalStat &= 0xFD;
            try
            {
                RolParam[0] = Convert.ToInt32(tbxRolParam1.Text);
                RolParam[1] = Convert.ToInt32(tbxRolParam2.Text);
                RolParam[2] = Convert.ToInt32(tbxRolParam3.Text);
                XDAA_Send_Param(RolParam, 0xA1);
                serialPort1.Write(CtrlByte, 0, 10);
            }
            catch (Exception)
            { }
        }
        /*读取roll控制器参数*/
        private void btnReadRol_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) return;
            GlobalStat |= 0x02;
            XDAA_Send_Req(0x01);
            serialPort1.Write(CtrlByte, 0, 5);
        }
        /*写入pitch控制器参数*/
        private void btnWritePit_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) return;
            GlobalStat &= 0xFD;
            try
            {
                PitParam[0] = Convert.ToInt32(tbxPitParam1.Text);
                PitParam[1] = Convert.ToInt32(tbxPitParam2.Text);
                PitParam[2] = Convert.ToInt32(tbxPitParam3.Text);
                XDAA_Send_Param(PitParam, 0xA3);
                serialPort1.Write(CtrlByte, 0, 10);
            }
            catch (Exception)
            { }
        }
        /*读取pitch控制器参数*/
        private void btnReadPit_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) return;
            GlobalStat |= 0x02;
            XDAA_Send_Req(0x02);
            serialPort1.Write(CtrlByte, 0, 5);
        }
    }
}
