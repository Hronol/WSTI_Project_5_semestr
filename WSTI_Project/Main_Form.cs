﻿using System;
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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void dodajStudentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Student_Form add_Student_Form = new Add_Student_Form();
            add_Student_Form.Show(this);
        }

        private void listaStudentówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsListForm studentsListForm = new StudentsListForm();
            studentsListForm.Show(this);
        }

        private void statystykiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void edytujUsuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Student_Form update_Student_Form = new Update_Student_Form();
            update_Student_Form.Show(this);
        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}