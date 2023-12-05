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
    public partial class CreateTests : Form
    {
        ConnectClass conclass = new ConnectClass();

        public CreateTests()
        {
            InitializeComponent();
            Test.i = 0;
        }

        Point lastPoint;
        private void CreateTests_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void CreateTests_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachForm teachForm = new TeachForm();
            teachForm.Show();
        }

        private void add_name_Click(object sender, EventArgs e)
        {
            conclass.connection();
            Test.nametest = name_test.Text;
            try
            {
                Test.c_question = Convert.ToInt32(count_question.Text);
            }
            catch
            {
                MessageBox.Show("ВВЕДИТЕ ЧИСЛО!!!");
                return; 
            }
            if (Test.c_question > 0)
            {



                string sql_insert_test = $"INSERT INTO \"Tests\" (name , id_teachers, max_score) VALUES( @name, @id_teachers, @max_score)";
                NpgsqlCommand cmd_insert_test = new NpgsqlCommand(sql_insert_test, conclass.vCon);
                cmd_insert_test.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Convert.ToString(Test.nametest);
                cmd_insert_test.Parameters.Add("@id_teachers", NpgsqlTypes.NpgsqlDbType.Bigint).Value = Convert.ToInt32(Infoclass.id);
                cmd_insert_test.Parameters.Add("@max_score", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(Test.c_question);
                if(Convert.ToString(Test.nametest) == "")
                {
                    MessageBox.Show("ВВЕДИТЕ НАЗВАНИЕ ТЕСТА");
                    return;
                }
                try
                {
                    cmd_insert_test.ExecuteReader();
                }
                catch
                {
                    MessageBox.Show("Название уже используется");
                    return;
                }
                MessageBox.Show("Название успешно добавлено");
                add_name.Visible = false;
                name_test.Visible = false;
                label6.Visible = false;
                count_question.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                question_tb.Visible = true;
                answer1.Visible = true;
                answer2.Visible = true;
                answer3.Visible = true;
                answer4.Visible = true;
                correct1.Visible = true;
                correct2.Visible = true;
                correct3.Visible = true;
                correct4.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                correct1.Checked = false;
                correct2.Checked = false;
                correct3.Checked = false;
                correct4.Checked = false;
                add_question.Visible = true;
            }
            else
            {
                MessageBox.Show("ВВЕДИТЕ ПОЛОЖИТЕЛЬНОЕ ЧИСЛО");
            }
        }

        private void add_question_Click(object sender, EventArgs e)
        {
            conclass.connection();
            string question = question_tb.Text;
            string answ1 = answer1.Text;
            string answ2 = answer2.Text;
            string answ3 = answer3.Text;
            string answ4 = answer4.Text;
            bool cor_answ1 = correct1.Checked;
            bool cor_answ2 = correct2.Checked;
            bool cor_answ3 = correct3.Checked;
            bool cor_answ4 = correct4.Checked;
            string sql_insert_question = $"INSERT INTO \"Questions\" ( id_test, question, option1, option2, option3, option4, correct_answer) VALUES( (SELECT id FROM \"Tests\" WHERE name = @name),@question,@option1,@option2,@option3,@option4,@correct_answer)";
            NpgsqlCommand cmd_insert_question = new NpgsqlCommand(sql_insert_question, conclass.vCon);
            cmd_insert_question.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Convert.ToString(Test.nametest);
            cmd_insert_question.Parameters.Add("@question", NpgsqlTypes.NpgsqlDbType.Varchar).Value = question;
            cmd_insert_question.Parameters.Add("@option1", NpgsqlTypes.NpgsqlDbType.Varchar).Value = answ1;
            cmd_insert_question.Parameters.Add("@option2", NpgsqlTypes.NpgsqlDbType.Varchar).Value = answ2;
            cmd_insert_question.Parameters.Add("@option3", NpgsqlTypes.NpgsqlDbType.Varchar).Value = answ3;
            cmd_insert_question.Parameters.Add("@option4", NpgsqlTypes.NpgsqlDbType.Varchar).Value = answ4;
            if (cor_answ1 == true)
            {
                cmd_insert_question.Parameters.Add("@correct_answer", NpgsqlTypes.NpgsqlDbType.Varchar).Value = answ1;
                cmd_insert_question.ExecuteReader();
            }
            else if (cor_answ2 == true)
            {
                cmd_insert_question.Parameters.Add("@correct_answer", NpgsqlTypes.NpgsqlDbType.Varchar).Value = answ2;
                cmd_insert_question.ExecuteReader();
            }
            else if (cor_answ3 == true)
            {
                cmd_insert_question.Parameters.Add("@correct_answer", NpgsqlTypes.NpgsqlDbType.Varchar).Value = answ3;
                cmd_insert_question.ExecuteReader();
            }
            else if (cor_answ4 == true)
            {
                cmd_insert_question.Parameters.Add("@correct_answer", NpgsqlTypes.NpgsqlDbType.Varchar).Value = answ4;
                cmd_insert_question.ExecuteReader();
            }
            else
            {
                MessageBox.Show("Выберете правильный ответ!!!");
                return;
            }
            
            MessageBox.Show("Вопрос успешно добавлен");
            question_tb.Text = "";
            answer1.Text = "";
            answer2.Text = "";
            answer3.Text = "";
            answer4.Text = "";
            correct1.Checked = false;
            correct2.Checked = false;
            correct3.Checked = false;
            correct4.Checked = false;
            Test.i += 1;
           
            if (Test.i == Test.c_question)
            {
                MessageBox.Show("Тест успешно создан");
                this.Hide();
                TeachForm teachForm = new TeachForm();
                teachForm.Show();
            }
           
        }

        private void count_question_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
