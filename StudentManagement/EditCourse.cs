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
    public partial class EditCourse : Form
    {
        public EditCourse()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        private void EditCourse_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource = course.getAllCourse();
            comboBoxCourse.DisplayMember = "course_name";
            comboBoxCourse.ValueMember = "id";

            comboBoxCourse.SelectedItem = null;
        }
        public void fillCombo(int index)
        {
            comboBoxCourse.DataSource = course.getAllCourse();
            comboBoxCourse.DisplayMember = "course_name";
            comboBoxCourse.ValueMember = "id";

            comboBoxCourse.SelectedIndex = index;
        }
        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBoxCourse.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                textBoxCourseName.Text = table.Rows[0][1].ToString();
                numericUpDownHourNumber.Value = Int32.Parse(table.Rows[0][2].ToString());
                textBoxDescription.Text = table.Rows[0][3].ToString();

            }
            catch { }
        }

        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            
            try
            {
                string courseName = textBoxCourseName.Text;
                int hrNumber = Convert.ToInt32(numericUpDownHourNumber.Value);
                string description = textBoxDescription.Text;
                int id = (int)comboBoxCourse.SelectedValue;

                if (courseName.Trim() != "")
                {
                    if (!course.checkCourseName(courseName, id))
                    {
                        MessageBox.Show("Course already exists.", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (course.updateCourse(id, courseName, hrNumber, description))
                    {
                        MessageBox.Show("Course updated successfully.", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillCombo(comboBoxCourse.SelectedIndex);
                    }
                    else
                    {
                        MessageBox.Show("Course not updated.", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter course name.", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch {
                MessageBox.Show("No selected course.", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
