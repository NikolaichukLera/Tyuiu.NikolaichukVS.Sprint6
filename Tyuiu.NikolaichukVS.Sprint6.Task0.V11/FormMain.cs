using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.NikolaichukVS.Sprint6.Task0.V11.Lib;
namespace Tyuiu.NikolaichukVS.Sprint6.Task0.V11
{
    public partial class FormMainTask_NVS : Form
    {
        public FormMainTask_NVS()
        {
            InitializeComponent();
        }

        private void buttonDone_NVS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_NVS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_NVS.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonPushMe_NVS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы РПСб-23-1 Николайчук Валерия Сергеевна", "Сообщение");
        }

        private void textBoxVarX_NVS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 3) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
