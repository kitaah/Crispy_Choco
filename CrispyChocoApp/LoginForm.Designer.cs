namespace CrispyChocoApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.iconEye = new FontAwesome.Sharp.IconPictureBox();
            this.iconEyeSlash = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyeSlash)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLoginEmail.Location = new System.Drawing.Point(52, 218);
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(324, 32);
            this.txtLoginEmail.TabIndex = 3;
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginPass.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLoginPass.Location = new System.Drawing.Point(52, 299);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.Size = new System.Drawing.Size(324, 32);
            this.txtLoginPass.TabIndex = 5;
            this.txtLoginPass.UseSystemPasswordChar = true;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.AutoSize = true;
            this.txtRegPassword.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegPassword.Location = new System.Drawing.Point(52, 272);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(103, 24);
            this.txtRegPassword.TabIndex = 4;
            this.txtRegPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(162, 359);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 48);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // iconEye
            // 
            this.iconEye.BackColor = System.Drawing.SystemColors.Window;
            this.iconEye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconEye.ForeColor = System.Drawing.Color.Blue;
            this.iconEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconEye.IconColor = System.Drawing.Color.Blue;
            this.iconEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEye.Location = new System.Drawing.Point(337, 299);
            this.iconEye.Name = "iconEye";
            this.iconEye.Size = new System.Drawing.Size(39, 32);
            this.iconEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconEye.TabIndex = 20;
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
            this.iconEyeSlash.Location = new System.Drawing.Point(337, 299);
            this.iconEyeSlash.Name = "iconEyeSlash";
            this.iconEyeSlash.Size = new System.Drawing.Size(39, 32);
            this.iconEyeSlash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconEyeSlash.TabIndex = 21;
            this.iconEyeSlash.TabStop = false;
            this.iconEyeSlash.Click += new System.EventHandler(this.IconEyeSlash_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(438, 441);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.txtLoginEmail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconEyeSlash);
            this.Controls.Add(this.iconEye);
            this.Controls.Add(this.txtLoginPass);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRISPY CHOCO - Admin Login 🔒";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyeSlash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtLoginPass;
        private Label txtRegPassword;
        private Button btnLogin;
        private FontAwesome.Sharp.IconPictureBox iconEye;
        private FontAwesome.Sharp.IconPictureBox iconEyeSlash;
        private TextBox txtLoginEmail;
    }
}