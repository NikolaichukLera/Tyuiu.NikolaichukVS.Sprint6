
namespace Tyuiu.NikolaichukVS.Sprint6.Task2.V10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxCond_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxStop_NVS = new System.Windows.Forms.GroupBox();
            this.textBoxStop_NVS = new System.Windows.Forms.TextBox();
            this.groupBoxStart_NVS = new System.Windows.Forms.GroupBox();
            this.textBoxStart_NVS = new System.Windows.Forms.TextBox();
            this.buttonClickMe_NVS = new System.Windows.Forms.Button();
            this.buttonDone_NVS = new System.Windows.Forms.Button();
            this.groupBoxOutPut_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_NVS = new System.Windows.Forms.GroupBox();
            this.chartGraf_NVS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult_NVS = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnX_NVS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCondition_NVS.SuspendLayout();
            this.groupBoxInPut_NVS.SuspendLayout();
            this.groupBoxStop_NVS.SuspendLayout();
            this.groupBoxStart_NVS.SuspendLayout();
            this.groupBoxOutPut_NVS.SuspendLayout();
            this.groupBoxResult_NVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf_NVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_NVS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_NVS
            // 
            this.groupBoxCondition_NVS.Controls.Add(this.groupBoxCond_NVS);
            this.groupBoxCondition_NVS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_NVS.Name = "groupBoxCondition_NVS";
            this.groupBoxCondition_NVS.Size = new System.Drawing.Size(481, 281);
            this.groupBoxCondition_NVS.TabIndex = 1;
            this.groupBoxCondition_NVS.TabStop = false;
            this.groupBoxCondition_NVS.Text = "Условие";
            // 
            // groupBoxCond_NVS
            // 
            this.groupBoxCond_NVS.Location = new System.Drawing.Point(7, 33);
            this.groupBoxCond_NVS.Name = "groupBoxCond_NVS";
            this.groupBoxCond_NVS.Size = new System.Drawing.Size(468, 258);
            this.groupBoxCond_NVS.TabIndex = 0;
            this.groupBoxCond_NVS.TabStop = false;
            this.groupBoxCond_NVS.Text = resources.GetString("groupBoxCond_NVS.Text");
            // 
            // groupBoxInPut_NVS
            // 
            this.groupBoxInPut_NVS.Controls.Add(this.groupBoxStop_NVS);
            this.groupBoxInPut_NVS.Controls.Add(this.groupBoxStart_NVS);
            this.groupBoxInPut_NVS.Location = new System.Drawing.Point(12, 309);
            this.groupBoxInPut_NVS.Name = "groupBoxInPut_NVS";
            this.groupBoxInPut_NVS.Size = new System.Drawing.Size(270, 129);
            this.groupBoxInPut_NVS.TabIndex = 2;
            this.groupBoxInPut_NVS.TabStop = false;
            this.groupBoxInPut_NVS.Text = "Ввод данных ";
            // 
            // groupBoxStop_NVS
            // 
            this.groupBoxStop_NVS.Controls.Add(this.textBoxStop_NVS);
            this.groupBoxStop_NVS.Location = new System.Drawing.Point(130, 34);
            this.groupBoxStop_NVS.Name = "groupBoxStop_NVS";
            this.groupBoxStop_NVS.Size = new System.Drawing.Size(116, 70);
            this.groupBoxStop_NVS.TabIndex = 1;
            this.groupBoxStop_NVS.TabStop = false;
            this.groupBoxStop_NVS.Text = "Конец шага:";
            // 
            // textBoxStop_NVS
            // 
            this.textBoxStop_NVS.Location = new System.Drawing.Point(7, 34);
            this.textBoxStop_NVS.Name = "textBoxStop_NVS";
            this.textBoxStop_NVS.Size = new System.Drawing.Size(87, 22);
            this.textBoxStop_NVS.TabIndex = 0;
            // 
            // groupBoxStart_NVS
            // 
            this.groupBoxStart_NVS.Controls.Add(this.textBoxStart_NVS);
            this.groupBoxStart_NVS.Location = new System.Drawing.Point(8, 34);
            this.groupBoxStart_NVS.Name = "groupBoxStart_NVS";
            this.groupBoxStart_NVS.Size = new System.Drawing.Size(116, 70);
            this.groupBoxStart_NVS.TabIndex = 0;
            this.groupBoxStart_NVS.TabStop = false;
            this.groupBoxStart_NVS.Text = "Старт шага:";
            // 
            // textBoxStart_NVS
            // 
            this.textBoxStart_NVS.Location = new System.Drawing.Point(7, 35);
            this.textBoxStart_NVS.Name = "textBoxStart_NVS";
            this.textBoxStart_NVS.Size = new System.Drawing.Size(86, 22);
            this.textBoxStart_NVS.TabIndex = 0;
            // 
            // buttonClickMe_NVS
            // 
            this.buttonClickMe_NVS.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonClickMe_NVS.Location = new System.Drawing.Point(300, 381);
            this.buttonClickMe_NVS.Name = "buttonClickMe_NVS";
            this.buttonClickMe_NVS.Size = new System.Drawing.Size(71, 57);
            this.buttonClickMe_NVS.TabIndex = 4;
            this.buttonClickMe_NVS.Text = "Справка";
            this.buttonClickMe_NVS.UseVisualStyleBackColor = false;
            this.buttonClickMe_NVS.Click += new System.EventHandler(this.buttonClickMe_NVS_Click);
            // 
            // buttonDone_NVS
            // 
            this.buttonDone_NVS.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_NVS.ForeColor = System.Drawing.Color.Black;
            this.buttonDone_NVS.Location = new System.Drawing.Point(390, 381);
            this.buttonDone_NVS.Name = "buttonDone_NVS";
            this.buttonDone_NVS.Size = new System.Drawing.Size(114, 57);
            this.buttonDone_NVS.TabIndex = 5;
            this.buttonDone_NVS.Text = "Выполнить";
            this.buttonDone_NVS.UseVisualStyleBackColor = false;
            this.buttonDone_NVS.Click += new System.EventHandler(this.buttonDone_NVS_Click);
            this.buttonDone_NVS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_NVS_MouseDown);
            this.buttonDone_NVS.MouseEnter += new System.EventHandler(this.buttonDone_NVS_MouseEnter);
            this.buttonDone_NVS.MouseLeave += new System.EventHandler(this.buttonDone_NVS_MouseLeave);
            // 
            // groupBoxOutPut_NVS
            // 
            this.groupBoxOutPut_NVS.Controls.Add(this.groupBoxResult_NVS);
            this.groupBoxOutPut_NVS.Location = new System.Drawing.Point(510, 16);
            this.groupBoxOutPut_NVS.Name = "groupBoxOutPut_NVS";
            this.groupBoxOutPut_NVS.Size = new System.Drawing.Size(502, 419);
            this.groupBoxOutPut_NVS.TabIndex = 6;
            this.groupBoxOutPut_NVS.TabStop = false;
            this.groupBoxOutPut_NVS.Text = "Вывод данных";
            // 
            // groupBoxResult_NVS
            // 
            this.groupBoxResult_NVS.Controls.Add(this.chartGraf_NVS);
            this.groupBoxResult_NVS.Controls.Add(this.dataGridViewResult_NVS);
            this.groupBoxResult_NVS.Location = new System.Drawing.Point(7, 21);
            this.groupBoxResult_NVS.Name = "groupBoxResult_NVS";
            this.groupBoxResult_NVS.Size = new System.Drawing.Size(489, 385);
            this.groupBoxResult_NVS.TabIndex = 0;
            this.groupBoxResult_NVS.TabStop = false;
            this.groupBoxResult_NVS.Text = "Результат:";
            // 
            // chartGraf_NVS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraf_NVS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraf_NVS.Legends.Add(legend1);
            this.chartGraf_NVS.Location = new System.Drawing.Point(158, 21);
            this.chartGraf_NVS.Name = "chartGraf_NVS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Legent1 - Empty";
            this.chartGraf_NVS.Series.Add(series1);
            this.chartGraf_NVS.Size = new System.Drawing.Size(325, 355);
            this.chartGraf_NVS.TabIndex = 1;
            this.chartGraf_NVS.Text = "chart1";
            // 
            // dataGridViewResult_NVS
            // 
            this.dataGridViewResult_NVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_NVS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.ColumnX_NVS});
            this.dataGridViewResult_NVS.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewResult_NVS.Name = "dataGridViewResult_NVS";
            this.dataGridViewResult_NVS.RowHeadersVisible = false;
            this.dataGridViewResult_NVS.RowHeadersWidth = 51;
            this.dataGridViewResult_NVS.RowTemplate.Height = 24;
            this.dataGridViewResult_NVS.Size = new System.Drawing.Size(131, 338);
            this.dataGridViewResult_NVS.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // ColumnX_NVS
            // 
            this.ColumnX_NVS.HeaderText = "F(x)";
            this.ColumnX_NVS.MinimumWidth = 6;
            this.ColumnX_NVS.Name = "ColumnX_NVS";
            this.ColumnX_NVS.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.groupBoxOutPut_NVS);
            this.Controls.Add(this.buttonDone_NVS);
            this.Controls.Add(this.buttonClickMe_NVS);
            this.Controls.Add(this.groupBoxInPut_NVS);
            this.Controls.Add(this.groupBoxCondition_NVS);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBoxCondition_NVS.ResumeLayout(false);
            this.groupBoxInPut_NVS.ResumeLayout(false);
            this.groupBoxStop_NVS.ResumeLayout(false);
            this.groupBoxStop_NVS.PerformLayout();
            this.groupBoxStart_NVS.ResumeLayout(false);
            this.groupBoxStart_NVS.PerformLayout();
            this.groupBoxOutPut_NVS.ResumeLayout(false);
            this.groupBoxResult_NVS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf_NVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_NVS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_NVS;
        private System.Windows.Forms.GroupBox groupBoxCond_NVS;
        private System.Windows.Forms.GroupBox groupBoxInPut_NVS;
        private System.Windows.Forms.GroupBox groupBoxStop_NVS;
        private System.Windows.Forms.TextBox textBoxStop_NVS;
        private System.Windows.Forms.GroupBox groupBoxStart_NVS;
        private System.Windows.Forms.TextBox textBoxStart_NVS;
        private System.Windows.Forms.Button buttonClickMe_NVS;
        private System.Windows.Forms.Button buttonDone_NVS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_NVS;
        private System.Windows.Forms.GroupBox groupBoxResult_NVS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraf_NVS;
        private System.Windows.Forms.DataGridView dataGridViewResult_NVS;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_NVS;
    }
}

