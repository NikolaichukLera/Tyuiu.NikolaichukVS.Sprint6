
namespace Tyuiu.NikolaichukVS.Sprint6.Task0.V11
{
    partial class FormMainTask_NVS
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
            this.groupBoxTask_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxCondition_NVS = new System.Windows.Forms.GroupBox();
            this.groupBowInPut_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxVarX_NVS = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_NVS = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_NVS = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_NVS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_NVS = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDone_NVS = new System.Windows.Forms.Button();
            this.buttonPushMe_NVS = new System.Windows.Forms.Button();
            this.groupBoxTask_NVS.SuspendLayout();
            this.groupBowInPut_NVS.SuspendLayout();
            this.groupBoxVarX_NVS.SuspendLayout();
            this.groupBoxOutPut_NVS.SuspendLayout();
            this.groupBoxResult_NVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_NVS
            // 
            this.groupBoxTask_NVS.Controls.Add(this.groupBoxCondition_NVS);
            this.groupBoxTask_NVS.Location = new System.Drawing.Point(26, 24);
            this.groupBoxTask_NVS.Name = "groupBoxTask_NVS";
            this.groupBoxTask_NVS.Size = new System.Drawing.Size(426, 149);
            this.groupBoxTask_NVS.TabIndex = 0;
            this.groupBoxTask_NVS.TabStop = false;
            this.groupBoxTask_NVS.Text = "Условие";
            // 
            // groupBoxCondition_NVS
            // 
            this.groupBoxCondition_NVS.Location = new System.Drawing.Point(0, 41);
            this.groupBoxCondition_NVS.Name = "groupBoxCondition_NVS";
            this.groupBoxCondition_NVS.Size = new System.Drawing.Size(420, 100);
            this.groupBoxCondition_NVS.TabIndex = 0;
            this.groupBoxCondition_NVS.TabStop = false;
            this.groupBoxCondition_NVS.Text = "Дано выражение, вычислить его значение при x = 2, результат вывести в TextBox. Ок" +
    "руглить до трёх знаков после запятой.";
            // 
            // groupBowInPut_NVS
            // 
            this.groupBowInPut_NVS.Controls.Add(this.groupBoxVarX_NVS);
            this.groupBowInPut_NVS.Controls.Add(this.groupBoxOutPut_NVS);
            this.groupBowInPut_NVS.Location = new System.Drawing.Point(26, 226);
            this.groupBowInPut_NVS.Name = "groupBowInPut_NVS";
            this.groupBowInPut_NVS.Size = new System.Drawing.Size(426, 198);
            this.groupBowInPut_NVS.TabIndex = 1;
            this.groupBowInPut_NVS.TabStop = false;
            this.groupBowInPut_NVS.Text = "Ввод данных";
            // 
            // groupBoxVarX_NVS
            // 
            this.groupBoxVarX_NVS.Controls.Add(this.textBoxVarX_NVS);
            this.groupBoxVarX_NVS.Location = new System.Drawing.Point(0, 54);
            this.groupBoxVarX_NVS.Name = "groupBoxVarX_NVS";
            this.groupBoxVarX_NVS.Size = new System.Drawing.Size(209, 100);
            this.groupBoxVarX_NVS.TabIndex = 1;
            this.groupBoxVarX_NVS.TabStop = false;
            this.groupBoxVarX_NVS.Text = "Переменная X:";
            // 
            // textBoxVarX_NVS
            // 
            this.textBoxVarX_NVS.Location = new System.Drawing.Point(6, 31);
            this.textBoxVarX_NVS.Name = "textBoxVarX_NVS";
            this.textBoxVarX_NVS.Size = new System.Drawing.Size(145, 22);
            this.textBoxVarX_NVS.TabIndex = 0;
            //this.textBoxVarX_NVS.TextChanged += new System.EventHandler(this.textBoxVarX_NVS_TextChanged);
            this.textBoxVarX_NVS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_NVS_KeyPress);
            // 
            // groupBoxOutPut_NVS
            // 
            this.groupBoxOutPut_NVS.Controls.Add(this.groupBoxResult_NVS);
            this.groupBoxOutPut_NVS.Location = new System.Drawing.Point(215, 0);
            this.groupBoxOutPut_NVS.Name = "groupBoxOutPut_NVS";
            this.groupBoxOutPut_NVS.Size = new System.Drawing.Size(200, 192);
            this.groupBoxOutPut_NVS.TabIndex = 0;
            this.groupBoxOutPut_NVS.TabStop = false;
            this.groupBoxOutPut_NVS.Text = "Вывод данных";
            // 
            // groupBoxResult_NVS
            // 
            this.groupBoxResult_NVS.Controls.Add(this.textBoxResult_NVS);
            this.groupBoxResult_NVS.Location = new System.Drawing.Point(7, 54);
            this.groupBoxResult_NVS.Name = "groupBoxResult_NVS";
            this.groupBoxResult_NVS.Size = new System.Drawing.Size(200, 100);
            this.groupBoxResult_NVS.TabIndex = 0;
            this.groupBoxResult_NVS.TabStop = false;
            this.groupBoxResult_NVS.Text = "Результат:";
            // 
            // textBoxResult_NVS
            // 
            this.textBoxResult_NVS.Location = new System.Drawing.Point(0, 31);
            this.textBoxResult_NVS.Name = "textBoxResult_NVS";
            this.textBoxResult_NVS.Size = new System.Drawing.Size(155, 22);
            this.textBoxResult_NVS.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.NikolaichukVS.Sprint6.Task0.V11.Properties.Resources.IMG_20231201_213211_341;
            this.pictureBox1.Location = new System.Drawing.Point(512, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 57);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDone_NVS
            // 
            this.buttonDone_NVS.Location = new System.Drawing.Point(607, 376);
            this.buttonDone_NVS.Name = "buttonDone_NVS";
            this.buttonDone_NVS.Size = new System.Drawing.Size(181, 48);
            this.buttonDone_NVS.TabIndex = 3;
            this.buttonDone_NVS.Text = "Выполнить";
            this.buttonDone_NVS.UseVisualStyleBackColor = true;
            this.buttonDone_NVS.Click += new System.EventHandler(this.buttonDone_NVS_Click);
            // 
            // buttonPushMe_NVS
            // 
            this.buttonPushMe_NVS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPushMe_NVS.Location = new System.Drawing.Point(537, 376);
            this.buttonPushMe_NVS.Name = "buttonPushMe_NVS";
            this.buttonPushMe_NVS.Size = new System.Drawing.Size(52, 48);
            this.buttonPushMe_NVS.TabIndex = 4;
            this.buttonPushMe_NVS.Text = "?";
            this.buttonPushMe_NVS.UseVisualStyleBackColor = true;
            this.buttonPushMe_NVS.Click += new System.EventHandler(this.buttonPushMe_NVS_Click);
            // 
            // FormMainTask_NVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPushMe_NVS);
            this.Controls.Add(this.buttonDone_NVS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBowInPut_NVS);
            this.Controls.Add(this.groupBoxTask_NVS);
            this.Name = "FormMainTask_NVS";
            this.Text = "Спринт 6 | Таск 0 | Вариант 11 | Николайчук В.С.";
            this.groupBoxTask_NVS.ResumeLayout(false);
            this.groupBowInPut_NVS.ResumeLayout(false);
            this.groupBoxVarX_NVS.ResumeLayout(false);
            this.groupBoxVarX_NVS.PerformLayout();
            this.groupBoxOutPut_NVS.ResumeLayout(false);
            this.groupBoxResult_NVS.ResumeLayout(false);
            this.groupBoxResult_NVS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_NVS;
        private System.Windows.Forms.GroupBox groupBoxCondition_NVS;
        private System.Windows.Forms.GroupBox groupBowInPut_NVS;
        private System.Windows.Forms.GroupBox groupBoxVarX_NVS;
        private System.Windows.Forms.TextBox textBoxVarX_NVS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_NVS;
        private System.Windows.Forms.GroupBox groupBoxResult_NVS;
        private System.Windows.Forms.TextBox textBoxResult_NVS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDone_NVS;
        private System.Windows.Forms.Button buttonPushMe_NVS;
    }
}

