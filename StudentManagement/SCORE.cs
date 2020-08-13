using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace project
{
    class SCORE
    {
        Mydb mydb = new Mydb();
        STUDENT std = new STUDENT();
        COURSE course = new COURSE();

        public bool insertScore(int studentId,int courseId,double score,string descrription)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`student_id`, `course_id`, `score`, `description`) VALUES (@id,@cid,@score,@descr)",mydb.getConnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = studentId;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseId;
            command.Parameters.Add("@score", MySqlDbType.Double).Value = score;
            command.Parameters.Add("@descr", MySqlDbType.VarChar).Value = descrription;
            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }
        public bool checkUnique(int studentId,int courseId)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE `student_id`=@id AND `course_id`=@cid", mydb.getConnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = studentId;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseId;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable getStudentScore()
        {
            MySqlCommand command = new MySqlCommand("SELECT score.student_id,student.name,score.course_id,course.course_name,score.score FROM student INNER JOIN score ON student.id = score.student_id INNER JOIN course ON course.id = score.course_id",mydb.getConnection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public bool deleteScore(int studentId,int courseId)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `student_id`=@sid AND `course_id`=@cid", mydb.getConnection);
            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentId;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseId;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public void averageScore()
        {
            double totalStudent=Convert.ToDouble(std.totalStudent());
            double totalCourse = Convert.ToDouble(course.totalCourse());
            
        }

    }
}
