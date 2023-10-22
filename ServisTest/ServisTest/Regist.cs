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

namespace ServisTest
{
    public partial class Regist : Form
    {
        public Regist()
        {
            InitializeComponent();

            regName.Text = "ИМЯ";
            regSurname.Text = "ФАМИЛИЯ";
            regPatronymic.Text = "ОТЧЕСТВО";
            regEmail.Text = "ЕМАИЛ";
            regPass.Text = "ПАРОЛЬ";
            regRepPass.Text = "ПОВТОРИТЕ ПАРОЛЬ";
        }
        

        private void Regist_Load(object sender, EventArgs e)
        {

        }



        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regName_Enter(object sender, EventArgs e)
        {
            if (regName.Text == "ИМЯ")
            {
                regName.Text = "";
            }
        }

        private void regName_Leave(object sender, EventArgs e)
        {
            if (regName.Text == "")
            {
                regName.Text = "ИМЯ";
            }
        }

        private void regSurname_Enter(object sender, EventArgs e)
        {
            if (regSurname.Text == "ФАМИЛИЯ")
            {
                regSurname.Text = "";
            }
        }

        private void regSurname_Leave(object sender, EventArgs e)
        {
            if (regSurname.Text == "")
            {
                regSurname.Text = "ФАМИЛИЯ";
            }
        }

        private void regPatronymic_Enter(object sender, EventArgs e)
        {
            if (regPatronymic.Text == "ОТЧЕСТВО")
            {
                regPatronymic.Text = "";
            }
        }

        private void regPatronymic_Leave(object sender, EventArgs e)
        {
            if (regPatronymic.Text == "")
            {
                regPatronymic.Text = "ОТЧЕСТВО";
            }
        }

        private void regEmail_Enter(object sender, EventArgs e)
        {
            if (regEmail.Text == "ЕМАИЛ")
            {
                regEmail.Text = "";
            }
        }

        private void regEmail_Leave(object sender, EventArgs e)
        {
            if (regEmail.Text == "")
            {
                regEmail.Text = "ЕМАИЛ";
            }
        }

        private void regPass_Enter(object sender, EventArgs e)
        {
            if (regPass.Text == "ПАРОЛЬ")
            {
                regPass.Text = "";
            }
        }

        private void regPass_Leave(object sender, EventArgs e)
        {
            if (regPass.Text == "")
            {
                regPass.Text = "ПАРОЛЬ";
            }
        }

        private void regRepPass_Enter(object sender, EventArgs e)
        {
            if (regRepPass.Text == "ПОВТОРИТЕ ПАРОЛЬ")
            {
                regRepPass.Text = "";
            }
        }

        private void regRepPass_Leave(object sender, EventArgs e)
        {
            if (regRepPass.Text == "")
            {
                regRepPass.Text = "ПОВТОРИТЕ ПАРОЛЬ";
            }
        }
        ConnectClass conclass = new ConnectClass();
        private void regButtom_Click(object sender, EventArgs e)
        {
            string name = regName.Text;
            string surname = regSurname.Text;
            string patronymic = regPatronymic.Text;
            if (regPatronymic.Text == "ОТЧЕСТВО")
            {
                patronymic = "";
            }
            string email = regEmail.Text;
            string password = regPass.Text;
            string reppass = regRepPass.Text;
            if (reppass == password)
            {
                if (regTeach.Checked == true)
                {
                    DataTable dtgetdata = new DataTable();
                   
                    dtgetdata = conclass.getdata($"INSERT INTO \"Teachers\" (name_t , surname_t, patronymic_t, email_t, password_t) VALUES( '{name}', '{surname}', '{patronymic}', '{email}', '{password}')");

                }
                if (regStud.Checked == true)
                {
                    DataTable dtgetdata = new DataTable();
                   
                    dtgetdata = conclass.getdata($"INSERT INTO \"Students\" (name , surname, patronymic, email, password) VALUES( '{name}', '{surname}', '{patronymic}', '{email}', '{password}')");
                }
            }
            else 
            {
                MessageBox.Show("ПАРОЛИ НЕ СОВПОДАЮТ!!!");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
