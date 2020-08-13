using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project
{
    public partial class UpdateDeleteStudent : Form
    {
        public UpdateDeleteStudent()
        {
            InitializeComponent();
        }
        STUDENT std = new STUDENT();
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
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
                    if ((std.updateStudent(id, name, bDate, gender, phone, email, address, pic)))
                    {
                        MessageBox.Show("Student Information updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }catch
            {
                MessageBox.Show("Enter a valid student id to edit.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool Verify()
        {
            if ((textBoxName.Text.Trim() == "") ||
               (textBoxPhone.Text.Trim() == "") ||
               (textBoxEmail.Text.Trim() == "") ||
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

        private void buttonRemoveStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                if (MessageBox.Show("Are you sure to delete this student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (std.deleteStudent(id))
                    {
                        MessageBox.Show("Student deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                
            }catch
            {
                MessageBox.Show("Enter a valid student id to delete.", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                MySqlCommand command = new MySqlCommand("SELECT `id`, `name`, `birthdate`, `gender`, `phone`, `email`, `address`, `picture` FROM `student` WHERE `id`=" + id);
                DataTable dataTable = std.getStudents(command);

                if (dataTable.Rows.Count > 0)
                {
                    textBoxName.Text = dataTable.Rows[0]["name"].ToString();
                    textBoxPhone.Text = dataTable.Rows[0]["phone"].ToString();
                    textBoxEmail.Text = dataTable.Rows[0]["email"].ToString();
                    textBoxAddress.Text = dataTable.Rows[0]["address"].ToString();
                    dateTimePicker1.Value = (DateTime)dataTable.Rows[0]["birthdate"];

                    if (dataTable.Rows[0]["gender"] == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    else
                    {
                        radioButtonMale.Checked = true;
                    }

                    byte[] pic;
                    pic = (byte[])dataTable.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBoxStudentImage.Image = Image.FromStream(picture);

                }

            }catch
            {
                MessageBox.Show("Enter a valid student id", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)){
                e.Handled = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
