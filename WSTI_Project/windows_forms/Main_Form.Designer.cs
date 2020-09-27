namespace WSTI_Project
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sTUDENCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajStudentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaStudentówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujUsuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kURSYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKierunekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszDaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENCIToolStripMenuItem,
            this.kURSYToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sTUDENCIToolStripMenuItem
            // 
            this.sTUDENCIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajStudentaToolStripMenuItem,
            this.listaStudentówToolStripMenuItem,
            this.edytujUsuńToolStripMenuItem,
            this.ustawieniaToolStripMenuItem,
            this.zapiszToolStripMenuItem});
            this.sTUDENCIToolStripMenuItem.Name = "sTUDENCIToolStripMenuItem";
            this.sTUDENCIToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.sTUDENCIToolStripMenuItem.Text = "STUDENCI";
            // 
            // dodajStudentaToolStripMenuItem
            // 
            this.dodajStudentaToolStripMenuItem.Name = "dodajStudentaToolStripMenuItem";
            this.dodajStudentaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.dodajStudentaToolStripMenuItem.Text = "Dodaj studenta";
            this.dodajStudentaToolStripMenuItem.Click += new System.EventHandler(this.dodajStudentaToolStripMenuItem_Click);
            // 
            // listaStudentówToolStripMenuItem
            // 
            this.listaStudentówToolStripMenuItem.Name = "listaStudentówToolStripMenuItem";
            this.listaStudentówToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.listaStudentówToolStripMenuItem.Text = "Lista studentów";
            this.listaStudentówToolStripMenuItem.Click += new System.EventHandler(this.listaStudentówToolStripMenuItem_Click);
            // 
            // edytujUsuńToolStripMenuItem
            // 
            this.edytujUsuńToolStripMenuItem.Name = "edytujUsuńToolStripMenuItem";
            this.edytujUsuńToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.edytujUsuńToolStripMenuItem.Text = "Edytuj/Usuń ";
            this.edytujUsuńToolStripMenuItem.Click += new System.EventHandler(this.edytujUsuńToolStripMenuItem_Click);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ustawieniaToolStripMenuItem.Text = "Zarządzaj studentami";
            this.ustawieniaToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz dane";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // kURSYToolStripMenuItem
            // 
            this.kURSYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKursToolStripMenuItem,
            this.dodajKierunekToolStripMenuItem,
            this.zapiszDaneToolStripMenuItem});
            this.kURSYToolStripMenuItem.Name = "kURSYToolStripMenuItem";
            this.kURSYToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.kURSYToolStripMenuItem.Text = "KURSY";
            // 
            // dodajKursToolStripMenuItem
            // 
            this.dodajKursToolStripMenuItem.Name = "dodajKursToolStripMenuItem";
            this.dodajKursToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.dodajKursToolStripMenuItem.Text = "Dodaj kurs";
            this.dodajKursToolStripMenuItem.Click += new System.EventHandler(this.dodajKursToolStripMenuItem_Click);
            // 
            // dodajKierunekToolStripMenuItem
            // 
            this.dodajKierunekToolStripMenuItem.Name = "dodajKierunekToolStripMenuItem";
            this.dodajKierunekToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.dodajKierunekToolStripMenuItem.Text = "Zarządzaj";
            this.dodajKierunekToolStripMenuItem.Click += new System.EventHandler(this.dodajKierunekToolStripMenuItem_Click);
            // 
            // zapiszDaneToolStripMenuItem
            // 
            this.zapiszDaneToolStripMenuItem.Name = "zapiszDaneToolStripMenuItem";
            this.zapiszDaneToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.zapiszDaneToolStripMenuItem.Text = "Zapisz dane";
            this.zapiszDaneToolStripMenuItem.Click += new System.EventHandler(this.zapiszDaneToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Manager";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTUDENCIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajStudentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaStudentówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujUsuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kURSYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKierunekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszDaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKursToolStripMenuItem;
    }
}