using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace project
{
    class COURSE
    {
        Mydb mydb = new Mydb();
        public bool insertCourse(string courseName,int hourNumber,string description)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `course`(`course_name`, `hours_number`, `description`) VALUES (@cname,@hrs,@description)", mydb.getConnection);
            command.Parameters.Add("@cname", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", MySqlDbType.Int32).Value = hourNumber;
            command.Parameters.Add("@description", MySqlDbType.Text).Value = description;

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
       //check unique course name
       public bool checkCourseName(string courseName,int courseId = 0)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `course` WHERE `course_name`=@cname AND `id` <> @cid", mydb.getConnection);

            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseId;
            command.Parameters.Add("@cname", MySqlDbType.VarChar).Value = courseName;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }

        }
        public bool deleteCourse(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `course` WHERE `id`=@CID", mydb.getConnection);
            command.Parameters.Add("@CID", MySqlDbType.Int32).Value = id;
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

        public DataTable getAllCourse()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `course` ", mydb.getConnection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public DataTable getCourseById(int courseId)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `course` where `id`=@cid", mydb.getConnection);

            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseId;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public bool updateCourse(int courseId,string courseName,int hrNumber,string description)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `course` SET `id`=@cid,`course_name`=@cname,`hours_number`=@hrs," +
                "`description`=@description" +
                " WHERE 1", mydb.getConnection);
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseId;
            command.Parameters.Add("@cname", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", MySqlDbType.Int32).Value = hrNumber;
            command.Parameters.Add("@description", MySqlDbType.Text).Value = description;

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
        public string execCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, mydb.getConnection);

            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            return count;
            mydb.closeConnection();
        }

        public string totalCourse()
        {
            return execCount("SELECT COUNT(*) FROM `course`");
        }
    }
}
 
