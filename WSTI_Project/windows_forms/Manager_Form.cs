using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSTI_Project
{
    public partial class Manager_Form : Form
    {
        public Manager_Form()
        {
            InitializeComponent();
        }

        StudentClass studentClass = new StudentClass();
        private void Manager_Form_Load(object sender, EventArgs e)
        {
            loadData(new MySqlCommand("SELECT * FROM `students` "));
        }

        public void loadData(MySqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn gridViewImageColumn = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = studentClass.getStudents(command);
            gridViewImageColumn = (DataGridViewImageColumn)dataGridView1.Columns[7];
            gridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dateTimePickerNewStudent.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            if(dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Kobieta")
            {
                radioBtnFemale.Checked = true;
            }
            else
            {
                radioBtnMale.Checked = true;
            }

            byte[] picture;
            picture = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream pic = new MemoryStream(picture);
            pictureBoxStudent.Image = Image.FromStream(pic);
            

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxLastName.Text = "";
            textBoxAdres.Text = "";
            textBoxPhone.Text = "";
            dateTimePickerNewStudent.Value = DateTime.Now;
            pictureBoxStudent.Image = null;
            radioBtnMale.Checked = true;
        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Select Image(*.jpg,*.png,*.bmp)|*.jpg;,*.png;,*.bmp;";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxStudent.Image = Image.FromFile(openFile.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd. Zweryfikuj dane i spróbuj ponownie");
            }
        }

        private void buttonDownloadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "Student_" + textBoxID.Text + "_" + textBoxName.Text + "_" + textBoxLastName.Text;

                if (pictureBoxStudent.Image == null)
                {
                    MessageBox.Show("Brak zdjęcia do pobrania", "Pobierz zdjęcie", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
                else if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxStudent.Image.Save(saveFileDialog.FileName + ("." + ImageFormat.Jpeg.ToString()));
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd. Zweryfikuj dane i spróbuj ponownie");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM `students` WHERE CONCAT(`first_name`,`last_name`,`address`) LIKE'% " + textBoxSearch.Text + "%'";
            MySqlCommand command = new MySqlCommand(sql);
            loadData(command);
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                StudentClass studentClass = new StudentClass();
                int student_courseID = Convert.ToInt32(textBoxStudentCourseID.Text);
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

                    if (studentClass.addStudent(student_courseID, name, lastName, birthday, gender, phone, address, picture))
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

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                int courseid = Convert.ToInt32(textBoxStudentCourseID.Text);
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

                    if (studentClass.updateStudent(id, courseid, name, lastName, birthday, gender, phone, address, picture))
                    {
                        MessageBox.Show("Zaktualizowano dane studenta", "Aktualizacja danych", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Wystąpił błąd podczas aktualizacji danych\nBłąd połączenia z bazą danych", "Aktualizacja danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nie wszystkie dane zostały wypełnione", "Aktualizacja danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd. Zweryfikuj dane i spróbuj ponownie");
            }
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);

                if (MessageBox.Show("Czy na pewno chcesz usunąć studenta?", "Usuń studenta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (studentClass.deleteStudent(id))
                    {
                        MessageBox.Show("Student został usunięty z bazy danych", "Usuń studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //czyszczenie pol
                        loadData(new MySqlCommand("SELECT * FROM `students`"));
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
            catch
            {
                MessageBox.Show("Wystąpił błąd. Zweryfikuj dane i spróbuj ponownie");
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
    }
}
