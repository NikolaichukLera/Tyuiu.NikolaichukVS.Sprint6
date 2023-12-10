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
using Tyuiu.NikolaichukVS.Sprint6.Task6.V22.Lib;

namespace Tyuiu.NikolaichukVS.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path;

        private void buttonOpenFile_NVS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_NVS.ShowDialog();
            path = openFileDialogTask_NVS.FileName;
            textBoxLoadFile_NVS.Text = File.ReadAllText(path);
            groupBoxOutPut_NVS.Text = groupBoxOutPut_NVS.Text + " " + openFileDialogTask_NVS.FileName;
            buttonDone_NVS.Enabled = true;
        }

        private void buttonDone_NVS_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxResault_NVS.Text = ds.CollectTextFromFile(str, path);
        }

        private void buttonClickMe_NVS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
