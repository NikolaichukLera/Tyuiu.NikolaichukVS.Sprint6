
namespace Tyuiu.NikolaichukVS.Sprint6.Task6.V22
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
            this.groupBoxCondition_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxCond_NVS = new System.Windows.Forms.GroupBox();
            this.buttonClickMe_NVS = new System.Windows.Forms.Button();
            this.buttonDone_NVS = new System.Windows.Forms.Button();
            this.buttonOpenFile_NVS = new System.Windows.Forms.Button();
            this.groupBoxOutPut_NVS = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialogTask_NVS = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTask_NVS = new System.Windows.Forms.SaveFileDialog();
            this.textBoxLoadFile_NVS = new System.Windows.Forms.TextBox();
            this.textBoxResault_NVS = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_NVS.SuspendLayout();
            this.groupBoxOutPut_NVS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_NVS
            // 
            this.groupBoxCondition_NVS.Controls.Add(this.groupBoxCond_NVS);
            this.groupBoxCondition_NVS.Location = new System.Drawing.Point(12, 95);
            this.groupBoxCondition_NVS.Name = "groupBoxCondition_NVS";
            this.groupBoxCondition_NVS.Size = new System.Drawing.Size(958, 91);
            this.groupBoxCondition_NVS.TabIndex = 16;
            this.groupBoxCondition_NVS.TabStop = false;
            this.groupBoxCondition_NVS.Text = "Условие";
            // 
            // groupBoxCond_NVS
            // 
            this.groupBoxCond_NVS.Location = new System.Drawing.Point(7, 21);
            this.groupBoxCond_NVS.Name = "groupBoxCond_NVS";
            this.groupBoxCond_NVS.Size = new System.Drawing.Size(909, 55);
            this.groupBoxCond_NVS.TabIndex = 0;
            this.groupBoxCond_NVS.TabStop = false;
            this.groupBoxCond_NVS.Text = resources.GetString("groupBoxCond_NVS.Text");
            // 
            // buttonClickMe_NVS
            // 
            this.buttonClickMe_NVS.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonClickMe_NVS.Image = global::Tyuiu.NikolaichukVS.Sprint6.Task6.V22.Properties.Resources.help;
            this.buttonClickMe_NVS.Location = new System.Drawing.Point(841, 14);
            this.buttonClickMe_NVS.Name = "buttonClickMe_NVS";
            this.buttonClickMe_NVS.Size = new System.Drawing.Size(110, 75);
            this.buttonClickMe_NVS.TabIndex = 17;
            this.buttonClickMe_NVS.UseVisualStyleBackColor = false;
            this.buttonClickMe_NVS.Click += new System.EventHandler(this.buttonClickMe_NVS_Click);
            // 
            // buttonDone_NVS
            // 
            this.buttonDone_NVS.BackColor = System.Drawing.Color.White;
            this.buttonDone_NVS.Enabled = false;
            this.buttonDone_NVS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_NVS.ForeColor = System.Drawing.Color.Black;
            this.buttonDone_NVS.Image = global::Tyuiu.NikolaichukVS.Sprint6.Task6.V22.Properties.Resources.page_go;
            this.buttonDone_NVS.Location = new System.Drawing.Point(164, 14);
            this.buttonDone_NVS.Name = "buttonDone_NVS";
            this.buttonDone_NVS.Size = new System.Drawing.Size(115, 75);
            this.buttonDone_NVS.TabIndex = 15;
            this.buttonDone_NVS.UseVisualStyleBackColor = false;
            this.buttonDone_NVS.Click += new System.EventHandler(this.buttonDone_NVS_Click);
            // 
            // buttonOpenFile_NVS
            // 
            this.buttonOpenFile_NVS.BackColor = System.Drawing.Color.White;
            this.buttonOpenFile_NVS.Image = global::Tyuiu.NikolaichukVS.Sprint6.Task6.V22.Properties.Resources.folder_page;
            this.buttonOpenFile_NVS.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_NVS.Name = "buttonOpenFile_NVS";
            this.buttonOpenFile_NVS.Size = new System.Drawing.Size(113, 77);
            this.buttonOpenFile_NVS.TabIndex = 13;
            this.buttonOpenFile_NVS.UseVisualStyleBackColor = false;
            this.buttonOpenFile_NVS.Click += new System.EventHandler(this.buttonOpenFile_NVS_Click);
            // 
            // groupBoxOutPut_NVS
            // 
            this.groupBoxOutPut_NVS.Controls.Add(this.textBoxLoadFile_NVS);
            this.groupBoxOutPut_NVS.Controls.Add(this.toolStrip1);
            this.groupBoxOutPut_NVS.Location = new System.Drawing.Point(12, 192);
            this.groupBoxOutPut_NVS.Name = "groupBoxOutPut_NVS";
            this.groupBoxOutPut_NVS.Size = new System.Drawing.Size(455, 414);
            this.groupBoxOutPut_NVS.TabIndex = 18;
            this.groupBoxOutPut_NVS.TabStop = false;
            this.groupBoxOutPut_NVS.Text = "Ввод:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(3, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(449, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "Подсказка";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxResault_NVS);
            this.groupBox1.Location = new System.Drawing.Point(473, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 408);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод:";
            // 
            // openFileDialogTask_NVS
            // 
            this.openFileDialogTask_NVS.FileName = "openFileDialog1";
            // 
            // textBoxLoadFile_NVS
            // 
            this.textBoxLoadFile_NVS.Location = new System.Drawing.Point(7, 21);
            this.textBoxLoadFile_NVS.Multiline = true;
            this.textBoxLoadFile_NVS.Name = "textBoxLoadFile_NVS";
            this.textBoxLoadFile_NVS.Size = new System.Drawing.Size(442, 387);
            this.textBoxLoadFile_NVS.TabIndex = 3;
            // 
            // textBoxResault_NVS
            // 
            this.textBoxResault_NVS.Location = new System.Drawing.Point(6, 21);
            this.textBoxResault_NVS.Multiline = true;
            this.textBoxResault_NVS.Name = "textBoxResault_NVS";
            this.textBoxResault_NVS.Size = new System.Drawing.Size(491, 387);
            this.textBoxResault_NVS.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxOutPut_NVS);
            this.Controls.Add(this.buttonClickMe_NVS);
            this.Controls.Add(this.groupBoxCondition_NVS);
            this.Controls.Add(this.buttonDone_NVS);
            this.Controls.Add(this.buttonOpenFile_NVS);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 22 | Николайчук В.С.";
            this.groupBoxCondition_NVS.ResumeLayout(false);
            this.groupBoxOutPut_NVS.ResumeLayout(false);
            this.groupBoxOutPut_NVS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_NVS;
        private System.Windows.Forms.Button buttonDone_NVS;
        private System.Windows.Forms.GroupBox groupBoxCondition_NVS;
        private System.Windows.Forms.GroupBox groupBoxCond_NVS;
        private System.Windows.Forms.Button buttonClickMe_NVS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_NVS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_NVS;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_NVS;
        private System.Windows.Forms.TextBox textBoxLoadFile_NVS;
        private System.Windows.Forms.TextBox textBoxResault_NVS;
    }
}

