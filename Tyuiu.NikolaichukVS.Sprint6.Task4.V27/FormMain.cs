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

using Tyuiu.NikolaichukVS.Sprint6.Task4.V27.Lib;

namespace Tyuiu.NikolaichukVS.Sprint6.Task4.V27
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
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartGraf_NVS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartGraf_NVS.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_NVS.Text = "";

                chartGraf_NVS.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartGraf_NVS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_NVS.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_NVS_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DataSprint5\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_NVS.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClickMe_NVS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы РПСб-23-1 Николайчук Валерия Сергеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
