using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSTI_Project
{
    public partial class Add_Course_From : Form
    {
        public Add_Course_From()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            string courseName = textBoxCourseLabel.Text;
            int hoursNumber = (int)numericUpDownhoursNumber.Value;
            string description = textBoxDescription.Text;

            CourseClass courseClass = new CourseClass();

            if (courseName.Trim() != "" && hoursNumber != 0 && description.Trim() != "")
            {
                if (courseClass.courseNameVerifi(courseName))
                {
                    if (courseClass.addCourse(courseName, hoursNumber, description))
                    {
                        MessageBox.Show("Poprawnie dodano kurs", "Zarządzanie kursami", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Wystąpił błąd podczas dodawania kursu", "Zarządzanie kursami", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pozostały pola do wypełnienia", "Zarządzanie kursami", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Course_From_Load(object sender, EventArgs e)
        {

        }
    }
}
