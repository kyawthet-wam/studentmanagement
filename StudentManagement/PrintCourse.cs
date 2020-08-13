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
    public partial class PrintCourse : Form
    {
        public PrintCourse()
        {
            InitializeComponent();
        }

        private void PrintCourse_Load(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
            dataGridView1.DataSource = course.getAllCourse();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\course_list.txt";

            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                //rolls
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    //columns
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
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
