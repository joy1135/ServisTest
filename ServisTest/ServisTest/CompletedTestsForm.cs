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
    public partial class CompletedTestsForm : Form
    {
        ConnectClass conclass = new ConnectClass();
        public CompletedTestsForm()
        {
            InitializeComponent();
            nametest.Text = Test.nametest;

            
            string sql_count_que = $"SELECT max_score FROM \"Tests\" WHERE \"name\" = @name_test";
            NpgsqlCommand cmd_count_que = new NpgsqlCommand(sql_count_que, conclass.vCon);
            cmd_count_que.Parameters.Add("@name_test", NpgsqlTypes.NpgsqlDbType.Varchar).Value = nametest.Text;
            int k = Convert.ToInt32(conclass.getpassword(cmd_count_que));
            Test.count = k-1;
            string sql_id_test = $"SELECT id FROM \"Tests\" WHERE name = @name_test";
            NpgsqlCommand cmd_id_test = new NpgsqlCommand(sql_id_test, conclass.vCon);
            cmd_id_test.Parameters.Add("@name_test", NpgsqlTypes.NpgsqlDbType.Varchar).Value = nametest.Text;
            Test.id_test = Convert.ToInt32(conclass.getpassword(cmd_id_test));

            string sql_check_compl = $"SELECT result FROM \"Results\" WHERE id_test = @id_test and id_stud = @id_stud";
            NpgsqlCommand cmd_check_compl = new NpgsqlCommand(sql_check_compl, conclass.vCon);
            cmd_check_compl.Parameters.Add("@id_test", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(Test.id_test);
            cmd_check_compl.Parameters.Add("@id_stud", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(Infoclass.id);
            if(conclass.getpassword(cmd_check_compl) != "")
            {
                Test.check_compl = true;
            }
            else
            {
                Test.check_compl = false;
            }
            

            string sql_question = $"SELECT question, option1, option2, option3, option4, correct_answer FROM \"Questions\" WHERE id_test = @id_test";
            NpgsqlCommand cmd_question = new NpgsqlCommand(sql_question, conclass.vCon);
            cmd_question.Parameters.Add("@id_test", NpgsqlTypes.NpgsqlDbType.Integer).Value = Test.id_test;
            DataTable que = conclass.getmultidata(cmd_question);
            Test.Questions= que.AsEnumerable().Select(row => new Question(
                row.Field<string>("question"),
                row.Field<string>("option1"),
                row.Field<string>("option2"),
                row.Field<string>("option3"),
                row.Field<string>("option4"),
                row.Field<string>("correct_answer")
            )).ToList();
            question_tb.Text = Test.Questions[Test.count].QuestionText.ToString();
            answer1.Text = Test.Questions[Test.count].Option1.ToString();
            answer2.Text = Test.Questions[Test.count].Option2.ToString();
            answer3.Text = Test.Questions[Test.count].Option3.ToString();
            answer4.Text = Test.Questions[Test.count].Option4.ToString();
            Test.c_question = Test.count;
            Test.count -= 1;
            
        }
        Point lastPoint;

        private void CompletedTestsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void CompletedTestsForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        

        private void add_question_Click(object sender, EventArgs e)
        {
          
            if (correct1.Checked == true || correct2.Checked == true || correct3.Checked == true || correct4.Checked == true)
            {
                if (Test.count == 0)
                {
                    add_question.Text = "ЗАКОНЧИТЬ ТЕСТ";
                }
                if (correct1.Checked == true)
                {
                    if (answer1.Text == Test.Questions[Test.c_question].Correct.ToString())
                    {
                        Test.i += 1;
                    }
                }
                else if (correct2.Checked == true)
                {
                    if (answer2.Text == Test.Questions[Test.c_question].Correct.ToString())
                    {
                        Test.i += 1;
                    }
                }
                else if (correct3.Checked == true)
                {
                    if (answer3.Text == Test.Questions[Test.c_question].Correct.ToString())
                    {
                        Test.i += 1;
                    }
                }
                else
                {
                    if (answer4.Text == Test.Questions[Test.c_question].Correct.ToString())
                    {
                        Test.i += 1;
                    }
                }
                Test.c_question -= 1;
                if (Test.count == -1)
                {
                    MessageBox.Show($"Ваш результат: {Test.i.ToString()}");
                    string sql_select_max_score = $"SELECT max_score FROM \"Tests\" WHERE id = @id_test";
                    NpgsqlCommand cmd_max_score = new NpgsqlCommand(sql_select_max_score, conclass.vCon);
                    cmd_max_score.Parameters.Add("@id_test", NpgsqlTypes.NpgsqlDbType.Integer).Value = Test.id_test;
                    int perfect = Convert.ToInt32(conclass.getpassword(cmd_max_score));
                    double satisfactory = perfect * 0.5;
                    double good = perfect * 0.7;
                    int score;
                    if (Test.i >= perfect * 0.9)
                    {
                        MessageBox.Show("Оценка 5");
                        score = 5;
                    }
                    else if(Test.i >= good && Test.i < perfect)
                    {
                        MessageBox.Show("Оценка 4");
                        score = 4;
                    }
                    else if(Test.i >= satisfactory && Test.i < good) 
                    {
                        MessageBox.Show("Оценка 3");
                        score = 3;
                    }
                    else
                    {
                        MessageBox.Show("Оценка 2");
                        score = 2;
                    }
                    if(Test.check_compl == true)
                    {
                        conclass.connection();
                        string sql_up_res = $"UPDATE \"Results\" SET result = @i , score = @score WHERE id_stud = @id_stud and id_test = @id_test";
                        NpgsqlCommand cmd_up_res= new NpgsqlCommand(sql_up_res, conclass.vCon);
                        cmd_up_res.Parameters.Add("@i", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(Test.i);
                        cmd_up_res.Parameters.Add("@score", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(score);
                        cmd_up_res.Parameters.Add("@id_stud", NpgsqlTypes.NpgsqlDbType.Bigint).Value = Convert.ToInt32(Infoclass.id);
                        cmd_up_res.Parameters.Add("@id_test", NpgsqlTypes.NpgsqlDbType.Bigint).Value = Convert.ToInt32(Test.id_test);
                        cmd_up_res.ExecuteReader();
                       
                    }
                    else
                    {
                        conclass.connection();
                        string sql_ins_res = $"INSERT INTO \"Results\" (id_stud , id_test, result, score) VALUES( @id_stud, @id_test, @i, @score)";
                        NpgsqlCommand cmd_ins_res = new NpgsqlCommand(sql_ins_res, conclass.vCon);
                        cmd_ins_res.Parameters.Add("@i", NpgsqlTypes.NpgsqlDbType.Integer).Value = Test.i;
                        cmd_ins_res.Parameters.Add("@score", NpgsqlTypes.NpgsqlDbType.Integer).Value = score;
                        cmd_ins_res.Parameters.Add("@id_stud", NpgsqlTypes.NpgsqlDbType.Bigint).Value = Convert.ToInt32(Infoclass.id);
                        cmd_ins_res.Parameters.Add("@id_test", NpgsqlTypes.NpgsqlDbType.Bigint).Value = Convert.ToInt32(Test.id_test);
                        cmd_ins_res.ExecuteReader();
                    }
                    
                    this.Hide();
                    StudForm studForm = new StudForm();
                    studForm.Show();
                    return;

                    
                }
                question_tb.Text = Test.Questions[Test.count].QuestionText.ToString();
                answer1.Text = Test.Questions[Test.count].Option1.ToString();
                answer2.Text = Test.Questions[Test.count].Option2.ToString();
                answer3.Text = Test.Questions[Test.count].Option3.ToString();
                answer4.Text = Test.Questions[Test.count].Option4.ToString();
                Test.count -= 1;
            }
            else 
            {
                return;
            }
            

        }
    }
}
