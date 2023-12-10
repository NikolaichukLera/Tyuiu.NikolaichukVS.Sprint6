
namespace Tyuiu.NikolaichukVS.Sprint6.Task6.V22
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_NVS = new System.Windows.Forms.Label();
            this.buttonOK_NVS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo_NVS
            // 
            this.labelInfo_NVS.AutoSize = true;
            this.labelInfo_NVS.Location = new System.Drawing.Point(12, 20);
            this.labelInfo_NVS.Name = "labelInfo_NVS";
            this.labelInfo_NVS.Size = new System.Drawing.Size(374, 153);
            this.labelInfo_NVS.TabIndex = 1;
            this.labelInfo_NVS.Text = resources.GetString("labelInfo_NVS.Text");
            // 
            // buttonOK_NVS
            // 
            this.buttonOK_NVS.Location = new System.Drawing.Point(431, 234);
            this.buttonOK_NVS.Name = "buttonOK_NVS";
            this.buttonOK_NVS.Size = new System.Drawing.Size(146, 35);
            this.buttonOK_NVS.TabIndex = 2;
            this.buttonOK_NVS.Text = "OK";
            this.buttonOK_NVS.UseVisualStyleBackColor = true;
            this.buttonOK_NVS.Click += new System.EventHandler(this.buttonOK_NVS_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 291);
            this.Controls.Add(this.buttonOK_NVS);
            this.Controls.Add(this.labelInfo_NVS);
            this.Name = "FormAbout";
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_NVS;
        private System.Windows.Forms.Button buttonOK_NVS;
    }
}