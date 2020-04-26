using System.Windows.Forms;
/**************文件说明**********************
主窗体加载与关闭时额外执行的任务
事件:
Form1_FormClosing
函数:
Form1_Init
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        /***********************
         初始化读取软件设置
         **********************/
        private void Form1_Init()
        {
            tabControl1.SelectedIndex = Properties.Settings.Default.TabIndexInt;
            cbxBaudRate1.Text = Properties.Settings.Default.cbxBaudRateStr;
            cbxBaudRate2.Text = Properties.Settings.Default.cbxBaudRate2Str;
            tbxTx1.Text = Properties.Settings.Default.tbxTx1Str;
            tbxTx2.Text = Properties.Settings.Default.tbxTx2Str;
            tbxTx3.Text = Properties.Settings.Default.tbxTx3Str;
            tbxRolCName1.Text = Properties.Settings.Default.tbxRolCName1Str;
            tbxRolCName2.Text = Properties.Settings.Default.tbxRolCName2Str;
            tbxRolCName3.Text = Properties.Settings.Default.tbxRolCName3Str;
            tbxRolCName4.Text = Properties.Settings.Default.tbxRolCName4Str;
            tbxRolCName1.Text = Properties.Settings.Default.tbxRolSName1Str;
            tbxRolCName2.Text = Properties.Settings.Default.tbxRolSName2Str;
            tbxRolCName3.Text = Properties.Settings.Default.tbxRolSName3Str;
            tbxRolCName4.Text = Properties.Settings.Default.tbxRolSName4Str;
            tbxPitCName1.Text = Properties.Settings.Default.tbxPitCName1Str;
            tbxPitCName2.Text = Properties.Settings.Default.tbxPitCName2Str;
            tbxPitCName3.Text = Properties.Settings.Default.tbxPitCName3Str;
            tbxPitCName4.Text = Properties.Settings.Default.tbxPitCName4Str;
            tbxPitCName1.Text = Properties.Settings.Default.tbxPitSName1Str;
            tbxPitCName2.Text = Properties.Settings.Default.tbxPitSName2Str;
            tbxPitCName3.Text = Properties.Settings.Default.tbxPitSName3Str;
            tbxPitCName4.Text = Properties.Settings.Default.tbxPitSName4Str;
        }
        /*窗口关闭保存软件设置*/
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.tbxTx1Str = tbxTx1.Text;
            Properties.Settings.Default.tbxTx2Str = tbxTx2.Text;
            Properties.Settings.Default.tbxTx3Str = tbxTx3.Text;
            Properties.Settings.Default.cbxBaudRateStr = cbxBaudRate1.Text;
            Properties.Settings.Default.cbxBaudRate2Str = cbxBaudRate2.Text;
            Properties.Settings.Default.TabIndexInt = tabControl1.SelectedIndex;
            Properties.Settings.Default.tbxIntervalStr = tbxInterval.Text;
            Properties.Settings.Default.tbxRolCName1Str = tbxRolCName1.Text;
            Properties.Settings.Default.tbxRolCName2Str = tbxRolCName2.Text;
            Properties.Settings.Default.tbxRolCName3Str = tbxRolCName3.Text;
            Properties.Settings.Default.tbxRolCName4Str = tbxRolCName4.Text;
            Properties.Settings.Default.tbxRolSName1Str = tbxRolCName1.Text;
            Properties.Settings.Default.tbxRolSName2Str = tbxRolCName2.Text;
            Properties.Settings.Default.tbxRolSName3Str = tbxRolCName3.Text;
            Properties.Settings.Default.tbxRolSName4Str = tbxRolCName4.Text;
            Properties.Settings.Default.tbxPitCName1Str = tbxPitCName1.Text;
            Properties.Settings.Default.tbxPitCName2Str = tbxPitCName2.Text;
            Properties.Settings.Default.tbxPitCName3Str = tbxPitCName3.Text;
            Properties.Settings.Default.tbxPitCName4Str = tbxPitCName4.Text;
            Properties.Settings.Default.tbxPitSName1Str = tbxPitCName1.Text;
            Properties.Settings.Default.tbxPitSName2Str = tbxPitCName2.Text;
            Properties.Settings.Default.tbxPitSName3Str = tbxPitCName3.Text;
            Properties.Settings.Default.tbxPitSName4Str = tbxPitCName4.Text;
            Properties.Settings.Default.Save();          
        }
    }
}
