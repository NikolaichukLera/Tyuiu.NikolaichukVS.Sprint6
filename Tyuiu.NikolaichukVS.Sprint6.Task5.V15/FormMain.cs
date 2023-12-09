using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Tyuiu.NikolaichukVS.Sprint6.Task5.V15.Lib;

namespace Tyuiu.NikolaichukVS.Sprint6.Task5.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\DataSprint5\InPutFileTask5V15.txt.";

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonDone_NVS_Click(object sender, EventArgs e)
        {
            dataGridViewNums_NVS.ColumnCount = 2;
            dataGridViewNums_NVS.Columns[0].Width = 20;
            dataGridViewNums_NVS.Columns[1].Width = 50;

            this.chartDiagram_NVS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiagram_NVS.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiagram_NVS.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_NVS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiagram_NVS.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonClickMe_NVS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы РПСб-23-1 Николайчук Валерия Сергеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
