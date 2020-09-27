namespace WSTI_Project
{
    partial class SaveCoursesForm
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
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCloseFormAddStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveToFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSaveToFile.Location = new System.Drawing.Point(205, 559);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(551, 86);
            this.buttonSaveToFile.TabIndex = 5;
            this.buttonSaveToFile.Text = "Zapisz do pliku tekstowego";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 531);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonCloseFormAddStudents
            // 
            this.buttonCloseFormAddStudents.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonCloseFormAddStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCloseFormAddStudents.Location = new System.Drawing.Point(12, 592);
            this.buttonCloseFormAddStudents.Name = "buttonCloseFormAddStudents";
            this.buttonCloseFormAddStudents.Size = new System.Drawing.Size(126, 53);
            this.buttonCloseFormAddStudents.TabIndex = 6;
            this.buttonCloseFormAddStudents.Text = "Wróć";
            this.buttonCloseFormAddStudents.UseVisualStyleBackColor = false;
            this.buttonCloseFormAddStudents.Click += new System.EventHandler(this.buttonCloseFormAddStudents_Click);
            // 
            // SaveCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 663);
            this.Controls.Add(this.buttonCloseFormAddStudents);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "SaveCoursesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School_manager";
            this.Load += new System.EventHandler(this.SaveCoursesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCloseFormAddStudents;
    }
}