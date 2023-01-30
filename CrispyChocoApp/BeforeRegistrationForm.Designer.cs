namespace CrispyChocoApp
{
    partial class BeforeRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeforeRegistrationForm));
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnNumber = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNumberZero = new FontAwesome.Sharp.IconButton();
            this.btnNumberNine = new FontAwesome.Sharp.IconButton();
            this.btnNumberEight = new FontAwesome.Sharp.IconButton();
            this.btnNumberSeven = new FontAwesome.Sharp.IconButton();
            this.btnNumberSix = new FontAwesome.Sharp.IconButton();
            this.btnNumberFive = new FontAwesome.Sharp.IconButton();
            this.btnNumberFour = new FontAwesome.Sharp.IconButton();
            this.btnNumberThree = new FontAwesome.Sharp.IconButton();
            this.btnNumberTwo = new FontAwesome.Sharp.IconButton();
            this.btnNumberOne = new FontAwesome.Sharp.IconButton();
            this.iconEyeSlash = new FontAwesome.Sharp.IconPictureBox();
            this.iconEye = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyeSlash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEye)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumber.Location = new System.Drawing.Point(88, 160);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(264, 32);
            this.txtNumber.TabIndex = 7;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumber.UseSystemPasswordChar = true;
            // 
            // btnNumber
            // 
            this.btnNumber.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNumber.FlatAppearance.BorderSize = 0;
            this.btnNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNumber.Location = new System.Drawing.Point(168, 480);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(96, 40);
            this.btnNumber.TabIndex = 6;
            this.btnNumber.Text = "Enter";
            this.btnNumber.UseVisualStyleBackColor = false;
            this.btnNumber.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(96, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "TYPE THE RIGHT NUMBER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNumberZero
            // 
            this.btnNumberZero.BackColor = System.Drawing.Color.Green;
            this.btnNumberZero.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNumberZero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNumberZero.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNumberZero.IconColor = System.Drawing.Color.Black;
            this.btnNumberZero.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNumberZero.Location = new System.Drawing.Point(192, 216);
            this.btnNumberZero.Name = "btnNumberZero";
            this.btnNumberZero.Size = new System.Drawing.Size(64, 48);
            this.btnNumberZero.TabIndex = 35;
            this.btnNumberZero.Text = "0";
            this.btnNumberZero.UseVisualStyleBackColor = false;
            this.btnNumberZero.Click += new System.EventHandler(this.BtnNumberZero_Click);
            // 
            // btnNumberNine
            // 
            this.btnNumberNine.BackColor = System.Drawing.Color.Green;
            this.btnNumberNine.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNumberNine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNumberNine.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNumberNine.IconColor = System.Drawing.Color.Black;
            this.btnNumberNine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNumberNine.Location = new System.Drawing.Point(272, 408);
            this.btnNumberNine.Name = "btnNumberNine";
            this.btnNumberNine.Size = new System.Drawing.Size(64, 48);
            this.btnNumberNine.TabIndex = 34;
            this.btnNumberNine.Text = "9";
            this.btnNumberNine.UseVisualStyleBackColor = false;
            this.btnNumberNine.Click += new System.EventHandler(this.BtnNumberNine_Click);
            // 
            // btnNumberEight
            // 
            this.btnNumberEight.BackColor = System.Drawing.Color.Green;
            this.btnNumberEight.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNumberEight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNumberEight.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNumberEight.IconColor = System.Drawing.Color.Black;
            this.btnNumberEight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNumberEight.Location = new System.Drawing.Point(192, 408);
            this.btnNumberEight.Name = "btnNumberEight";
            this.btnNumberEight.Size = new System.Drawing.Size(64, 48);
            this.btnNumberEight.TabIndex = 33;
            this.btnNumberEight.Text = "8";
            this.btnNumberEight.UseVisualStyleBackColor = false;
            this.btnNumberEight.Click += new System.EventHandler(this.BtnNumberEight_Click);
            // 
            // btnNumberSeven
            // 
            this.btnNumberSeven.BackColor = System.Drawing.Color.Green;
            this.btnNumberSeven.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNumberSeven.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNumberSeven.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNumberSeven.IconColor = System.Drawing.Color.Black;
            this.btnNumberSeven.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNumberSeven.Location = new System.Drawing.Point(104, 408);
            this.btnNumberSeven.Name = "btnNumberSeven";
            this.btnNumberSeven.Size = new System.Drawing.Size(64, 48);
            this.btnNumberSeven.TabIndex = 32;
            this.btnNumberSeven.Text = "7";
            this.btnNumberSeven.UseVisualStyleBackColor = false;
            this.btnNumberSeven.Click += new System.EventHandler(this.BtnNumberSeven_Click);
            // 
            // btnNumberSix
            // 
            this.btnNumberSix.BackColor = System.Drawing.Color.Green;
            this.btnNumberSix.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNumberSix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNumberSix.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNumberSix.IconColor = System.Drawing.Color.Black;
            this.btnNumberSix.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNumberSix.Location = new System.Drawing.Point(272, 344);
            this.btnNumberSix.Name = "btnNumberSix";
            this.btnNumberSix.Size = new System.Drawing.Size(64, 48);
            this.btnNumberSix.TabIndex = 31;
            this.btnNumberSix.Text = "6";
            this.btnNumberSix.UseVisualStyleBackColor = false;
            this.btnNumberSix.Click += new System.EventHandler(this.BtnNumberSix_Click);
            // 
            // btnNumberFive
            // 
            this.btnNumberFive.BackColor = System.Drawing.Color.Green;
            this.btnNumberFive.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNumberFive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNumberFive.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNumberFive.IconColor = System.Drawing.Color.Black;
            this.btnNumberFive.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNumberFive.Location = new System.Drawing.Point(192, 344);
            this.btnNumberFive.Name = "btnNumberFive";
            this.btnNumberFive.Size = new System.Drawing.Size(64, 48);
            this.btnNumberFive.TabIndex = 30;
            this.btnNumberFive.Text = "5";
            this.btnNumberFive.UseVisualStyleBackColor = false;
            this.btnNumberFive.Click += new System.EventHandler(this.BtnNumberFive_Click);
            // 
            // btnNumberFour
            // 
            this.btnNumberFour.BackColor = System.Drawing.Color.Green;
            this.btnNumberFour.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNumberFour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNumberFour.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNumberFour.IconColor = System.Drawing.Color.Black;
            this.btnNumberFour.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNumberFour.Location = new System.Drawing.Point(104, 344);
            this.btnNumberFour.Name = "btnNumberFour";
            this.btnNumberFour.Size = new System.Drawing.Size(64, 48);
            this.btnNumberFour.TabIndex = 29;
            this.btnNumberFour.Text = "4";
            this.btnNumberFour.UseVisualStyleBackColor = false;
            this.btnNumberFour.Click += new System.EventHandler(this.BtnNumberFour_Click);
            // 
            // btnNumberThree
            // 
            this.btnNumberThree.BackColor = System.Drawing.Color.Green;
            this.btnNumberThree.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNumberThree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNumberThree.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNumberThree.IconColor = System.Drawing.Color.Black;
            this.btnNumberThree.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNumberThree.Location = new System.Drawing.Point(272, 280);
            this.btnNumberThree.Name = "btnNumberThree";
            this.btnNumberThree.Size = new System.Drawing.Size(64, 48);
            this.btnNumberThree.TabIndex = 28;
            this.btnNumberThree.Text = "3";
            this.btnNumberThree.UseVisualStyleBackColor = false;
            this.btnNumberThree.Click += new System.EventHandler(this.BtnNumberThree_Click);
            // 
            // btnNumberTwo
            // 
            this.btnNumberTwo.BackColor = System.Drawing.Color.Green;
            this.btnNumberTwo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNumberTwo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNumberTwo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNumberTwo.IconColor = System.Drawing.Color.Black;
            this.btnNumberTwo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNumberTwo.Location = new System.Drawing.Point(192, 280);
            this.btnNumberTwo.Name = "btnNumberTwo";
            this.btnNumberTwo.Size = new System.Drawing.Size(64, 48);
            this.btnNumberTwo.TabIndex = 27;
            this.btnNumberTwo.Text = "2";
            this.btnNumberTwo.UseVisualStyleBackColor = false;
            this.btnNumberTwo.Click += new System.EventHandler(this.BtnNumberTwo_Click);
            // 
            // btnNumberOne
            // 
            this.btnNumberOne.BackColor = System.Drawing.Color.Green;
            this.btnNumberOne.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNumberOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNumberOne.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNumberOne.IconColor = System.Drawing.Color.Black;
            this.btnNumberOne.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNumberOne.Location = new System.Drawing.Point(104, 280);
            this.btnNumberOne.Name = "btnNumberOne";
            this.btnNumberOne.Size = new System.Drawing.Size(64, 48);
            this.btnNumberOne.TabIndex = 26;
            this.btnNumberOne.Text = "1";
            this.btnNumberOne.UseVisualStyleBackColor = false;
            this.btnNumberOne.Click += new System.EventHandler(this.BtnNumberOne_Click);
            // 
            // iconEyeSlash
            // 
            this.iconEyeSlash.BackColor = System.Drawing.SystemColors.Window;
            this.iconEyeSlash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconEyeSlash.ForeColor = System.Drawing.Color.Blue;
            this.iconEyeSlash.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconEyeSlash.IconColor = System.Drawing.Color.Blue;
            this.iconEyeSlash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEyeSlash.Location = new System.Drawing.Point(312, 160);
            this.iconEyeSlash.Name = "iconEyeSlash";
            this.iconEyeSlash.Size = new System.Drawing.Size(40, 32);
            this.iconEyeSlash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconEyeSlash.TabIndex = 37;
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
            this.iconEye.Location = new System.Drawing.Point(312, 160);
            this.iconEye.Name = "iconEye";
            this.iconEye.Size = new System.Drawing.Size(40, 32);
            this.iconEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconEye.TabIndex = 36;
            this.iconEye.TabStop = false;
            this.iconEye.Click += new System.EventHandler(this.IconEye_Click);
            // 
            // BeforeRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(438, 546);
            this.Controls.Add(this.iconEyeSlash);
            this.Controls.Add(this.iconEye);
            this.Controls.Add(this.btnNumberZero);
            this.Controls.Add(this.btnNumberNine);
            this.Controls.Add(this.btnNumberEight);
            this.Controls.Add(this.btnNumberSeven);
            this.Controls.Add(this.btnNumberSix);
            this.Controls.Add(this.btnNumberFive);
            this.Controls.Add(this.btnNumberFour);
            this.Controls.Add(this.btnNumberThree);
            this.Controls.Add(this.btnNumberTwo);
            this.Controls.Add(this.btnNumberOne);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BeforeRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRISPY CHOCO - Before Admin Registration 🔒 ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyeSlash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNumber;
        private Button btnNumber;
        private PictureBox pictureBox1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnNumberZero;
        private FontAwesome.Sharp.IconButton btnNumberNine;
        private FontAwesome.Sharp.IconButton btnNumberEight;
        private FontAwesome.Sharp.IconButton btnNumberSeven;
        private FontAwesome.Sharp.IconButton btnNumberSix;
        private FontAwesome.Sharp.IconButton btnNumberFive;
        private FontAwesome.Sharp.IconButton btnNumberFour;
        private FontAwesome.Sharp.IconButton btnNumberThree;
        private FontAwesome.Sharp.IconButton btnNumberTwo;
        private FontAwesome.Sharp.IconButton btnNumberOne;
        private FontAwesome.Sharp.IconPictureBox iconEyeSlash;
        private FontAwesome.Sharp.IconPictureBox iconEye;
    }
}