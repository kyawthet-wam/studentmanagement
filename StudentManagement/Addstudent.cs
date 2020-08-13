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

namespace project
{
    public partial class Addstudent : Form
    {
        public Addstudent()
        {
            InitializeComponent();
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
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
        