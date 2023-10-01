﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WPandCPL
{
    public partial class Support : Form
    {
        public Support(Plan ParrentForm)
        {
            InitializeComponent();
        }

        private void btn_ExitSupport_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DobPrepSup_Click(object sender, EventArgs e)
        {
            lbl_textSup.Text = "Для того, что бы добавить преподавателя необходимо нажать на форме 'Plan' на кнопку 'Добавить преподавателя'. Откроется форма добавления преподавателей, на которой пользователю необходимо заполнить поле 'ФИО преподавателя' и нажать кнопку 'Добавить'. Для закрытия формы необходимо нажать на кнопку 'Закрыть форму'.";
        }

        private void btn_DobGrSup_Click(object sender, EventArgs e)
        {
            lbl_textSup.Text = "Для того, что бы добавить группу необходимо нажать на форме 'Plan' на кнопку 'Добавить группу'. Откроется форма добавления групп, на которой пользователю необходимо заполнить поля отделения, семестра, номера группы, начальной и конечной недели и нажать кнопку 'Добавить'. Для закрытия формы необходимо нажать на кнопку 'Закрыть форму'.";
        }

        private void btn_DopDisSup_Click(object sender, EventArgs e)
        {
            lbl_textSup.Text = "Для того, что бы добавить дисциплину необходимо нажать на форме 'Plan' на кнопку 'Добавить дисциплину'. Откроется форма добавления дисциплин, на которой пользователю необходимо заполнить поля отделения, семестра, номера группы, преподавателя, наименования дисциплины, часов в неделю, часов всего и нажать кнопку 'Добавить'. Для того, что бы очистить поля формы необходимо нажать на кнопку 'Очистить'.Для закрытия формы необходимо нажать на кнопку 'Закрыть форму'.";
        }

        private void btn_ExitProgSup_Click(object sender, EventArgs e)
        {
            lbl_textSup.Text = "Для того, что бы выйти из программы необходимо нажать на форме 'Рабочие программы и календарные планы преподавателей' на кнопку 'Выход'";
        }

        private void btn_DobRedSup_Click(object sender, EventArgs e)
        {
            lbl_textSup.Text = "Для того, что бы добавить рабочие программы или календарные планы преподавателей необходимо последовательно заполнить поля отделения, семестра, номера группы, преподавателя, дисциплины, наименования разделов, задания для обучающегося, вида занятия, уровня освоения, объёма аудит и сам часов и календарные сроки на форме 'Рабочие программы и календарные планы преподавателей', затем нажать на кнопку 'Добавить запись'. Для редактирования рабочих программ и календарных планов преподавателей по введённым отделению, семестру, номеру группы, преподавателю и дисциплине необходимо заполнить поля отделения, семестра, номера группы, преподавателя и дисциплины и нажать на кнопку 'Редактировать рабочие программы и календарные планы'";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbl_textSup.Text = "Для того, что бы сформировать отчёт рабочих программ или календарных планов необходимо на форме 'Plan' заполнить поля отделения, семестра, номера группы, преподавателя, дисциплины, нажать на кнопку 'Просмотреть отчёт рабочих программ' или 'Просмотреть отчёт календарных планов'. После просмотра отчёта необходимо на форме 'Plan' нажать на кнопку 'Сформировать отчёт рабочих программ' или 'Сформировать отчёт календарных планов'. На появившемся окне выбрать тип создаваемого документа, нажать кнопку 'Ок', выбрать имя и путь для создаваемого документа, надать на кнопку 'Ок'";
        }

        private void Support_Load(object sender, EventArgs e)
        {
            lbl_textSup.Text = "Добро пожаловать в справочную систему программы 'Рабочие программы и календарные планы преподавателей'. Выберите действие, о котором хотите узнать подробнее.";
        }
    }
}
