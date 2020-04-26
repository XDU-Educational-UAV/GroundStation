using System;
/**************文件说明**********************
控制器参数读写
事件:
btnReadRol_Click
btnReadPit_Click
btnWriteRol_Click
btnWritePit_Click
btnGyroCali_Click
btnAccCali_Click
函数:
Check_Port
Status_Display
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        private bool Check_Port()  //避免同时发送多个数据帧
        {
            byte check = 0;
            if (!serialPort1.IsOpen) check |= 1;
            if (cbxRolDisp.Checked) check |= 1;
            if (cbxPitDisp.Checked) check |= 1;
            if (check != 0)
            {
                lblVersion.Text = "未发送!";
                return false;
            }
            lblVersion.Text = version;
            return true;
        }
        /*读取roll控制器参数*/
        private void btnReadRol_Click(object sender, EventArgs e)
        {
            if (!Check_Port()) return;
            stat.TextSave = true;
            byte DataAdd = ptcl1.Send_Req(0, 0x01, SerialPort1_Send);
            TxCount += DataAdd;
        }
        /*读取pitch控制器参数*/
        private void btnReadPit_Click(object sender, EventArgs e)
        {
            if (!Check_Port()) return;
            stat.TextSave = true;
            byte DataAdd = ptcl1.Send_Req(0, 0x04, SerialPort1_Send);
            TxCount += DataAdd;
        }
        /*写入roll控制器参数*/
        private void btnWriteRol_Click(object sender, EventArgs e)
        {
            if (!Check_Port()) return;
            int[] idata = new int[4];
            stat.TextSave = false;
            try
            {
                idata[0] = Convert.ToInt32(tbxRolParam1.Text);
                idata[1] = Convert.ToInt32(tbxRolParam2.Text);
                idata[2] = Convert.ToInt32(tbxRolParam3.Text);
                idata[3] = Convert.ToInt32(tbxRolParam4.Text);
                byte DataAdd = ptcl1.Send_S16_Data(idata, 4, 0xA1, SerialPort1_Send);
                TxCount += DataAdd;
            }
            catch (Exception) { }
        }
        /*写入pitch控制器参数*/
        private void btnWritePit_Click(object sender, EventArgs e)
        {
            if (!Check_Port()) return;
            int[] idata = new int[4];
            stat.TextSave = false;
            try
            {
                idata[0] = Convert.ToInt32(tbxPitParam1.Text);
                idata[1] = Convert.ToInt32(tbxPitParam2.Text);
                idata[2] = Convert.ToInt32(tbxPitParam3.Text);
                idata[3] = Convert.ToInt32(tbxPitParam4.Text);
                byte DataAdd = ptcl1.Send_S16_Data(idata, 4, 0xA3, SerialPort1_Send);
                TxCount += DataAdd;
            }
            catch (Exception) { }
        }
        /*陀螺仪校准*/
        private void btnGyroCali_Click(object sender, EventArgs e)
        {
            if (!Check_Port()) return;
            byte DataAdd = ptcl1.Send_Req(0, 0x80, SerialPort1_Send);
            TxCount += DataAdd;
            labelTxCnt.Text = $"Tx:{TxCount}";
        }
        /*加速度计校准*/
        private void btnAccCali_Click(object sender, EventArgs e)
        {
            if (!Check_Port()) return;
            byte DataAdd = ptcl1.Send_Req(0, 0x40, SerialPort1_Send);
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
                byte DataAdd = ptcl1.Send_Req(0, req, SerialPort1_Send);
                TxCount += DataAdd;
            }
            labelTxCnt.Text = $"Tx:{TxCount}";
        }
    }
}
