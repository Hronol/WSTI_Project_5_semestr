using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSTI_Project
{
    public partial class SaveCoursesForm : Form
    {
        public SaveCoursesForm()
        {
            InitializeComponent();
        }

        private void SaveCoursesForm_Load(object sender, EventArgs e)
        {
            CourseClass courseClass = new CourseClass();
            dataGridView1.DataSource = courseClass.getAllcourses();
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {

            try 
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\courseslist.txt";

                using (var writer = new StreamWriter(path))
                {
                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                        {
                            {
                                writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                            }
                        }
                        writer.WriteLine("");
                    }

                    writer.Close();
                    MessageBox.Show("Dane zostały zapisane na pulpicie.");
                } 
            }catch
            {
                MessageBox.Show("Błąd zapisywania danych.");
            }

        }

    }
}