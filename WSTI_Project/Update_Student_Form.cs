using MySql.Data.MySqlClient;
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

namespace WSTI_Project
{
    public partial class Update_Student_Form : Form
    {

        StudentClass studentClass = new StudentClass();
        Student_Database db = new Student_Database();

        public Update_Student_Form()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Select Image(*.jpg,*.png,*.bmp)|*.jpg;,*.png;,*.bmp;";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudent.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string name = textBoxName.Text;
            string lastName = textBoxLastName.Text;
            DateTime birthday = dateTimePickerNewStudent.Value;
            string gender = "Mężczyzna";
            string phone = textBoxPhone.Text;
            string address = textBoxAdres.Text;

            if (radioButtonFemale.Checked)
            {
                gender = "Kobieta";
            }

            MemoryStream picture = new MemoryStream();

            if (veryfication() == true)
            {
                pictureBoxStudent.Image.Save(picture, pictureBoxStudent.Image.RawFormat);

                if (studentClass.updateStudent(id, name, lastName, birthday, phone, gender, address, picture))
                {
                    MessageBox.Show("Aktualizowane dane studenta", "Gratulacje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas aktualizacji danych\nBłąd połączenia z bazą danych", "Błąd edytowania studenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nie wszystkie dane zostały wypełnione", "Błąd edytowania danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public bool veryfication()
        {
            if ((textBoxName.Text.Trim() == "") ||
                (textBoxLastName.Text.Trim() == "") ||
                (textBoxPhone.Text.Trim() == "") ||
                (textBoxAdres.Text.Trim() == "") ||
                (pictureBoxStudent.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
            private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);

            if(MessageBox.Show("Czy na pewno chcesz usunąć studenta?", "Usuń studenta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                if(studentClass.deleteStudent(id))
                {
                    MessageBox.Show("Student został usunięty z bazy danych", "Usuń studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //czyszczenie pol
                    textBoxID.Text = "";
                    textBoxName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxAdres.Text = "";
                    textBoxPhone.Text = "";
                    dateTimePickerNewStudent.Value = DateTime.Now;
                    pictureBoxStudent.Image = null;
                }
                else
                {
                    MessageBox.Show("Operacja usuwania została przerwana", "Usuń studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonFindStudent_Click(object sender, EventArgs e)
        {
            //przeszukiwanie

            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                MySqlCommand command = new MySqlCommand("SELECT `id`, `first_name`, `last_name`, `birthday`, `gender`, `phone`, `address`, `picture` FROM `students` WHERE `id` =" + id, db.getConnection);

                DataTable dataTable = studentClass.getStudents(command);

                if (dataTable.Rows.Count > 0)
                {
                    textBoxName.Text = dataTable.Rows[0]["first_name"].ToString();
                    textBoxLastName.Text = dataTable.Rows[0]["last_name"].ToString();
                    textBoxPhone.Text = dataTable.Rows[0]["phone"].ToString();
                    textBoxAdres.Text = dataTable.Rows[0]["address"].ToString();
                    dateTimePickerNewStudent.Value = (DateTime)dataTable.Rows[0]["birthday"];

                    if (dataTable.Rows[0]["gender"].ToString() == "Kobieta")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    else
                    {
                        radioButtonMale.Checked = true;
                    }
                }

                byte[] picture = (byte[])dataTable.Rows[0]["picture"];
                MemoryStream pic = new MemoryStream(picture);
                pictureBoxStudent.Image = Image.FromStream(pic);
            }catch(Exception e)
            {
                MessageBox.Show("Podaj poprawny numer ID", "Niepoprawny numer ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
