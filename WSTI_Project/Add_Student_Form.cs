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
    public partial class Add_Student_Form : Form
    {
        public Add_Student_Form()
        {
            InitializeComponent();
        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            //przeglądanie z pliku
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Select Image(*.jpg,*.png,*.bmp)|*.jpg;,*.png;,*.bmp;";

            if(openFile.ShowDialog()==DialogResult.OK)
            {
                pictureBoxStudent.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void buttonSaveStudent_Click(object sender, EventArgs e)
        {
            try
            {
                StudentClass studentClass = new StudentClass();
                string name = textBoxName.Text;
                string lastName = textBoxLastName.Text;
                DateTime birthday = dateTimePickerNewStudent.Value;
                string gender = "Mężczyzna";
                string phone = textBoxPhone.Text;
                string address = textBoxAdres.Text;

                if (radioBtnFemale.Checked)
                {
                    gender = "Kobieta";
                }

                MemoryStream picture = new MemoryStream();

                if (veryfication() == true)
                {
                    pictureBoxStudent.Image.Save(picture, pictureBoxStudent.Image.RawFormat);

                    if (studentClass.addStudent(name, lastName, birthday, gender, phone, address, picture))
                    {
                        MessageBox.Show("Dodano studenta!", "Gratulacje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Wystąpił błąd podczas dodawania studenta\nBłąd połączenia z bazą danych", "Błąd dodawania studenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nie wszystkie dane zostały wypełnione", "Błąd dodawania danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd. Zweryfikuj dane i spróbuj ponownie");
            }

        }

        private void buttonCancelStudent_Click(object sender, EventArgs e)
        {

        }

        public bool veryfication()
        {
            if((textBoxName.Text.Trim() == "") ||
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
    }
}
