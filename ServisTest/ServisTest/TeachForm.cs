﻿using ServisTest.Class;
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
           
        }

        

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
