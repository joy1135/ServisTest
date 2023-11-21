using Npgsql;
using ServisTest.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisTest
{
    public partial class TeachForm : Form
    {
        ConnectClass conclass = new ConnectClass();
       
        public TeachForm()
        {
            InitializeComponent();

            string email = Infoclass.email;
            string sql_fio = $"SELECT surname_t, name_t, patronymic_t FROM \"Teachers\" WHERE email_t = @email";
            NpgsqlCommand cmd_select_fio = new NpgsqlCommand(sql_fio, conclass.vCon);
            cmd_select_fio.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = email;
            nameteach.Text = conclass.getfio(cmd_select_fio);
            

        }
        Point lastPoint;

        private void TeachForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TeachForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }



        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nameteach_Leave(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = Infoclass.email;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name_text = poisk.Text;
            string sql_test = $"SELECT name FROM \"Tests\" WHERE name = @name";
            NpgsqlCommand cmd_test = new NpgsqlCommand(sql_test, conclass.vCon);
            cmd_test.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = name_text;
            string n = conclass.getpassword(cmd_test);
            
            if (n == "")
            {
                MessageBox.Show("ТЕСТ НЕ НАЙДЕН");
                return;
            }
            else
            {
                name.Text = n;
                name.Visible = true;
                res_buttom.Visible = true;
            }
        }

        private void res_buttom_Click(object sender, EventArgs e)
        {
            string name_t = name.Text;
            string sql_id = $"SELECT id FROM \"Tests\" WHERE name = @name";
            NpgsqlCommand cmd_id = new NpgsqlCommand(sql_id, conclass.vCon);
            cmd_id.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = name_t;
            int id = Convert.ToInt32(conclass.getpassword(cmd_id));

            string sql_res = $"SELECT surname AS фамилия , \"Students\".name AS имя, result AS результат FROM \"Results\" JOIN \"Students\" ON \"Results\".id_stud = \"Students\".id_student JOIN \"Tests\" ON \"Results\".id_test=\"Tests\".id WHERE \"Tests\".id = @id";
            
            
            
            using (NpgsqlCommand cmd_res = new NpgsqlCommand(sql_res, conclass.vCon))
            {
                cmd_res.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id;


                DataTable dt = conclass.getmultidata(cmd_res);
                dg_result.Visible = true;
                dg_result.DataSource = dt;
            }
        }

        private void test_dt_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Infoclass.id);
            string sql_res = $"SELECT name FROM \"Tests\" JOIN \"Teachers\" AS ts ON  \"Tests\".id_teachers=ts.id_teacher    WHERE id_teacher = @id";

            using (NpgsqlCommand cmd_res = new NpgsqlCommand(sql_res, conclass.vCon))
            {
                cmd_res.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id;
                
                
                DataTable dt = conclass.getmultidata(cmd_res);
                dg_result.Visible = true;
                dg_result.DataSource = dt;
            }
        }

        private void newtest_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateTests createTests = new CreateTests();
            createTests.Show();
        }

        
    }
}
