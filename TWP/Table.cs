using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop;
using System.Printing;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;



namespace WPandCPL
{
    public partial class Table : Form
    {
        
        public Table()
        {

            InitializeComponent();

        }
        private MySqlConnection Connetion()
        {
            MySqlConnectionStringBuilder mysqlCSB;
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "123";//Пароль пользователя MySQL
            mysqlCSB.CharacterSet = "utf8";//Используем кодировку для киррилицы utf8

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
            }

            return con;
        }

        private DataTable GetComments()
        {
            DataTable dt = new DataTable();
            Plan main = this.Owner as Plan;
            string Otdel = main.OtdelBox.Text;
            string Sem = main.Sem_comboBox.Text;
            string NumGr = main.NumGr_comboBox.Text;
            string Prep = main.Prep_comboBox.Text;
            string Dis = main.Dis_comboBox.Text;

            MySqlConnectionStringBuilder mysqlCSB;
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "123";//Пароль пользователя MySQL
            mysqlCSB.CharacterSet = "utf8";//Используем кодировку для киррилицы utf8

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
            }
            string sql = "SET names utf8";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            string ID_Gr = "";
            string ID_Prep = "";
            string ID_Pred = "";
            string MaxSubsection = "0";
            string MaxTheme = "0";
            //Расчет значение для запроса.
            cmd.CommandText = "SELECT ID_Gr FROM groups WHERE department='" + Otdel + "' and half_year=" + Sem + " and Num_Gr=" + NumGr + "";
            ID_Gr += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT ID_Prep FROM lecturer WHERE FIO_Lecturer='" + Prep + "'";
            ID_Prep += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT ID_Pred FROM discipline WHERE ID_Gr=" + ID_Gr + " and ID_Prep=" + ID_Prep + " and discipline='" + Dis + "'";
            ID_Pred += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT MAX(subsection) FROM Plan WHERE ID_Pred=" + ID_Pred+"";
            MaxSubsection += cmd.ExecuteScalar();
            
            //Строка для текста запроса. 
            string queryString = "";
         
              
         /*  queryString = "Select subsection as '№ раздела', " +
                       "theme as '№ темы', " +
                      "scope as 'Наименование раздела', " +
                      "in_theme '№ подтемы', " +
                     "hour_aud as 'Кол-во аудит.часов', " +
                     "homework as 'Задание для сам.работ', " +
                    "time_homework as 'Кол-во часов\nдля сам.дом.работ', " +
                    "Max_time as 'Мак. кол-во часов\nна тему', " +
                    "lvl_assimilation as 'Уровень\nосвоения', " +
                    "Form as 'Форма проведения' " +
                    " FROM Plan WHERE ID_Pred=" + ID_Pred + "";*/

           for(int i = 1; i<=Convert.ToInt32(MaxSubsection);i++)
           {
               //Раздел
               queryString = "Select subsection as '№ раздела', " +
                       "theme as '№ темы', " +
                      "scope as 'Наименование раздела', " +
                      "in_theme '№ подтемы', " +
                     "hour_aud as 'Кол-во аудит.часов', " +
                     "homework as 'Задание для сам.работ', " +
                    "time_homework as 'Кол-во часов\nдля сам.дом.работ', " +
                    "Max_time as 'Мак. кол-во часов\nна тему', " +
                    "lvl_assimilation as 'Уровень\nосвоения', " +
                    "Form as 'Форма проведения' " +
                    " FROM Plan WHERE ID_Pred=" + ID_Pred + " and subsection=" + i + "  and theme is null";

               MySqlCommand com = new MySqlCommand(queryString, con);

               try
               {

                   using (MySqlDataReader dr = com.ExecuteReader())
                   {
                       if (dr.HasRows)
                       {
                           dt.Load(dr);
                       }
                   }
               }

               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }

               

               cmd.CommandText = "SELECT MAX(theme) FROM Plan WHERE ID_Pred=" + ID_Pred + " and subsection=" + i + "";
               MaxTheme += cmd.ExecuteScalar();
               for(int j=1; j<=Convert.ToInt32(MaxTheme);j++)
               {

                   //Раздел
                   queryString = "Select subsection as '№ раздела', " +
                           "theme as '№ темы', " +
                          "scope as 'Наименование раздела', " +
                          "in_theme '№ подтемы', " +
                         "hour_aud as 'Кол-во аудит.часов', " +
                         "homework as 'Задание для сам.работ', " +
                        "time_homework as 'Кол-во часов\nдля сам.дом.работ', " +
                        "Max_time as 'Мак. кол-во часов\nна тему', " +
                        "lvl_assimilation as 'Уровень\nосвоения', " +
                        "Form as 'Форма проведения' " +
                        " FROM Plan WHERE ID_Pred=" + ID_Pred + " and subsection=" + i + "  and theme="+j+" and in_theme is null";

                   com = new MySqlCommand(queryString, con);

                   try
                   {

                       using (MySqlDataReader dr = com.ExecuteReader())
                       {
                           if (dr.HasRows)
                           {
                               dt.Load(dr);
                           }
                       }
                   }

                   catch (Exception ex)
                   {
                       MessageBox.Show(ex.Message);
                   }
               //Лекция Урок и т.д

                 queryString = "Select subsection as '№ раздела', " +
                       "theme as '№ темы', " +
                      "scope as 'Наименование раздела', " +
                      "in_theme '№ подтемы', " +
                     "hour_aud as 'Кол-во аудит.часов', " +
                     "homework as 'Задание для сам.работ', " +
                    "time_homework as 'Кол-во часов\nдля сам.дом.работ', " +
                    "Max_time as 'Мак. кол-во часов\nна тему', " +
                    "lvl_assimilation as 'Уровень\nосвоения', " +
                    "Form as 'Форма проведения' " +
                    " FROM Plan WHERE ID_Pred=" + ID_Pred + " and subsection=" + i + " and theme=" + j + " and form IN('Лекция','Урок','Семинар','Контрольная работа','Урок-Лекция')";

                 com = new MySqlCommand(queryString, con);

                 try
                 {

                     using (MySqlDataReader dr = com.ExecuteReader())
                     {
                         if (dr.HasRows)
                         {
                             dt.Load(dr);
                         }
                     }
                 }

                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }

                 //Лабораторная работа

                 queryString = "Select subsection as '№ раздела', " +
                       "theme as '№ темы', " +
                      "scope as 'Наименование раздела', " +
                      "in_theme '№ подтемы', " +
                     "hour_aud as 'Кол-во аудит.часов', " +
                     "homework as 'Задание для сам.работ', " +
                    "time_homework as 'Кол-во часов\nдля сам.дом.работ', " +
                    "Max_time as 'Мак. кол-во часов\nна тему', " +
                    "lvl_assimilation as 'Уровень\nосвоения', " +
                    "Form as 'Форма проведения' " +
                    " FROM Plan WHERE ID_Pred=" + ID_Pred + " and subsection=" + i + " and theme=" + j + " and form='Лабораторная работа'";

                 com = new MySqlCommand(queryString, con);

                 try
                 {

                     using (MySqlDataReader dr = com.ExecuteReader())
                     {
                         if (dr.HasRows)
                         {
                             dt.Load(dr);
                         }
                     }
                 }

                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }

                 //Практическое занятие

                 queryString = "Select subsection as '№ раздела', " +
                       "theme as '№ темы', " +
                      "scope as 'Наименование раздела', " +
                      "in_theme '№ подтемы', " +
                     "hour_aud as 'Кол-во аудит.часов', " +
                     "homework as 'Задание для сам.работ', " +
                    "time_homework as 'Кол-во часов\nдля сам.дом.работ', " +
                    "Max_time as 'Мак. кол-во часов\nна тему', " +
                    "lvl_assimilation as 'Уровень\nосвоения', " +
                    "Form as 'Форма проведения' " +
                    " FROM Plan WHERE ID_Pred=" + ID_Pred + " and subsection=" + i + " and theme=" + j + " and form='Практическое занятие'";

                 com = new MySqlCommand(queryString, con);

                 try
                 {

                     using (MySqlDataReader dr = com.ExecuteReader())
                     {
                         if (dr.HasRows)
                         {
                             dt.Load(dr);
                         }
                     }
                     }
                 

                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }

                 //Самостоятельная работа

                 queryString = "Select subsection as '№ раздела', " +
                       "theme as '№ темы', " +
                      "scope as 'Наименование раздела', " +
                      "in_theme '№ подтемы', " +
                     "hour_aud as 'Кол-во аудит.часов', " +
                     "homework as 'Задание для сам.работ', " +
                    "time_homework as 'Кол-во часов\nдля сам.дом.работ', " +
                    "Max_time as 'Мак. кол-во часов\nна тему', " +
                    "lvl_assimilation as 'Уровень\nосвоения', " +
                    "Form as 'Форма проведения' " +
                    " FROM Plan WHERE ID_Pred=" + ID_Pred + " and subsection=" + i + " and theme=" + j + " and form='Самостоятельная работа'";

                 com = new MySqlCommand(queryString, con);

                 try
                 {

                     using (MySqlDataReader dr = com.ExecuteReader())
                     {
                         if (dr.HasRows)
                         {
                             dt.Load(dr);
                         }
                     }
                 }

                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
        } 
            }

            return dt;

        }

        private void Table_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.WrapMode =
    DataGridViewTriState.True;
                        dataGridView1.DataSource = GetComments();

            MySqlConnectionStringBuilder mysqlCSB;
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";//Сервер на котором находится база данных к которомой на необходимо подключиться
            mysqlCSB.Database = "Diplom";//Имя базы данных которая нам необходима
            mysqlCSB.UserID = "root";//Имя пользователя MySQL
            mysqlCSB.Password = "123";//Пароль пользователя MySQL
            mysqlCSB.CharacterSet = "utf8";//Используем кодировку для киррилицы utf8

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
            }
            
            MySqlDataReader reader;
            string sql = "SET names cp866";
           
            MySqlCommand cmd = new MySqlCommand(sql, con);
            Plan main = this.Owner as Plan;
            string Otdel = main.OtdelBox.Text;
            string Sem = main.Sem_comboBox.Text;
            string NumGr = main.NumGr_comboBox.Text;
            string Prep = main.Prep_comboBox.Text;
            string Dis = main.Dis_comboBox.Text;
            string ID_Gr = "";
            string ID_Prep = "";
            string ID_Pred = "";
            cmd.CommandText = "SELECT ID_Gr FROM groups WHERE department='" + Otdel + "' and half_year=" + Sem + " and Num_Gr=" + NumGr + "";
            ID_Gr += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT ID_Prep FROM lecturer WHERE FIO_Lecturer='" + Prep + "'";
            ID_Prep += cmd.ExecuteScalar();
            cmd.CommandText = "SELECT ID_Pred FROM discipline WHERE ID_Gr=" + ID_Gr + " and ID_Prep=" + ID_Prep + " and discipline='" + Dis + "'";
            ID_Pred += cmd.ExecuteScalar();
            cmd.ExecuteNonQuery();
          
            cmd.CommandText = "SELECT subsection FROM Plan WHERE ID_Pred=" + ID_Pred + "";
            reader = cmd.ExecuteReader();
            string a;
            a = "";

            int i = 0;
           while (reader.Read() && i < this.dataGridView1.RowCount )
            {
                a = reader["subsection"].ToString();
                if (Convert.ToInt32(a) % 2 == 0) { dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Gray; }
                else { dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray; }//Не четное
                i++;
            }
             
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Печать таблицы Plan
        private void btn_Print_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = GetComments();

            PrintDialog a = new PrintDialog();
            a.Reset();
            a.ShowDialog();

        }
        //Выход из формы Table
        private void btn_TableExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Предворительный просмотр документа на печать
        private void btn_EarlyView_Click(object sender, EventArgs e)
        {

            printDocument1.DefaultPageSettings.Landscape = true;
            printDocument1.DefaultPageSettings.Margins.Left = 0;
            printDocument1.DefaultPageSettings.Margins.Top = 0;
            printDocument1.DefaultPageSettings.Margins.Bottom = 0;
            printDocument1.DefaultPageSettings.Margins.Right = 0;
            printPreviewDialog1.ShowDialog();


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            DataTable dt = new DataTable();
            dt = GetComments();

            int x = 0;
            int y = 20;
            int cell_height = 0;

            int colCount = dataGridView1.ColumnCount;
            int rowCount = dataGridView1.RowCount-1;
            int current_col = 0;
            int current_row = 0;
            string value = "";

            int width = dataGridView1[current_col, current_row].Size.Width;
            int height = dataGridView1[current_col, current_row].Size.Height;

            Rectangle cell_border;
            SolidBrush brush = new SolidBrush(Color.Black);


            while (current_col < colCount)
            {

                x += dataGridView1[current_col, current_row].Size.Width;
                cell_height = dataGridView1[current_col, current_row].Size.Height;
                cell_border = new Rectangle(x, y, width, height);
                value = dataGridView1.Columns[current_col].HeaderText.ToString();
                g.DrawRectangle(new Pen(Color.Black), cell_border);
                g.DrawString(value, new Font("Times New Roman", 5, FontStyle.Bold, GraphicsUnit.Point), brush, x, y);
                current_col++;
            }
            while (current_row < rowCount+1)
            {
                while (current_col < colCount)
                {
                    x += dataGridView1[current_col, current_row].Size.Width;
                    cell_height = dataGridView1[current_col, current_row].Size.Height;
                    cell_border = new Rectangle(x, y, width, height);
                    value = dataGridView1[current_col, current_row-1].Value.ToString();
                    g.DrawRectangle(new Pen(Color.Black), cell_border);
                    g.DrawString(value, new Font("Times New Roman", 6, FontStyle.Regular, GraphicsUnit.Point), brush, x, y);
                    current_col++;
                }
                current_col = 0;
                current_row++;
                x = 0;
                y += cell_height;
            }
        }

        private void btn_Print_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetComments();
            PrintDialog printDialog = new PrintDialog();
            printDialog.Reset();
            printDialog.ShowDialog();
        }

        private void btn_Word_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(dataGridView1.DataSource) == "") { MessageBox.Show("Рабочая программа не добавлена!!!"); }
            else
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                Microsoft.Office.Interop.Word.Application WordApp = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document doc;
                Microsoft.Office.Interop.Word.Table wordTable;
                Microsoft.Office.Interop.Word.Paragraph wordParag;
                //Книга.
                doc = WordApp.Documents.Add(System.Reflection.Missing.Value);
                //Параметры текста документа

                doc.Content.Font.Size = 14;
                doc.Content.Font.Name = "Times new roman";
                doc.Paragraphs.SpaceAfter = 0;
                doc.Paragraphs.LineSpacing = 12;
                //Задаем альбомную оринетацию документу.
                doc.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;
               
                //Поля страницы
                doc.PageSetup.LeftMargin = 71.9f;
                doc.PageSetup.RightMargin = 19.50f;
                doc.PageSetup.TopMargin = 28.4F;
                doc.PageSetup.BottomMargin = 35.90f;


                Plan main = this.Owner as Plan;
                wordParag = doc.Paragraphs.Add(Type.Missing);


                //Кол-во столбцов и строк DataGridView
                int colCount = dataGridView1.ColumnCount-1;
                int rowCount = dataGridView1.RowCount;

                doc.Paragraphs.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                //Добавляем новый параграф.
                doc.Paragraphs.Add(Type.Missing);
                wordParag.Range.Tables.Add(wordParag.Range, rowCount, colCount, Type.Missing, Type.Missing);
                wordTable = doc.Tables[1];
                //Вариация заголовка и шапки таблицы документа Word 
                if (main.rbCalendarPlan.Checked == true)
                {
                    doc.Content.Text = "Календарный план учебной дисциплины «" + main.Dis_comboBox.Text + "»";
                    doc.Paragraphs.Add(Type.Missing);
                    wordParag.Range.Tables.Add(wordParag.Range, rowCount, colCount, Type.Missing, Type.Missing);
                    wordTable = doc.Tables[1];
                  
                    //Заполняем шапку таблицы.
                    wordTable.Cell(1, 1).Range.Text = "№ Раздела";
                    wordTable.Cell(1, 2).Range.Text = "№ темы";
                    wordTable.Cell(1, 3).Range.Text = "№ подтемы";
                    wordTable.Cell(1, 4).Range.Text = "Наименование";
                    wordTable.Cell(1, 5).Range.Text = "Форма проведения";
                    wordTable.Cell(1, 6).Range.Text = "Кол-во аудиторных часов";
                    wordTable.Cell(1, 7).Range.Text = "Календарные сроки";
                    wordTable.Cell(1, 8).Range.Text = "Задания для сам. работ";
                    wordTable.Cell(1, 9).Range.Text = "Кол-во часов для сам. дом. работ";
                    wordTable.Cell(1, 10).Range.Text = "Макс. часов на тему";
                    wordTable.Cell(1, 11).Range.Text = "Уровень освоения";
                    wordTable.Cell(1, 12).Range.Text = "Серийный номер";
                }
                else
                {
                    
                    doc.Content.Text = "Тематический план и содержание учебной дисциплины «" + main.Dis_comboBox.Text + "»";
                    doc.Paragraphs.Add(Type.Missing);
                    
                    wordParag.Range.Tables.Add(wordParag.Range, rowCount, colCount, Type.Missing, Type.Missing);
                    wordTable = doc.Tables[1];
                    object begCell = wordTable.Cell(1, 1).Range.Start;
                    object endCell = wordTable.Cell(1, 3).Range.End;
                    Microsoft.Office.Interop.Word.Range wordcellrange = doc.Range(ref begCell, ref endCell);
                    wordcellrange.Cells.Merge();
                    begCell = wordTable.Cell(1, 2).Range.Start;
                    endCell = wordTable.Cell(1, 5).Range.End;
                    wordcellrange = doc.Range(ref begCell, ref endCell);
                    wordcellrange.Select();
                    WordApp.Selection.Cells.Merge();
                    
                    wordTable.Cell(1, 1).Range.Text = "Наименование разделов и тем";
                    wordTable.Cell(1, 2).Range.Text = "Содержание учебного материала, лабораторные и практические работы, самостоятельная работа обучающихся";
                    wordTable.Cell(1, 3).Range.Text = "Объем часов";
                    wordTable.Cell(1, 4).Range.Text = "Уровень освоения";
                }

                //Задаем рамки ячейкам шапки таблицы.
                for (int i = 1; i <=4 ; i++)
                {
                    wordTable.Cell(1, i).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                    wordTable.Cell(1, i).Range.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                }

                //заполняем ячейки таблицы.
                for (int i = 1; i < rowCount; i++)
                {

                    for (int j = 1; j < colCount+1; j++)
                    {
                        
                        wordTable.Cell(i + 1, j).Range.Text = Convert.ToString(dataGridView1.Rows[i - 1].Cells[j - 1].Value);
                        wordTable.Cell(i + 1, j).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                        wordTable.Cell(i + 1, j).Range.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;

                    }

                }
                
                if (main.rbWorkProgramm.Checked == true)
                {
                    wordTable.Range.Font.Size = 12;
                    object begCell = wordTable.Cell(1, 1).Range.Start;
                    object endCell = wordTable.Cell(1, 1).Range.Start;
                    Microsoft.Office.Interop.Word.Range wordcellrange = doc.Range(ref begCell, ref endCell);
                    //Формирование таблицы в документе word по стандарту
                    colCount = 3;
                    //Объеденяем столбцы: разделы, темы, содержания,наименование.
                    for (int i = 2; i < rowCount+1; i++)
                    {

                        for (int j = 1; j < colCount+1; j++)
                        {

                            //Раздел.
                            if (Convert.ToString(dataGridView1.Rows[i - 2].Cells[j - 1].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[j].Value) == "")
                            {
                                wordTable.Cell(i, j).Range.Text = null;
                                wordTable.Cell(i, j + 2).Range.Text = null;
                                begCell = wordTable.Cell(i, j).Range.Start;
                                endCell = wordTable.Cell(i, j + 2).Range.End;
                               
                               String MergeContent = "Раздел " + Convert.ToString(dataGridView1.Rows[i - 2].Cells[j - 1].Value) + ". " + Convert.ToString(dataGridView1.Rows[i - 2].Cells[j + 1].Value);
                                wordcellrange = doc.Range(ref begCell, ref endCell);
                                wordcellrange.Select();
                                WordApp.Selection.Cells.Merge();
                                wordcellrange.Text = MergeContent;
                                wordTable.Rows[i].Range.Bold = 2;
                                //Для второго столбца
                                begCell = wordTable.Cell(i, j+1).Range.Start;
                                endCell = wordTable.Cell(i, j + 4).Range.End;
                                wordcellrange = doc.Range(ref begCell, ref endCell);
                                wordcellrange.Select();
                                WordApp.Selection.Cells.Merge();
                               

                                break;

                            }
                            //Тема.
                            if (Convert.ToString(dataGridView1.Rows[i - 2].Cells[j - 1].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[j].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[j+2].Value) == "")
                            {
                                wordTable.Cell(i, j).Range.Text = null;
                                wordTable.Cell(i, j + 1).Range.Text = null;
                                wordTable.Cell(i, j + 2).Range.Text = null;
                                begCell = wordTable.Cell(i, j).Range.Start;
                                endCell = wordTable.Cell(i, j + 2).Range.End;

                                String MergeContent = "Тема " + Convert.ToString(dataGridView1.Rows[i - 2].Cells[j - 1].Value) + "." + Convert.ToString(dataGridView1.Rows[i - 2].Cells[j].Value) + ". " + Convert.ToString(dataGridView1.Rows[i - 2].Cells[j + 1].Value);
                                wordcellrange = doc.Range(ref begCell, ref endCell);
                                wordcellrange.Select();
                                WordApp.Selection.Cells.Merge();

                                wordcellrange.Text = MergeContent;
                                wordcellrange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify;
                               
                                //Для второго столбца
                                begCell = wordTable.Cell(i, j + 1).Range.Start;
                                endCell = wordTable.Cell(i, j + 4).Range.End;
                                wordcellrange = doc.Range(ref begCell, ref endCell);
                                wordcellrange.Select();
                                WordApp.Selection.Cells.Merge();

                                wordTable.Cell(i, j + 1).Range.Text = "Содержание учебного материала";
                                wordTable.Cell(i, j + 1).Range.Bold = 2;
                                wordTable.Cell(i, j + 1).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify;
                                break;

                            }
                            //Если есть содержание.
                            if (Convert.ToString(dataGridView1.Rows[i - 2].Cells[j - 1].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[j].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[j + 2].Value) != "")
                            {
                                wordTable.Cell(i, j).Range.Text = null;
                                wordTable.Cell(i, j + 1).Range.Text = null;
                                wordTable.Cell(i, j + 2).Range.Text = null;
                                begCell = wordTable.Cell(i, j).Range.Start;
                                endCell = wordTable.Cell(i, j + 2).Range.End;

                                wordcellrange = doc.Range(ref begCell, ref endCell);
                                wordcellrange.Select();
                                WordApp.Selection.Cells.Merge();

                                wordcellrange.Text = null;

                                break;

                            }
                        }
                       
                    }
                    //Редактирование второго стобца таблицы
                    for (int i = 2; i <= rowCount; i++)
                    {
                       
                        //Содержание. 
                        if (Convert.ToString(dataGridView1.Rows[i - 2].Cells[0].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[1].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[2].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[3].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[5].Value) == "")
                        {
                                wordTable.Cell(i, 3).Range.Text = null;
                                wordTable.Cell(i, 4).Range.Text = null;
                                wordTable.Cell(i, 5).Range.Text = null;
                                begCell = wordTable.Cell(i, 3).Range.Start;
                                endCell = wordTable.Cell(i, 5).Range.End;

                                
                                string Otdel = main.OtdelBox.Text;
                                string Sem = main.Sem_comboBox.Text;
                                string NumGr = main.NumGr_comboBox.Text;
                                string Prep = main.Prep_comboBox.Text;
                                string Dis = main.Dis_comboBox.Text;
                                string sql = "SET names utf8";
                                MySqlCommand cmd = new MySqlCommand(sql, Connetion());
                                string ID_Gr = "";
                                string ID_Prep = "";
                                string ID_Pred = "";
                                string SumAutHour = "";
                                
                               
                                //Расчет значение для запроса.
                                cmd.CommandText = "SELECT ID_Gr FROM groups WHERE department='" + Otdel + "' and half_year=" + Sem + " and Num_Gr=" + NumGr + "";
                                ID_Gr += cmd.ExecuteScalar();
                                cmd.CommandText = "SELECT ID_Prep FROM lecturer WHERE FIO_Lecturer='" + Prep + "'";
                                ID_Prep += cmd.ExecuteScalar();
                                cmd.CommandText = "SELECT ID_Pred FROM discipline WHERE ID_Gr=" + ID_Gr + " and ID_Prep=" + ID_Prep + " and discipline='" + Dis + "'";
                                ID_Pred += cmd.ExecuteScalar();

                                //Cумма Аудиторных часов на тему

                                cmd.CommandText = "SELECT Sum(Hour_Aud) FROM Plan WHERE ID_Pred=" + ID_Pred + " and  theme=" + Convert.ToString(dataGridView1.Rows[i - 2].Cells[1].Value) + " and subsection=" + Convert.ToString(dataGridView1.Rows[i - 2].Cells[0].Value) + " and form IN('Лекция','Урок','Семинар','Контрольная работа','Урок-Лекция')";
                                SumAutHour += cmd.ExecuteScalar();
                            //Если лабораторная
                                 if (Convert.ToString(dataGridView1.Rows[i - 2].Cells[0].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[1].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[2].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[3].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[5].Value) == "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[9].Value) == "Лабораторная работа")
                                 {
                                     cmd.CommandText = "SELECT Sum(Hour_Aud) FROM Plan WHERE ID_Pred=" + ID_Pred + " and  theme=" + Convert.ToString(dataGridView1.Rows[i - 2].Cells[1].Value) + " and subsection=" + Convert.ToString(dataGridView1.Rows[i - 2].Cells[0].Value) + " and form='Лабораторная работа' ";
                                     SumAutHour = "";
                                     SumAutHour += cmd.ExecuteScalar();
                                 }

                                 //Если Практическое занятие
                                 if (Convert.ToString(dataGridView1.Rows[i - 2].Cells[0].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[1].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[2].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[3].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[5].Value) == "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[9].Value) == "Практическое занятие")
                                 {
                                     cmd.CommandText = "SELECT Sum(Hour_Aud) FROM Plan WHERE ID_Pred=" + ID_Pred + " and  theme=" + Convert.ToString(dataGridView1.Rows[i - 2].Cells[1].Value) + " and subsection=" + Convert.ToString(dataGridView1.Rows[i - 2].Cells[0].Value) + " and form='Практическое занятие' ";
                                     SumAutHour = "";
                                     SumAutHour += cmd.ExecuteScalar();
                                 }
                                wordcellrange = doc.Range(ref begCell, ref endCell);
                                wordcellrange.Select();
                                WordApp.Selection.Cells.Merge();
                                wordTable.Cell(i, 3).Range.Text = Convert.ToString(dataGridView1.Rows[i - 2].Cells[9].Value)+":"+"\n"+Convert.ToString(dataGridView1.Rows[i - 2].Cells[2].Value);
                                wordTable.Cell(i, 4).Range.Text = SumAutHour;//Convert.ToString(dataGridView1.Rows[i - 2].Cells[4].Value); 
                                wordTable.Cell(i, 3).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify;
                             
                        }
                       
                        
                        //Самостоятельная работа.
                        if (Convert.ToString(dataGridView1.Rows[i - 2].Cells[0].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[1].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[2].Value) == "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[3].Value) != "" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[5].Value) != "")
                        {
                            wordTable.Cell(i, 2).Range.Text = null;
                            wordTable.Cell(i, 3).Range.Text = null;
                            wordTable.Cell(i, 4).Range.Text = null;
                            wordTable.Cell(i, 5).Range.Text = null;
                            begCell = wordTable.Cell(i, 2).Range.Start;
                            endCell = wordTable.Cell(i, 5).Range.End;

                            string Otdel = main.OtdelBox.Text;
                            string Sem = main.Sem_comboBox.Text;
                            string NumGr = main.NumGr_comboBox.Text;
                            string Prep = main.Prep_comboBox.Text;
                            string Dis = main.Dis_comboBox.Text;
                            string sql = "SET names utf8";
                            MySqlCommand cmd = new MySqlCommand(sql, Connetion());
                            string ID_Gr = "";
                            string ID_Prep = "";
                            string ID_Pred = "";
                          
                            string SumSelfHour = "";
                            //Расчет значение для запроса.
                            cmd.CommandText = "SELECT ID_Gr FROM groups WHERE department='" + Otdel + "' and half_year=" + Sem + " and Num_Gr=" + NumGr + "";
                            ID_Gr += cmd.ExecuteScalar();
                            cmd.CommandText = "SELECT ID_Prep FROM lecturer WHERE FIO_Lecturer='" + Prep + "'";
                            ID_Prep += cmd.ExecuteScalar();
                            cmd.CommandText = "SELECT ID_Pred FROM discipline WHERE ID_Gr=" + ID_Gr + " and ID_Prep=" + ID_Prep + " and discipline='" + Dis + "'";
                            ID_Pred += cmd.ExecuteScalar();

                            
                            cmd.CommandText = "SELECT Sum(time_homework) FROM Plan WHERE ID_Pred=" + ID_Pred + " and  theme=" + Convert.ToString(dataGridView1.Rows[i - 2].Cells[1].Value) + " and subsection=" + Convert.ToString(dataGridView1.Rows[i - 2].Cells[0].Value) + " ";
                            SumSelfHour += cmd.ExecuteScalar();

                            wordcellrange = doc.Range(ref begCell, ref endCell);
                            wordcellrange.Select();
                            WordApp.Selection.Cells.Merge();
                            wordcellrange.Text = null;
                            wordTable.Cell(i,2).Range.Text =Convert.ToString(dataGridView1.Rows[i - 2].Cells[9].Value)+"\n"+Convert.ToString(dataGridView1.Rows[i - 2].Cells[5].Value);
                            wordTable.Cell(i, 3).Range.Text = SumSelfHour;
                            wordTable.Cell(i, 2).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify;
                        }
                        
                    }
                    //Объеденение пустых ячеек с темой
                    rowCount = wordTable.Rows.Count;
                    int h = 0;
                    for (int i = 2; i <= rowCount; i++)
                    {
                        
                        if (Convert.ToString(wordTable.Cell(i, 1).Range.Text) == "\r\a")
                        {

                            begCell = wordTable.Cell(i-1-h, 1).Range.Start;
                            endCell = wordTable.Cell(i, 1).Range.End;
                            wordcellrange = doc.Range(ref begCell, ref endCell);
                            wordcellrange.Select();
                            WordApp.Selection.Cells.Merge();
                            h = h + 1;
                           
                        }
                        else { h = 0; }

                    }
                    //Объеденение для часов
                    rowCount = wordTable.Rows.Count;
                    //Переменные счетчики для объеденения.
                    int laba=0;
                    int Prak = 0;
                    int Sam = 0;
                    h = 0;
                    for (int i = 3; i <= rowCount; i++)
                    {

                        if ( (Convert.ToString(dataGridView1.Rows[i - 3].Cells[9].Value) == "Лекция" || Convert.ToString(dataGridView1.Rows[i - 3].Cells[9].Value) == "Урок" || Convert.ToString(dataGridView1.Rows[i - 3].Cells[9].Value) == "Семинар" || Convert.ToString(dataGridView1.Rows[i - 3].Cells[9].Value) == "Контрольная работа" || Convert.ToString(dataGridView1.Rows[i - 3].Cells[9].Value) == "Урок-Лекция")
                            && (Convert.ToString(dataGridView1.Rows[i - 2].Cells[9].Value) == "Лекция" || Convert.ToString(dataGridView1.Rows[i - 2].Cells[9].Value) == "Урок" || Convert.ToString(dataGridView1.Rows[i - 2].Cells[9].Value) == "Семинар" || Convert.ToString(dataGridView1.Rows[i - 2].Cells[9].Value) == "Контрольная работа" || Convert.ToString(dataGridView1.Rows[i - 2].Cells[9].Value) == "Урок-Лекция"))
                        {
                            wordTable.Cell(i, 4).Range.Text = null;
                            begCell = wordTable.Cell(i - 1 - h, 4).Range.Start;
                            endCell = wordTable.Cell(i, 4).Range.End;
                            wordcellrange = doc.Range(ref begCell, ref endCell);
                            wordcellrange.Select();
                            WordApp.Selection.Cells.Merge();
                            h = h + 1;
                            
                        }
                        else { h = 0; }
                       

                    }
                    //Лабораторная работа
                    for (int i = 3; i <= rowCount; i++)
                    {
                            //Лабораторная работа
                            if (Convert.ToString(dataGridView1.Rows[i - 3].Cells[9].Value) == "Лабораторная работа" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[9].Value) == "Лабораторная работа")
                            {
                                wordTable.Cell(i , 4).Range.Text = null;
                                begCell = wordTable.Cell(i - 1 - laba, 4).Range.Start;
                                endCell = wordTable.Cell(i, 4).Range.End;
                                wordcellrange = doc.Range(ref begCell, ref endCell);
                                wordcellrange.Select();
                                WordApp.Selection.Cells.Merge();
                                
                                laba = laba + 1;
                            }
                            else { laba = 0; }
                    }
                    //Практическая работа
                    for (int i = 3; i <= rowCount; i++)
                    {
                        //Практическое занятие
                        if (Convert.ToString(dataGridView1.Rows[i - 3].Cells[9].Value) == "Практическое занятие" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[9].Value) == "Практическое занятие")
                        {
                            wordTable.Cell(i, 4).Range.Text = null;
                            begCell = wordTable.Cell(i - 1 - Prak, 4).Range.Start;
                            endCell = wordTable.Cell(i, 4).Range.End;
                            wordcellrange = doc.Range(ref begCell, ref endCell);
                            wordcellrange.Select();
                            WordApp.Selection.Cells.Merge();
                           
                            Prak = Prak + 1;
                        }
                        else { Prak = 0; }
                    }
                    //Самостаятельная работа
                    for (int i = 3; i <= rowCount; i++)
                    {
                        //Самостоятельная работа
                        if (Convert.ToString(dataGridView1.Rows[i - 3].Cells[9].Value) == "Самостоятельная работа" && Convert.ToString(dataGridView1.Rows[i - 2].Cells[9].Value) == "Самостоятельная работа")
                        {
                            wordTable.Cell(i, 3).Range.Text = null;
                            begCell = wordTable.Cell(i - 1 - Sam, 3).Range.Start;
                            endCell = wordTable.Cell(i, 3).Range.End;
                            wordcellrange = doc.Range(ref begCell, ref endCell);
                            wordcellrange.Select();
                            WordApp.Selection.Cells.Merge();

                            Sam = Sam + 1;
                        }
                        else { Sam = 0; }
                    }
                    WordApp.Visible = true;
                    WordApp.WindowState = Microsoft.Office.Interop.Word.WdWindowState.wdWindowStateMaximize; //Окно на фул сайз
                    WordApp.Activate(); //Док становится активным
                }
                else
                {

                    WordApp.Visible = true;
                }
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }
        //Событие закрытие формы Table
        private void Table_FormClosed(object sender, FormClosedEventArgs e)
        {

            Plan main = this.Owner as Plan;
            
            main.rbWorkProgramm.Enabled = true;
            main.OtdelBox.Enabled = true;
            main.Sem_comboBox.Enabled = true;
            main.NumGr_comboBox.Enabled = true;
            main.Prep_comboBox.Enabled = true;
            main.Dis_comboBox.Enabled = true;
        }
           
            
        }

    }
    
    

