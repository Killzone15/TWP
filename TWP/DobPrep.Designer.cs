namespace WPandCPL
{
    partial class DobPrep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DobPrep));
            this.btn_DobPrep = new System.Windows.Forms.Button();
            this.btn_ExitDobPrep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FIOPrep_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_DobPrep
            // 
            this.btn_DobPrep.Location = new System.Drawing.Point(22, 174);
            this.btn_DobPrep.Name = "btn_DobPrep";
            this.btn_DobPrep.Size = new System.Drawing.Size(212, 78);
            this.btn_DobPrep.TabIndex = 0;
            this.btn_DobPrep.Text = "Добавить преподавателя";
            this.btn_DobPrep.UseVisualStyleBackColor = true;
            this.btn_DobPrep.Click += new System.EventHandler(this.btn_DobPrep_Click);
            // 
            // btn_ExitDobPrep
            // 
            this.btn_ExitDobPrep.Location = new System.Drawing.Point(257, 174);
            this.btn_ExitDobPrep.Name = "btn_ExitDobPrep";
            this.btn_ExitDobPrep.Size = new System.Drawing.Size(212, 78);
            this.btn_ExitDobPrep.TabIndex = 1;
            this.btn_ExitDobPrep.Text = "Закрыть форму";
            this.btn_ExitDobPrep.UseVisualStyleBackColor = true;
            this.btn_ExitDobPrep.Click += new System.EventHandler(this.btn_ExitDobPrep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО преподавателя";
            // 
            // FIOPrep_textBox
            // 
            this.FIOPrep_textBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.FIOPrep_textBox.Location = new System.Drawing.Point(216, 34);
            this.FIOPrep_textBox.Name = "FIOPrep_textBox";
            this.FIOPrep_textBox.Size = new System.Drawing.Size(253, 22);
            this.FIOPrep_textBox.TabIndex = 3;
            this.FIOPrep_textBox.TextChanged += new System.EventHandler(this.FIOPrep_textBox_TextChanged);
            // 
            // DobPrep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 265);
            this.Controls.Add(this.FIOPrep_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ExitDobPrep);
            this.Controls.Add(this.btn_DobPrep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DobPrep";
            this.Text = "Добавление преподавателя";
            this.Load += new System.EventHandler(this.DobPrep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DobPrep;
        private System.Windows.Forms.Button btn_ExitDobPrep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FIOPrep_textBox;
    }
}