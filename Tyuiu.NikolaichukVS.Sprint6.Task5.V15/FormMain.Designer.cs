
namespace Tyuiu.NikolaichukVS.Sprint6.Task5.V15
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxCond_NVS = new System.Windows.Forms.GroupBox();
            this.buttonDone_NVS = new System.Windows.Forms.Button();
            this.buttonClickMe_NVS = new System.Windows.Forms.Button();
            this.groupBoxOutPut_NVS = new System.Windows.Forms.GroupBox();
            this.buttonOutPutFile_NVS = new System.Windows.Forms.Button();
            this.chartDiagram_NVS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewNums_NVS = new System.Windows.Forms.DataGridView();
            this.groupBoxCondition_NVS.SuspendLayout();
            this.groupBoxOutPut_NVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_NVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_NVS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_NVS
            // 
            this.groupBoxCondition_NVS.Controls.Add(this.groupBoxCond_NVS);
            this.groupBoxCondition_NVS.Location = new System.Drawing.Point(2, 12);
            this.groupBoxCondition_NVS.Name = "groupBoxCondition_NVS";
            this.groupBoxCondition_NVS.Size = new System.Drawing.Size(537, 126);
            this.groupBoxCondition_NVS.TabIndex = 3;
            this.groupBoxCondition_NVS.TabStop = false;
            this.groupBoxCondition_NVS.Text = "Условие";
            // 
            // groupBoxCond_NVS
            // 
            this.groupBoxCond_NVS.Location = new System.Drawing.Point(7, 21);
            this.groupBoxCond_NVS.Name = "groupBoxCond_NVS";
            this.groupBoxCond_NVS.Size = new System.Drawing.Size(524, 78);
            this.groupBoxCond_NVS.TabIndex = 0;
            this.groupBoxCond_NVS.TabStop = false;
            this.groupBoxCond_NVS.Text = "Прочитать данные из файла InPutFileTask5V15.txt. Вывести в dataGridView. Вывести " +
    "все числа от 2 до 7. Построить диаграмму по этим значениям. ";
            // 
            // buttonDone_NVS
            // 
            this.buttonDone_NVS.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_NVS.ForeColor = System.Drawing.Color.Black;
            this.buttonDone_NVS.Location = new System.Drawing.Point(556, 33);
            this.buttonDone_NVS.Name = "buttonDone_NVS";
            this.buttonDone_NVS.Size = new System.Drawing.Size(115, 94);
            this.buttonDone_NVS.TabIndex = 7;
            this.buttonDone_NVS.Text = "Выполнить";
            this.buttonDone_NVS.UseVisualStyleBackColor = false;
            this.buttonDone_NVS.Click += new System.EventHandler(this.buttonDone_NVS_Click);
            // 
            // buttonClickMe_NVS
            // 
            this.buttonClickMe_NVS.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonClickMe_NVS.Location = new System.Drawing.Point(801, 33);
            this.buttonClickMe_NVS.Name = "buttonClickMe_NVS";
            this.buttonClickMe_NVS.Size = new System.Drawing.Size(116, 94);
            this.buttonClickMe_NVS.TabIndex = 8;
            this.buttonClickMe_NVS.Text = "Справка";
            this.buttonClickMe_NVS.UseVisualStyleBackColor = false;
            this.buttonClickMe_NVS.Click += new System.EventHandler(this.buttonClickMe_NVS_Click);
            // 
            // groupBoxOutPut_NVS
            // 
            this.groupBoxOutPut_NVS.Controls.Add(this.dataGridViewNums_NVS);
            this.groupBoxOutPut_NVS.Location = new System.Drawing.Point(9, 144);
            this.groupBoxOutPut_NVS.Name = "groupBoxOutPut_NVS";
            this.groupBoxOutPut_NVS.Size = new System.Drawing.Size(182, 458);
            this.groupBoxOutPut_NVS.TabIndex = 9;
            this.groupBoxOutPut_NVS.TabStop = false;
            this.groupBoxOutPut_NVS.Text = "Вывод данных";
            // 
            // buttonOutPutFile_NVS
            // 
            this.buttonOutPutFile_NVS.BackColor = System.Drawing.Color.Aqua;
            this.buttonOutPutFile_NVS.Location = new System.Drawing.Point(677, 33);
            this.buttonOutPutFile_NVS.Name = "buttonOutPutFile_NVS";
            this.buttonOutPutFile_NVS.Size = new System.Drawing.Size(118, 94);
            this.buttonOutPutFile_NVS.TabIndex = 11;
            this.buttonOutPutFile_NVS.Text = "Открыть файл";
            this.buttonOutPutFile_NVS.UseVisualStyleBackColor = false;
            this.buttonOutPutFile_NVS.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartDiagram_NVS
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDiagram_NVS.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDiagram_NVS.Legends.Add(legend3);
            this.chartDiagram_NVS.Location = new System.Drawing.Point(197, 144);
            this.chartDiagram_NVS.Name = "chartDiagram_NVS";
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartDiagram_NVS.Series.Add(series3);
            this.chartDiagram_NVS.Size = new System.Drawing.Size(720, 451);
            this.chartDiagram_NVS.TabIndex = 12;
            this.chartDiagram_NVS.Text = "chart1";
            // 
            // dataGridViewNums_NVS
            // 
            this.dataGridViewNums_NVS.AllowUserToAddRows = false;
            this.dataGridViewNums_NVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_NVS.Location = new System.Drawing.Point(3, 37);
            this.dataGridViewNums_NVS.Name = "dataGridViewNums_NVS";
            this.dataGridViewNums_NVS.ReadOnly = true;
            this.dataGridViewNums_NVS.RowHeadersWidth = 51;
            this.dataGridViewNums_NVS.RowTemplate.Height = 24;
            this.dataGridViewNums_NVS.Size = new System.Drawing.Size(173, 414);
            this.dataGridViewNums_NVS.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 607);
            this.Controls.Add(this.chartDiagram_NVS);
            this.Controls.Add(this.buttonOutPutFile_NVS);
            this.Controls.Add(this.groupBoxOutPut_NVS);
            this.Controls.Add(this.buttonClickMe_NVS);
            this.Controls.Add(this.buttonDone_NVS);
            this.Controls.Add(this.groupBoxCondition_NVS);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 15 | Николайчук В.С.";
            this.groupBoxCondition_NVS.ResumeLayout(false);
            this.groupBoxOutPut_NVS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_NVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_NVS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_NVS;
        private System.Windows.Forms.GroupBox groupBoxCond_NVS;
        private System.Windows.Forms.Button buttonDone_NVS;
        private System.Windows.Forms.Button buttonClickMe_NVS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_NVS;
        private System.Windows.Forms.Button buttonOutPutFile_NVS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagram_NVS;
        private System.Windows.Forms.DataGridView dataGridViewNums_NVS;
    }
}

