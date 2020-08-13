using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace project
{
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            fillGrid(new MySqlCommand("SELECT * FROM `student`"));
        }

        public void fillGrid(MySqlCommand command)
        {
            
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.DataSource = student.getStudents(command);
            dataGridView1.Columns["picture"].Visible = false;
            pic = (DataGridViewImageColumn)dataGridView1.Columns[7];
            pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

            labelTotalStudent.Text = "Total Student:" + dataGridView1.Rows.Count;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[2].Value;
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Female")
            {
                radioButtonFemale.Checked = true;
            }
            else
            {
                radioButtonMale.Checked = true;
            }
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxStudentImage.Image = Image.FromStream(picture);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            textBoxEmail.Text = "";
            radioButtonMale.Checked = true;
            pictureBoxStudentImage.Image = null;
            fillGrid(new MySqlCommand("SELECT * FROM `student`"));
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = "Student_" + textBoxId.Text;

            if (pictureBoxStudentImage.Image == null)
            {
                MessageBox.Show("No picture to download", "Empty field in picture box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (svf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image.Save(svf.FileName + ("." + ImageFormat.Jpeg.ToString()));
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`name`,`address`) LIKE'%" + textBoxSearch.Text + "%'");
            fillGrid(command);
            if(textBoxSearch.Text ==null)
            {
                fillGrid(new MySqlCommand("SELECT * FROM `student`"));
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            STUDENT std = new STUDENT();
            String name = textBoxName.Text;
            DateTime bDate = dateTimePicker1.Value;
            String phone = textBoxPhone.Text;
            String email = textBoxEmail.Text;
            String address = textBoxAddress.Text;
            String gender = "Male";

            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();

            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year < 10 || this_year - born_year > 100))
            {
                MessageBox.Show("Student age must be between 10 and 100 year", "Invalid birth date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Verify())
            {
                pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);
                if ((std.insertStudent(name, bDate, gender, phone, email, address, pic)))
                {
                    MessageBox.Show("New student added", "Successfully added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new MySqlCommand("SELECT * FROM `student`"));
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        bool Verify()
        {
            if ((textBoxName.Text.Trim() == "") ||
               (textBoxPhone.Text.Trim() == "") ||
               (textBoxPhone.Text.Trim() == "") ||
               (textBoxAddress.Text.Trim() == "") ||
               (pictureBoxStudentImage.Image == null)
                )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                String name = textBoxName.Text;
                DateTime bDate = dateTimePicker1.Value;
                String phone = textBoxPhone.Text;
                String email = textBoxEmail.Text;
                String address = textBoxAddress.Text;
                String gender = "Male";

                if (radioButtonFemale.Checked)
                {
                    gender = "Female";
                }
                MemoryStream pic = new MemoryStream();

                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;
                if ((this_year - born_year < 10 || this_year - born_year > 100))
                {
                    MessageBox.Show("Student age must be between 10 and 100 year", "Invalid birth date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Verify())
                {
                    pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);
                    if ((student.updateStudent(id, name, bDate, gender, phone, email, address, pic)))
                    {
                        MessageBox.Show("Student Information updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new MySqlCommand("SELECT * FROM `student`"));
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty field", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Enter a valid student id to edit.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                if (MessageBox.Show("Are you sure to delete this student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (student.deleteStudent(id))
                    {
                        MessageBox.Show("Student deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new MySqlCommand("SELECT * FROM `student`"));
                        textBoxId.Text = "";
                        textBoxName.Text = "";
                        textBoxPhone.Text = "";
                        textBoxEmail.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBoxStudentImage.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student cannot be deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch
            {
                MessageBox.Show("Enter a valid student id to delete.", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
