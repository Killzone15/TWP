namespace TWP
{
    partial class Support
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Support));
            this.btn_DobPrepSup = new System.Windows.Forms.Button();
            this.btn_DobGrSup = new System.Windows.Forms.Button();
            this.btn_DopDisSup = new System.Windows.Forms.Button();
            this.btn_ExitProgSup = new System.Windows.Forms.Button();
            this.btn_DobRedSup = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_ExitSupport = new System.Windows.Forms.Button();
            this.lbl_textSup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_DobPrepSup
            // 
            this.btn_DobPrepSup.Location = new System.Drawing.Point(12, 12);
            this.btn_DobPrepSup.Name = "btn_DobPrepSup";
            this.btn_DobPrepSup.Size = new System.Drawing.Size(265, 37);
            this.btn_DobPrepSup.TabIndex = 0;
            this.btn_DobPrepSup.Text = "Добавление преподавателей";
            this.btn_DobPrepSup.UseVisualStyleBackColor = true;
            this.btn_DobPrepSup.Click += new System.EventHandler(this.btn_DobPrepSup_Click);
            // 
            // btn_DobGrSup
            // 
            this.btn_DobGrSup.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btn_DobGrSup.Location = new System.Drawing.Point(312, 12);
            this.btn_DobGrSup.Name = "btn_DobGrSup";
            this.btn_DobGrSup.Size = new System.Drawing.Size(265, 37);
            this.btn_DobGrSup.TabIndex = 1;
            this.btn_DobGrSup.Text = "Добавление групп";
            this.btn_DobGrSup.UseVisualStyleBackColor = true;
            this.btn_DobGrSup.Click += new System.EventHandler(this.btn_DobGrSup_Click);
            // 
            // btn_DopDisSup
            // 
            this.btn_DopDisSup.Location = new System.Drawing.Point(12, 55);
            this.btn_DopDisSup.Name = "btn_DopDisSup";
            this.btn_DopDisSup.Size = new System.Drawing.Size(265, 37);
            this.btn_DopDisSup.TabIndex = 2;
            this.btn_DopDisSup.Text = "Добавление дисциплин";
            this.btn_DopDisSup.UseVisualStyleBackColor = true;
            this.btn_DopDisSup.Click += new System.EventHandler(this.btn_DopDisSup_Click);
            // 
            // btn_ExitProgSup
            // 
            this.btn_ExitProgSup.Location = new System.Drawing.Point(312, 55);
            this.btn_ExitProgSup.Name = "btn_ExitProgSup";
            this.btn_ExitProgSup.Size = new System.Drawing.Size(265, 37);
            this.btn_ExitProgSup.TabIndex = 3;
            this.btn_ExitProgSup.Text = "Выход из программы";
            this.btn_ExitProgSup.UseVisualStyleBackColor = true;
            this.btn_ExitProgSup.Click += new System.EventHandler(this.btn_ExitProgSup_Click);
            // 
            // btn_DobRedSup
            // 
            this.btn_DobRedSup.Location = new System.Drawing.Point(12, 98);
            this.btn_DobRedSup.Name = "btn_DobRedSup";
            this.btn_DobRedSup.Size = new System.Drawing.Size(265, 78);
            this.btn_DobRedSup.TabIndex = 4;
            this.btn_DobRedSup.Text = "Добавление  и редактирование рабочих программ и календарных планов преподавателей" +
                "";
            this.btn_DobRedSup.UseVisualStyleBackColor = true;
            this.btn_DobRedSup.Click += new System.EventHandler(this.btn_DobRedSup_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(312, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(265, 78);
            this.button6.TabIndex = 5;
            this.button6.Text = "Подготовка к печати формирование отчёта рабочих программ  и календарных планов пр" +
                "еподавателей";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_ExitSupport
            // 
            this.btn_ExitSupport.Location = new System.Drawing.Point(205, 341);
            this.btn_ExitSupport.Name = "btn_ExitSupport";
            this.btn_ExitSupport.Size = new System.Drawing.Size(184, 37);
            this.btn_ExitSupport.TabIndex = 6;
            this.btn_ExitSupport.Text = "Закрыть форму";
            this.btn_ExitSupport.UseVisualStyleBackColor = true;
            this.btn_ExitSupport.Click += new System.EventHandler(this.btn_ExitSupport_Click);
            // 
            // lbl_textSup
            // 
            this.lbl_textSup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_textSup.Location = new System.Drawing.Point(12, 190);
            this.lbl_textSup.Name = "lbl_textSup";
            this.lbl_textSup.Size = new System.Drawing.Size(565, 140);
            this.lbl_textSup.TabIndex = 7;
            // 
            // Support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 390);
            this.Controls.Add(this.lbl_textSup);
            this.Controls.Add(this.btn_ExitSupport);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_DobRedSup);
            this.Controls.Add(this.btn_ExitProgSup);
            this.Controls.Add(this.btn_DopDisSup);
            this.Controls.Add(this.btn_DobGrSup);
            this.Controls.Add(this.btn_DobPrepSup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Support";
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.Support_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DobPrepSup;
        private System.Windows.Forms.Button btn_DobGrSup;
        private System.Windows.Forms.Button btn_DopDisSup;
        private System.Windows.Forms.Button btn_ExitProgSup;
        private System.Windows.Forms.Button btn_DobRedSup;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_ExitSupport;
        private System.Windows.Forms.Label lbl_textSup;
    }
}