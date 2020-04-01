using System;
/**************文件说明**********************
控制器参数读写
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        /*读取roll控制器参数*/
        private void btnReadRol_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) return;
            GlobalStat |= 0x02;
            byte DataAdd = ptcl.Send_Req(0x01);
            serialPort1.Write(ptcl.DataToSend, 0, DataAdd);
            TxCount += DataAdd;
        }
        /*读取pitch控制器参数*/
        private void btnReadPit_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) return;
            GlobalStat |= 0x02;
            byte DataAdd = ptcl.Send_Req(0x04);
            serialPort1.Write(ptcl.DataToSend, 0, DataAdd);
            TxCount += DataAdd;
        }
        /*写入roll控制器参数*/
        private void btnWriteRol_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) return;
            if (cbxRolDisp.Checked) return;
            if (cbxPitDisp.Checked) return;
            int[] idata = new int[4];
            GlobalStat &= 0xFD;
            try
            {
                idata[0] = Convert.ToInt32(tbxRolParam1.Text);
                idata[1] = Convert.ToInt32(tbxRolParam2.Text);
                idata[2] = Convert.ToInt32(tbxRolParam3.Text);
                idata[3] = Convert.ToInt32(tbxRolParam4.Text);
                byte DataAdd = ptcl.Send_S16_Data(idata, 4, 0xA1);
                serialPort1.Write(ptcl.DataToSend, 0, DataAdd);
                TxCount += DataAdd;
            }
            catch (Exception)
            { }
        }
        /*写入pitch控制器参数*/
        private void btnWritePit_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) return;
            if (cbxRolDisp.Checked) return;
            if (cbxPitDisp.Checked) return;
            int[] idata = new int[4];
            GlobalStat &= 0xFD;
            try
            {
                idata[0] = Convert.ToInt32(tbxPitParam1.Text);
                idata[1] = Convert.ToInt32(tbxPitParam2.Text);
                idata[2] = Convert.ToInt32(tbxPitParam3.Text);
                idata[3] = Convert.ToInt32(tbxPitParam4.Text);
                byte DataAdd = ptcl.Send_S16_Data(idata, 4, 0xA3);
                serialPort1.Write(ptcl.DataToSend, 0, DataAdd);
                TxCount += DataAdd;
            }
            catch (Exception)
            { }
        }
        /*状态参数显示*/
        private void Status_Display()
        {
            if (serialPort1.IsOpen == false) return;
            byte req = 0;
            if (cbxRolDisp.Checked)
                req |= 0x02;
            if (cbxPitDisp.Checked)
                req |= 0x08;
            if (req != 0)
            {
                byte DataAdd = ptcl.Send_Req(req);
                serialPort1.Write(ptcl.DataToSend, 0, DataAdd);
                TxCount += DataAdd;
            }
            labelTxCnt.Text = $"Tx:{TxCount}";
        }
    }
}
