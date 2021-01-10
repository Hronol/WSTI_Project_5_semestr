using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSTI_Project
{
    class CourseClass
    {
        Student_Database db = new Student_Database();

        public bool addCourse(string courseName, int hourNumber, string description)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `studies`(`label`, `hours`, `description`) VALUES (@name,@hoursnumber,@description)", db.getConnection);

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hoursnumber", MySqlDbType.Int32).Value = hourNumber;
            command.Parameters.Add("@description", MySqlDbType.Text).Value = description;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
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

        public bool courseNameVerifi(string courseName, int courseID = 0)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `studies` WHERE `label` = @name AND id_course <> @id", db.getConnection);

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = courseID;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            //sprawdza czy kurs istnieje bo rekordach
            if(dataTable.Rows.Count > 0)
            {
                db.closeConnection();
                MessageBox.Show("Kurs już istnieje");
                return false;
            }
            else
            {
                db.closeConnection();
                return true;
            }

        }

        public bool removeCourse(int courseID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `studies` WHERE `id_course` = @id", db.getConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = courseID;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                MessageBox.Show("Wystąpił błąd podczas usuwania kursu", "Zarządzaj kursami", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable getAllcourses()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `studies`", db.getConnection);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable getCoursesByID(int courseID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `studies` WHERE id_course =@id", db.getConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = courseID;

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public bool editCourse(int courseID, string courseName, int hoursNumber, string description)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `studies` SET `label`=@name,`hours`=@hoursnumber,`description`=@description WHERE `id_course` = @id", db.getConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = courseID;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hoursnumber", MySqlDbType.Int32).Value = hoursNumber;
            command.Parameters.Add("@description", MySqlDbType.Text).Value = description;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
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

        //query do ilosci wszystkich kursow
        public string sqlCount(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, db.getConnection);
            db.openConnection();
            string count = command.ExecuteScalar().ToString();
            db.closeConnection();

            return count;
        }

        //ilosc wszystkich kursow
        public string allCourses()
        {
            return sqlCount("SELECT COUNT(*) FROM `studies`");
        }


    }
}
