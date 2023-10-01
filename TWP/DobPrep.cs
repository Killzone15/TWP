using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WPandCPL
{
    public partial class DobPrep : Form
    {
        public DobPrep(Plan ParrentForm)
        {
            InitializeComponent();
        }

        private void btn_ExitDobPrep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DobPrep_Load(object sender, EventArgs e)
        {

        }

        private void btn_DobPrep_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder mysqlCSB; //Создаем объект класса MySQLConnectionStringBuilder
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "";//Пароль пользователя MySQL
            mysqlCSB.CharacterSet = "cp866";
     
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

            //Выполняем запрос добавления преподавателя
            
           
            string sql = "INSERT INTO lecturer (FIO_Lecturer)" +
             "VALUES ('"+FIOPrep_textBox.Text+"')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            
           
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
            con.Close();//Закрываем подключение
        }

        private void FIOPrep_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
