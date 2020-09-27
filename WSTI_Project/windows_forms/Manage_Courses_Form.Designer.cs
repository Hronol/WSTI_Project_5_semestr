namespace WSTI_Project
{
    partial class Manage_Courses_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRemoveCourse = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.buttonEditCourse = new System.Windows.Forms.Button();
            this.numericUpDownhoursNumber = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.buttonCloseFormAddStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownhoursNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRemoveCourse
            // 
            this.buttonRemoveCourse.BackColor = System.Drawing.Color.Red;
            this.buttonRemoveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemoveCourse.Location = new System.Drawing.Point(602, 622);
            this.buttonRemoveCourse.Name = "buttonRemoveCourse";
            this.buttonRemoveCourse.Size = new System.Drawing.Size(290, 80);
            this.buttonRemoveCourse.TabIndex = 0;
            this.buttonRemoveCourse.Text = "Usuń kurs";
            this.buttonRemoveCourse.UseVisualStyleBackColor = false;
            this.buttonRemoveCourse.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxID.Location = new System.Drawing.Point(207, 119);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(294, 38);
            this.textBoxID.TabIndex = 1;
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCourseName.Location = new System.Drawing.Point(207, 183);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(294, 38);
            this.textBoxCourseName.TabIndex = 2;
            // 
            // buttonEditCourse
            // 
            this.buttonEditCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditCourse.Location = new System.Drawing.Point(209, 622);
            this.buttonEditCourse.Name = "buttonEditCourse";
            this.buttonEditCourse.Size = new System.Drawing.Size(290, 80);
            this.buttonEditCourse.TabIndex = 4;
            this.buttonEditCourse.Text = "Edytuj kurs";
            this.buttonEditCourse.UseVisualStyleBackColor = true;
            this.buttonEditCourse.Click += new System.EventHandler(this.buttonEditCourse_Click);
            // 
            // numericUpDownhoursNumber
            // 
            this.numericUpDownhoursNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownhoursNumber.Location = new System.Drawing.Point(209, 248);
            this.numericUpDownhoursNumber.Name = "numericUpDownhoursNumber";
            this.numericUpDownhoursNumber.Size = new System.Drawing.Size(292, 38);
            this.numericUpDownhoursNumber.TabIndex = 34;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDescription.Location = new System.Drawing.Point(209, 313);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(292, 262);
            this.textBoxDescription.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(26, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 31);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ilość godzin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nazwa kursu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(114, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 31);
            this.label6.TabIndex = 38;
            this.label6.Text = "Opis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(142, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 31);
            this.label3.TabIndex = 39;
            this.label3.Text = "ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.Location = new System.Drawing.Point(538, 59);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(416, 511);
            this.listBoxCourses.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 31);
            this.label4.TabIndex = 41;
            this.label4.Text = "Wybierz kurs:";
            // 
            // comboBoxSelectCourse
            // 
            this.comboBoxSelectCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSelectCourse.FormattingEnabled = true;
            this.comboBoxSelectCourse.Location = new System.Drawing.Point(209, 59);
            this.comboBoxSelectCourse.Name = "comboBoxSelectCourse";
            this.comboBoxSelectCourse.Size = new System.Drawing.Size(292, 39);
            this.comboBoxSelectCourse.TabIndex = 42;
            this.comboBoxSelectCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectCourse_SelectedIndexChanged);
            // 
            // buttonCloseFormAddStudents
            // 
            this.buttonCloseFormAddStudents.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonCloseFormAddStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCloseFormAddStudents.Location = new System.Drawing.Point(12, 696);
            this.buttonCloseFormAddStudents.Name = "buttonCloseFormAddStudents";
            this.buttonCloseFormAddStudents.Size = new System.Drawing.Size(126, 53);
            this.buttonCloseFormAddStudents.TabIndex = 43;
            this.buttonCloseFormAddStudents.Text = "Wróć";
            this.buttonCloseFormAddStudents.UseVisualStyleBackColor = false;
            this.buttonCloseFormAddStudents.Click += new System.EventHandler(this.buttonCloseFormAddStudents_Click);
            // 
            // Manage_Courses_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.buttonCloseFormAddStudents);
            this.Controls.Add(this.comboBoxSelectCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.numericUpDownhoursNumber);
            this.Controls.Add(this.buttonEditCourse);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonRemoveCourse);
            this.Name = "Manage_Courses_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School_manager";
            this.Load += new System.EventHandler(this.Manage_Courses_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownhoursNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemoveCourse;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Button buttonEditCourse;
        private System.Windows.Forms.NumericUpDown numericUpDownhoursNumber;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSelectCourse;
        private System.Windows.Forms.Button buttonCloseFormAddStudents;
    }
}