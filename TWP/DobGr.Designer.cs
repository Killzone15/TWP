namespace TWP
{
    partial class DobGr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DobGr));
            this.lbl_nameGr = new System.Windows.Forms.Label();
            this.lbl_Sem = new System.Windows.Forms.Label();
            this.Sem_comboBox = new System.Windows.Forms.ComboBox();
            this.NumGr_comboBox = new System.Windows.Forms.ComboBox();
            this.lbl_NumGr = new System.Windows.Forms.Label();
            this.lbl_ending = new System.Windows.Forms.Label();
            this.lbl_onset = new System.Windows.Forms.Label();
            this.btn_DobGr = new System.Windows.Forms.Button();
            this.btn_CloseDobGr = new System.Windows.Forms.Button();
            this.NameGr_textBox = new System.Windows.Forms.TextBox();
            this.onset_textBox = new System.Windows.Forms.TextBox();
            this.ending_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_nameGr
            // 
            this.lbl_nameGr.AutoSize = true;
            this.lbl_nameGr.Location = new System.Drawing.Point(18, 19);
            this.lbl_nameGr.Name = "lbl_nameGr";
            this.lbl_nameGr.Size = new System.Drawing.Size(125, 13);
            this.lbl_nameGr.TabIndex = 0;
            this.lbl_nameGr.Text = "Наименование группы:";
            // 
            // lbl_Sem
            // 
            this.lbl_Sem.AutoSize = true;
            this.lbl_Sem.Location = new System.Drawing.Point(18, 58);
            this.lbl_Sem.Name = "lbl_Sem";
            this.lbl_Sem.Size = new System.Drawing.Size(54, 13);
            this.lbl_Sem.TabIndex = 3;
            this.lbl_Sem.Text = "Семестр:";
            // 
            // Sem_comboBox
            // 
            this.Sem_comboBox.FormattingEnabled = true;
            this.Sem_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.Sem_comboBox.Location = new System.Drawing.Point(75, 55);
            this.Sem_comboBox.Name = "Sem_comboBox";
            this.Sem_comboBox.Size = new System.Drawing.Size(181, 21);
            this.Sem_comboBox.TabIndex = 4;
            // 
            // NumGr_comboBox
            // 
            this.NumGr_comboBox.FormattingEnabled = true;
            this.NumGr_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.NumGr_comboBox.Location = new System.Drawing.Point(375, 55);
            this.NumGr_comboBox.Name = "NumGr_comboBox";
            this.NumGr_comboBox.Size = new System.Drawing.Size(151, 21);
            this.NumGr_comboBox.TabIndex = 5;
            // 
            // lbl_NumGr
            // 
            this.lbl_NumGr.AutoSize = true;
            this.lbl_NumGr.Location = new System.Drawing.Point(273, 58);
            this.lbl_NumGr.Name = "lbl_NumGr";
            this.lbl_NumGr.Size = new System.Drawing.Size(83, 13);
            this.lbl_NumGr.TabIndex = 6;
            this.lbl_NumGr.Text = "Номер группы:";
            // 
            // lbl_ending
            // 
            this.lbl_ending.AutoSize = true;
            this.lbl_ending.Location = new System.Drawing.Point(273, 101);
            this.lbl_ending.Name = "lbl_ending";
            this.lbl_ending.Size = new System.Drawing.Size(96, 13);
            this.lbl_ending.TabIndex = 10;
            this.lbl_ending.Text = "конечная неделя:";
            // 
            // lbl_onset
            // 
            this.lbl_onset.AutoSize = true;
            this.lbl_onset.Location = new System.Drawing.Point(18, 101);
            this.lbl_onset.Name = "lbl_onset";
            this.lbl_onset.Size = new System.Drawing.Size(104, 13);
            this.lbl_onset.TabIndex = 7;
            this.lbl_onset.Text = "Начальная неделя:";
            // 
            // btn_DobGr
            // 
            this.btn_DobGr.Location = new System.Drawing.Point(42, 166);
            this.btn_DobGr.Name = "btn_DobGr";
            this.btn_DobGr.Size = new System.Drawing.Size(208, 84);
            this.btn_DobGr.TabIndex = 11;
            this.btn_DobGr.Text = "Добавить группу";
            this.btn_DobGr.UseVisualStyleBackColor = true;
            this.btn_DobGr.Click += new System.EventHandler(this.btn_DobGr_Click);
            // 
            // btn_CloseDobGr
            // 
            this.btn_CloseDobGr.Location = new System.Drawing.Point(294, 166);
            this.btn_CloseDobGr.Name = "btn_CloseDobGr";
            this.btn_CloseDobGr.Size = new System.Drawing.Size(208, 84);
            this.btn_CloseDobGr.TabIndex = 12;
            this.btn_CloseDobGr.Text = "Закрыть форму";
            this.btn_CloseDobGr.UseVisualStyleBackColor = true;
            this.btn_CloseDobGr.Click += new System.EventHandler(this.btn_CloseDobGr_Click);
            // 
            // NameGr_textBox
            // 
            this.NameGr_textBox.ForeColor = System.Drawing.Color.Black;
            this.NameGr_textBox.Location = new System.Drawing.Point(149, 16);
            this.NameGr_textBox.Name = "NameGr_textBox";
            this.NameGr_textBox.Size = new System.Drawing.Size(377, 20);
            this.NameGr_textBox.TabIndex = 13;
            this.NameGr_textBox.TextChanged += new System.EventHandler(this.NameGr_textBox_TextChanged);
            // 
            // onset_textBox
            // 
            this.onset_textBox.Location = new System.Drawing.Point(125, 98);
            this.onset_textBox.Name = "onset_textBox";
            this.onset_textBox.Size = new System.Drawing.Size(131, 20);
            this.onset_textBox.TabIndex = 14;
            // 
            // ending_textBox
            // 
            this.ending_textBox.Location = new System.Drawing.Point(375, 98);
            this.ending_textBox.Name = "ending_textBox";
            this.ending_textBox.Size = new System.Drawing.Size(151, 20);
            this.ending_textBox.TabIndex = 15;
            // 
            // DobGr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 265);
            this.Controls.Add(this.ending_textBox);
            this.Controls.Add(this.onset_textBox);
            this.Controls.Add(this.NameGr_textBox);
            this.Controls.Add(this.btn_CloseDobGr);
            this.Controls.Add(this.btn_DobGr);
            this.Controls.Add(this.lbl_ending);
            this.Controls.Add(this.lbl_onset);
            this.Controls.Add(this.lbl_NumGr);
            this.Controls.Add(this.NumGr_comboBox);
            this.Controls.Add(this.Sem_comboBox);
            this.Controls.Add(this.lbl_Sem);
            this.Controls.Add(this.lbl_nameGr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DobGr";
            this.Text = "Добавление группы";
            this.Load += new System.EventHandler(this.DobGr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nameGr;
        private System.Windows.Forms.Label lbl_Sem;
        private System.Windows.Forms.ComboBox Sem_comboBox;
        private System.Windows.Forms.ComboBox NumGr_comboBox;
        private System.Windows.Forms.Label lbl_NumGr;
        private System.Windows.Forms.Label lbl_ending;
        private System.Windows.Forms.Label lbl_onset;
        private System.Windows.Forms.Button btn_DobGr;
        private System.Windows.Forms.Button btn_CloseDobGr;
        private System.Windows.Forms.TextBox NameGr_textBox;
        private System.Windows.Forms.TextBox onset_textBox;
        private System.Windows.Forms.TextBox ending_textBox;
    }
}