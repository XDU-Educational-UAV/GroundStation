using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
/**************文件说明**********************
波形显示
ChartInit
Chart_Update
Chart_Display
Chart_Clear
cbxData_CheckedChanged
********************************************/

namespace GroundStation
{
    partial class Form1
    {
        private byte DatasetNum = 8, DataLen = 100;
        private Queue<double>[] DataQueue = new Queue<double>[8];
        CheckBox[] cbxData = new CheckBox[8];

        /***********************
         图表初始化
         **********************/
        private void ChartInit()
        {
            Color[] DataColor = new Color[]
                {Color.Red,Color.Blue,Color.Green,Color.Orange,Color.Purple,Color.Silver,Color.Pink,Color.Cyan};
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 0;
            chart1.ChartAreas[0].AxisX.Interval = 5;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Silver;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Silver;
            Series[] series = new Series[DatasetNum];
            for (int i = 0; i < DatasetNum; i++)
            {
                cbxData[i] = new CheckBox();
                cbxData[i].Location = new Point(6 + i * 70, 475);
                cbxData[i].Name = $"cbxData{i}";
                cbxData[i].Text = $"DATA{i}";
                cbxData[i].Size = new Size(65, 20);
                cbxData[i].ForeColor = DataColor[i];
                cbxData[i].TabIndex = i;
                cbxData[i].CheckedChanged += cbxData_CheckedChanged;
                tabPage4.Controls.Add(cbxData[i]);
                DataQueue[i] = new Queue<double>(DataLen);
                chart1.Series.Add(new Series());
                chart1.Series[i].Color = DataColor[i];
                chart1.Series[i].ChartType = SeriesChartType.Line;
            }
        }
        private void cbxData_CheckedChanged(object sender, EventArgs e)
        {
            Chart_Clear();
        }
        /***********************
        图表更新
        **********************/
        private void Chart_Update(double data, int LineLabel)
        {
            if (DataQueue[LineLabel].Count >= DataLen)
                DataQueue[LineLabel].Dequeue();
            DataQueue[LineLabel].Enqueue(data);
            chart1.Series[LineLabel].Points.Clear();
            for (int i = 0; i < DataQueue[LineLabel].Count; i++)
            {
                if (data > chart1.ChartAreas[0].AxisY.Maximum)
                    chart1.ChartAreas[0].AxisY.Maximum = data;
                else if (data < chart1.ChartAreas[0].AxisY.Minimum)
                    chart1.ChartAreas[0].AxisY.Minimum = data;
                chart1.Series[LineLabel].Points.AddXY(i + 1, DataQueue[LineLabel].ElementAt(i));
            }
        }
        private void Chart_Display()
        {
            if (!serialPort1.IsOpen) return;
            if (cbxDisp.Checked)
            {
                byte DataAdd = ptcl.Send_Req(0, 0x0A, SerialPort_Send);
                TxCount += DataAdd;
                labelTxCnt.Text = $"Tx:{TxCount}";
            }
        }
        /***********************
         清除缓存
         **********************/
        private void Chart_Clear()
        {
            int cnt;
            for (int i = 0; i < DatasetNum; i++)
            {
                cnt = DataQueue[i].Count;
                for (int j = 0; j < cnt; j++)
                    DataQueue[i].Dequeue();
                chart1.Series[i].Points.Clear();
            }
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 0;
        }
    }
}
