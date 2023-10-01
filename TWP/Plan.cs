using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace WPandCPL
{
    public partial class Plan : Form
    {

        public Plan()
        {
            InitializeComponent();
        }

        private void Plan_Load(object sender, EventArgs e)
        {
            LoginForm newForm = new LoginForm();
            newForm.Owner = this;
            newForm.ShowDialog();
        }
        
        private void Dob_Dis_Click(object sender, EventArgs e)
        {
            DobDis newForm = new DobDis();
            newForm.Show(); 
        }
             
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dob_Prep_Click(object sender, EventArgs e)//Кнопка добавить преподавателя
        {

            DobPrep newForm = new DobPrep(this);//Создаем новый объект класса формы
            newForm.Show();//Открываем форму DobPrep
        }

        private void Dob_Gr_Click(object sender, EventArgs e)//Кнопка добавить дисциплину
        {
            DobGr newMDIChild = new DobGr();
            newMDIChild.Show();
        }

        private void Support_Click(object sender, EventArgs e)//Кнопка справка 
        {
            Support newForm = new Support(this);
            newForm.Show();
        }

        public void Connection()
        {
            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "123";//Пароль пользователя MySQL
            mysqlCSB.CharacterSet = "cp866";//Используем кодировку для киррилицы cp866

            MySqlConnection con = new MySqlConnection();//Создаем объект для подключения к СУБД MySQL
            con.ConnectionString = mysqlCSB.ConnectionString;//присваиваем значение строк объекта mysqlCSB к объекты для подключения con

            try
            {
                con.Open();//Подключаемся к базе данных
            }
            catch (Exception)
            {
                // если произошли ошибки покажем их
                MessageBox.Show("Ошибка подключения к БД");
                return;
            }
            return;
        }
        private void OtdelBox_DropDown(object sender, EventArgs e)
        {
            Dob_listBox.SelectedItem = null;
            Sem_comboBox.SelectedItem = null;
            OtdelBox.SelectedItem = null;
            NumGr_comboBox.SelectedItem = null;
            Prep_comboBox.SelectedItem = null;
            Dis_comboBox.SelectedItem = null;
 
            Sem_comboBox.Enabled = false;
            NumGr_comboBox.Enabled = false;
            Prep_comboBox.Enabled = false;
            Dis_comboBox.Enabled = false;

            btn_DobPlan.Enabled = false;
            lvlassimilation_comboBox.Enabled = false;
            ZadStud_textBox.Enabled = false;
            VidZanBox.Enabled = false;
            VolumeAuditHours_textBox.Enabled = false;
            VolumeSelfHours_textBox.Enabled = false;
           

            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "123";//Пароль пользователя MySQL
            mysqlCSB.CharacterSet = "cp866";//Используем кодировку для киррилицы cp866

            MySqlConnection con = new MySqlConnection();//Создаем объект для подключения к СУБД MySQL
            con.ConnectionString = mysqlCSB.ConnectionString;//присваиваем значение строк объекта mysqlCSB к объекты для подключения con

            try
            {
                con.Open();//Подключаемся к базе данных

            }
            catch (Exception ee)
            {
                // если произошли ошибки покажем
                MessageBox.Show(ee.ToString(), "Ошибка подключения к БД");
                return;
            }
            string sql = "SET names cp866";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.ExecuteNonQuery();
            MySqlDataReader reader;

            cmd.ExecuteNonQuery();
            cmd.CommandText = "select distinct department from groups";
            reader = cmd.ExecuteReader();
            string a;           
            OtdelBox.Items.Clear();
            while (reader.Read())
            {
                a = reader["department"].ToString();
                OtdelBox.Items.Add(a);
            }
            con.Close();//Закрывает подключение с БД MySQL
        }

        private void Prep_comboBox_DropDown_1(object sender, EventArgs e)
        {
            Dob_listBox.SelectedItem = null;
            Dis_comboBox.SelectedItem = null;
            Prep_comboBox.SelectedItem = null;

            btn_DobPlan.Enabled = false;
            lvlassimilation_comboBox.Enabled = false;
            ZadStud_textBox.Enabled = false;
            VidZanBox.Enabled = false;
            VolumeAuditHours_textBox.Enabled = false;
            VolumeSelfHours_textBox.Enabled = false;
            Dob_listBox.SelectedItem = null;

            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "123";//Пароль пользователя MySQL
            mysqlCSB.CharacterSet = "cp866";//Используем кодировку для киррилицы cp866

            MySqlConnection con = new MySqlConnection();//Создаем объект для подключения к СУБД MySQL
            con.ConnectionString = mysqlCSB.ConnectionString;//присваиваем значение строк объекта mysqlCSB к объекты для подключения con

            try
            {
                con.Open();//Подключаемся к базе данных

            }
            catch (Exception ee)
            {
                // если произошли ошибки покажем их
                MessageBox.Show(ee.ToString(), "Ошибка подключения к БД");
                return;
            }
            
           
            string queryString = "SELECT Id_Gr from groups where department='" + OtdelBox.Text + "' and half_year=" + Sem_comboBox.Text + " and Num_Gr=" + NumGr_comboBox.Text + "";
            MySqlCommand cmd = new MySqlCommand(queryString, con);
            
            string ID_Gr = "";
            //Получаем ID_Gr
            ID_Gr += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT DISTINCT FIO_lecturer FROM lecturer,discipline WHERE discipline.Id_Prep=lecturer.Id_Prep and ID_Gr="+Convert.ToInt32(ID_Gr)+"";
            MySqlDataReader reader = cmd.ExecuteReader();
            string a;
            Prep_comboBox.Items.Clear();
            while (reader.Read())
            {
                a = reader["FIO_lecturer"].ToString();
                Prep_comboBox.Items.Add(a);
            }
            con.Close();//Закрывает подключение с БД MySQL
        }

        private void Dis_comboBox_DropDown(object sender, EventArgs e)
        {
            Dob_listBox.SelectedItem = null;
            RazdeltextBox.Text = "";
            ZadStud_textBox.Text = "";
            ZadStud_textBox.Enabled = false;
            btn_Redakt.Enabled = false;
            VidZanBox.Text = "";
            
            VidZanBox.Enabled = false;
            lvlassimilation_comboBox.Text = "";
            lvlassimilation_comboBox.Enabled = false;
            VolumeAuditHours_textBox.Text = "";
            VolumeAuditHours_textBox.Enabled = false;
            VolumeSelfHours_textBox.Text = "";
            VolumeSelfHours_textBox.Enabled = false;

            btn_DobPlan.Enabled = false;
            lvlassimilation_comboBox.Enabled = false;
            ZadStud_textBox.Enabled = false;
            VidZanBox.Enabled = false;
            VolumeAuditHours_textBox.Enabled = false;
            VolumeSelfHours_textBox.Enabled = false;
            

            Dis_comboBox.Text = "";
            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "123";//Пароль пользователя MySQL
            mysqlCSB.CharacterSet = "cp866";//Используем кодировку для киррилицы cp866

            MySqlConnection con = new MySqlConnection();//Создаем объект для подключения к СУБД MySQL
            con.ConnectionString = mysqlCSB.ConnectionString;//присваиваем значение строк объекта mysqlCSB к объекты для подключения con

            try
            {
                con.Open();//Подключаемся к базе данных

            }
            catch (Exception ee)
            {
                // если произошли ошибки покажем их
                MessageBox.Show(ee.ToString(), "Ошибка подключения к БД");
                return;
            }
            string sql = "SET names cp866";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            string ID_Prep, ID_Gr;
            ID_Prep = "";
            ID_Gr = "";
            cmd.CommandText = "SELECT ID_Prep FROM lecturer WHERE FIO_Lecturer='" + Prep_comboBox.Text + "'";
            ID_Prep += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT ID_Gr FROM groups WHERE department='"+OtdelBox.Text+"' and half_year="+Sem_comboBox.Text+" and Num_Gr="+NumGr_comboBox.Text+"";
            ID_Gr += cmd.ExecuteScalar();
            MySqlDataReader reader;

            
            cmd.CommandText = "select discipline from discipline where ID_Prep="+ID_Prep+" and "+"ID_Gr="+ID_Gr+"";
            reader = cmd.ExecuteReader();
            string a;
            Dis_comboBox.Items.Clear();
            while (reader.Read())
            {
                a = reader["discipline"].ToString();
                Dis_comboBox.Items.Add(a);
            }
            con.Close();//Закрывает подключение с БД MySQL
        }

        private void OtdelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(OtdelBox.Text)) { Sem_comboBox.Enabled = false; }
            else { Sem_comboBox.Enabled = true; } 
        }

        private void Sem_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (String.IsNullOrWhiteSpace(Sem_comboBox.Text)) { NumGr_comboBox.Enabled = false; }
            else { NumGr_comboBox.Enabled = true; }
        }
        public string Otdel
        {
            get{return OtdelBox.Text;}
            set{OtdelBox.Text = value;}

        }
        //Свойство "семест" для получения значения из Sem_comboBox
        public string Sem
        {
            get{return Sem_comboBox.Text;}
            set{Sem_comboBox.Text = value;}
        }
        //Свойство "номер группы" для получения значения из NumGr_comboBox
        public String NumGr
        {
            get{return NumGr_comboBox.Text;}
            set{NumGr_comboBox.Text = value; }
        }
        //Свойство "преподаватель" для получения значения из Prep_comboBox
        public String Prep
        {
            get
            {
                return Prep_comboBox.Text;
            }
            set
            {
                Prep_comboBox.Text = value;
            }
        }
        //Свойство "семест" для получения значения из Sem_comboBox
        public String Disc
        {
            get
            {
                return Dis_comboBox.Text;
            }
            set
            {
                Dis_comboBox.Text = value;
            }
        }
       
        private void Sem_comboBox_DropDown(object sender, EventArgs e)
        {
            Dob_listBox.SelectedItem = null;
            NumGr_comboBox.Enabled = false;
            Prep_comboBox.Enabled = false;
            Dis_comboBox.Enabled = false;

            Sem_comboBox.SelectedItem = null;
            NumGr_comboBox.SelectedItem = null;
            Prep_comboBox.SelectedItem = null;
            Dis_comboBox.SelectedItem = null;

            btn_DobPlan.Enabled = false;
            lvlassimilation_comboBox.Enabled = false;
            ZadStud_textBox.Enabled = false;
            VidZanBox.Enabled = false;
            VolumeAuditHours_textBox.Enabled = false;
            VolumeSelfHours_textBox.Enabled = false;
            Dob_listBox.SelectedItem = null;

            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "123";//Пароль пользователя MySQL
            mysqlCSB.CharacterSet = "cp866";//Используем кодировку для киррилицы cp866
            
            MySqlConnection con = new MySqlConnection();//Создаем объект для подключения к СУБД MySQL
            con.ConnectionString = mysqlCSB.ConnectionString;//присваиваем значение строк объекта mysqlCSB к объекты для подключения con

            try
            {
                con.Open();//Подключаемся к базе данных

            }
            catch (Exception ee)
            {
                // если произошли ошибки покажем их
                MessageBox.Show(ee.ToString(), "Ошибка подключения к БД");
                return;
            }
            string sql = "SET names cp866";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.ExecuteNonQuery();
            MySqlDataReader reader;

            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT DISTINCT half_year FROM groups WHERE department='"+OtdelBox.Text+"' ORDER BY half_year";
            reader = cmd.ExecuteReader();
            string a;
            a = "";
            Sem_comboBox.Items.Clear();
            while (reader.Read())
            {
                a = reader["half_year"].ToString();
                Sem_comboBox.Items.Add(a);
            }
            con.Close();
        }

        private void NumGr_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(NumGr_comboBox.Text)) { Prep_comboBox.Enabled = false; }
            else { Prep_comboBox.Enabled = true; }
            
        }

        private void NumGr_comboBox_DropDown(object sender, EventArgs e)
        {
            Dob_listBox.SelectedItem = null;
            NumGr_comboBox.SelectedItem = null;
            Prep_comboBox.SelectedItem = null;
            Dis_comboBox.SelectedItem = null;
            Prep_comboBox.Enabled = false;
            Dis_comboBox.Enabled = false;

            btn_DobPlan.Enabled = false;
            lvlassimilation_comboBox.Enabled = false;
            ZadStud_textBox.Enabled = false;
            VidZanBox.Enabled = false;
            VolumeAuditHours_textBox.Enabled = false;
            VolumeSelfHours_textBox.Enabled = false;
            Dob_listBox.SelectedItem = null;

            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "123";//Пароль пользователя MySQL
            mysqlCSB.CharacterSet = "cp866";//Используем кодировку для киррилицы cp866

            MySqlConnection con = new MySqlConnection();//Создаем объект для подключения к СУБД MySQL
            con.ConnectionString = mysqlCSB.ConnectionString;//присваиваем значение строк объекта mysqlCSB к объекты для подключения con

            try
            {
                con.Open();//Подключаемся к базе данных

            }
            catch (Exception ee)
            {
                // если произошли ошибки покажем их
                MessageBox.Show(ee.ToString(), "Ошибка подключения к БД");
                return;
            }
            string sql = "SET names cp866";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.ExecuteNonQuery();
            MySqlDataReader reader;

            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT DISTINCT Num_Gr FROM groups WHERE department='" + OtdelBox.Text + "' and half_year="+Sem_comboBox.Text+"";
            reader = cmd.ExecuteReader();
            string a;
            a = "";
            NumGr_comboBox.Items.Clear();
            while (reader.Read())
            {
                a = reader["Num_Gr"].ToString();
                NumGr_comboBox.Items.Add(a);
            }
            con.Close();
            
        }

        private void Prep_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Prep_comboBox.Text)) { Dis_comboBox.Enabled = false; }
            else { Dis_comboBox.Enabled = true; }
            n = 0;
        }

        private void btn_DobPlan_Click(object sender, EventArgs e)
        {

            
            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "123";//Пароль пользователя MySQL
            mysqlCSB.CharacterSet = "cp866";//Используем кодировку для киррилицы cp866

            MySqlConnection con = new MySqlConnection();//Создаем объект для подключения к СУБД MySQL
            con.ConnectionString = mysqlCSB.ConnectionString;//присваиваем значение строк объекта mysqlCSB к объекты для подключения con

            try
            {
                con.Open();//Подключаемся к базе данных
            }
            catch (Exception ee)
            {
                // если произошли ошибки покажем их
                MessageBox.Show(ee.ToString(), "Ошибка подключения к БД");
                return;
            }
            string sql = "SET names cp866";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            string ID_Gr = "";
            string ID_Prep = "";
            string ID_Pred="";
            string str_NumberSubsection = "0";
            string str_NumberTheme = "0";
            string str_newNumberSubsection = "0";
            int NumberTheme = 0;
            int NumberSubsection = 0;
            int newNumberSubsection = 0;
            string str_newNumberTheme = "0";
            string in_NumberTheme="0";
            int newNumberTheme=0;
            int in_theme = 0;
            //Переменные для максимального кол-ва часов на подраздел
            int Max_time = 0;
            string strNumberLab = "";
            int NumberLab=0;
            string strNumberPrak = "";
            int NumberPrak = 0;
            string str_Maxtime = "0";
            //...
            cmd.CommandText = "SELECT ID_Gr FROM groups WHERE department='" + OtdelBox.Text + "' and half_year=" + Sem_comboBox.Text + " and Num_Gr=" + NumGr_comboBox.Text + "";
            ID_Gr += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT ID_Prep FROM lecturer WHERE FIO_Lecturer='" + Prep_comboBox.Text + "'";
            ID_Prep += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT ID_Pred FROM discipline WHERE ID_Gr="+ID_Gr+" and ID_Prep="+ID_Prep+" and discipline='"+Dis_comboBox.Text+"'";
            ID_Pred += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT MAX(subsection) FROM Plan WHERE ID_Pred="+ID_Pred+"";
            str_NumberSubsection += cmd.ExecuteScalar();
            NumberSubsection += Convert.ToInt32(str_NumberSubsection);
            cmd.CommandText = "SELECT MAX(theme) FROM Plan WHERE ID_Pred="+ID_Pred+" and subsection="+NumberSubsection+"";
            str_NumberTheme += cmd.ExecuteScalar();
            NumberTheme += Convert.ToInt32(str_NumberTheme);
            cmd.CommandText = "SELECT MAX(in_theme) FROM Plan WHERE ID_Pred="+ID_Pred+" and subsection="+NumberSubsection+" and theme="+NumberTheme+" and lvl_assimilation not like ''";
            in_NumberTheme += cmd.ExecuteScalar();
            in_theme = Convert.ToInt32(in_NumberTheme);
            if (NumberSubsection != 0)
            {
                cmd.CommandText = "SELECT Max(subsection) FROM Plan WHERE ID_Pred=" + ID_Pred + " and  theme is null";//разчет предпоследней записи
                str_newNumberSubsection += cmd.ExecuteScalar();
                newNumberSubsection += Convert.ToInt32(str_newNumberSubsection);
            }
            if(NumberTheme!=0)
            {
            cmd.CommandText = "SELECT MAX(theme) FROM Plan WHERE ID_Pred=" + ID_Pred + " and subsection="+NumberSubsection+" and in_theme is null";
            str_newNumberTheme += cmd.ExecuteScalar();
            newNumberTheme += Convert.ToInt32(str_newNumberTheme);
            }
            //Если выбрали добавить раздел то
            if (Dob_listBox.SelectedIndex == 0)
            {

                //Обновление записи с подчетом мак. колво часов на подраздел
                if (NumberSubsection != 0)
                {
                    cmd.CommandText = "SELECT Sum(max_time) FROM Plan WHERE ID_Pred=" + ID_Pred + " and subsection=" + NumberSubsection + "";
                    str_Maxtime += cmd.ExecuteScalar();
                    Max_time = Convert.ToInt32(str_Maxtime);
                    cmd.CommandText = "Update Plan set Max_time=" + Max_time + " WHERE ID_Pred=" + ID_Pred + " and Subsection=" + NumberSubsection + " and theme is null";
                    cmd.ExecuteNonQuery();
                }
                //Обновление закончино
                NumberSubsection++;
                //Добавление подраздела
                cmd.CommandText = "INSERT INTO Plan(ID_Pred,scope,subsection)" +
          "VALUES(" + ID_Pred + ",'" + RazdeltextBox.Text + "',"+NumberSubsection+")";
            }
            //Если выбрали добавить тему
            if (Dob_listBox.SelectedIndex == 1)
            {
                if (NumberSubsection != 0)
                {
                    if (NumberSubsection != newNumberSubsection)
                    { NumberTheme = 0; }

                    NumberTheme++;
                   
                    cmd.CommandText = "SELECT Max(Subsection) FROM plan WHERE ID_Pred=" + ID_Pred + "";
                    string Subsection = "";
                    Subsection += cmd.ExecuteScalar();
                    //Добавление темы
                    cmd.CommandText = "INSERT INTO Plan(ID_Pred,scope,subsection,theme)" +
                    "VALUES(" + ID_Pred + ",'" + RazdeltextBox.Text + "', " + Subsection + " , "  + NumberTheme + ")";
                    RazdeltextBox.Text = "";
                    lvlassimilation_comboBox.Text = null;
                }
                else { MessageBox.Show("Раздел в текущем плане на добавлен!"); return; }
            }
            //Если выбрали добавить содержание
            if (Dob_listBox.SelectedIndex == 2)
            {

                if (NumberTheme != 0)
                {
                    if (NumberTheme != newNumberTheme)
                    { in_theme = 0; }
                    in_theme++;
                    string lvl_assimilation = "";
                    //ЛАБОРАТОРНЫЕ РАБОТЫ
                    if (VidZanBox.Text == "Лабораторная работа" )
                    {
                        cmd.CommandText = "SELECT Max(in_theme) FROM Plan WHERE ID_Pred=" + ID_Pred + " and subsection=" + NumberSubsection + " and theme=" + NumberTheme + " and form='Лабораторная работа'";
                        strNumberLab += cmd.ExecuteScalar();
                       
                        if (strNumberLab == "")
                        {
                            NumberLab = 0;
                        }
                        else{ NumberLab = Convert.ToInt32(strNumberLab);}
                        NumberLab++;
                        cmd.CommandText = "INSERT INTO Plan(ID_Pred,scope,form,Hour_Aud,time_homework,max_time,subsection,theme,in_theme)" +
                  "VALUES(" + ID_Pred + ",'" + RazdeltextBox.Text + "','"  + VidZanBox.Text + "'," + VolumeAuditHours_textBox.Text + "," + VolumeSelfHours_textBox.Text + "," + MaxVolumeHour_textBox.Text + "," + NumberSubsection + "," + NumberTheme + "," + NumberLab +  ")";
                    }
                    if (VidZanBox.Text == "Практическое занятие")
                    {
                        cmd.CommandText = "SELECT Max(in_theme) FROM Plan WHERE ID_Pred=" + ID_Pred + " and subsection=" + NumberSubsection + " and theme=" + NumberTheme + " and form='Практическое занятие'";
                        strNumberPrak += cmd.ExecuteScalar();

                        if (strNumberPrak == "")
                        {
                            NumberPrak = 0;
                        }
                        else { NumberPrak = Convert.ToInt32(strNumberPrak); }
                        NumberPrak++;
                        cmd.CommandText = "INSERT INTO Plan(ID_Pred,scope,form,Hour_Aud,time_homework,max_time,subsection,theme,in_theme)" +
                  "VALUES(" + ID_Pred + ",'" + RazdeltextBox.Text + "','" + VidZanBox.Text + "'," + VolumeAuditHours_textBox.Text + "," + VolumeSelfHours_textBox.Text + "," + MaxVolumeHour_textBox.Text + "," + NumberSubsection + "," + NumberTheme + "," + NumberPrak + ")";
                    }
                    if (VidZanBox.Text == "Самостоятельная работа")
                    {
                       
                        in_theme--;
                        cmd.CommandText = "INSERT INTO Plan(ID_Pred,scope,homework,form,subsection,theme,in_theme)" +
                    "VALUES(" + ID_Pred + ",'" + RazdeltextBox.Text + "','" + ZadStud_textBox.Text + "','" + VidZanBox.Text + "'," + NumberSubsection + "," + NumberTheme + "," + in_theme + ")";
                    }
                        
                    if(VidZanBox.Text != "Самостоятельная работа" && VidZanBox.Text != "Лабораторная работа" && VidZanBox.Text != "Практическое занятие")
                    {
                        if (lvlassimilation_comboBox.SelectedIndex == 0)
                        {
                            lvl_assimilation = "1";
                        }

                        if (lvlassimilation_comboBox.SelectedIndex == 1) { lvl_assimilation = "2"; }
                        if (lvlassimilation_comboBox.SelectedIndex == 2) { lvl_assimilation = "3"; }
                        cmd.CommandText = "INSERT INTO Plan(ID_Pred,scope,homework,form,Hour_Aud,time_homework,max_time,subsection,theme,in_theme,lvl_assimilation)" +
                    "VALUES(" + ID_Pred + ",'" + RazdeltextBox.Text + "','" + ZadStud_textBox.Text + "','" + VidZanBox.Text + "'," + VolumeAuditHours_textBox.Text + "," + VolumeSelfHours_textBox.Text + "," + MaxVolumeHour_textBox.Text + "," + NumberSubsection + "," + NumberTheme + "," + in_theme + "," + lvl_assimilation + ")";
                       
                    }
                    //После добавление записи очищаем поля основной формы
                    VolumeAuditHours_textBox.Text = "";
                    VolumeSelfHours_textBox.Text = "";
                    ZadStud_textBox.Text = "";
                    VidZanBox.Text = "";
                    lvlassimilation_comboBox.Text = null;
                    //Очистка окончина
                }
                else { MessageBox.Show("Тема в текущем разделе не добавлена!"); return; }
            }
          
            try
            {
                cmd.ExecuteNonQuery(); ;//Выполняем запрос SQL
                MessageBox.Show("Запись добавлена!");
            }
            catch (Exception ee)
            {
                // если произошли ошибки покажем их
                MessageBox.Show(ee.ToString(), "Ошибка добавления преподавателя");
                return;

            }
            con.Close();
            RazdeltextBox.Text = "";
        }

        private void btn_Redakt_Click(object sender, EventArgs e)
        {
            Table newForm = new Table();
            rbCalendarPlan.Enabled = false;
            rbWorkProgramm.Enabled = false;
            OtdelBox.Enabled = false;
            Sem_comboBox.Enabled = false;
            NumGr_comboBox.Enabled = false;
            Prep_comboBox.Enabled = false;
            Dis_comboBox.Enabled = false;
            newForm.Owner = this;
            newForm.Show();
        }
       
        private void VolumeSelfHours_textBox_TextChanged(object sender, EventArgs e)
        {
            
            if (VolumeSelfHours_textBox.Text != "" && VolumeAuditHours_textBox.Text != "" )
            {
                int a, b;
                a = Convert.ToInt32(VolumeAuditHours_textBox.Text);
                b = Convert.ToInt32(VolumeSelfHours_textBox.Text);
                MaxVolumeHour_textBox.Text = Convert.ToString(a + b);
            }
            else { MaxVolumeHour_textBox.Text = ""; }
        
        }

        private void VolumeAuditHours_textBox_TextChanged(object sender, EventArgs e)
        {

            if (VolumeSelfHours_textBox.Text != "" && VolumeAuditHours_textBox.Text != "")
            {
                int a, b;
                a = Convert.ToInt32(VolumeAuditHours_textBox.Text);
                b = Convert.ToInt32(VolumeSelfHours_textBox.Text);
                MaxVolumeHour_textBox.Text = Convert.ToString(a + b);

            }
            else { MaxVolumeHour_textBox.Text = ""; }

            //Подключение к БД
            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "123";//Пароль пользователя MySQL
            mysqlCSB.CharacterSet = "cp866";//Используем кодировку для киррилицы cp866

            MySqlConnection con = new MySqlConnection();//Создаем объект для подключения к СУБД MySQL
            con.ConnectionString = mysqlCSB.ConnectionString;//присваиваем значение строк объекта mysqlCSB к объекты для подключения con

            try
            {
                con.Open();//Подключаемся к базе данных

            }
            catch (Exception ee)
            {
                // если произошли ошибки покажем их
                MessageBox.Show(ee.ToString(), "Ошибка подключения к БД");
                return;
            }
            

            string sql = "SET names cp866";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            string ID_Gr = "";
            string ID_Prep = "";
            string ID_Pred = "";
            // Запросы для выбора конкретных 
            // id изходя из значений выбраных пользователем.
            cmd.CommandText = "SELECT ID_Gr FROM groups WHERE department='" + OtdelBox.Text + "' and half_year=" + Sem_comboBox.Text + " and Num_Gr=" + NumGr_comboBox.Text + "";
            ID_Gr += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT ID_Prep FROM lecturer WHERE FIO_Lecturer='" + Prep_comboBox.Text + "'";
            ID_Prep += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT ID_Pred FROM discipline WHERE ID_Gr=" + ID_Gr + " and ID_Prep=" + ID_Prep + "";
            ID_Pred += cmd.ExecuteScalar();
            // ИД для исходных данных.
            // Кол-во часов в неделю.
            int k = 0;
            // Кол-во часов на тему.
            int h = 0;
            cmd.CommandText = "SELECT Hour_week FROM discipline WHERE ID_Pred=" + ID_Pred + "";
            k += Convert.ToInt32(cmd.ExecuteScalar());
            //Дописать запрос//cmd.CommandText = "SELECT Sum(Max FROM discipline WHERE ID_Pred=" + ID_Pred + "";
            h += Convert.ToInt32(cmd.ExecuteScalar());
            n = h % k;
            
            // Итог.
            textBox_Ot.Text = "";
            textBox_Do.Text = "";
        }
        //Маска ввода только цифры Объем.аудит.часов
        private void VolumeAuditHours_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            { e.Handled = true; }    
        }
        //Маска ввода только цифры Объем.сам.часов
        private void VolumeSelfHours_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            { e.Handled = true; } 
        }

        private void btn_DobPlanTheme_Click(object sender, EventArgs e)
        {
            
            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "123";//Пароль пользователя MySQL
            mysqlCSB.CharacterSet = "cp866";//Используем кодировку для киррилицы cp866

            MySqlConnection con = new MySqlConnection();//Создаем объект для подключения к СУБД MySQL
            con.ConnectionString = mysqlCSB.ConnectionString;//присваиваем значение строк объекта mysqlCSB к объекты для подключения con

            try
            {
                con.Open();//Подключаемся к базе данных

            }
            catch (Exception ee)
            {
                // если произошли ошибки покажем их
                MessageBox.Show(ee.ToString(), "Ошибка подключения к БД");
                return;
            }
            string sql = "SET names cp866";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            string ID_Gr = "";
            string ID_Prep = "";
            string ID_Pred = "";
            string lvl_assimilation = "";
            cmd.CommandText = "SELECT ID_Gr FROM groups WHERE department='" + OtdelBox.Text + "' and half_year=" + Sem_comboBox.Text + " and Num_Gr=" + NumGr_comboBox.Text + "";
            ID_Gr += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT ID_Prep FROM lecturer WHERE FIO_Lecturer='" + Prep_comboBox.Text + "'";
            ID_Prep += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT ID_Pred FROM discipline WHERE ID_Gr=" + ID_Gr + " and ID_Prep=" + ID_Prep + "";
            ID_Pred += cmd.ExecuteScalar();

            if (lvlassimilation_comboBox.SelectedIndex == 0)
            {
                lvl_assimilation = "1";
            }
            if (lvlassimilation_comboBox.SelectedIndex == 1) { lvl_assimilation = "2"; }
            if (lvlassimilation_comboBox.SelectedIndex == 2) { lvl_assimilation = "3"; }
            cmd.CommandText = "INSERT INTO Plan(ID_Pred,scope,lvl_assimilation)" +
            "VALUES(" + ID_Pred + ",'" + RazdeltextBox.Text + "',"+lvl_assimilation+")";
            try
            {
                cmd.ExecuteNonQuery(); ;//Выполняем запрос SQL
                MessageBox.Show("Запись добавлена!");
            }
            catch (Exception ee)
            {
                // если произошли ошибки покажем их
                MessageBox.Show(ee.ToString(), "Ошибка добавления преподавателя");
                return;

            }
            con.Close();
            RazdeltextBox.Text = "";
            VidZanBox.Text = "";
            lvlassimilation_comboBox.Text = "";
            VidZanBox.Enabled = true;
            ZadStud_textBox.Enabled = true;
            VolumeAuditHours_textBox.Enabled = true;
            VolumeSelfHours_textBox.Enabled = true;
            lvlassimilation_comboBox.Enabled = false;
            lvlassimilation_comboBox.Enabled = true;
            
            
        }
        // Переменная для запоминая остатка от деления
        int n;
        private void Dis_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Redakt.Enabled = true;
           
            n = 0;
            MaxVolumeHour_textBox.Text = "";
            VolumeAuditHours_textBox.Text = "";
            VolumeSelfHours_textBox.Text = "";
        
        }

        private void MaxVolumeHour_textBox_TextChanged(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "123";//Пароль пользователя MySQL
            mysqlCSB.CharacterSet = "cp866";//Используем кодировку для киррилицы cp866

            MySqlConnection con = new MySqlConnection();//Создаем объект для подключения к СУБД MySQL
            con.ConnectionString = mysqlCSB.ConnectionString;//присваиваем значение строк объекта mysqlCSB к объекты для подключения con

            try
            {
                con.Open();//Подключаемся к базе данных

            }
            catch (Exception ee)
            {
                // если произошли ошибки покажем их
                MessageBox.Show(ee.ToString(), "Ошибка подключения к БД");
                return;
            }
            string sql = "SET names cp866";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            
        }

        private void Dob_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Dob_listBox.SelectedIndex == 0 && Dis_comboBox.Text != "")
            {
                btn_DobPlan.Enabled = true;
                RazdeltextBox.Enabled = true;
                lvlassimilation_comboBox.Enabled = false;
                ZadStud_textBox.Enabled = false;
                VidZanBox.Enabled = false;
                VidZanBox.Text = "";
                VolumeAuditHours_textBox.Enabled = false;
                VolumeSelfHours_textBox.Enabled = false;
                textBox_Ot.Enabled = false;
                textBox_Do.Enabled = false;
                lbl_NameRasd.Text = "Наименование раздела:";
            }
            
            if (Dob_listBox.SelectedIndex == 1 && Dis_comboBox.Text!="")
            {
                btn_DobPlan.Enabled = true;
                lvlassimilation_comboBox.Enabled = false;
                ZadStud_textBox.Enabled = false;
                VidZanBox.Enabled = false;
                VidZanBox.Text = "";
                VolumeAuditHours_textBox.Enabled = false;
                VolumeAuditHours_textBox.Text = "";
                VolumeSelfHours_textBox.Text = "";
                VolumeSelfHours_textBox.Enabled = false;
                textBox_Ot.Enabled = false;
                textBox_Do.Enabled = false;

                lbl_NameRasd.Text = "Наименование темы:";
            }
           
            if (Dob_listBox.SelectedIndex == 2 && Dis_comboBox.Text != "")
            {
                btn_DobPlan.Enabled = true;
                lvlassimilation_comboBox.Enabled = true;
                
                VidZanBox.Enabled = true;
                VolumeAuditHours_textBox.Enabled = true;
                VolumeSelfHours_textBox.Enabled = true;
                textBox_Ot.Enabled = true;
                textBox_Do.Enabled = true;
                lbl_NameRasd.Text = "Содержание:";
            }
            
            if (Dob_listBox.SelectedItem==null)
            {
                lbl_NameRasd.Text = "Наименование разделов, тем, содержание учебного материала, лабораторные и контрольные работы, практические занятия";
            }
        }

        private void лToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LoginForm newForm = new LoginForm();
            newForm.Owner = this;
            newForm.ShowDialog();
            
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
            foreach (Control c in Controls)
            {

                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = string.Empty;
                }
               

            }
          
        }

        

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void очиститьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Метод по очисте формы Plan
            Dob_listBox.SelectedItem = null;
            btn_DobPlan.Enabled = false;
            lvlassimilation_comboBox.Enabled = false;
            ZadStud_textBox.Enabled = false;
            VidZanBox.Enabled = false;
            VolumeAuditHours_textBox.Enabled = false;
            VolumeSelfHours_textBox.Enabled = false;
            textBox_Ot.Enabled = false;
            textBox_Do.Enabled = false;

            foreach (Control c in Controls)
            {

                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = string.Empty;
                }
                if (c.GetType() == typeof(ComboBox))
                {
                    c.Text = null;
                }

            }
        }

        private void оПрограммеWPCPLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWPL NewForm = new AboutWPL();
            NewForm.Show();
        }

        private void просмотрСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(null, "Resources/WPandCPLSupport.chm");
        }

        private void VidZanBox_DropDown(object sender, EventArgs e)
        {
            
                MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
                mysqlCSB = new MySqlConnectionStringBuilder();
                mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
                mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
                mysqlCSB.UserID = "root";//Имя пользователя MySQL
                mysqlCSB.Password = "123";//Пароль пользователя MySQL
                mysqlCSB.CharacterSet = "cp866";//Используем кодировку для киррилицы cp866

                MySqlConnection con = new MySqlConnection();//Создаем объект для подключения к СУБД MySQL
                con.ConnectionString = mysqlCSB.ConnectionString;//присваиваем значение строк объекта mysqlCSB к объекты для подключения con

                try
                {
                    con.Open();//Подключаемся к базе данных

                }
                catch (Exception ee)
                {
                    // если произошли ошибки покажем их
                    MessageBox.Show(ee.ToString(), "Ошибка подключения к БД");
                    return;
                }
                string sql = "SET names cp866";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                string Otdel = OtdelBox.Text;
                string Sem = Sem_comboBox.Text;
                string NumGr = NumGr_comboBox.Text;
                string Prep = Prep_comboBox.Text;
                string Dis = Dis_comboBox.Text;
                string ID_Gr = "";
                string ID_Prep = "";
                string ID_Pred = "";
                string MaxTheme = "";
                string MaxRazdel = "";
                string ThreeLvLAssimilation = "";
                //Расчет значение для запроса.
                cmd.CommandText = "SELECT ID_Gr FROM groups WHERE department='" + Otdel + "' and half_year=" + Sem + " and Num_Gr=" + NumGr + "";
                ID_Gr += cmd.ExecuteScalar();
                cmd.CommandText = "SELECT ID_Prep FROM lecturer WHERE FIO_Lecturer='" + Prep + "'";
                ID_Prep += cmd.ExecuteScalar();
                cmd.CommandText = "SELECT ID_Pred FROM discipline WHERE ID_Gr=" + ID_Gr + " and ID_Prep=" + ID_Prep + " and discipline='" + Dis + "'";
                ID_Pred += cmd.ExecuteScalar();
                cmd.CommandText = "SELECT Max(subsection) FROM Plan WHERE ID_Pred=" + ID_Pred + "";
                MaxRazdel += cmd.ExecuteScalar();   
            
                if (MaxRazdel != "")
                {
                    cmd.CommandText = "SELECT Max(theme) FROM Plan WHERE ID_Pred=" + ID_Pred + " and subsection=" + MaxRazdel + "";
                    MaxTheme += cmd.ExecuteScalar();
                    if (MaxTheme != "")
                    {
                        cmd.CommandText = "SELECT lvl_assimilation FROM Plan WHERE ID_Pred=" + ID_Pred + " and lvl_assimilation=3 and theme=" + MaxTheme + " and subsection=" + MaxRazdel + "";
                        ThreeLvLAssimilation += cmd.ExecuteScalar();
                    }

                }
              
                if (ThreeLvLAssimilation == "")
                {
                    VidZanBox.Items.Remove("Лабораторная работа");
                    VidZanBox.Items.Remove("Практическое занятие");
                }
                else
                {
                    VidZanBox.Items.Remove("Лабораторная работа");
                    VidZanBox.Items.Remove("Практическое занятие");
                    VidZanBox.Items.Add("Лабораторная работа");
                    VidZanBox.Items.Add("Практическое занятие");
                }
            
        }

        private void VidZanBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VolumeAuditHours_textBox.Text = "";
            VolumeSelfHours_textBox.Text = "";
            lvlassimilation_comboBox.Text = "";
            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "123";//Пароль пользователя MySQL
            mysqlCSB.CharacterSet = "cp866";//Используем кодировку для киррилицы cp866

            MySqlConnection con = new MySqlConnection();//Создаем объект для подключения к СУБД MySQL
            con.ConnectionString = mysqlCSB.ConnectionString;//присваиваем значение строк объекта mysqlCSB к объекты для подключения con

            try
            {
                con.Open();//Подключаемся к базе данных

            }
            catch (Exception ee)
            {
                // если произошли ошибки покажем их
                MessageBox.Show(ee.ToString(), "Ошибка подключения к БД");
                return;
            }
            string sql = "SET names cp866";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            string Otdel = OtdelBox.Text;
            string Sem = Sem_comboBox.Text;
            string NumGr = NumGr_comboBox.Text;
            string Prep = Prep_comboBox.Text;
            string Dis = Dis_comboBox.Text;
            string ID_Gr = "";
            string ID_Prep = "";
            string ID_Pred = "";
            string MaxTheme = "";
            string MaxRazdel = "";
            string MaxSelfHours = "";
            //Расчет значение для запроса.
            cmd.CommandText = "SELECT ID_Gr FROM groups WHERE department='" + Otdel + "' and half_year=" + Sem + " and Num_Gr=" + NumGr + "";
            ID_Gr += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT ID_Prep FROM lecturer WHERE FIO_Lecturer='" + Prep + "'";
            ID_Prep += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT ID_Pred FROM discipline WHERE ID_Gr=" + ID_Gr + " and ID_Prep=" + ID_Prep + " and discipline='" + Dis + "'";
            ID_Pred += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT Max(subsection) FROM Plan WHERE ID_Pred=" + ID_Pred + "";
            MaxRazdel += cmd.ExecuteScalar();

            if (MaxRazdel != "")
            {
                cmd.CommandText = "SELECT Max(theme) FROM Plan WHERE ID_Pred=" + ID_Pred + " and subsection=" + MaxRazdel + "";
                MaxTheme += cmd.ExecuteScalar();
                if (MaxTheme != "")
                {
                    cmd.CommandText = "SELECT Sum(time_homework) FROM Plan WHERE ID_Pred=" + ID_Pred + " and  theme=" + MaxTheme + " and subsection=" + MaxRazdel + "";
                    MaxSelfHours += cmd.ExecuteScalar();
                }

            }
            if (VidZanBox.Text == "Самостоятельная работа")
            {
                RazdeltextBox.Text = "";
                RazdeltextBox.Enabled = false;
                ZadStud_textBox.Enabled = true;
                
                VolumeAuditHours_textBox.Enabled = false;
                
                VolumeSelfHours_textBox.Enabled = false;
                lvlassimilation_comboBox.Text = "";
                lvlassimilation_comboBox.Enabled = false;
                VolumeSelfHours_textBox.Text = MaxSelfHours;

            }

            else
            {
                RazdeltextBox.Enabled = true;
                ZadStud_textBox.Enabled = false;
                VolumeAuditHours_textBox.Enabled = true;
                lvlassimilation_comboBox.Enabled = true;
                VolumeSelfHours_textBox.Enabled = true;
            }
            if (VidZanBox.Text == "Лабораторная работа" || VidZanBox.Text == "Практическое занятие")
            {
                RazdeltextBox.Enabled = true;
                ZadStud_textBox.Enabled = false;
                lvlassimilation_comboBox.Text = "";

              
                VolumeAuditHours_textBox.Enabled = true;
               
                VolumeSelfHours_textBox.Enabled = true;
                lvlassimilation_comboBox.Enabled = false;
                

            }
        }

        private void lbl_Prep_Click(object sender, EventArgs e)
        {

        }

        private void lbl_NumGr_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Sem_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Otdel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
