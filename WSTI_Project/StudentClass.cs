using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSTI_Project
{
    class StudentClass
    {
        Student_Database db = new Student_Database();

        public bool addStudent(string name, string lastName, DateTime birthday, string phone, string gender, string address, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `students`(`first_name`, `last_name`, `birthday`, `gender`, `phone`, `address`, `picture`) VALUES (@n,@ln,@bdt,@gdr,@phn,@adrs,@pic)", db.getConnection);
            //@n,@ln,@bdt,@gdr,@phn,@adrs,@pic
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@bdt", MySqlDbType.Date).Value = birthday;
            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@adrs", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = picture.ToArray();

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        //dodawanie tabeli studentow do widoku listy studentow
        public DataTable getStudents(MySqlCommand command)
        {

            command.Connection = db.getConnection;
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            return dataTable;

        }

        public bool updateStudent(int studentID, string name, string lastName, DateTime birthday, string phone, string gender, string address, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `students` SET `first_name`=@n,`last_name`=@ln,`birthday`=@bdt,`gender`=@gdr,`phone`=@adrs,`address`=@adrs,`picture`=@pic WHERE `id`=@ID", db.getConnection);
            //@n,@ln,@bdt,@gdr,@phn,@adrs,@pic
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = studentID;
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@bdt", MySqlDbType.Date).Value = birthday;
            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@adrs", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = picture.ToArray();

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool deleteStudent(int studentID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `students` WHERE `id`=@ID", db.getConnection);
            //@ID
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = studentID;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }

        }
    }
}
