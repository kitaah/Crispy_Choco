namespace CrispyChocoApp
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.btnRegistration = new System.Windows.Forms.Button();
            this.txtRegPass = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.Label();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconLogin = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iconEyeSlash = new FontAwesome.Sharp.IconPictureBox();
            this.iconEye = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyeSlash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEye)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.Green;
            this.btnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistration.FlatAppearance.BorderSize = 0;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistration.Location = new System.Drawing.Point(165, 463);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(98, 48);
            this.btnRegistration.TabIndex = 12;
            this.btnRegistration.Text = "Sign in";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.BtnRegistration_Click);
            // 
            // txtRegPass
            // 
            this.txtRegPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegPass.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegPass.Location = new System.Drawing.Point(57, 323);
            this.txtRegPass.Name = "txtRegPass";
            this.txtRegPass.Size = new System.Drawing.Size(324, 32);
            this.txtRegPass.TabIndex = 11;
            this.txtRegPass.UseSystemPasswordChar = true;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.AutoSize = true;
            this.txtRegPassword.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegPassword.Location = new System.Drawing.Point(57, 296);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(103, 24);
            this.txtRegPassword.TabIndex = 10;
            this.txtRegPassword.Text = "Password:";
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegEmail.Location = new System.Drawing.Point(57, 242);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(324, 32);
            this.txtRegEmail.TabIndex = 9;
            this.txtRegEmail.TextChanged += new System.EventHandler(this.TxtRegEmail_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email:";
            // 
            // iconLogin
            // 
            this.iconLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.iconLogin.ForeColor = System.Drawing.Color.Maroon;
            this.iconLogin.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconLogin.IconColor = System.Drawing.Color.Maroon;
            this.iconLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogin.IconSize = 51;
            this.iconLogin.Location = new System.Drawing.Point(375, 36);
            this.iconLogin.Name = "iconLogin";
            this.iconLogin.Size = new System.Drawing.Size(51, 53);
            this.iconLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconLogin.TabIndex = 13;
            this.iconLogin.TabStop = false;
            this.iconLogin.Click += new System.EventHandler(this.IconLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "minimum eight characters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(56, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "one uppercase letter, one lowercase letter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(56, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "one digit and one special character";
            // 
            // iconEyeSlash
            // 
            this.iconEyeSlash.BackColor = System.Drawing.SystemColors.Window;
            this.iconEyeSlash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconEyeSlash.ForeColor = System.Drawing.Color.Blue;
            this.iconEyeSlash.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconEyeSlash.IconColor = System.Drawing.Color.Blue;
            this.iconEyeSlash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEyeSlash.Location = new System.Drawing.Point(342, 323);
            this.iconEyeSlash.Name = "iconEyeSlash";
            this.iconEyeSlash.Size = new System.Drawing.Size(39, 32);
            this.iconEyeSlash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconEyeSlash.TabIndex = 18;
            this.iconEyeSlash.TabStop = false;
            this.iconEyeSlash.Click += new System.EventHandler(this.IconEyeSlash_Click);
            // 
            // iconEye
            // 
            this.iconEye.BackColor = System.Drawing.SystemColors.Window;
            this.iconEye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconEye.ForeColor = System.Drawing.Color.Blue;
            this.iconEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconEye.IconColor = System.Drawing.Color.Blue;
            this.iconEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEye.Location = new System.Drawing.Point(342, 323);
            this.iconEye.Name = "iconEye";
            this.iconEye.Size = new System.Drawing.Size(39, 32);
            this.iconEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconEye.TabIndex = 19;
            this.iconEye.TabStop = false;
            this.iconEye.Click += new System.EventHandler(this.IconEye_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(438, 536);
            this.Controls.Add(this.iconEyeSlash);
            this.Controls.Add(this.iconEye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconLogin);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.txtRegPass);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRISPY CHOCO - Admin Registration Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyeSlash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegistration;
        private TextBox txtRegPass;
        private Label txtRegPassword;
        private TextBox txtRegEmail;
        private PictureBox pictureBox1;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconLogin;
        private Label label2;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconEyeSlash;
        private FontAwesome.Sharp.IconPictureBox iconEye;
    }
}