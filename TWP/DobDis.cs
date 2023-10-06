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


namespace TWP
{
    public partial class DobDis : Form
    {
        public DobDis()
        {
            InitializeComponent();
        }
        private void btn_ClearDobDis_Click(object sender, EventArgs e)
        {
            NameDisDobDis_textBox.Text = "";
            CountHourAll_textBox.Text = "";
            CountHourWeek_textBox.Text = "";
            onset_textBox.Text = "";
            ending_textBox.Text = "";
            OtdelDobDis_comboBox.Text = null;
            SemDobDis_comboBox.Text = null; 
            NumGrDobDis_comboBox.Text = null;
            PrepDobDis_comboBox.Text = null;
            
        }

        private void btn_ExitDobDis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DobDis_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "twp";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "1234";//Пароль пользователя MySQL
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
            cmd.CommandText = "SELECT ID_Prep FROM lecturer WHERE FIO_Lecturer='" + PrepDobDis_comboBox.Text + "'";
            ID_Prep += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT ID_Gr FROM groups WHERE department='" + OtdelDobDis_comboBox.Text + "' and half_year=" + SemDobDis_comboBox.Text + " and Num_Gr=" + NumGrDobDis_comboBox.Text + "";
            ID_Gr += cmd.ExecuteScalar();


            cmd.CommandText = "INSERT INTO discipline(ID_Gr,ID_Prep,discipline,Hour_Week,Hour_All) VALUES(" + ID_Gr + "," + ID_Prep + ",'" + NameDisDobDis_textBox.Text + "'," + CountHourWeek_textBox.Text + "," + CountHourAll_textBox.Text + ")";
            try
            {
                cmd.ExecuteNonQuery();//Выполняем запрос SQL
                MessageBox.Show("Запись добавлена!");
            }
            catch (Exception ee)
            {
                // если произошли ошибки покажем их
                MessageBox.Show(ee.ToString(), "Ошибка добавления преподавателя");
                return;
            }
        }

        private void OtdelDobDis_comboBox_DropDown(object sender, EventArgs e)
        {
            onset_textBox.Text = "";
            ending_textBox.Text = "";

            SemDobDis_comboBox.SelectedItem = null;
            OtdelDobDis_comboBox.SelectedItem = null;
            NumGrDobDis_comboBox.SelectedItem = null;

            SemDobDis_comboBox.Enabled = false;
            NumGrDobDis_comboBox.Enabled = false;

            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "";//Пароль пользователя MySQL
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
            cmd.CommandText = "select distinct department from groups";
            reader = cmd.ExecuteReader();
            string a;
            a = "";
            OtdelDobDis_comboBox.Items.Clear();
            while (reader.Read())
            {
                a = reader["department"].ToString();
                OtdelDobDis_comboBox.Items.Add(a);
            }
            con.Close();//Закрывает подключение с БД MySQL
        }

        private void PrepDobDis_comboBox_DropDown(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "";//Пароль пользователя MySQL
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
            cmd.CommandText = "select FIO_lecturer from lecturer";
            reader = cmd.ExecuteReader();
            string a;
            a = "";
            PrepDobDis_comboBox.Items.Clear();
            while (reader.Read())
            {
                a = reader["FIO_lecturer"].ToString();
                PrepDobDis_comboBox.Items.Add(a);
            }
            con.Close();//Закрывает подключение с БД MySQL
        }

        private void SemDobDis_comboBox_DropDown(object sender, EventArgs e)
        {
            onset_textBox.Text = "";
            ending_textBox.Text="";
            NumGrDobDis_comboBox.Enabled = false;
            NumGrDobDis_comboBox.SelectedItem = null;
            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "";//Пароль пользователя MySQL
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
            cmd.CommandText = "SELECT DISTINCT half_year FROM groups WHERE department='" + OtdelDobDis_comboBox.Text + "' ORDER BY half_year";
            reader = cmd.ExecuteReader();
            string a;
            a = "";
            SemDobDis_comboBox.Items.Clear();
            while (reader.Read())
            {
                a = reader["half_year"].ToString();
                SemDobDis_comboBox.Items.Add(a);
            }
            con.Close();
        }

        private void SemDobDis_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(SemDobDis_comboBox.Text)) { NumGrDobDis_comboBox.Enabled = false; }
            else { NumGrDobDis_comboBox.Enabled = true; }
        }

        private void OtdelDobDis_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(OtdelDobDis_comboBox.Text)) { SemDobDis_comboBox.Enabled = false; }
            else { SemDobDis_comboBox.Enabled = true; }
        }

        private void NumGrDobDis_comboBox_DropDown(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "";//Пароль пользователя MySQL
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
            cmd.CommandText = "SELECT DISTINCT Num_Gr FROM groups WHERE department='" + OtdelDobDis_comboBox.Text + "' and half_year=" + SemDobDis_comboBox.Text + "";
            reader = cmd.ExecuteReader();
            string a;
            a = "";
            NumGrDobDis_comboBox.Items.Clear();
            while (reader.Read())
            {
                a = reader["Num_Gr"].ToString();
                NumGrDobDis_comboBox.Items.Add(a);
            }
            con.Close();
        }

        private void btn_OpenDobGr_Click(object sender, EventArgs e)
        {
            DobGr newMDIChild = new DobGr();
            
            newMDIChild.Show();
        }

        private void CountHourWeek_textBox_TextChanged(object sender, EventArgs e)
        {
           int count_week;

            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "";//Пароль пользователя MySQL
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
            string sql = "Select Id_Gr from groups where department='" + OtdelDobDis_comboBox.Text + "' and " + "half_year=" + SemDobDis_comboBox.Text + " and Num_Gr=" + NumGrDobDis_comboBox.Text + "";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            string Id_Gr = "";
            string onset = "";
            string ending = "";
            int hour_all;
            Id_Gr += cmd.ExecuteScalar();
            cmd.CommandText = "Select onset from groups where ID_Gr=" + Id_Gr + "";
            onset += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT ending FROM groups WHERE ID_Gr=" + Id_Gr + "";
            ending += cmd.ExecuteScalar();
            if (Convert.ToInt32(onset) < 18 || Convert.ToInt32(onset) < 19)
            {
                count_week = (Convert.ToInt32(ending) - Convert.ToInt32(onset)) + 1;
                count_week = count_week -2;
            }
            else { count_week = (Convert.ToInt32(ending) - Convert.ToInt32(onset)) + 1; }
            if (CountHourWeek_textBox.Text != "")
            {
                hour_all = Convert.ToInt32(CountHourWeek_textBox.Text) * count_week;
                CountHourAll_textBox.Text = Convert.ToString(hour_all);
            }
            else { CountHourAll_textBox.Text = ""; }
            
        }

        private void NumGrDobDis_comboBox_TextChanged(object sender, EventArgs e)
        {
            if (NumGrDobDis_comboBox.Enabled == true)
            {
                CountHourWeek_textBox.Enabled = true;
            }
            else { CountHourWeek_textBox.Enabled = false; }
        }

        private void lид_Click(object sender, EventArgs e)
        {

        }

        private void NumGrDobDis_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "";//Пароль пользователя MySQL
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
            string sql = "Select onset from groups where department='" + OtdelDobDis_comboBox.Text + "' and " + "half_year=" + SemDobDis_comboBox.Text + " and Num_Gr=" + NumGrDobDis_comboBox.Text + "";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            int onset=0, ending=0;
            if (OtdelDobDis_comboBox.Text != "" && SemDobDis_comboBox.Text != "" && NumGrDobDis_comboBox.Text != "")
            {
                onset += Convert.ToInt32(cmd.ExecuteScalar());
                cmd.CommandText = "Select ending from groups where department='" + OtdelDobDis_comboBox.Text + "' and " + "half_year=" + SemDobDis_comboBox.Text + " and Num_Gr=" + NumGrDobDis_comboBox.Text + "";
                ending += Convert.ToInt32(cmd.ExecuteScalar());
                onset_textBox.Text = Convert.ToString(onset);
                ending_textBox.Text = Convert.ToString(ending);
            }
            else { onset_textBox.Text = ""; ending_textBox.Text = ""; }

        }

        private void CountHourWeek_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            { e.Handled = true; }    
        }
    }
}
