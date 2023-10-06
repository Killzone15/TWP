using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TWP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void comboBoxLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            mskPassword.Text = "";
            if (comboBoxLogin.SelectedIndex == 0)
            {
                mskPassword.Enabled = true;
            }
            else { mskPassword.Enabled = false; }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            string password = "MAI";
            if (comboBoxLogin.Text == "")
            {
                MessageBox.Show("Пользователь не выбран!!!");
            }
            else
            {

                if (comboBoxLogin.SelectedIndex == 0)
                {

                    if (mskPassword.Text == password)
                    {
                        Plan main = this.Owner as Plan;
                        main.Dob_Dis.Enabled = true;
                        main.Dob_Prep.Enabled = true;
                        main.Dob_Gr.Enabled = true;
                        
                        MessageBox.Show("Вы вошли как МЕТОДИСТ!");
                        this.Close();
                    }
                    else { MessageBox.Show("Пароль не верен!"); }

                }
                else
                {
                    mskPassword.Enabled = false;
                    Plan main = this.Owner as Plan;
                    main.Dob_Dis.Enabled = false;
                    main.Dob_Prep.Enabled = false;
                    main.Dob_Gr.Enabled = false;
                    
                    MessageBox.Show("Вы вошли как ПРЕПОДАВАТЕЛЬ!");
                    this.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //полный выход из ПО
            Application.Exit();
        }

    }
}
