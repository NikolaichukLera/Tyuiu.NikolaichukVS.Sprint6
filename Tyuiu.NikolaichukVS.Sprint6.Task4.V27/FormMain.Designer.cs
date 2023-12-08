
namespace Tyuiu.NikolaichukVS.Sprint6.Task4.V27
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxCondition_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxCond_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxStop_NVS = new System.Windows.Forms.GroupBox();
            this.textBoxStop_NVS = new System.Windows.Forms.TextBox();
            this.groupBoxStart_NVS = new System.Windows.Forms.GroupBox();
            this.textBoxStart_NVS = new System.Windows.Forms.TextBox();
            this.buttonDone_NVS = new System.Windows.Forms.Button();
            this.buttonClickMe_NVS = new System.Windows.Forms.Button();
            this.groupBoxOutPut_NVS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_NVS = new System.Windows.Forms.TextBox();
            this.chartGraf_NVS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonSave_NVS = new System.Windows.Forms.Button();
            this.groupBoxCondition_NVS.SuspendLayout();
            this.groupBoxInPut_NVS.SuspendLayout();
            this.groupBoxStop_NVS.SuspendLayout();
            this.groupBoxStart_NVS.SuspendLayout();
            this.groupBoxOutPut_NVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf_NVS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_NVS
            // 
            this.groupBoxCondition_NVS.Controls.Add(this.groupBoxCond_NVS);
            this.groupBoxCondition_NVS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_NVS.Name = "groupBoxCondition_NVS";
            this.groupBoxCondition_NVS.Size = new System.Drawing.Size(448, 136);
            this.groupBoxCondition_NVS.TabIndex = 2;
            this.groupBoxCondition_NVS.TabStop = false;
            this.groupBoxCondition_NVS.Text = "Условие";
            // 
            // groupBoxCond_NVS
            // 
            this.groupBoxCond_NVS.Location = new System.Drawing.Point(7, 21);
            this.groupBoxCond_NVS.Name = "groupBoxCond_NVS";
            this.groupBoxCond_NVS.Size = new System.Drawing.Size(435, 109);
            this.groupBoxCond_NVS.TabIndex = 0;
            this.groupBoxCond_NVS.TabStop = false;
            this.groupBoxCond_NVS.Text = resources.GetString("groupBoxCond_NVS.Text");
            // 
            // groupBoxInPut_NVS
            // 
            this.groupBoxInPut_NVS.Controls.Add(this.buttonSave_NVS);
            this.groupBoxInPut_NVS.Controls.Add(this.buttonClickMe_NVS);
            this.groupBoxInPut_NVS.Controls.Add(this.buttonDone_NVS);
            this.groupBoxInPut_NVS.Controls.Add(this.groupBoxStop_NVS);
            this.groupBoxInPut_NVS.Controls.Add(this.groupBoxStart_NVS);
            this.groupBoxInPut_NVS.Location = new System.Drawing.Point(466, 12);
            this.groupBoxInPut_NVS.Name = "groupBoxInPut_NVS";
            this.groupBoxInPut_NVS.Size = new System.Drawing.Size(582, 136);
            this.groupBoxInPut_NVS.TabIndex = 3;
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
            // buttonDone_NVS
            // 
            this.buttonDone_NVS.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_NVS.ForeColor = System.Drawing.Color.Black;
            this.buttonDone_NVS.Location = new System.Drawing.Point(264, 34);
            this.buttonDone_NVS.Name = "buttonDone_NVS";
            this.buttonDone_NVS.Size = new System.Drawing.Size(90, 70);
            this.buttonDone_NVS.TabIndex = 6;
            this.buttonDone_NVS.Text = "Выполнить";
            this.buttonDone_NVS.UseVisualStyleBackColor = false;
            this.buttonDone_NVS.Click += new System.EventHandler(this.buttonDone_NVS_Click);
            // 
            // buttonClickMe_NVS
            // 
            this.buttonClickMe_NVS.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonClickMe_NVS.Location = new System.Drawing.Point(492, 34);
            this.buttonClickMe_NVS.Name = "buttonClickMe_NVS";
            this.buttonClickMe_NVS.Size = new System.Drawing.Size(75, 70);
            this.buttonClickMe_NVS.TabIndex = 7;
            this.buttonClickMe_NVS.Text = "Справка";
            this.buttonClickMe_NVS.UseVisualStyleBackColor = false;
            this.buttonClickMe_NVS.Click += new System.EventHandler(this.buttonClickMe_NVS_Click);
            // 
            // groupBoxOutPut_NVS
            // 
            this.groupBoxOutPut_NVS.Controls.Add(this.textBoxResult_NVS);
            this.groupBoxOutPut_NVS.Location = new System.Drawing.Point(12, 154);
            this.groupBoxOutPut_NVS.Name = "groupBoxOutPut_NVS";
            this.groupBoxOutPut_NVS.Size = new System.Drawing.Size(332, 404);
            this.groupBoxOutPut_NVS.TabIndex = 7;
            this.groupBoxOutPut_NVS.TabStop = false;
            this.groupBoxOutPut_NVS.Text = "Вывод данных";
            // 
            // textBoxResult_NVS
            // 
            this.textBoxResult_NVS.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_NVS.Location = new System.Drawing.Point(7, 29);
            this.textBoxResult_NVS.Multiline = true;
            this.textBoxResult_NVS.Name = "textBoxResult_NVS";
            this.textBoxResult_NVS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_NVS.Size = new System.Drawing.Size(295, 369);
            this.textBoxResult_NVS.TabIndex = 1;
            // 
            // chartGraf_NVS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraf_NVS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraf_NVS.Legends.Add(legend1);
            this.chartGraf_NVS.Location = new System.Drawing.Point(350, 167);
            this.chartGraf_NVS.Name = "chartGraf_NVS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraf_NVS.Series.Add(series1);
            this.chartGraf_NVS.Size = new System.Drawing.Size(683, 407);
            this.chartGraf_NVS.TabIndex = 8;
            this.chartGraf_NVS.Text = "График функции cos(x)";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "TitleCos";
            title1.ShadowColor = System.Drawing.Color.Blue;
            title1.Text = "График функции cos(x)";
            this.chartGraf_NVS.Titles.Add(title1);
            // 
            // buttonSave_NVS
            // 
            this.buttonSave_NVS.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSave_NVS.ForeColor = System.Drawing.Color.Black;
            this.buttonSave_NVS.Location = new System.Drawing.Point(378, 34);
            this.buttonSave_NVS.Name = "buttonSave_NVS";
            this.buttonSave_NVS.Size = new System.Drawing.Size(90, 70);
            this.buttonSave_NVS.TabIndex = 8;
            this.buttonSave_NVS.Text = "Сохранить";
            this.buttonSave_NVS.UseVisualStyleBackColor = false;
            this.buttonSave_NVS.Click += new System.EventHandler(this.buttonSave_NVS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 570);
            this.Controls.Add(this.chartGraf_NVS);
            this.Controls.Add(this.groupBoxOutPut_NVS);
            this.Controls.Add(this.groupBoxInPut_NVS);
            this.Controls.Add(this.groupBoxCondition_NVS);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 27 | Николайчук В.С.";
            this.groupBoxCondition_NVS.ResumeLayout(false);
            this.groupBoxInPut_NVS.ResumeLayout(false);
            this.groupBoxStop_NVS.ResumeLayout(false);
            this.groupBoxStop_NVS.PerformLayout();
            this.groupBoxStart_NVS.ResumeLayout(false);
            this.groupBoxStart_NVS.PerformLayout();
            this.groupBoxOutPut_NVS.ResumeLayout(false);
            this.groupBoxOutPut_NVS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf_NVS)).EndInit();
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
        private System.Windows.Forms.Button buttonDone_NVS;
        private System.Windows.Forms.Button buttonClickMe_NVS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_NVS;
        private System.Windows.Forms.TextBox textBoxResult_NVS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraf_NVS;
        private System.Windows.Forms.Button buttonSave_NVS;
    }
}

