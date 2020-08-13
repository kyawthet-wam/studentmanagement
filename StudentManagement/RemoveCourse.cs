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
    public partial class RemoveCourse : Form
    {
        Mydb mydb = new Mydb();
        COURSE course = new COURSE();
        int id;
        public RemoveCourse()
        {
            InitializeComponent();
        }

        private void buttonRenove_Click(object sender, EventArgs e)
        {
           
            try
            {
                id = Convert.ToInt32(textBoxCourseId.Text);
                if (MessageBox.Show("Are you sure to delete this course.", "Remove course", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (course.deleteCourse(id))
                    {
                        MessageBox.Show("Successfully delected.", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Course not delected.", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter valid numeric id.", "Invalid field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
