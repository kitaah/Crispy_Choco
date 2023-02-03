namespace CrispyChocoApp
{
    partial class AdminModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminModuleForm));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAid = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRetypePassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iconEye = new FontAwesome.Sharp.IconPictureBox();
            this.iconEyeSlash = new FontAwesome.Sharp.IconPictureBox();
            this.iconEyeSlashTwo = new FontAwesome.Sharp.IconPictureBox();
            this.iconEyeTwo = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyeSlash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyeSlashTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyeTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(366, 299);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 48);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(53, 61);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(411, 32);
            this.txtEmail.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Email:";
            // 
            // lblAid
            // 
            this.lblAid.AutoSize = true;
            this.lblAid.Location = new System.Drawing.Point(53, 316);
            this.lblAid.Name = "lblAid";
            this.lblAid.Size = new System.Drawing.Size(53, 18);
            this.lblAid.TabIndex = 26;
            this.lblAid.Text = "user id";
            this.lblAid.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(53, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(411, 32);
            this.txtPassword.TabIndex = 31;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Enter a new password:";
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRetypePassword.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRetypePassword.Location = new System.Drawing.Point(53, 233);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.Size = new System.Drawing.Size(411, 32);
            this.txtRetypePassword.TabIndex = 33;
            this.txtRetypePassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Re-type Password:";
            // 
            // iconEye
            // 
            this.iconEye.BackColor = System.Drawing.SystemColors.Window;
            this.iconEye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconEye.ForeColor = System.Drawing.Color.Blue;
            this.iconEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconEye.IconColor = System.Drawing.Color.Blue;
            this.iconEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEye.Location = new System.Drawing.Point(425, 146);
            this.iconEye.Name = "iconEye";
            this.iconEye.Size = new System.Drawing.Size(39, 32);
            this.iconEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconEye.TabIndex = 34;
            this.iconEye.TabStop = false;
            this.iconEye.Click += new System.EventHandler(this.IconEye_Click);
            // 
            // iconEyeSlash
            // 
            this.iconEyeSlash.BackColor = System.Drawing.SystemColors.Window;
            this.iconEyeSlash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconEyeSlash.ForeColor = System.Drawing.Color.Blue;
            this.iconEyeSlash.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconEyeSlash.IconColor = System.Drawing.Color.Blue;
            this.iconEyeSlash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEyeSlash.Location = new System.Drawing.Point(425, 146);
            this.iconEyeSlash.Name = "iconEyeSlash";
            this.iconEyeSlash.Size = new System.Drawing.Size(39, 32);
            this.iconEyeSlash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconEyeSlash.TabIndex = 36;
            this.iconEyeSlash.TabStop = false;
            this.iconEyeSlash.Click += new System.EventHandler(this.IconEyeSlash_Click);
            // 
            // iconEyeSlashTwo
            // 
            this.iconEyeSlashTwo.BackColor = System.Drawing.SystemColors.Window;
            this.iconEyeSlashTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconEyeSlashTwo.ForeColor = System.Drawing.Color.Blue;
            this.iconEyeSlashTwo.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconEyeSlashTwo.IconColor = System.Drawing.Color.Blue;
            this.iconEyeSlashTwo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEyeSlashTwo.Location = new System.Drawing.Point(425, 233);
            this.iconEyeSlashTwo.Name = "iconEyeSlashTwo";
            this.iconEyeSlashTwo.Size = new System.Drawing.Size(39, 32);
            this.iconEyeSlashTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconEyeSlashTwo.TabIndex = 37;
            this.iconEyeSlashTwo.TabStop = false;
            this.iconEyeSlashTwo.Click += new System.EventHandler(this.IconEyeSlashTwo_Click);
            // 
            // iconEyeTwo
            // 
            this.iconEyeTwo.BackColor = System.Drawing.SystemColors.Window;
            this.iconEyeTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconEyeTwo.ForeColor = System.Drawing.Color.Blue;
            this.iconEyeTwo.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconEyeTwo.IconColor = System.Drawing.Color.Blue;
            this.iconEyeTwo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEyeTwo.Location = new System.Drawing.Point(425, 233);
            this.iconEyeTwo.Name = "iconEyeTwo";
            this.iconEyeTwo.Size = new System.Drawing.Size(39, 32);
            this.iconEyeTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconEyeTwo.TabIndex = 38;
            this.iconEyeTwo.TabStop = false;
            this.iconEyeTwo.Click += new System.EventHandler(this.IconEyeTwo_Click);
            // 
            // AdminModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(524, 408);
            this.Controls.Add(this.iconEyeSlashTwo);
            this.Controls.Add(this.iconEyeTwo);
            this.Controls.Add(this.iconEyeSlash);
            this.Controls.Add(this.iconEye);
            this.Controls.Add(this.txtRetypePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAid);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminModuleForm";
            ((System.ComponentModel.ISupportInitialize)(this.iconEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyeSlash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyeSlashTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyeTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button btnUpdate;
        public TextBox txtEmail;
        private Label label1;
        public Label lblAid;
        public TextBox txtPassword;
        private Label label2;
        public TextBox txtRetypePassword;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconEye;
        private FontAwesome.Sharp.IconPictureBox iconEyeSlash;
        private FontAwesome.Sharp.IconPictureBox iconEyeSlashTwo;
        private FontAwesome.Sharp.IconPictureBox iconEyeTwo;
    }
}