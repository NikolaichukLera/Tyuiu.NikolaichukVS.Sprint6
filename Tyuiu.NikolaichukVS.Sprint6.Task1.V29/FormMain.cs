using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.NikolaichukVS.Sprint6.Task1.V29.Lib;

namespace Tyuiu.NikolaichukVS.Sprint6.Task1.V29
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_NVS.Text = "";
                textBoxResult_NVS.AppendText("+--------+---------+" + Environment.NewLine);
                textBoxResult_NVS.AppendText("|   X    |   f(x)  |" + Environment.NewLine);
                textBoxResult_NVS.AppendText("+--------+---------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}   |   {1, 4:f2}   | ", startStep, valueArray[i]);
                    textBoxResult_NVS.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_NVS.AppendText("+---------+--------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClickMe_NVS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы РПСб-23-1 Николайчук Валерия Сергеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
