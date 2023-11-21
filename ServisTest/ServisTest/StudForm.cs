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
    public partial class StudForm : Form
    {
        ConnectClass conclass = new ConnectClass();
        public StudForm()
        {
            InitializeComponent();
            string email = Infoclass.email;
            string sql_fio = $"SELECT surname_t, name_t, patronymic_t FROM \"Teachers\" WHERE email_t = @email";
            NpgsqlCommand cmd_select_fio = new NpgsqlCommand(sql_fio, conclass.vCon);
            cmd_select_fio.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = email;
            namestud.Text = conclass.getfio(cmd_select_fio);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
