namespace WSTI_Project
{
    partial class Add_Course_From
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
            this.textBoxCourseLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.numericUpDownhoursNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownhoursNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCourseLabel
            // 
            this.textBoxCourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCourseLabel.Location = new System.Drawing.Point(212, 65);
            this.textBoxCourseLabel.Name = "textBoxCourseLabel";
            this.textBoxCourseLabel.Size = new System.Drawing.Size(292, 38);
            this.textBoxCourseLabel.TabIndex = 28;
            this.textBoxCourseLabel.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(37, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ilość godzin:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nazwa kursu:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDescription.Location = new System.Drawing.Point(212, 186);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(292, 262);
            this.textBoxDescription.TabIndex = 30;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxAdres_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(125, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 31);
            this.label6.TabIndex = 27;
            this.label6.Text = "Opis:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(212, 492);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(292, 89);
            this.buttonAddCourse.TabIndex = 31;
            this.buttonAddCourse.Text = "Dodaj kurs";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // numericUpDownhoursNumber
            // 
            this.numericUpDownhoursNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownhoursNumber.Location = new System.Drawing.Point(212, 121);
            this.numericUpDownhoursNumber.Name = "numericUpDownhoursNumber";
            this.numericUpDownhoursNumber.Size = new System.Drawing.Size(292, 38);
            this.numericUpDownhoursNumber.TabIndex = 33;
            // 
            // Add_Course_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(750, 623);
            this.Controls.Add(this.numericUpDownhoursNumber);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.textBoxCourseLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label6);
            this.Name = "Add_Course_From";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Course_Form";
            this.Load += new System.EventHandler(this.Add_Course_From_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownhoursNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCourseLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.NumericUpDown numericUpDownhoursNumber;
    }
}