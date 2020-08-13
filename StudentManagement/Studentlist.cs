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
    public partial class Studentlist : Form
    {
        STUDENT student = new STUDENT();
        public Studentlist()
        {
            InitializeComponent();
        }
        Color totalPanelColor;
        Color malePanelColor;
        Color femalePanelColor;
        private void Studentlist_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = student.getStudents(command);
            dataGridView1.Columns["picture"].Visible = false;
            pic = (DataGridViewImageColumn)dataGridView1.Columns[7];
            pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

            //get color for panel
            totalPanelColor = panelTotal.BackColor;
            malePanelColor = panelMale.BackColor;
            femalePanelColor = panelFemale.BackColor;

            //get student count
            double totalStudent = Convert.ToDouble(student.totalStudent());
            double totalMaleStudent = Convert.ToDouble(student.maleStudent());
            double totalFemaleStudent = Convert.ToDouble(student.femaleStudent());

            //percentage for male and female students

            double malePercentage = totalMaleStudent * 100 / totalStudent;
            double femalePercentage = totalFemaleStudent * 100 / totalStudent;

            labelTotal.Text = "Total Students:" + totalStudent;
            labelMale.Text = "Male Student:" + malePercentage.ToString("0.00") +"%";
            labelFemale.Text = "Female Student:" + femalePercentage.ToString("0.00")+"%";
        }

        


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudent updateDelete = new UpdateDeleteStudent();
            updateDelete.textBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDelete.textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDelete.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[2].Value;

            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Female")
            {
                updateDelete.radioButtonFemale.Checked = true;
            }

            updateDelete.textBoxPhone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            updateDelete.textBoxEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDelete.textBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDelete.pictureBoxStudentImage.Image = Image.FromStream(picture);
            updateDelete.Show();

        }
        

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void refresh_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.DataSource = student.getStudents(command);
            dataGridView1.Columns["picture"].Visible = false;
            pic = (DataGridViewImageColumn)dataGridView1.Columns[7];
            pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

            totalPanelColor = panelTotal.BackColor;
            malePanelColor = panelMale.BackColor;
            femalePanelColor = panelFemale.BackColor;
        }

        private void total_MouseEnter(object sender, EventArgs e)
        {
            panelTotal.BackColor = Color.White;
            panelTotal.ForeColor = totalPanelColor;
        }

        private void total_MouseLeave(object sender, EventArgs e)
        {
            panelTotal.BackColor = totalPanelColor;
            panelTotal.ForeColor = Color.White;
        }

        private void male_MouseEnter(object sender, EventArgs e)
        {
            panelMale.BackColor = Color.White;
            panelMale.ForeColor = malePanelColor;
        }

        private void male_MouseLeave(object sender, EventArgs e)
        {
            panelMale.BackColor = malePanelColor;
            panelMale.ForeColor = Color.White;
        }

        private void female_MouseEnter(object sender, EventArgs e)
        {
            panelFemale.BackColor = Color.White;
            panelFemale.ForeColor = femalePanelColor;
        }

        private void female_MouseLeave(object sender, EventArgs e)
        {
            panelFemale.BackColor = femalePanelColor;
            panelFemale.ForeColor = Color.White;
        }
    }
}
