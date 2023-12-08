using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NikolaichukVS.Sprint6.Task2.V10.Lib;

namespace Tyuiu.NikolaichukVS.Sprint6.Task2.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_NVS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_NVS.Text);
                int stopStep = Convert.ToInt32(textBoxStop_NVS.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartGraf_NVS.Titles.Add("График функции sin(x)");

                this.chartGraf_NVS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartGraf_NVS.ChartAreas[0].AxisX.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_NVS.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartGraf_NVS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;

                }



            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClickMe_NVS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы РПСб-23-1 Николайчук Валерия Сергеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_NVS_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_NVS.BackColor = Color.Red;
           
        }

        private void buttonDone_NVS_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_NVS.BackColor = Color.Green;
        }

        private void buttonDone_NVS_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_NVS.BackColor = Color.;
        }
    }
}
