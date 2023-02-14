using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // package pour accès et interaction avec la base de données
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrispyChocoApp
{
    public partial class AdminModuleForm : Form // Formulaire de modification ou de suppression de données d'un compte admin (hormis email)
    {
        private readonly SqlConnection con = new(@"Data Source=.\sqlexpress;Initial Catalog=db_crispy_choco;Integrated Security=True");
        private SqlCommand cm = new();
        public AdminModuleForm()
        {
            InitializeComponent();
        }

        // Modification de certaines données du compte admin
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtRetypePassword.Text == "")
            {
                MessageBox.Show("Please complete all the fields of the form!", "INVALID PASSWORD FORMAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword.Text == "" || !Regex.Match(txtPassword.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d.*)(?=.*\\W.*)[a-zA-Z0-9\\S]{8,}$").Success)
            {
                MessageBox.Show("Invalid password format!", "INVALID PASSWORD FORMAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtRetypePassword.Text == "" || !Regex.Match(txtRetypePassword.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d.*)(?=.*\\W.*)[a-zA-Z0-9\\S]{8,}$").Success)
            {
                MessageBox.Show("Invalid re-typed password format!", "INVALID PASSWORD FORMAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (txtPassword.Text != txtRetypePassword.Text)
                    {
                        MessageBox.Show("Password did not Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (MessageBox.Show("Are you sure you want to update this user ?", "UPDATE THE USER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("UPDATE tbAdmin SET password = @password WHERE adminId LIKE '" + lblAid.Text + "' ", con);
                        cm.Parameters.AddWithValue("password", txtPassword.Text);
                        con.Open();
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("User has been successfully updated !");
                        this.Dispose();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Visibilité ou non du mot de passe pour chaque champ
        private void IconEye_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            iconEyeSlash.BringToFront();
        }
        private void IconEyeSlash_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            iconEye.BringToFront();
        }
        private void IconEyeTwo_Click(object sender, EventArgs e)
        {
            txtRetypePassword.UseSystemPasswordChar = true;
            iconEyeSlashTwo.BringToFront();
        }
        private void IconEyeSlashTwo_Click(object sender, EventArgs e)
        {
            txtRetypePassword.UseSystemPasswordChar = false;
            iconEyeTwo.BringToFront();
        }
    }
}
