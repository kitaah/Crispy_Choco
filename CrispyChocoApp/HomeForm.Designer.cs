namespace CrispyChocoApp
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.iconAdministrators = new FontAwesome.Sharp.IconButton();
            this.iconVisitors = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // iconAdministrators
            // 
            this.iconAdministrators.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconAdministrators.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconAdministrators.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconAdministrators.IconColor = System.Drawing.Color.Maroon;
            this.iconAdministrators.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAdministrators.IconSize = 70;
            this.iconAdministrators.Location = new System.Drawing.Point(154, 131);
            this.iconAdministrators.Name = "iconAdministrators";
            this.iconAdministrators.Size = new System.Drawing.Size(232, 193);
            this.iconAdministrators.TabIndex = 0;
            this.iconAdministrators.Text = "Administrators";
            this.iconAdministrators.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconAdministrators.UseVisualStyleBackColor = true;
            this.iconAdministrators.Click += new System.EventHandler(this.IconAdministrators_Click);
            // 
            // iconVisitors
            // 
            this.iconVisitors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconVisitors.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconVisitors.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            this.iconVisitors.IconColor = System.Drawing.Color.Maroon;
            this.iconVisitors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVisitors.IconSize = 70;
            this.iconVisitors.Location = new System.Drawing.Point(447, 131);
            this.iconVisitors.Name = "iconVisitors";
            this.iconVisitors.Size = new System.Drawing.Size(232, 193);
            this.iconVisitors.TabIndex = 1;
            this.iconVisitors.Text = "Visitors";
            this.iconVisitors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconVisitors.UseVisualStyleBackColor = true;
            this.iconVisitors.Click += new System.EventHandler(this.IconVisitors_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconVisitors);
            this.Controls.Add(this.iconAdministrators);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRISPY CHOCO - Home 🏠";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconAdministrators;
        private FontAwesome.Sharp.IconButton iconVisitors;
    }
}