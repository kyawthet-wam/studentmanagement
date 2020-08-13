using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

       
        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

     

        private void login_Click(object sender, EventArgs e)
        {
            Mydb db = new Mydb();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username`= @usn AND `password` = @pass", db.getConnection);
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUserName.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid username or password","Login error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
