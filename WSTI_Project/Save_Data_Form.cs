using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WSTI_Project
{
    public partial class Save_Data_Form : Form
    {

        StudentClass studentClass = new StudentClass();
        public Save_Data_Form()
        {
            InitializeComponent();
        }

        private void Save_Data_Form_Load(object sender, EventArgs e)
        {
            loadData(new MySqlCommand("SELECT * FROM `students`"));

            if(radioButtonNo.Checked)
            {
                dateTimePickerFrom.Enabled = false;
                dateTimePickerTo.Enabled = false;
            }
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

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerFrom.Enabled = false;
            dateTimePickerTo.Enabled = false;
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerFrom.Enabled = true;
            dateTimePickerTo.Enabled = true;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            string sql = "";

            if(radioButtonYes.Checked)
            {
                string dateFrom = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
                string dateTo = dateTimePickerTo.Value.ToString("yyyy-MM-dd");

                sql = "SELECT * FROM `students` WHERE `birthday` BETWEEN '"+dateFrom+"' AND '"+dateTo+"'";

            } else
            {
                sql = "SELECT * FROM `students`";
            }

            command = new MySqlCommand(sql);
            loadData(command);
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\studentlist.txt";

            using(var writer = new StreamWriter(path))
            {
                if(!File.Exists(path))
                {
                    File.Create(path);
                }

                DateTime birthday;

                for(int i=0; i<dataGridView1.Rows.Count; i++)
                {
                    for(int j=0; j< dataGridView1.Columns.Count-1; j++)
                    {
                        if(j == 3)
                        {
                            birthday = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            writer.Write("\t" + birthday.ToString("yyyy-MM-dd") + "\t" + "|");
                        }
                        else if(j == dataGridView1.Columns.Count-2)
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                    }
                    writer.Write("\n");
                }

                writer.Close();
                MessageBox.Show("Dane zostały zapisane na pulpicie.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
