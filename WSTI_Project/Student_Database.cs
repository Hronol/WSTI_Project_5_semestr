using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace WSTI_Project
{
    class Student_Database
    {
        private MySqlConnection sqlcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=wsti_students_db");
        public  MySqlConnection getConnection
        {
            get
            {
                return sqlcon;
            }
        }
        //otwieranie polaczenia
        public void openConnection()
        {
            if(sqlcon.State == System.Data.ConnectionState.Closed)
            {
                sqlcon.Open();
            }
        }
        //zamykanie polaczenia
        public void closeConnection()
        {
            if (sqlcon.State == System.Data.ConnectionState.Open)
            {
                sqlcon.Close();
            }
        }
    }
}
