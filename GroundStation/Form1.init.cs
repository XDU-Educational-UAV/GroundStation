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
            tbxTx1.Text = Properties.Settings.Default.tbxTx1Str;
            tbxTx2.Text = Properties.Settings.Default.tbxTx2Str;
            tbxTx3.Text = Properties.Settings.Default.tbxTx3Str;
            tabControl1.SelectedIndex = Properties.Settings.Default.TabIndexInt;
            cbxBaudRate1.Text = Properties.Settings.Default.cbxBaudRateStr;
            cbxBaudRate2.Text = Properties.Settings.Default.cbxBaudRate2Str;
            tbxInterval.Text = Properties.Settings.Default.tbxIntervalStr;
        }
        /*窗口关闭保存软件设置*/
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.tbxTx1Str = tbxTx1.Text;
            Properties.Settings.Default.tbxTx2Str = tbxTx2.Text;
            Properties.Settings.Default.tbxTx3Str = tbxTx3.Text;
            Properties.Settings.Default.TabIndexInt = tabControl1.SelectedIndex;
            Properties.Settings.Default.cbxBaudRateStr = cbxBaudRate1.Text;
            Properties.Settings.Default.cbxBaudRate2Str = cbxBaudRate2.Text;
            Properties.Settings.Default.tbxIntervalStr = tbxInterval.Text;
            Properties.Settings.Default.Save();          
        }
    }
}
