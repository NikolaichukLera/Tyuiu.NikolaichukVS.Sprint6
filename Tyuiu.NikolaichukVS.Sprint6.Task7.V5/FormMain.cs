using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.NikolaichukVS.Sprint6.Task7.V5.Lib;

using System.IO;
namespace Tyuiu.NikolaichukVS.Sprint6.Task7.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_NVS.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_NVS.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        private void buttonOpenFile_NVS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_NVS.ShowDialog();
            openFilePath = openFileDialogTask_NVS.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_NVS.ColumnCount = columns;
            dataGridViewInPut_NVS.RowCount = rows;
            dataGridViewOutPut_NVS.ColumnCount = columns;
            dataGridViewOutPut_NVS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_NVS.Columns[i].Width = 25;
                dataGridViewOutPut_NVS.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_NVS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonSaveFile_NVS.Enabled = true;



        }

        private void buttonClickMe_NVS_Click(object sender, EventArgs e)
        {
            FormAbout_NVS formAbout = new FormAbout_NVS();
            formAbout.ShowDialog();
        }

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonSaveFile_NVS_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_NVS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_NVS.Enabled = true;
            
        }

        private void buttonSave_NVS_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_NVS.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask_NVS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_NVS.ShowDialog();

            string path = saveFileDialogTask_NVS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_NVS.RowCount;
            int columns = dataGridViewOutPut_NVS.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_NVS.Rows[i].Cells[j].Value + ";"; 
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_NVS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}
