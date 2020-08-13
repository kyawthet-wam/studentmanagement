using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            String courseName = textBoxCourseName.Text;
            int hrNumber = (int)numericUpDownHourNumber.Value;
            String description = textBoxDescription.Text;

            COURSE c = new COURSE();
            if (courseName.Trim() == "")
            {
                MessageBox.Show("Add a course name.", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (c.checkCourseName(courseName))
            {
                if (c.insertCourse(courseName, hrNumber, description))
                {
                    MessageBox.Show("Course inserted successfully.", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course not inserted.", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Course already exists.", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
