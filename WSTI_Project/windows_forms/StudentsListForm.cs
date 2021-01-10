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
    public partial class StudentsListForm : Form
    {
        public StudentsListForm()
        {
            InitializeComponent();
        }

        StudentClass studentClass = new StudentClass();

        private void StudentsListForm_Load(object sender, EventArgs e)
        {
            //ladowanie danych

            MySqlCommand command = new MySqlCommand("SELECT * FROM `students`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn gridViewImageColumn = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = studentClass.getStudents(command);
            gridViewImageColumn = (DataGridViewImageColumn)dataGridView1.Columns[8];
            gridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //edytuj studenta podwojnym klikiem
            Update_Student_Form updateStudentForm = new Update_Student_Form();
            updateStudentForm.textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateStudentForm.textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateStudentForm.textBoxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateStudentForm.textBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateStudentForm.textBoxAdres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            updateStudentForm.dateTimePickerNewStudent.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            if(dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Kobieta")
            {
                updateStudentForm.radioButtonFemale.Checked = true;
            }

            byte[] picture;
            picture = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream pic = new MemoryStream(picture);
            updateStudentForm.pictureBoxStudent.Image = Image.FromStream(pic);
            updateStudentForm.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `students`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn gridViewImageColumn = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = studentClass.getStudents(command);
            gridViewImageColumn = (DataGridViewImageColumn)dataGridView1.Columns[8];
            gridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonCloseFormAddStudents_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
