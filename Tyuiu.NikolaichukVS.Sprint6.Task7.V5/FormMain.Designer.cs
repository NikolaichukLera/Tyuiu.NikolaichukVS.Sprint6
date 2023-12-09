
namespace Tyuiu.NikolaichukVS.Sprint6.Task7.V5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxCond_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_NVS = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_NVS = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_NVS = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_NVS = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSave_NVS = new System.Windows.Forms.Button();
            this.buttonSaveFile_NVS = new System.Windows.Forms.Button();
            this.buttonClickMe_NVS = new System.Windows.Forms.Button();
            this.buttonOpenFile_NVS = new System.Windows.Forms.Button();
            this.saveFileDialogTask_NVS = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxCondition_NVS.SuspendLayout();
            this.groupBoxOutPut_NVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_NVS)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_NVS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_NVS
            // 
            this.groupBoxCondition_NVS.Controls.Add(this.groupBoxCond_NVS);
            this.groupBoxCondition_NVS.Location = new System.Drawing.Point(12, 95);
            this.groupBoxCondition_NVS.Name = "groupBoxCondition_NVS";
            this.groupBoxCondition_NVS.Size = new System.Drawing.Size(922, 107);
            this.groupBoxCondition_NVS.TabIndex = 4;
            this.groupBoxCondition_NVS.TabStop = false;
            this.groupBoxCondition_NVS.Text = "Условие";
            // 
            // groupBoxCond_NVS
            // 
            this.groupBoxCond_NVS.Location = new System.Drawing.Point(7, 21);
            this.groupBoxCond_NVS.Name = "groupBoxCond_NVS";
            this.groupBoxCond_NVS.Size = new System.Drawing.Size(909, 69);
            this.groupBoxCond_NVS.TabIndex = 0;
            this.groupBoxCond_NVS.TabStop = false;
            this.groupBoxCond_NVS.Text = resources.GetString("groupBoxCond_NVS.Text");
            // 
            // groupBoxOutPut_NVS
            // 
            this.groupBoxOutPut_NVS.Controls.Add(this.dataGridViewInPut_NVS);
            this.groupBoxOutPut_NVS.Location = new System.Drawing.Point(12, 208);
            this.groupBoxOutPut_NVS.Name = "groupBoxOutPut_NVS";
            this.groupBoxOutPut_NVS.Size = new System.Drawing.Size(445, 368);
            this.groupBoxOutPut_NVS.TabIndex = 10;
            this.groupBoxOutPut_NVS.TabStop = false;
            this.groupBoxOutPut_NVS.Text = "Ввод:";
            // 
            // dataGridViewInPut_NVS
            // 
            this.dataGridViewInPut_NVS.AllowUserToAddRows = false;
            this.dataGridViewInPut_NVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_NVS.Location = new System.Drawing.Point(6, 36);
            this.dataGridViewInPut_NVS.Name = "dataGridViewInPut_NVS";
            this.dataGridViewInPut_NVS.ReadOnly = true;
            this.dataGridViewInPut_NVS.RowHeadersWidth = 51;
            this.dataGridViewInPut_NVS.RowTemplate.Height = 24;
            this.dataGridViewInPut_NVS.Size = new System.Drawing.Size(433, 326);
            this.dataGridViewInPut_NVS.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewOutPut_NVS);
            this.groupBox1.Location = new System.Drawing.Point(463, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 368);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод:";
            // 
            // dataGridViewOutPut_NVS
            // 
            this.dataGridViewOutPut_NVS.AllowUserToAddRows = false;
            this.dataGridViewOutPut_NVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_NVS.Location = new System.Drawing.Point(19, 36);
            this.dataGridViewOutPut_NVS.Name = "dataGridViewOutPut_NVS";
            this.dataGridViewOutPut_NVS.ReadOnly = true;
            this.dataGridViewOutPut_NVS.RowHeadersWidth = 51;
            this.dataGridViewOutPut_NVS.RowTemplate.Height = 24;
            this.dataGridViewOutPut_NVS.Size = new System.Drawing.Size(433, 326);
            this.dataGridViewOutPut_NVS.TabIndex = 2;
            // 
            // openFileDialogTask_NVS
            // 
            this.openFileDialogTask_NVS.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // buttonSave_NVS
            // 
            this.buttonSave_NVS.BackColor = System.Drawing.Color.White;
            this.buttonSave_NVS.Enabled = false;
            this.buttonSave_NVS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_NVS.ForeColor = System.Drawing.Color.Black;
            this.buttonSave_NVS.Image = global::Tyuiu.NikolaichukVS.Sprint6.Task7.V5.Properties.Resources.page_save;
            this.buttonSave_NVS.Location = new System.Drawing.Point(288, 14);
            this.buttonSave_NVS.Name = "buttonSave_NVS";
            this.buttonSave_NVS.Size = new System.Drawing.Size(115, 75);
            this.buttonSave_NVS.TabIndex = 15;
            this.toolTip1.SetToolTip(this.buttonSave_NVS, "Сохранить в файл\r\nСохранить обработанные данные в файл в формате CSV.");
            this.buttonSave_NVS.UseVisualStyleBackColor = false;
            this.buttonSave_NVS.Click += new System.EventHandler(this.buttonSave_NVS_Click);
            // 
            // buttonSaveFile_NVS
            // 
            this.buttonSaveFile_NVS.BackColor = System.Drawing.Color.White;
            this.buttonSaveFile_NVS.Enabled = false;
            this.buttonSaveFile_NVS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_NVS.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveFile_NVS.Image = global::Tyuiu.NikolaichukVS.Sprint6.Task7.V5.Properties.Resources.page_go;
            this.buttonSaveFile_NVS.Location = new System.Drawing.Point(147, 14);
            this.buttonSaveFile_NVS.Name = "buttonSaveFile_NVS";
            this.buttonSaveFile_NVS.Size = new System.Drawing.Size(115, 75);
            this.buttonSaveFile_NVS.TabIndex = 14;
            this.toolTip1.SetToolTip(this.buttonSaveFile_NVS, "Выполнить\r\nВыполнить обработку данных");
            this.buttonSaveFile_NVS.UseVisualStyleBackColor = false;
            this.buttonSaveFile_NVS.Click += new System.EventHandler(this.buttonSaveFile_NVS_Click);
            // 
            // buttonClickMe_NVS
            // 
            this.buttonClickMe_NVS.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonClickMe_NVS.Image = global::Tyuiu.NikolaichukVS.Sprint6.Task7.V5.Properties.Resources.help;
            this.buttonClickMe_NVS.Location = new System.Drawing.Point(805, 14);
            this.buttonClickMe_NVS.Name = "buttonClickMe_NVS";
            this.buttonClickMe_NVS.Size = new System.Drawing.Size(110, 75);
            this.buttonClickMe_NVS.TabIndex = 13;
            this.toolTip1.SetToolTip(this.buttonClickMe_NVS, "Справка\r\nСведения о программе");
            this.buttonClickMe_NVS.UseVisualStyleBackColor = false;
            this.buttonClickMe_NVS.Click += new System.EventHandler(this.buttonClickMe_NVS_Click);
            // 
            // buttonOpenFile_NVS
            // 
            this.buttonOpenFile_NVS.BackColor = System.Drawing.Color.White;
            this.buttonOpenFile_NVS.Image = global::Tyuiu.NikolaichukVS.Sprint6.Task7.V5.Properties.Resources.folder_page;
            this.buttonOpenFile_NVS.Location = new System.Drawing.Point(18, 14);
            this.buttonOpenFile_NVS.Name = "buttonOpenFile_NVS";
            this.buttonOpenFile_NVS.Size = new System.Drawing.Size(113, 77);
            this.buttonOpenFile_NVS.TabIndex = 12;
            this.toolTip1.SetToolTip(this.buttonOpenFile_NVS, "Открыть файл\r\nВыберете нужный файл для обработки");
            this.buttonOpenFile_NVS.UseVisualStyleBackColor = false;
            this.buttonOpenFile_NVS.Click += new System.EventHandler(this.buttonOpenFile_NVS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 588);
            this.Controls.Add(this.buttonSave_NVS);
            this.Controls.Add(this.buttonSaveFile_NVS);
            this.Controls.Add(this.buttonClickMe_NVS);
            this.Controls.Add(this.buttonOpenFile_NVS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxOutPut_NVS);
            this.Controls.Add(this.groupBoxCondition_NVS);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 5 | Николайчук В.С.";
            this.groupBoxCondition_NVS.ResumeLayout(false);
            this.groupBoxOutPut_NVS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_NVS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_NVS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_NVS;
        private System.Windows.Forms.GroupBox groupBoxCond_NVS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_NVS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewInPut_NVS;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_NVS;
        private System.Windows.Forms.Button buttonOpenFile_NVS;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_NVS;
        private System.Windows.Forms.Button buttonClickMe_NVS;
        private System.Windows.Forms.Button buttonSaveFile_NVS;
        private System.Windows.Forms.Button buttonSave_NVS;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_NVS;
    }
}

