namespace CrispyChocoApp
{
    partial class AdministratorsMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorsMenuForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconEmployees = new FontAwesome.Sharp.IconButton();
            this.iconDepartments = new FontAwesome.Sharp.IconButton();
            this.iconSites = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainAdminPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainAdminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.iconEmployees);
            this.panel1.Controls.Add(this.iconDepartments);
            this.panel1.Controls.Add(this.iconSites);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1622, 125);
            this.panel1.TabIndex = 0;
            // 
            // iconEmployees
            // 
            this.iconEmployees.BackColor = System.Drawing.Color.Firebrick;
            this.iconEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconEmployees.FlatAppearance.BorderSize = 0;
            this.iconEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEmployees.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconEmployees.ForeColor = System.Drawing.SystemColors.Info;
            this.iconEmployees.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconEmployees.IconColor = System.Drawing.SystemColors.Info;
            this.iconEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEmployees.IconSize = 55;
            this.iconEmployees.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconEmployees.Location = new System.Drawing.Point(1258, 17);
            this.iconEmployees.Name = "iconEmployees";
            this.iconEmployees.Size = new System.Drawing.Size(126, 79);
            this.iconEmployees.TabIndex = 5;
            this.iconEmployees.Text = "Employees";
            this.iconEmployees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconEmployees.UseVisualStyleBackColor = false;
            this.iconEmployees.Click += new System.EventHandler(this.IconEmployees_Click);
            // 
            // iconDepartments
            // 
            this.iconDepartments.BackColor = System.Drawing.Color.Firebrick;
            this.iconDepartments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconDepartments.FlatAppearance.BorderSize = 0;
            this.iconDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDepartments.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconDepartments.ForeColor = System.Drawing.SystemColors.Info;
            this.iconDepartments.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            this.iconDepartments.IconColor = System.Drawing.SystemColors.Info;
            this.iconDepartments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDepartments.IconSize = 55;
            this.iconDepartments.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconDepartments.Location = new System.Drawing.Point(1065, 17);
            this.iconDepartments.Name = "iconDepartments";
            this.iconDepartments.Size = new System.Drawing.Size(138, 79);
            this.iconDepartments.TabIndex = 4;
            this.iconDepartments.Text = "Departments";
            this.iconDepartments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconDepartments.UseVisualStyleBackColor = false;
            this.iconDepartments.Click += new System.EventHandler(this.IconDepartments_Click);
            // 
            // iconSites
            // 
            this.iconSites.BackColor = System.Drawing.Color.Firebrick;
            this.iconSites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconSites.FlatAppearance.BorderSize = 0;
            this.iconSites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSites.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconSites.ForeColor = System.Drawing.SystemColors.Info;
            this.iconSites.IconChar = FontAwesome.Sharp.IconChar.BuildingCircleArrowRight;
            this.iconSites.IconColor = System.Drawing.SystemColors.Info;
            this.iconSites.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSites.IconSize = 55;
            this.iconSites.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconSites.Location = new System.Drawing.Point(906, 17);
            this.iconSites.Name = "iconSites";
            this.iconSites.Size = new System.Drawing.Size(104, 79);
            this.iconSites.TabIndex = 1;
            this.iconSites.Text = "Sites";
            this.iconSites.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconSites.UseVisualStyleBackColor = false;
            this.iconSites.Click += new System.EventHandler(this.IconSites_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(37, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Directory Software";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 594);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1622, 31);
            this.panel2.TabIndex = 1;
            // 
            // mainAdminPanel
            // 
            this.mainAdminPanel.Controls.Add(this.pictureBox2);
            this.mainAdminPanel.Controls.Add(this.label2);
            this.mainAdminPanel.Controls.Add(this.pictureBox3);
            this.mainAdminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainAdminPanel.Location = new System.Drawing.Point(0, 125);
            this.mainAdminPanel.Name = "mainAdminPanel";
            this.mainAdminPanel.Size = new System.Drawing.Size(1622, 469);
            this.mainAdminPanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(776, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(696, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "ADMIN DASHBOARD";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(568, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(568, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // AdministratorsMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1622, 625);
            this.Controls.Add(this.mainAdminPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministratorsMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRISPY CHOCO - Admin dashboard 🏠";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainAdminPanel.ResumeLayout(false);
            this.mainAdminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconEmployees;
        private FontAwesome.Sharp.IconButton iconDepartments;
        private FontAwesome.Sharp.IconButton iconSites;
        private Panel panel2;
        private Panel mainAdminPanel;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox3;
    }
}