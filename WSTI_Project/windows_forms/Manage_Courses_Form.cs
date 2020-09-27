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
    public partial class Manage_Courses_Form : Form
    {
        Student_Database db = new Student_Database();
        CourseClass courseClass = new CourseClass();
        public Manage_Courses_Form()
        {
            InitializeComponent();
        }

        private void Manage_Courses_Form_Load(object sender, EventArgs e)
        {
            listboxShowCourses();
            populateComboBox();
            
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            
            try
            {
                int courseId = Convert.ToInt32(textBoxID.Text);
            
                if (MessageBox.Show("Czy na pewno chcesz usunąć kurs?", "Zarządzaj kursami", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
                {
                    if (courseClass.removeCourse(courseId))
                    {
                        MessageBox.Show("Kurs został usunięty", "Zarządzaj kursami", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kurs nie został usunięty", "Zarządzaj kursami", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch
            {
                MessageBox.Show("Podaj poprawny numer ID", "Zarządzaj kursami", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            listboxShowCourses();
            populateComboBox();
        }

        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            try
            {
                
                string courseName = textBoxCourseName.Text;
                int hoursNumber = (int)numericUpDownhoursNumber.Value;
                string description = textBoxDescription.Text;
                int courseID = (int)comboBoxSelectCourse.SelectedValue;

                if (courseName.Trim() != "" && hoursNumber != 0 && description.Trim() != "")
                {
                    if (courseClass.courseNameVerifi(courseName, courseID))
                    {
                        if (courseClass.editCourse(courseID, courseName, hoursNumber, description))
                        {
                            MessageBox.Show("Poprawnie edytowano kurs", "Zarządzanie kursami", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Wystąpił błąd podczas edytowania kursu", "Zarządzanie kursami", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pozostały pola do wypełnienia", "Zarządzanie kursami", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch
            {
                MessageBox.Show("Wystąpił błąd podczas edytowania kursu", "Zarządzanie kursami", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            listboxShowCourses();
            populateComboBox();
        }

        public void listboxShowCourses()
        {
            listBoxCourses.DataSource = courseClass.getAllcourses();
            listBoxCourses.ValueMember = "id";
            listBoxCourses.DisplayMember = "label";

            listBoxCourses.SelectedItem = null;
        }

        public void populateComboBox()
        {
            comboBoxSelectCourse.DataSource = courseClass.getAllcourses();
            comboBoxSelectCourse.ValueMember = "id";
            comboBoxSelectCourse.DisplayMember = "label";

            comboBoxSelectCourse.SelectedItem = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBoxSelectCourse.SelectedValue);
                DataTable dataTable = new DataTable();
                dataTable = courseClass.getCoursesByID(id);
                textBoxID.Text = dataTable.Rows[0][0].ToString();
                textBoxCourseName.Text = dataTable.Rows[0][1].ToString();
                numericUpDownhoursNumber.Value = Int32.Parse(dataTable.Rows[0][2].ToString());
                textBoxDescription.Text = dataTable.Rows[0][3].ToString();
            } catch
            {

            }
        }

        private void buttonCloseFormAddStudents_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
