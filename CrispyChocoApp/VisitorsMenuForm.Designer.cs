namespace CrispyChocoApp
{
    partial class VisitorsMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorsMenuForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconHelp = new FontAwesome.Sharp.IconButton();
            this.iconHome = new FontAwesome.Sharp.IconButton();
            this.iconEmployeesLastName = new FontAwesome.Sharp.IconButton();
            this.iconEmployeesDepartments = new FontAwesome.Sharp.IconButton();
            this.iconEmployeesSites = new FontAwesome.Sharp.IconButton();
            this.mainVisitorPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.mainVisitorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 721);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1622, 64);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(51, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Directory Software";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.iconHelp);
            this.panel1.Controls.Add(this.iconHome);
            this.panel1.Controls.Add(this.iconEmployeesLastName);
            this.panel1.Controls.Add(this.iconEmployeesDepartments);
            this.panel1.Controls.Add(this.iconEmployeesSites);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1622, 164);
            this.panel1.TabIndex = 3;
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
            this.iconHelp.Location = new System.Drawing.Point(1216, 42);
            this.iconHelp.Name = "iconHelp";
            this.iconHelp.Size = new System.Drawing.Size(126, 79);
            this.iconHelp.TabIndex = 10;
            this.iconHelp.Text = "Help";
            this.iconHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconHelp.UseVisualStyleBackColor = false;
            this.iconHelp.Click += new System.EventHandler(this.IconHelp_Click);
            // 
            // iconHome
            // 
            this.iconHome.BackColor = System.Drawing.Color.Firebrick;
            this.iconHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconHome.FlatAppearance.BorderSize = 0;
            this.iconHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconHome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconHome.ForeColor = System.Drawing.SystemColors.Info;
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconHome.IconColor = System.Drawing.SystemColors.Info;
            this.iconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHome.IconSize = 55;
            this.iconHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconHome.Location = new System.Drawing.Point(1402, 42);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(126, 79);
            this.iconHome.TabIndex = 9;
            this.iconHome.Text = "Home";
            this.iconHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconHome.UseVisualStyleBackColor = false;
            this.iconHome.Click += new System.EventHandler(this.IconHome_Click);
            // 
            // iconEmployeesLastName
            // 
            this.iconEmployeesLastName.BackColor = System.Drawing.Color.Firebrick;
            this.iconEmployeesLastName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconEmployeesLastName.FlatAppearance.BorderSize = 0;
            this.iconEmployeesLastName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEmployeesLastName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconEmployeesLastName.ForeColor = System.Drawing.SystemColors.Info;
            this.iconEmployeesLastName.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconEmployeesLastName.IconColor = System.Drawing.SystemColors.Info;
            this.iconEmployeesLastName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEmployeesLastName.IconSize = 55;
            this.iconEmployeesLastName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconEmployeesLastName.Location = new System.Drawing.Point(668, 42);
            this.iconEmployeesLastName.Name = "iconEmployeesLastName";
            this.iconEmployeesLastName.Size = new System.Drawing.Size(126, 79);
            this.iconEmployeesLastName.TabIndex = 8;
            this.iconEmployeesLastName.Text = "Last name";
            this.iconEmployeesLastName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconEmployeesLastName.UseVisualStyleBackColor = false;
            this.iconEmployeesLastName.Click += new System.EventHandler(this.iconEmployeesLastName_Click);
            // 
            // iconEmployeesDepartments
            // 
            this.iconEmployeesDepartments.BackColor = System.Drawing.Color.Firebrick;
            this.iconEmployeesDepartments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconEmployeesDepartments.FlatAppearance.BorderSize = 0;
            this.iconEmployeesDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEmployeesDepartments.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconEmployeesDepartments.ForeColor = System.Drawing.SystemColors.Info;
            this.iconEmployeesDepartments.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            this.iconEmployeesDepartments.IconColor = System.Drawing.SystemColors.Info;
            this.iconEmployeesDepartments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEmployeesDepartments.IconSize = 55;
            this.iconEmployeesDepartments.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconEmployeesDepartments.Location = new System.Drawing.Point(854, 42);
            this.iconEmployeesDepartments.Name = "iconEmployeesDepartments";
            this.iconEmployeesDepartments.Size = new System.Drawing.Size(138, 79);
            this.iconEmployeesDepartments.TabIndex = 7;
            this.iconEmployeesDepartments.Text = "Department";
            this.iconEmployeesDepartments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconEmployeesDepartments.UseVisualStyleBackColor = false;
            this.iconEmployeesDepartments.Click += new System.EventHandler(this.iconEmployeesDepartments_Click);
            // 
            // iconEmployeesSites
            // 
            this.iconEmployeesSites.BackColor = System.Drawing.Color.Firebrick;
            this.iconEmployeesSites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconEmployeesSites.FlatAppearance.BorderSize = 0;
            this.iconEmployeesSites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEmployeesSites.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconEmployeesSites.ForeColor = System.Drawing.SystemColors.Info;
            this.iconEmployeesSites.IconChar = FontAwesome.Sharp.IconChar.BuildingCircleArrowRight;
            this.iconEmployeesSites.IconColor = System.Drawing.SystemColors.Info;
            this.iconEmployeesSites.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEmployeesSites.IconSize = 55;
            this.iconEmployeesSites.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconEmployeesSites.Location = new System.Drawing.Point(1052, 42);
            this.iconEmployeesSites.Name = "iconEmployeesSites";
            this.iconEmployeesSites.Size = new System.Drawing.Size(104, 79);
            this.iconEmployeesSites.TabIndex = 6;
            this.iconEmployeesSites.Text = "Site";
            this.iconEmployeesSites.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconEmployeesSites.UseVisualStyleBackColor = false;
            this.iconEmployeesSites.Click += new System.EventHandler(this.iconEmployeesSites_Click);
            // 
            // mainVisitorPanel
            // 
            this.mainVisitorPanel.Controls.Add(this.label3);
            this.mainVisitorPanel.Controls.Add(this.pictureBox2);
            this.mainVisitorPanel.Controls.Add(this.label2);
            this.mainVisitorPanel.Controls.Add(this.pictureBox3);
            this.mainVisitorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainVisitorPanel.Location = new System.Drawing.Point(0, 164);
            this.mainVisitorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainVisitorPanel.Name = "mainVisitorPanel";
            this.mainVisitorPanel.Size = new System.Drawing.Size(1622, 557);
            this.mainVisitorPanel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(399, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(921, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "CLICK ON THE ICONS TO SEARCH AN EMPLOYEE BASED ON THE LAST NAME, DEPARTMENT OR SI" +
    "TE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(744, 256);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(680, 424);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "VISITOR DASHBOARD";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(448, 80);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(784, 176);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // VisitorsMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1622, 785);
            this.Controls.Add(this.mainVisitorPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisitorsMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRISPY CHOCO - Visitors Dashboard 🏠";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainVisitorPanel.ResumeLayout(false);
            this.mainVisitorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel mainVisitorPanel;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton iconEmployeesLastName;
        private FontAwesome.Sharp.IconButton iconEmployeesDepartments;
        private FontAwesome.Sharp.IconButton iconEmployeesSites;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconHome;
        private FontAwesome.Sharp.IconButton iconHelp;
    }
}