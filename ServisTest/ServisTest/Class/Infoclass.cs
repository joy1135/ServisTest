using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisTest.Class
{
    static class Infoclass
    {
        public static string email;
        public static string id;
        
    }
    class Test
    {
        public static string nametest;
        public static int id_test;
        public static int c_question;
        public static int i = 0;
        public static int count;
        public static bool check_compl;
        public static List<Question> Questions;
    }
    class Question
    {
        public Question(string questionText, string option1, string option2, string option3, string option4, string correct)
        {
            QuestionText = questionText;
            Option1 = option1;
            Option2 = option2;
            Option3 = option3;
            Option4 = option4;
            Correct = correct;
        }

        public string QuestionText { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Correct { get; set; }
    }

}
