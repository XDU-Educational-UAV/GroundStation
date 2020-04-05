using System;
/**************文件说明**********************
控制器参数读写
事件:
btnReadRol_Click
btnReadPit_Click
btnWriteRol_Click
btnWritePit_Click
函数:
Status_Display
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        private bool Check_Port()  //避免同时发送多个数据帧
        {
            if (!serialPort1.IsOpen) return false;
            if (cbxRolDisp.Checked) return false;
            if (cbxPitDisp.Checked) return false;
            return true;
        }
        /*读取roll控制器参数*/
        private void btnReadRol_Click(object sender, EventArgs e)
        {
            if (!Check_Port()) return;
            GlobalStat |= 0x02;
            byte DataAdd = ptcl.Send_Req(0, 0x01,serialPort1.Write);
            TxCount += DataAdd;
        }
        /*读取pitch控制器参数*/
        private void btnReadPit_Click(object sender, EventArgs e)
        {
            if (!Check_Port()) return;
            GlobalStat |= 0x02;
            byte DataAdd = ptcl.Send_Req(0, 0x04, serialPort1.Write);
            TxCount += DataAdd;
        }
        /*写入roll控制器参数*/
        private void btnWriteRol_Click(object sender, EventArgs e)
        {
            if (!Check_Port()) return;
            int[] idata = new int[4];
            GlobalStat &= 0xFD;
            try
            {
                idata[0] = Convert.ToInt32(tbxRolParam1.Text);
                idata[1] = Convert.ToInt32(tbxRolParam2.Text);
                idata[2] = Convert.ToInt32(tbxRolParam3.Text);
                idata[3] = Convert.ToInt32(tbxRolParam4.Text);
                byte DataAdd = ptcl.Send_S16_Data(idata, 4, 0xA1,serialPort1.Write);
                TxCount += DataAdd;
            }
            catch (Exception) { }
        }
        /*写入pitch控制器参数*/
        private void btnWritePit_Click(object sender, EventArgs e)
        {
            if (!Check_Port()) return;
            int[] idata = new int[4];
            GlobalStat &= 0xFD;
            try
            {
                idata[0] = Convert.ToInt32(tbxPitParam1.Text);
                idata[1] = Convert.ToInt32(tbxPitParam2.Text);
                idata[2] = Convert.ToInt32(tbxPitParam3.Text);
                idata[3] = Convert.ToInt32(tbxPitParam4.Text);
                byte DataAdd = ptcl.Send_S16_Data(idata, 4, 0xA3, serialPort1.Write);
                TxCount += DataAdd;
            }
            catch (Exception) { }
        }
        /*陀螺仪校准*/
        private void btnGyroCali_Click(object sender, EventArgs e)
        {
            if (!Check_Port()) return;
            byte DataAdd = ptcl.Send_Req(0, 0x20, serialPort1.Write);
            TxCount += DataAdd;
            labelTxCnt.Text = $"Tx:{TxCount}";
        }
        /*加速度计校准*/
        private void btnAccCali_Click(object sender, EventArgs e)
        {
            if (!Check_Port()) return;
            byte DataAdd = ptcl.Send_Req(0, 0x10, serialPort1.Write);
            TxCount += DataAdd;
            labelTxCnt.Text = $"Tx:{TxCount}";
        }
        /***********************
         状态参数显示
         **********************/
        private void Status_Display()
        {
            if (!serialPort1.IsOpen) return;
            byte req = 0;
            if (cbxRolDisp.Checked)
                req |= 0x02;
            if (cbxPitDisp.Checked)
                req |= 0x08;
            if (req != 0)
            {
                byte DataAdd = ptcl.Send_Req(0, req, serialPort1.Write);
                TxCount += DataAdd;
            }
            labelTxCnt.Text = $"Tx:{TxCount}";
        }
    }
}
