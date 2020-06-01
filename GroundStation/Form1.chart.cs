using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
/**************文件说明**********************
波形显示
事件:
cbxData_CheckedChanged
函数:
ChartInit
Chart_Update
Chart_Display
Chart_Clear
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        private const int DataLen = 500;
        private readonly Queue<double>[] DataQueue = new Queue<double>[8];
        private readonly CheckBox[] cbxChart = new CheckBox[8];

        /*图表初始化*/
        private void ChartInit()
        {
            Color[] DataColor = new Color[]
                {Color.Red,Color.Blue,Color.Green,Color.Orange,Color.Purple,Color.Black,Color.Pink,Color.Cyan};
            chart1.Series.Clear();
            Series[] series = new Series[8];
            for (int i = 0; i < 8; i++)
            {
                cbxChart[i] = new CheckBox();
                cbxChart[i].Location = new Point(6 + i * 70, 475);
                cbxChart[i].Name = $"cbxData{i}";
                cbxChart[i].Text = $"DATA{i}";
                cbxChart[i].Size = new Size(65, 20);
                cbxChart[i].ForeColor = DataColor[i];
                cbxChart[i].TabIndex = i;
                tabPage4.Controls.Add(cbxChart[i]);
                DataQueue[i] = new Queue<double>(DataLen);
                chart1.Series.Add(new Series());
                chart1.Series[i].Color = DataColor[i];
                chart1.Series[i].ChartType = SeriesChartType.Line;
            }
        }

        /*向图表的队列中添加数据*/
        private void Chart_AddPoints(double data, int LineLabel)
        {
            if (!cbxDisplay.Checked) return;
            if (DataQueue[LineLabel].Count >= DataLen)
                DataQueue[LineLabel].Dequeue();
            DataQueue[LineLabel].Enqueue(data);
        }

        /*向下位机发送显示指令并更新图表*/
        private void Chart_Update()
        {
            if (!serialPort1.IsOpen) return;
            if (!cbxDisplay.Checked) return;
            byte channel = 0;
            double temp, max = -1e6, min = 1e6;
            for (int i = 0; i < 8; i++)
            {
                //通知下位机获取哪个通道的数据
                if (cbxChart[i].Checked)
                    channel |= (byte)(1 << i);
                else continue;
                //获取图表的最大值和最小值
                if (DataQueue[i].Count == 0) continue;
                temp = DataQueue[i].Max();
                max = temp > max ? temp : max;
                temp = DataQueue[i].Min();
                min = temp < min ? temp : min;
            }
            chart1.ChartAreas[0].AxisY.Maximum = max + 0.001;
            chart1.ChartAreas[0].AxisY.Minimum = min - 0.001;
            //更新图表
            for (int i = 0; i < 8; i++)
            {
                chart1.Series[i].Points.Clear();
                if (!cbxChart[i].Checked) continue;
                if (DataQueue[i].Count == 0) continue;
                for (int j = 0; j < DataQueue[i].Count; j++)
                    chart1.Series[i].Points.AddXY(j + 1, DataQueue[i].ElementAt(j));
            }
            //发送指令
            if (channel != 0)
            {
                byte DataAdd = ptcl1.Send_Req(0xC3, channel, SerialPort1_Send);
                TxCount += DataAdd;
                labelTxCnt.Text = $"Tx:{TxCount}";
            }
        }

        /*清除缓存*/
        private void Chart_Clear()
        {
            int cnt;
            for (int i = 0; i < 8; i++)
            {
                cnt = DataQueue[i].Count;
                for (int j = 0; j < cnt; j++)
                    DataQueue[i].Dequeue();
                chart1.Series[i].Points.Clear();
            }
        }
    }
}
