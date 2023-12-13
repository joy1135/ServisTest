using Npgsql;
using ServisTest.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisTest
{
    public partial class StudForm : Form
    {
        ConnectClass conclass = new ConnectClass();
        Point lastPoint;


        private void StudForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }
        private void StudForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }


        public StudForm()
        {
            InitializeComponent();
            string email = Infoclass.email;
            string sql_fio = $"SELECT surname, name, patronymic FROM \"Students\" WHERE email = @email";
            NpgsqlCommand cmd_select_fio = new NpgsqlCommand(sql_fio, conclass.vCon);
            cmd_select_fio.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = email;
            namestud.Text = conclass.getfio(cmd_select_fio);
            string id = Infoclass.id;
            string sql_tests = $"Select t.id AS номер_теста, t.name AS название_теста, r.result AS результат FROM \"Tests\" AS t LEFT JOIN \"Results\" as r on r.id_test = t.id WHERE id_stud = @id OR id > 0 ORDER BY id";
            NpgsqlCommand cmd_tests = new NpgsqlCommand(sql_tests, conclass.vCon);
            cmd_tests.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = id;
            DataTable dt = conclass.getmultidata(cmd_tests);
            dg_tests.DataSource = dt;
        }


        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void dg_tests_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1 & e.RowIndex > -1)
            {
                name.Text = this.ActiveControl.Text;
                if (name.Text != "")
                {
                    name.Visible = true;
                    compl_buttom.Visible = true;
                    name.Text = this.ActiveControl.Text;
                    Test.nametest = this.ActiveControl.Text;
                }
                else
                {
                    name.Visible = false;
                    compl_buttom.Visible = false;
                }
            }
            else
            {
                return;
            }
        }

        

        private void compl_buttom_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompletedTestsForm completedTestsForm = new CompletedTestsForm();
            completedTestsForm.Show();

        }
    }
}
