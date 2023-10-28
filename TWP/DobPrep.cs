using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TWP
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

        private void btnAddLecturerClick(object sender, EventArgs e)
        { 
            string queryString = "INSERT INTO lecturer (FIO_Lecturer)" +
             "VALUES ('"+FIOPrep_textBox.Text+"')";

            MySQLDatabaseManager db = new MySQLDatabaseManager();
           
            try
            {
                db.InsertToDatabase(queryString);//Выполняем запрос SQL
                MessageBox.Show("Запись добавлена!");
            }
            catch (Exception ee)
            {
                // если произошли ошибки покажем их
                MessageBox.Show(ee.Message, "Ошибка добавления преподавателя");
                return;

            }

        }

    }
}
