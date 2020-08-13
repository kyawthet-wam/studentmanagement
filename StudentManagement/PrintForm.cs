using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace project
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void PrintForm_Load(object sender, EventArgs e)
        {
            fillGrid(new MySqlCommand("SELECT * FROM `student`"));

            if (radioButtonNo.Checked == true)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
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
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;

            radioButtonMale.Enabled = true;
            radioButtonFemale.Enabled = true;
            radioButtonAll.Enabled = true;
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            string query="";
            if (radioButtonYes.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                if (radioButtonMale.Checked)
                {
                    query = "SELECT * FROM `student` WHERE `gender`= 'Male' AND `birthdate`BETWEEN '" + date1 + "' AND '" + date2 + "'";
                    
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT * FROM `student` WHERE `gender`= 'Female' AND `birthdate`BETWEEN '" + date1 + "' AND '" + date2 + "'";
                }
                else
                {
                        query = "SELECT * FROM `student` WHERE `birthdate`BETWEEN '" + date1 + "' AND '" + date2 + "'";
                }

                command = new MySqlCommand(query);
                fillGrid(command);
            }
            else
            {
                if (radioButtonMale.Checked)
                {
                    query = "SELECT * FROM `student` WHERE `gender`= 'Male'";

                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT * FROM `student` WHERE `gender`= 'Female'";
                }
                else
                {
                    query = "SELECT * FROM `student`";
                }

                command = new MySqlCommand(query);
                fillGrid(command);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop ) + @"\student_list.txt";
            
            using(var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                DateTime bdirth;
              //rolls
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    //columns
                    for (int j = 0; j < dataGridView1.Columns.Count-1; j++)
                    {
                        //birthdate column
                        if (j == 2)
                        {
                            bdirth = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value);
                            writer.Write("\t" + bdirth.ToString("dd/MM/yyyy") + "\t" + "|");
                        }
                        //the last column
                        else if(j== dataGridView1.Columns.Count - 2)
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }

                    }
                    //make new line
                    writer.WriteLine(" ");
                    writer.WriteLine(" ");
                    
                }
                    

                writer.Close();
                MessageBox.Show("Data exported");
            }
        }
    }
}
