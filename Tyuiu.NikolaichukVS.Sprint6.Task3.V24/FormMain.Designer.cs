
namespace Tyuiu.NikolaichukVS.Sprint6.Task3.V24
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
            this.groupBoxOutPut_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_NVS = new System.Windows.Forms.GroupBox();
            this.buttonDone_NVS = new System.Windows.Forms.Button();
            this.buttonClickMe_NVS = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_NVS = new System.Windows.Forms.DataGridView();
            this.textBoxCondition_NVS = new System.Windows.Forms.TextBox();
            this.dataGridViewResult_NVS = new System.Windows.Forms.DataGridView();
            this.groupBoxCondition_NVS.SuspendLayout();
            this.groupBoxOutPut_NVS.SuspendLayout();
            this.groupBoxResult_NVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_NVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_NVS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_NVS
            // 
            this.groupBoxCondition_NVS.Controls.Add(this.textBoxCondition_NVS);
            this.groupBoxCondition_NVS.Controls.Add(this.dataGridViewMatrix_NVS);
            this.groupBoxCondition_NVS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_NVS.Name = "groupBoxCondition_NVS";
            this.groupBoxCondition_NVS.Size = new System.Drawing.Size(718, 417);
            this.groupBoxCondition_NVS.TabIndex = 2;
            this.groupBoxCondition_NVS.TabStop = false;
            this.groupBoxCondition_NVS.Text = "Условие";
            // 
            // groupBoxOutPut_NVS
            // 
            this.groupBoxOutPut_NVS.Controls.Add(this.groupBoxResult_NVS);
            this.groupBoxOutPut_NVS.Location = new System.Drawing.Point(736, 16);
            this.groupBoxOutPut_NVS.Name = "groupBoxOutPut_NVS";
            this.groupBoxOutPut_NVS.Size = new System.Drawing.Size(395, 419);
            this.groupBoxOutPut_NVS.TabIndex = 7;
            this.groupBoxOutPut_NVS.TabStop = false;
            this.groupBoxOutPut_NVS.Text = "Вывод данных";
            // 
            // groupBoxResult_NVS
            // 
            this.groupBoxResult_NVS.Controls.Add(this.dataGridViewResult_NVS);
            this.groupBoxResult_NVS.Controls.Add(this.buttonClickMe_NVS);
            this.groupBoxResult_NVS.Controls.Add(this.buttonDone_NVS);
            this.groupBoxResult_NVS.Location = new System.Drawing.Point(6, 29);
            this.groupBoxResult_NVS.Name = "groupBoxResult_NVS";
            this.groupBoxResult_NVS.Size = new System.Drawing.Size(371, 384);
            this.groupBoxResult_NVS.TabIndex = 0;
            this.groupBoxResult_NVS.TabStop = false;
            this.groupBoxResult_NVS.Text = "Результат:";
            // 
            // buttonDone_NVS
            // 
            this.buttonDone_NVS.Location = new System.Drawing.Point(74, 333);
            this.buttonDone_NVS.Name = "buttonDone_NVS";
            this.buttonDone_NVS.Size = new System.Drawing.Size(135, 51);
            this.buttonDone_NVS.TabIndex = 1;
            this.buttonDone_NVS.Text = "Выполнить";
            this.buttonDone_NVS.UseVisualStyleBackColor = true;
            this.buttonDone_NVS.Click += new System.EventHandler(this.buttonDone_NVS_Click);
            // 
            // buttonClickMe_NVS
            // 
            this.buttonClickMe_NVS.Location = new System.Drawing.Point(7, 333);
            this.buttonClickMe_NVS.Name = "buttonClickMe_NVS";
            this.buttonClickMe_NVS.Size = new System.Drawing.Size(61, 51);
            this.buttonClickMe_NVS.TabIndex = 2;
            this.buttonClickMe_NVS.Text = "?";
            this.buttonClickMe_NVS.UseVisualStyleBackColor = true;
            this.buttonClickMe_NVS.Click += new System.EventHandler(this.buttonClickMe_NVS_Click);
            // 
            // dataGridViewMatrix_NVS
            // 
            this.dataGridViewMatrix_NVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_NVS.Location = new System.Drawing.Point(342, 33);
            this.dataGridViewMatrix_NVS.Name = "dataGridViewMatrix_NVS";
            this.dataGridViewMatrix_NVS.RowHeadersVisible = false;
            this.dataGridViewMatrix_NVS.RowHeadersWidth = 51;
            this.dataGridViewMatrix_NVS.RowTemplate.Height = 24;
            this.dataGridViewMatrix_NVS.Size = new System.Drawing.Size(357, 378);
            this.dataGridViewMatrix_NVS.TabIndex = 1;
            // 
            // textBoxCondition_NVS
            // 
            this.textBoxCondition_NVS.Location = new System.Drawing.Point(6, 33);
            this.textBoxCondition_NVS.Multiline = true;
            this.textBoxCondition_NVS.Name = "textBoxCondition_NVS";
            this.textBoxCondition_NVS.ReadOnly = true;
            this.textBoxCondition_NVS.Size = new System.Drawing.Size(321, 256);
            this.textBoxCondition_NVS.TabIndex = 2;
            this.textBoxCondition_NVS.Text = resources.GetString("textBoxCondition_NVS.Text");
            // 
            // dataGridViewResult_NVS
            // 
            this.dataGridViewResult_NVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_NVS.Location = new System.Drawing.Point(16, 35);
            this.dataGridViewResult_NVS.Name = "dataGridViewResult_NVS";
            this.dataGridViewResult_NVS.RowHeadersWidth = 51;
            this.dataGridViewResult_NVS.RowTemplate.Height = 24;
            this.dataGridViewResult_NVS.Size = new System.Drawing.Size(333, 292);
            this.dataGridViewResult_NVS.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 440);
            this.Controls.Add(this.groupBoxOutPut_NVS);
            this.Controls.Add(this.groupBoxCondition_NVS);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_NVS.ResumeLayout(false);
            this.groupBoxCondition_NVS.PerformLayout();
            this.groupBoxOutPut_NVS.ResumeLayout(false);
            this.groupBoxResult_NVS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_NVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_NVS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_NVS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_NVS;
        private System.Windows.Forms.GroupBox groupBoxResult_NVS;
        private System.Windows.Forms.Button buttonDone_NVS;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_NVS;
        private System.Windows.Forms.Button buttonClickMe_NVS;
        private System.Windows.Forms.TextBox textBoxCondition_NVS;
        private System.Windows.Forms.DataGridView dataGridViewResult_NVS;
    }
}

