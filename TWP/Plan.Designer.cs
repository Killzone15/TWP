namespace TWP
{
    partial class Plan
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plan));
            this.OtdelComboBox = new System.Windows.Forms.ComboBox();
            this.SemestrComboBox = new System.Windows.Forms.ComboBox();
            this.NumberGroupComboBox = new System.Windows.Forms.ComboBox();
            this.PrepComboBox = new System.Windows.Forms.ComboBox();
            this.DisciplineComboBox = new System.Windows.Forms.ComboBox();
            this.lbl_Otdel = new System.Windows.Forms.Label();
            this.lbl_Sem = new System.Windows.Forms.Label();
            this.lbl_NumGr = new System.Windows.Forms.Label();
            this.lbl_Prep = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_NameRasd = new System.Windows.Forms.Label();
            this.RazdeltextBox = new System.Windows.Forms.TextBox();
            this.Dob_Dis = new System.Windows.Forms.Button();
            this.Dob_Prep = new System.Windows.Forms.Button();
            this.Dob_Gr = new System.Windows.Forms.Button();
            this.Support = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.lbl_ZadObuj = new System.Windows.Forms.Label();
            this.ZadStud_textBox = new System.Windows.Forms.TextBox();
            this.lbl_VidZan = new System.Windows.Forms.Label();
            this.VidZanBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LevelAssimilationComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MaxVolumeHour_textBox = new System.Windows.Forms.TextBox();
            this.btn_DobPlan = new System.Windows.Forms.Button();
            this.btn_Redakt = new System.Windows.Forms.Button();
            this.lblOt = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.VolumeAuditHours_textBox = new System.Windows.Forms.TextBox();
            this.VolumeSelfHours_textBox = new System.Windows.Forms.TextBox();
            this.Dob_listBox = new System.Windows.Forms.ListBox();
            this.textBox_Ot = new System.Windows.Forms.TextBox();
            this.textBox_Do = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрСправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеWPCPLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbWorkProgramm = new System.Windows.Forms.RadioButton();
            this.rbCalendarPlan = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OtdelBox
            // 
            this.OtdelComboBox.DisplayMember = "1";
            this.OtdelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OtdelComboBox.FormattingEnabled = true;
            this.OtdelComboBox.Location = new System.Drawing.Point(26, 57);
            this.OtdelComboBox.Name = "OtdelBox";
            this.OtdelComboBox.Size = new System.Drawing.Size(121, 21);
            this.OtdelComboBox.TabIndex = 1;
            this.OtdelComboBox.DropDown += new System.EventHandler(this.OtdelComboBoxDropDown);
            this.OtdelComboBox.SelectedIndexChanged += new System.EventHandler(this.OtdelBox_SelectedIndexChanged);
            // 
            // Sem_comboBox
            // 
            this.SemestrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SemestrComboBox.Enabled = false;
            this.SemestrComboBox.FormattingEnabled = true;
            this.SemestrComboBox.Location = new System.Drawing.Point(194, 57);
            this.SemestrComboBox.Name = "Sem_comboBox";
            this.SemestrComboBox.Size = new System.Drawing.Size(78, 21);
            this.SemestrComboBox.TabIndex = 2;
            this.SemestrComboBox.DropDown += new System.EventHandler(this.SemestrComboBoxDropDown);
            this.SemestrComboBox.SelectedIndexChanged += new System.EventHandler(this.Sem_comboBox_SelectedIndexChanged);
            // 
            // NumGr_comboBox
            // 
            this.NumberGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumberGroupComboBox.Enabled = false;
            this.NumberGroupComboBox.FormattingEnabled = true;
            this.NumberGroupComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.NumberGroupComboBox.Location = new System.Drawing.Point(318, 57);
            this.NumberGroupComboBox.Name = "NumGr_comboBox";
            this.NumberGroupComboBox.Size = new System.Drawing.Size(121, 21);
            this.NumberGroupComboBox.TabIndex = 3;
            this.NumberGroupComboBox.DropDown += new System.EventHandler(this.NumberGroupComboBoxDropDown);
            this.NumberGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.NumGr_comboBox_SelectedIndexChanged);
            // 
            // Prep_comboBox
            // 
            this.PrepComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrepComboBox.Enabled = false;
            this.PrepComboBox.FormattingEnabled = true;
            this.PrepComboBox.Location = new System.Drawing.Point(485, 57);
            this.PrepComboBox.Name = "Prep_comboBox";
            this.PrepComboBox.Size = new System.Drawing.Size(167, 21);
            this.PrepComboBox.TabIndex = 4;
            this.PrepComboBox.DropDown += new System.EventHandler(this.PrepComboBoxDropDown);
            this.PrepComboBox.SelectedIndexChanged += new System.EventHandler(this.Prep_comboBox_SelectedIndexChanged);
            // 
            // Dis_comboBox
            // 
            this.DisciplineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DisciplineComboBox.Enabled = false;
            this.DisciplineComboBox.FormattingEnabled = true;
            this.DisciplineComboBox.Location = new System.Drawing.Point(685, 57);
            this.DisciplineComboBox.Name = "Dis_comboBox";
            this.DisciplineComboBox.Size = new System.Drawing.Size(211, 21);
            this.DisciplineComboBox.TabIndex = 5;
            this.DisciplineComboBox.DropDown += new System.EventHandler(this.DisciplineComboBoxDropDown);
            this.DisciplineComboBox.SelectedIndexChanged += new System.EventHandler(this.Dis_comboBox_SelectedIndexChanged);
            // 
            // lbl_Otdel
            // 
            this.lbl_Otdel.AutoSize = true;
            this.lbl_Otdel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Otdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_Otdel.Location = new System.Drawing.Point(23, 37);
            this.lbl_Otdel.Name = "lbl_Otdel";
            this.lbl_Otdel.Size = new System.Drawing.Size(82, 17);
            this.lbl_Otdel.TabIndex = 6;
            this.lbl_Otdel.Text = "Отделение";
            
            // 
            // lbl_Sem
            // 
            this.lbl_Sem.AutoSize = true;
            this.lbl_Sem.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_Sem.Location = new System.Drawing.Point(191, 37);
            this.lbl_Sem.Name = "lbl_Sem";
            this.lbl_Sem.Size = new System.Drawing.Size(64, 17);
            this.lbl_Sem.TabIndex = 7;
            this.lbl_Sem.Text = "Семестр";
            
            // 
            // lbl_NumGr
            // 
            this.lbl_NumGr.AutoSize = true;
            this.lbl_NumGr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NumGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_NumGr.Location = new System.Drawing.Point(315, 37);
            this.lbl_NumGr.Name = "lbl_NumGr";
            this.lbl_NumGr.Size = new System.Drawing.Size(101, 17);
            this.lbl_NumGr.TabIndex = 8;
            this.lbl_NumGr.Text = "Номер группы";
            
            // 
            // lbl_Prep
            // 
            this.lbl_Prep.AutoSize = true;
            this.lbl_Prep.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Prep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_Prep.Location = new System.Drawing.Point(482, 37);
            this.lbl_Prep.Name = "lbl_Prep";
            this.lbl_Prep.Size = new System.Drawing.Size(111, 17);
            this.lbl_Prep.TabIndex = 9;
            this.lbl_Prep.Text = "Преподаватель";
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(682, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дисциплина";
           
            // 
            // lbl_NameRasd
            // 
            this.lbl_NameRasd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NameRasd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_NameRasd.Location = new System.Drawing.Point(20, 161);
            this.lbl_NameRasd.Name = "lbl_NameRasd";
            this.lbl_NameRasd.Size = new System.Drawing.Size(227, 94);
            this.lbl_NameRasd.TabIndex = 11;
            this.lbl_NameRasd.Text = "Наименование разделов, тем, содержание учебного материала, лабораторные и контрол" +
    "ьные работы, практические занятия";
            this.lbl_NameRasd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RazdeltextBox
            // 
            this.RazdeltextBox.Location = new System.Drawing.Point(253, 137);
            this.RazdeltextBox.Multiline = true;
            this.RazdeltextBox.Name = "RazdeltextBox";
            this.RazdeltextBox.Size = new System.Drawing.Size(412, 118);
            this.RazdeltextBox.TabIndex = 12;
            // 
            // Dob_Dis
            // 
            this.Dob_Dis.Enabled = false;
            this.Dob_Dis.Location = new System.Drawing.Point(686, 137);
            this.Dob_Dis.Name = "Dob_Dis";
            this.Dob_Dis.Size = new System.Drawing.Size(210, 30);
            this.Dob_Dis.TabIndex = 13;
            this.Dob_Dis.Text = "Добавить дисциплину";
            this.Dob_Dis.UseVisualStyleBackColor = true;
            this.Dob_Dis.Click += new System.EventHandler(this.Dob_Dis_Click);
            // 
            // Dob_Prep
            // 
            this.Dob_Prep.Enabled = false;
            this.Dob_Prep.Location = new System.Drawing.Point(686, 182);
            this.Dob_Prep.Name = "Dob_Prep";
            this.Dob_Prep.Size = new System.Drawing.Size(210, 30);
            this.Dob_Prep.TabIndex = 14;
            this.Dob_Prep.Text = "Добавить преподавателя";
            this.Dob_Prep.UseVisualStyleBackColor = true;
            this.Dob_Prep.Click += new System.EventHandler(this.Dob_Prep_Click);
            // 
            // Dob_Gr
            // 
            this.Dob_Gr.Enabled = false;
            this.Dob_Gr.Location = new System.Drawing.Point(686, 234);
            this.Dob_Gr.Name = "Dob_Gr";
            this.Dob_Gr.Size = new System.Drawing.Size(210, 30);
            this.Dob_Gr.TabIndex = 15;
            this.Dob_Gr.Text = "Добавить группу";
            this.Dob_Gr.UseVisualStyleBackColor = true;
            this.Dob_Gr.Click += new System.EventHandler(this.Dob_Gr_Click);
            // 
            // Support
            // 
            this.Support.Location = new System.Drawing.Point(686, 286);
            this.Support.Name = "Support";
            this.Support.Size = new System.Drawing.Size(210, 30);
            this.Support.TabIndex = 16;
            this.Support.Text = "Справка";
            this.Support.UseVisualStyleBackColor = true;
            this.Support.Click += new System.EventHandler(this.Support_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(686, 334);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(210, 30);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.ExitClick);
            // 
            // lbl_ZadObuj
            // 
            this.lbl_ZadObuj.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ZadObuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_ZadObuj.Location = new System.Drawing.Point(27, 286);
            this.lbl_ZadObuj.Name = "lbl_ZadObuj";
            this.lbl_ZadObuj.Size = new System.Drawing.Size(168, 37);
            this.lbl_ZadObuj.TabIndex = 18;
            this.lbl_ZadObuj.Text = "Задания для обучающихся:";
            // 
            // ZadStud_textBox
            // 
            this.ZadStud_textBox.Enabled = false;
            this.ZadStud_textBox.Location = new System.Drawing.Point(130, 267);
            this.ZadStud_textBox.Multiline = true;
            this.ZadStud_textBox.Name = "ZadStud_textBox";
            this.ZadStud_textBox.Size = new System.Drawing.Size(535, 71);
            this.ZadStud_textBox.TabIndex = 19;
            // 
            // lbl_VidZan
            // 
            this.lbl_VidZan.AutoSize = true;
            this.lbl_VidZan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_VidZan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_VidZan.Location = new System.Drawing.Point(20, 137);
            this.lbl_VidZan.Name = "lbl_VidZan";
            this.lbl_VidZan.Size = new System.Drawing.Size(95, 17);
            this.lbl_VidZan.TabIndex = 20;
            this.lbl_VidZan.Text = "Вид занятия:";
            // 
            // VidZanBox
            // 
            this.VidZanBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VidZanBox.Enabled = false;
            this.VidZanBox.FormattingEnabled = true;
            this.VidZanBox.Items.AddRange(new object[] {
            "Лекция",
            "Урок",
            "Семинар",
            "Контрольная работа",
            "Урок-Лекция",
            "Самостоятельная работа",
            "Лабораторная работа",
            "Практическое занятие"});
            this.VidZanBox.Location = new System.Drawing.Point(119, 137);
            this.VidZanBox.Name = "VidZanBox";
            this.VidZanBox.Size = new System.Drawing.Size(121, 21);
            this.VidZanBox.TabIndex = 21;
            this.VidZanBox.DropDown += new System.EventHandler(this.VidZanBox_DropDown);
            this.VidZanBox.SelectedIndexChanged += new System.EventHandler(this.VidZanBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.Location = new System.Drawing.Point(28, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Уровень освоения:";
            // 
            // lvlassimilation_comboBox
            // 
            this.LevelAssimilationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LevelAssimilationComboBox.Enabled = false;
            this.LevelAssimilationComboBox.FormattingEnabled = true;
            this.LevelAssimilationComboBox.Items.AddRange(new object[] {
            "Ознакомительный",
            "Репродуктивны",
            "Продуктивный"});
            this.LevelAssimilationComboBox.Location = new System.Drawing.Point(167, 353);
            this.LevelAssimilationComboBox.Name = "lvlassimilation_comboBox";
            this.LevelAssimilationComboBox.Size = new System.Drawing.Size(121, 21);
            this.LevelAssimilationComboBox.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label11.Location = new System.Drawing.Point(28, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Объем аудит. часов:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.Location = new System.Drawing.Point(250, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Объем сам. часов:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.Location = new System.Drawing.Point(453, 387);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Макс. объем часов:";
            // 
            // MaxVolumeHour_textBox
            // 
            this.MaxVolumeHour_textBox.Enabled = false;
            this.MaxVolumeHour_textBox.Location = new System.Drawing.Point(596, 388);
            this.MaxVolumeHour_textBox.Multiline = true;
            this.MaxVolumeHour_textBox.Name = "MaxVolumeHour_textBox";
            this.MaxVolumeHour_textBox.Size = new System.Drawing.Size(63, 20);
            this.MaxVolumeHour_textBox.TabIndex = 29;
            this.MaxVolumeHour_textBox.TextChanged += new System.EventHandler(this.MaxVolumeHour_textBox_TextChanged);
            // 
            // btn_DobPlan
            // 
            this.btn_DobPlan.Enabled = false;
            this.btn_DobPlan.Location = new System.Drawing.Point(12, 420);
            this.btn_DobPlan.Name = "btn_DobPlan";
            this.btn_DobPlan.Size = new System.Drawing.Size(293, 76);
            this.btn_DobPlan.TabIndex = 30;
            this.btn_DobPlan.Text = "Добавить запись";
            this.btn_DobPlan.UseVisualStyleBackColor = true;
            this.btn_DobPlan.Click += new System.EventHandler(this.btn_DobPlan_Click);
            // 
            // btn_Redakt
            // 
            this.btn_Redakt.Enabled = false;
            this.btn_Redakt.Location = new System.Drawing.Point(624, 420);
            this.btn_Redakt.Name = "btn_Redakt";
            this.btn_Redakt.Size = new System.Drawing.Size(272, 76);
            this.btn_Redakt.TabIndex = 31;
            this.btn_Redakt.Text = "Редактировать рабочие программы";
            this.btn_Redakt.UseVisualStyleBackColor = true;
            this.btn_Redakt.Click += new System.EventHandler(this.btn_Redakt_Click);
            // 
            // lblOt
            // 
            this.lblOt.AutoSize = true;
            this.lblOt.BackColor = System.Drawing.Color.Transparent;
            this.lblOt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblOt.Location = new System.Drawing.Point(324, 357);
            this.lblOt.Name = "lblOt";
            this.lblOt.Size = new System.Drawing.Size(23, 17);
            this.lblOt.TabIndex = 32;
            this.lblOt.Text = "от";
            this.lblOt.Visible = false;
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.BackColor = System.Drawing.Color.Transparent;
            this.lblDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDo.Location = new System.Drawing.Point(426, 357);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(24, 17);
            this.lblDo.TabIndex = 34;
            this.lblDo.Text = "до";
            this.lblDo.Visible = false;
            // 
            // VolumeAuditHours_textBox
            // 
            this.VolumeAuditHours_textBox.Enabled = false;
            this.VolumeAuditHours_textBox.Location = new System.Drawing.Point(180, 388);
            this.VolumeAuditHours_textBox.MaxLength = 4;
            this.VolumeAuditHours_textBox.Name = "VolumeAuditHours_textBox";
            this.VolumeAuditHours_textBox.Size = new System.Drawing.Size(60, 20);
            this.VolumeAuditHours_textBox.TabIndex = 37;
            this.VolumeAuditHours_textBox.TextChanged += new System.EventHandler(this.VolumeAuditHours_textBox_TextChanged);
            this.VolumeAuditHours_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VolumeAuditHours_textBox_KeyPress);
            // 
            // VolumeSelfHours_textBox
            // 
            this.VolumeSelfHours_textBox.Enabled = false;
            this.VolumeSelfHours_textBox.Location = new System.Drawing.Point(387, 388);
            this.VolumeSelfHours_textBox.Name = "VolumeSelfHours_textBox";
            this.VolumeSelfHours_textBox.Size = new System.Drawing.Size(60, 20);
            this.VolumeSelfHours_textBox.TabIndex = 38;
            this.VolumeSelfHours_textBox.TextChanged += new System.EventHandler(this.VolumeSelfHours_textBox_TextChanged);
            this.VolumeSelfHours_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VolumeSelfHours_textBox_KeyPress);
            // 
            // Dob_listBox
            // 
            this.Dob_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Dob_listBox.FormattingEnabled = true;
            this.Dob_listBox.ItemHeight = 20;
            this.Dob_listBox.Items.AddRange(new object[] {
            "Добавить раздел",
            "Добавить тему",
            "Добавить содержание"});
            this.Dob_listBox.Location = new System.Drawing.Point(335, 420);
            this.Dob_listBox.Name = "Dob_listBox";
            this.Dob_listBox.Size = new System.Drawing.Size(255, 64);
            this.Dob_listBox.TabIndex = 39;
            this.Dob_listBox.SelectedIndexChanged += new System.EventHandler(this.Dob_listBox_SelectedIndexChanged);
            // 
            // textBox_Ot
            // 
            this.textBox_Ot.Enabled = false;
            this.textBox_Ot.Location = new System.Drawing.Point(353, 354);
            this.textBox_Ot.Name = "textBox_Ot";
            this.textBox_Ot.Size = new System.Drawing.Size(67, 20);
            this.textBox_Ot.TabIndex = 41;
            this.textBox_Ot.Visible = false;
            // 
            // textBox_Do
            // 
            this.textBox_Do.Enabled = false;
            this.textBox_Do.Location = new System.Drawing.Point(456, 354);
            this.textBox_Do.Name = "textBox_Do";
            this.textBox_Do.Size = new System.Drawing.Size(67, 20);
            this.textBox_Do.TabIndex = 42;
            this.textBox_Do.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GrayText;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 27);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.очиститьВсеToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // лToolStripMenuItem
            // 
            this.лToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.лToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.лToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("лToolStripMenuItem.Image")));
            this.лToolStripMenuItem.Name = "лToolStripMenuItem";
            this.лToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.лToolStripMenuItem.Text = "Логин";
            this.лToolStripMenuItem.Click += new System.EventHandler(this.лToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.очиститьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.очиститьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("очиститьToolStripMenuItem.Image")));
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // очиститьВсеToolStripMenuItem
            // 
            this.очиститьВсеToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.очиститьВсеToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.очиститьВсеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("очиститьВсеToolStripMenuItem.Image")));
            this.очиститьВсеToolStripMenuItem.Name = "очиститьВсеToolStripMenuItem";
            this.очиститьВсеToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.очиститьВсеToolStripMenuItem.Text = "Очистить все";
            this.очиститьВсеToolStripMenuItem.Click += new System.EventHandler(this.очиститьВсеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.выходToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.выходToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem1.Image")));
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(170, 24);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрСправкиToolStripMenuItem,
            this.оПрограммеWPCPLToolStripMenuItem});
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // просмотрСправкиToolStripMenuItem
            // 
            this.просмотрСправкиToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.просмотрСправкиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.просмотрСправкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("просмотрСправкиToolStripMenuItem.Image")));
            this.просмотрСправкиToolStripMenuItem.Name = "просмотрСправкиToolStripMenuItem";
            this.просмотрСправкиToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.просмотрСправкиToolStripMenuItem.Text = "Просмотр справки";
            this.просмотрСправкиToolStripMenuItem.Click += new System.EventHandler(this.просмотрСправкиToolStripMenuItem_Click);
            // 
            // оПрограммеWPCPLToolStripMenuItem
            // 
            this.оПрограммеWPCPLToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.оПрограммеWPCPLToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.оПрограммеWPCPLToolStripMenuItem.Name = "оПрограммеWPCPLToolStripMenuItem";
            this.оПрограммеWPCPLToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.оПрограммеWPCPLToolStripMenuItem.Text = "О программе WPandCPL";
            this.оПрограммеWPCPLToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеWPCPLToolStripMenuItem_Click);
            // 
            // rbWorkProgramm
            // 
            this.rbWorkProgramm.AutoSize = true;
            this.rbWorkProgramm.BackColor = System.Drawing.SystemColors.GrayText;
            this.rbWorkProgramm.Checked = true;
            this.rbWorkProgramm.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.rbWorkProgramm.ForeColor = System.Drawing.Color.Coral;
            this.rbWorkProgramm.Location = new System.Drawing.Point(151, 1);
            this.rbWorkProgramm.Name = "rbWorkProgramm";
            this.rbWorkProgramm.Size = new System.Drawing.Size(158, 23);
            this.rbWorkProgramm.TabIndex = 45;
            this.rbWorkProgramm.TabStop = true;
            this.rbWorkProgramm.Text = "Рабочая программа";
            this.rbWorkProgramm.UseVisualStyleBackColor = false;
            this.rbWorkProgramm.Visible = false;
            // 
            // rbCalendarPlan
            // 
            this.rbCalendarPlan.AutoSize = true;
            this.rbCalendarPlan.BackColor = System.Drawing.SystemColors.GrayText;
            this.rbCalendarPlan.Enabled = false;
            this.rbCalendarPlan.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.rbCalendarPlan.ForeColor = System.Drawing.Color.Coral;
            this.rbCalendarPlan.Location = new System.Drawing.Point(315, 1);
            this.rbCalendarPlan.Name = "rbCalendarPlan";
            this.rbCalendarPlan.Size = new System.Drawing.Size(158, 23);
            this.rbCalendarPlan.TabIndex = 47;
            this.rbCalendarPlan.Text = "Календарный план";
            this.rbCalendarPlan.UseVisualStyleBackColor = false;
            this.rbCalendarPlan.Visible = false;
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(916, 514);
            this.Controls.Add(this.rbCalendarPlan);
            this.Controls.Add(this.rbWorkProgramm);
            this.Controls.Add(this.textBox_Do);
            this.Controls.Add(this.textBox_Ot);
            this.Controls.Add(this.Dob_listBox);
            this.Controls.Add(this.VolumeSelfHours_textBox);
            this.Controls.Add(this.VolumeAuditHours_textBox);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.lblOt);
            this.Controls.Add(this.btn_Redakt);
            this.Controls.Add(this.btn_DobPlan);
            this.Controls.Add(this.MaxVolumeHour_textBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LevelAssimilationComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.VidZanBox);
            this.Controls.Add(this.lbl_VidZan);
            this.Controls.Add(this.ZadStud_textBox);
            this.Controls.Add(this.lbl_ZadObuj);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Support);
            this.Controls.Add(this.Dob_Gr);
            this.Controls.Add(this.Dob_Prep);
            this.Controls.Add(this.Dob_Dis);
            this.Controls.Add(this.RazdeltextBox);
            this.Controls.Add(this.lbl_NameRasd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Prep);
            this.Controls.Add(this.lbl_NumGr);
            this.Controls.Add(this.lbl_Sem);
            this.Controls.Add(this.lbl_Otdel);
            this.Controls.Add(this.DisciplineComboBox);
            this.Controls.Add(this.PrepComboBox);
            this.Controls.Add(this.NumberGroupComboBox);
            this.Controls.Add(this.SemestrComboBox);
            this.Controls.Add(this.OtdelComboBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Plan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рабочие программы преподавателей";
            this.Load += new System.EventHandler(this.Plan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Otdel;
        private System.Windows.Forms.Label lbl_Sem;
        private System.Windows.Forms.Label lbl_NumGr;
        private System.Windows.Forms.Label lbl_Prep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_NameRasd;
        private System.Windows.Forms.TextBox RazdeltextBox;
        private System.Windows.Forms.Button Support;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label lbl_ZadObuj;
        private System.Windows.Forms.TextBox ZadStud_textBox;
        private System.Windows.Forms.Label lbl_VidZan;
        private System.Windows.Forms.ComboBox VidZanBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox LevelAssimilationComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MaxVolumeHour_textBox;
        private System.Windows.Forms.Button btn_DobPlan;
        private System.Windows.Forms.Button btn_Redakt;
        private System.Windows.Forms.Label lblOt;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.TextBox VolumeAuditHours_textBox;
        private System.Windows.Forms.TextBox VolumeSelfHours_textBox;
        private System.Windows.Forms.ListBox Dob_listBox;
        public System.Windows.Forms.ComboBox OtdelComboBox;
        public System.Windows.Forms.ComboBox SemestrComboBox;
        public System.Windows.Forms.ComboBox NumberGroupComboBox;
        public System.Windows.Forms.ComboBox DisciplineComboBox;
        public System.Windows.Forms.ComboBox PrepComboBox;
        private System.Windows.Forms.TextBox textBox_Ot;
        private System.Windows.Forms.TextBox textBox_Do;
        public System.Windows.Forms.Button Dob_Dis;
        public System.Windows.Forms.Button Dob_Prep;
        public System.Windows.Forms.Button Dob_Gr;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрСправкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеWPCPLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        public System.Windows.Forms.RadioButton rbWorkProgramm;
        public System.Windows.Forms.RadioButton rbCalendarPlan;
    }
}

