using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace project
{
    class STUDENT
    {
        Mydb mydb = new Mydb();
        public bool insertStudent(String name,DateTime bdate,String gender,String phone,String email,String address, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`name`, `birthdate`, `gender`, `phone`, `email`, `address`, `picture`) VALUES (@name,@bdate,@gen,@phone,@email,@address,@picture)", mydb.getConnection);

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@bdate", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gen", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@address", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@picture", MySqlDbType.Blob).Value = picture.ToArray();

            mydb.openConnection();
            
            if(command.ExecuteNonQuery() == 1)
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
        public DataTable getStudents(MySqlCommand command)
        {
            command.Connection = mydb.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateStudent(int id, String name, DateTime bdate, String gender, String phone, String email, String address, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `name`=@name,`birthdate`=@bdate,`gender`=@gen,`phone`=@phone,`email`=@email,`address`=@address,`picture`=@picture WHERE `id`=@ID", mydb.getConnection);
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@bdate", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gen", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@address", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@picture", MySqlDbType.Blob).Value = picture.ToArray();

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

        public bool deleteStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE `id`=@studentId", mydb.getConnection);
            command.Parameters.Add("@studentId",MySqlDbType.Int32).Value = id;
           
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

        public string totalStudent()
        {
            return execCount("SELECT COUNT(*) FROM `student`");
        }

        public string maleStudent()
        {
            return execCount("SELECT COUNT(*) FROM `student` where `gender`='Male'");
        }

        public string femaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM `student` where `gender`='Female'");
        }

    }
}
