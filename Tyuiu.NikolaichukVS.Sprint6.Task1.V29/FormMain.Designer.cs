
namespace Tyuiu.NikolaichukVS.Sprint6.Task1.V29
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxCond_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxStart_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxStop_NVS = new System.Windows.Forms.GroupBox();
            this.textBoxStart_NVS = new System.Windows.Forms.TextBox();
            this.textBoxStop_NVS = new System.Windows.Forms.TextBox();
            this.buttonDone_NVS = new System.Windows.Forms.Button();
            this.buttonClickMe_NVS = new System.Windows.Forms.Button();
            this.groupBoxOutPut_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_NVS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_NVS = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_NVS.SuspendLayout();
            this.groupBoxInPut_NVS.SuspendLayout();
            this.groupBoxStart_NVS.SuspendLayout();
            this.groupBoxStop_NVS.SuspendLayout();
            this.groupBoxOutPut_NVS.SuspendLayout();
            this.groupBoxResult_NVS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_NVS
            // 
            this.groupBoxCondition_NVS.Controls.Add(this.groupBoxCond_NVS);
            this.groupBoxCondition_NVS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_NVS.Name = "groupBoxCondition_NVS";
            this.groupBoxCondition_NVS.Size = new System.Drawing.Size(461, 308);
            this.groupBoxCondition_NVS.TabIndex = 0;
            this.groupBoxCondition_NVS.TabStop = false;
            this.groupBoxCondition_NVS.Text = "Условие";
            // 
            // groupBoxCond_NVS
            // 
            this.groupBoxCond_NVS.Location = new System.Drawing.Point(7, 33);
            this.groupBoxCond_NVS.Name = "groupBoxCond_NVS";
            this.groupBoxCond_NVS.Size = new System.Drawing.Size(430, 230);
            this.groupBoxCond_NVS.TabIndex = 0;
            this.groupBoxCond_NVS.TabStop = false;
            this.groupBoxCond_NVS.Text = resources.GetString("groupBoxCond_NVS.Text");
            // 
            // groupBoxInPut_NVS
            // 
            this.groupBoxInPut_NVS.Controls.Add(this.groupBoxStop_NVS);
            this.groupBoxInPut_NVS.Controls.Add(this.groupBoxStart_NVS);
            this.groupBoxInPut_NVS.Location = new System.Drawing.Point(12, 328);
            this.groupBoxInPut_NVS.Name = "groupBoxInPut_NVS";
            this.groupBoxInPut_NVS.Size = new System.Drawing.Size(265, 110);
            this.groupBoxInPut_NVS.TabIndex = 1;
            this.groupBoxInPut_NVS.TabStop = false;
            this.groupBoxInPut_NVS.Text = "Ввод данных ";
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
            // textBoxStart_NVS
            // 
            this.textBoxStart_NVS.Location = new System.Drawing.Point(7, 35);
            this.textBoxStart_NVS.Name = "textBoxStart_NVS";
            this.textBoxStart_NVS.Size = new System.Drawing.Size(86, 22);
            this.textBoxStart_NVS.TabIndex = 0;
            // 
            // textBoxStop_NVS
            // 
            this.textBoxStop_NVS.Location = new System.Drawing.Point(7, 34);
            this.textBoxStop_NVS.Name = "textBoxStop_NVS";
            this.textBoxStop_NVS.Size = new System.Drawing.Size(87, 22);
            this.textBoxStop_NVS.TabIndex = 0;
            // 
            // buttonDone_NVS
            // 
            this.buttonDone_NVS.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_NVS.ForeColor = System.Drawing.Color.Black;
            this.buttonDone_NVS.Location = new System.Drawing.Point(360, 375);
            this.buttonDone_NVS.Name = "buttonDone_NVS";
            this.buttonDone_NVS.Size = new System.Drawing.Size(114, 57);
            this.buttonDone_NVS.TabIndex = 2;
            this.buttonDone_NVS.Text = "Выполнить";
            this.buttonDone_NVS.UseVisualStyleBackColor = false;
            this.buttonDone_NVS.Click += new System.EventHandler(this.buttonDone_NVS_Click);
            // 
            // buttonClickMe_NVS
            // 
            this.buttonClickMe_NVS.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonClickMe_NVS.Location = new System.Drawing.Point(283, 375);
            this.buttonClickMe_NVS.Name = "buttonClickMe_NVS";
            this.buttonClickMe_NVS.Size = new System.Drawing.Size(71, 57);
            this.buttonClickMe_NVS.TabIndex = 3;
            this.buttonClickMe_NVS.Text = "Справка";
            this.buttonClickMe_NVS.UseVisualStyleBackColor = false;
            this.buttonClickMe_NVS.Click += new System.EventHandler(this.buttonClickMe_NVS_Click);
            // 
            // groupBoxOutPut_NVS
            // 
            this.groupBoxOutPut_NVS.Controls.Add(this.groupBoxResult_NVS);
            this.groupBoxOutPut_NVS.Location = new System.Drawing.Point(480, 13);
            this.groupBoxOutPut_NVS.Name = "groupBoxOutPut_NVS";
            this.groupBoxOutPut_NVS.Size = new System.Drawing.Size(308, 419);
            this.groupBoxOutPut_NVS.TabIndex = 4;
            this.groupBoxOutPut_NVS.TabStop = false;
            this.groupBoxOutPut_NVS.Text = "Вывод данных";
            // 
            // groupBoxResult_NVS
            // 
            this.groupBoxResult_NVS.Controls.Add(this.textBoxResult_NVS);
            this.groupBoxResult_NVS.Location = new System.Drawing.Point(7, 21);
            this.groupBoxResult_NVS.Name = "groupBoxResult_NVS";
            this.groupBoxResult_NVS.Size = new System.Drawing.Size(295, 385);
            this.groupBoxResult_NVS.TabIndex = 0;
            this.groupBoxResult_NVS.TabStop = false;
            this.groupBoxResult_NVS.Text = "Результат:";
            // 
            // textBoxResult_NVS
            // 
            this.textBoxResult_NVS.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_NVS.Location = new System.Drawing.Point(7, 33);
            this.textBoxResult_NVS.Multiline = true;
            this.textBoxResult_NVS.Name = "textBoxResult_NVS";
            this.textBoxResult_NVS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_NVS.Size = new System.Drawing.Size(272, 346);
            this.textBoxResult_NVS.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutPut_NVS);
            this.Controls.Add(this.buttonClickMe_NVS);
            this.Controls.Add(this.buttonDone_NVS);
            this.Controls.Add(this.groupBoxInPut_NVS);
            this.Controls.Add(this.groupBoxCondition_NVS);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1| Вариант 29 | Николайчук В. С.";
            this.groupBoxCondition_NVS.ResumeLayout(false);
            this.groupBoxInPut_NVS.ResumeLayout(false);
            this.groupBoxStart_NVS.ResumeLayout(false);
            this.groupBoxStart_NVS.PerformLayout();
            this.groupBoxStop_NVS.ResumeLayout(false);
            this.groupBoxStop_NVS.PerformLayout();
            this.groupBoxOutPut_NVS.ResumeLayout(false);
            this.groupBoxResult_NVS.ResumeLayout(false);
            this.groupBoxResult_NVS.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxResult_NVS;
        private System.Windows.Forms.TextBox textBoxResult_NVS;
    }
}

