using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace TWP
{
    class MySQLDatabaseManager
    {
        readonly MySqlConnection connection = new MySqlConnection(
            "server=localhost;" +
            "username=root;" +
            "password=1234;" +
            "database=twp;" +
            "characterset=cp866;"
            );

        public void OpenConnection()
        {

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public List<string> GetListFromQuery(string queryString, string columnName)
        {
            List<string> valuesList = new List<string>();

            MySQLDatabaseManager db = new MySQLDatabaseManager();

            db.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(queryString, db.GetConnection());
            MySqlDataReader reader;

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string cellValue = reader[columnName].ToString();
                valuesList.Add(cellValue);
            }

            db.CloseConnection();

            return valuesList;
           
        }
        public string GetValueFromQuery(string queryString)
        {
            
            string value;

            MySQLDatabaseManager db = new MySQLDatabaseManager();
                
            db.OpenConnection();


            MySqlCommand cmd = new MySqlCommand(queryString, db.GetConnection());

            value = cmd.ExecuteScalar().ToString();

            db.CloseConnection();
                
            return value;
            
        }
        public void InsertToDatabase(string queryString)
        {
            MySQLDatabaseManager db = new MySQLDatabaseManager();
            db.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(queryString, db.GetConnection());
            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }

    }
}
