﻿using System;
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
        
        Point lastPoint;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
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
            Infoclass.email = logEmail.Text;
            string sql_select_password = $"SELECT password_t FROM \"Teachers\" WHERE email_t = @email";
            NpgsqlCommand cmd_select_password = new NpgsqlCommand(sql_select_password, conclass.vCon);
            cmd_select_password.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar).Value = password;
            cmd_select_password.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = email;
            string check_password = conclass.getpassword(cmd_select_password);
            if (check_password == "")
            {
                MessageBox.Show("НЕПРАВИЛЬНЫЙ ЛОГИН ИЛИ ПАРОЛЬ");
                return ;
            }
            
             bool pass = BCrypt.Net.BCrypt.Verify(password, check_password);
           
            
            if (logTeach.Checked == true)
            {
                if (pass == true)
                {
                    
                    string sql_id = $"SELECT id_teacher FROM \"Teachers\" WHERE email_t = @email";
                    NpgsqlCommand cmd_id = new NpgsqlCommand(sql_id, conclass.vCon);
                    cmd_id.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = email;
                    Infoclass.id = conclass.getpassword(cmd_id);
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
                if (pass == true)
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

        private void checkpass_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkpass.Checked == false)
            {
                logPass.UseSystemPasswordChar = true;


                logPass.PasswordChar = '*';
            }
            else
            {
                logPass.UseSystemPasswordChar = false;


            }
        }
    }
}
