using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using ServisTest.Class;
using BCrypt;

namespace ServisTest
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            logEmail.Text = "ЕМАИЛ";
            logPass.Text = "ПАРОЛЬ";
        }
       
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logEmail_Enter(object sender, EventArgs e)
        {
            if (logEmail.Text == "ЕМАИЛ")
            {
                logEmail.Text = "";
            }
        }

        private void logEmail_Leave(object sender, EventArgs e)
        {
            if (logEmail.Text == "")
            {
                logEmail.Text = "ЕМАИЛ";
            }
        }

        private void logPass_Enter(object sender, EventArgs e)
        {
            if (logPass.Text == "ПАРОЛЬ")
            {
                logPass.Text = "";
            }
        }

        private void logPass_Leave(object sender, EventArgs e)
        {
            if (logPass.Text == "")
            {
                logPass.Text = "ПАРОЛЬ";
            }
        }

        private void logRegit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regist regist = new Regist();
            regist.Show();
        }
        ConnectClass conclass = new ConnectClass();
        private void logButtom_Click(object sender, EventArgs e)
        {
            string email = logEmail.Text;
            string password = logPass.Text;
            DataTable dtgetdata = new DataTable();
            if(logTeach.Checked == true)
            {
                dtgetdata = conclass.getdata($"SELECT * FROM \"Teachers\" WHERE email_t = '{email}' AND password_t = '{password}'");
                if (dtgetdata.Rows.Count > 0)
                {
                    this.Hide();
                    TeachForm teachForm = new TeachForm();
                    teachForm.Show();
                }
                else
                {
                    MessageBox.Show("НЕПРАВИЛЬНЫЙ ЛОГИН ИЛИ ПАРОЛЬ");
                }
            }
            if (logStud.Checked == true) 
            {
                dtgetdata = conclass.getdata($"SELECT * FROM \"Students\" WHERE email = '{email}' AND password = '{password}'");
                if (dtgetdata.Rows.Count > 0)
                {
                    this.Hide();
                    StudForm studForm = new StudForm();
                    studForm.Show();
                }
                else
                {
                    MessageBox.Show("НЕПРАВИЛЬНЫЙ ЛОГИН ИЛИ ПАРОЛЬ");
                }
            }
                
        }
    }
}
