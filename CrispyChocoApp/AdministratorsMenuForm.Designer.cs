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
            this.iconHelp = new FontAwesome.Sharp.IconButton();
            this.iconLogout = new FontAwesome.Sharp.IconButton();
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
            this.iconUsers = new FontAwesome.Sharp.IconButton();
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
            this.panel1.Controls.Add(this.iconUsers);
            this.panel1.Controls.Add(this.iconHelp);
            this.panel1.Controls.Add(this.iconLogout);
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
            // iconHelp
            // 
            this.iconHelp.BackColor = System.Drawing.Color.Firebrick;
            this.iconHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconHelp.FlatAppearance.BorderSize = 0;
            this.iconHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconHelp.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconHelp.ForeColor = System.Drawing.SystemColors.Info;
            this.iconHelp.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.iconHelp.IconColor = System.Drawing.SystemColors.Info;
            this.iconHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHelp.IconSize = 55;
            this.iconHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconHelp.Location = new System.Drawing.Point(1236, 24);
            this.iconHelp.Name = "iconHelp";
            this.iconHelp.Size = new System.Drawing.Size(126, 79);
            this.iconHelp.TabIndex = 7;
            this.iconHelp.Text = "Help";
            this.iconHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconHelp.UseVisualStyleBackColor = false;
            this.iconHelp.Click += new System.EventHandler(this.IconHelp_Click);
            // 
            // iconLogout
            // 
            this.iconLogout.BackColor = System.Drawing.Color.Firebrick;
            this.iconLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconLogout.FlatAppearance.BorderSize = 0;
            this.iconLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLogout.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconLogout.ForeColor = System.Drawing.SystemColors.Info;
            this.iconLogout.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.iconLogout.IconColor = System.Drawing.SystemColors.Info;
            this.iconLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogout.IconSize = 55;
            this.iconLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconLogout.Location = new System.Drawing.Point(1406, 24);
            this.iconLogout.Name = "iconLogout";
            this.iconLogout.Size = new System.Drawing.Size(126, 79);
            this.iconLogout.TabIndex = 6;
            this.iconLogout.Text = "Logout";
            this.iconLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconLogout.UseVisualStyleBackColor = false;
            this.iconLogout.Click += new System.EventHandler(this.IconLogout_Click);
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
            this.iconEmployees.Location = new System.Drawing.Point(1057, 24);
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
            this.iconDepartments.Location = new System.Drawing.Point(871, 24);
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
            this.iconSites.Location = new System.Drawing.Point(719, 24);
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
            // iconUsers
            // 
            this.iconUsers.BackColor = System.Drawing.Color.Firebrick;
            this.iconUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconUsers.FlatAppearance.BorderSize = 0;
            this.iconUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconUsers.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconUsers.ForeColor = System.Drawing.SystemColors.Info;
            this.iconUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconUsers.IconColor = System.Drawing.SystemColors.Info;
            this.iconUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUsers.IconSize = 55;
            this.iconUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconUsers.Location = new System.Drawing.Point(568, 24);
            this.iconUsers.Name = "iconUsers";
            this.iconUsers.Size = new System.Drawing.Size(104, 79);
            this.iconUsers.TabIndex = 8;
            this.iconUsers.Text = "Users";
            this.iconUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconUsers.UseVisualStyleBackColor = false;
            this.iconUsers.Click += new System.EventHandler(this.IconUsers_Click);
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
        private FontAwesome.Sharp.IconButton iconLogout;
        private FontAwesome.Sharp.IconButton iconHelp;
        private FontAwesome.Sharp.IconButton iconUsers;
    }
}