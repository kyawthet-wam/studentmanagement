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
    public partial class ManageScore : Form
    {
        public ManageScore()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        COURSE course = new COURSE();
        STUDENT std = new STUDENT();
        private void ManageScore_Load(object sender, EventArgs e)
        {
            
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = score.getStudentScore();
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
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(textBoxId.Text);
                int courseId = Convert.ToInt32(comboBoxCourse.SelectedValue);
                double scoreValue = Convert.ToDouble(textBoxScore.Text);
                string description = textBoxDescription.Text;

                if (!score.checkUnique(studentId, courseId))
                {
                    if (score.insertScore(studentId, courseId, scoreValue, description))
                    {
                        MessageBox.Show("Student score added successfully.", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = score.getStudentScore();
                    }
                    else
                    {
                        MessageBox.Show("Student score not added.", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Student score already exists.", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

            int studentId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int courseId = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            textBoxId.Text = studentId.ToString();
            
            if (MessageBox.Show("Are you sure to delete this score.", "Delete score", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (score.deleteScore(studentId, courseId))
                {
                    MessageBox.Show("Successfully delected.", "Delete score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = score.getStudentScore();
                }
                else
                {
                    MessageBox.Show("Score not delected.", "Delete score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonStudentList_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT `id`,`name`,`birthdate` FROM `student`");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = std.getStudents(command);
        }

        private void buttonShowStudentScore_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentScore();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxCourse.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxScore.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           
           
        }

       
    }
}
