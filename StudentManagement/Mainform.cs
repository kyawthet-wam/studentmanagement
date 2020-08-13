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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void add_student_Click(object sender, EventArgs e)
        {
            Addstudent addstudent = new Addstudent();
            addstudent.Show(this);
        }

        private void student_list_Click(object sender, EventArgs e)
        {
            Studentlist studentlist = new Studentlist();
            studentlist.Show(this);
        }

        private void manageStudent_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent();
            manageStudent.Show(this);
        }

        private void print_Click(object sender, EventArgs e)
        {
            PrintForm pf = new PrintForm();
            pf.Show(this);
        }

        private void buttonEditRemove_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent updateDeleteStudent = new UpdateDeleteStudent();
            updateDeleteStudent.Show(this);
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            AddCourse addCourse = new AddCourse();
            addCourse.Show(this);
        }

        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            EditCourse editCourse = new EditCourse();
            editCourse.Show(this);
        }

        private void buttonRemoveCourse_Click(object sender, EventArgs e)
        {
            RemoveCourse removeCourse = new RemoveCourse();
            removeCourse.Show(this);
        }

        private void buttonManageCourse_Click(object sender, EventArgs e)
        {
            ManageCourse mc = new ManageCourse();
            mc.Show(this);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintCourse pc = new PrintCourse();
            pc.Show(this);
        }

        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            AddScore addScore = new AddScore();
            addScore.Show(this);
        }

        private void buttonRemoveScore_Click(object sender, EventArgs e)
        {
            RemoveScore rmScore = new RemoveScore();
            rmScore.Show(this);
        }

        private void buttonManageScore_Click(object sender, EventArgs e)
        {
            ManageScore ms = new ManageScore();
            ms.Show(this);
        }
    }
}
