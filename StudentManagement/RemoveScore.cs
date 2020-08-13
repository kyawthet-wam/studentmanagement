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
    public partial class RemoveScore : Form
    {
        public RemoveScore()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void RemoveScore_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentScore();
        }

        private void buttonRemoveScore_Click(object sender, EventArgs e)
        {
            int studentId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int courseId = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());

            if (MessageBox.Show("Are you sure to delete this score.", "Delete score", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (score.deleteScore(studentId,courseId))
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
    }
}
