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
    
    public partial class ManageCourse : Form
    {
        public ManageCourse()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        int pos;
        private void ManageCourse_Load(object sender, EventArgs e)
        {
            reloadlistBox();
        }
        public void reloadlistBox()
        {
            listBoxCourses.DataSource = course.getAllCourse();
            listBoxCourses.ValueMember = "id";
            listBoxCourses.DisplayMember = "course_name";

            listBoxCourses.SelectedItem = null;
            labelTotalCourse.Text = "Total Course: " + course.totalCourse();
        }

        void showData(int index)
        {
            try
            {
                DataRow dataRow = course.getAllCourse().Rows[index];
                listBoxCourses.SelectedIndex = index;
                textBoxCourseId.Text = dataRow.ItemArray[0].ToString();
                textBoxCourseName.Text = dataRow.ItemArray[1].ToString();
                numericUpDownHourNumber.Value = int.Parse(dataRow.ItemArray[2].ToString());
                textBoxDescription.Text = dataRow.ItemArray[3].ToString();

            }
            catch { }

        }

        

        private void listBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pos = listBoxCourses.SelectedIndex;
                showData(pos);
            }
            catch { }

        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            pos = pos + 1;
            showData(pos);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            pos = pos - 1;
            showData(pos);
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourse().Rows.Count - 1;
            showData(pos);
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
                    reloadlistBox();
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

        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            try
            {
                string courseName = textBoxCourseName.Text;
                int hrNumber = Convert.ToInt32(numericUpDownHourNumber.Value);
                string description = textBoxDescription.Text;
                int id = Convert.ToInt32(textBoxCourseId.Text);

                if (courseName.Trim() != "")
                {
                    if (!course.checkCourseName(courseName, id))
                    {
                        MessageBox.Show("Course already exists.", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (course.updateCourse(id, courseName, hrNumber, description))
                    {
                        MessageBox.Show("Course updated successfully.", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadlistBox();

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
            catch
            {
                MessageBox.Show("No selected course.", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pos = 0;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxCourseId.Text);
                if (MessageBox.Show("Are you sure to delete this course.", "Remove course", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (course.deleteCourse(id))
                    {
                        MessageBox.Show("Successfully delected.", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadlistBox();
                        textBoxCourseId.Text = "";
                        textBoxCourseName.Text = "";
                        numericUpDownHourNumber.Value = 10;
                        textBoxDescription.Text = "";
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
            pos=0;
        }
    }
}
