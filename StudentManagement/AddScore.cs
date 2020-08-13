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
    public partial class AddScore : Form
    {
        public AddScore()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        STUDENT std = new STUDENT();
        COURSE course = new COURSE();

        private void AddScore_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource = course.getAllCourse();
            comboBoxCourse.ValueMember = "id";
            comboBoxCourse.DisplayMember = "course_name";

            MySqlCommand command = new MySqlCommand("SELECT `id`, `name` FROM `student`");
            dataGridView1.DataSource = std.getStudents(command);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonAddScore_Click(object sender, EventArgs e)
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
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Add score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
