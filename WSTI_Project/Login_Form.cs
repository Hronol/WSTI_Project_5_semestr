using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WSTI_Project
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            // ustawienie obrazka loginu
            //pictureBox1.Image = Image.FromFile("");

        }

        private void loginAcceptBtn_Click(object sender, EventArgs e)
        {
            Student_Database db = new Student_Database();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn AND `password` = @pass", db.getConnection);

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = usernameTextbox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwordTextbox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                //MessageBox.Show("Logowanie powiodło się!","Wskakuj!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;

            } else
            {
                MessageBox.Show("Niepoprawne hasło i login","Błąd logowania",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void loginCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
