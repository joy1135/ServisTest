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
        public CompletedTestsForm()
        {
            InitializeComponent();
            nametest.Text = Test.nametest; 
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

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
