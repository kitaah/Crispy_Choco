using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace CrispyChocoApp
{
    public partial class RegistrationForm : Form
    {
        private readonly SqlConnection con = new(@"Data Source=.\sqlexpress;Initial Catalog=db_crispy_choco;Integrated Security=True");
        private SqlCommand cm = new();
        private SqlDataReader? dr;
        public RegistrationForm() => InitializeComponent();
        private void TxtRegEmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtRegEmail.Text != "")
                {
                    cm = new SqlCommand("SELECT email FROM tbAdmin WHERE email=@email", con);
                    cm.Parameters.AddWithValue("@email", txtRegEmail.Text);
                    con.Open();
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("This account already exists!", "THIS ACCOUNT ALREADY EXISTS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRegEmail.Clear();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            try
            {
            if (txtRegEmail.Text == "" && txtRegPass.Text == "")
                {
                    MessageBox.Show("Please complete all the fields of the registration form!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtRegEmail.Text == "" || !Regex.Match(txtRegEmail.Text, "^[^@\\s]+@[^@\\s]+\\.(com)$").Success)
                {
                    MessageBox.Show("Invalid email format!", "INVALID EMAIL FORMAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtRegPass.Text == "" || !Regex.Match(txtRegPass.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d.*)(?=.*\\W.*)[a-zA-Z0-9\\S]{8,}$").Success)
                {
                    MessageBox.Show("Invalid password format!", "INVALID PASSWORD FORMAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cm = new SqlCommand("INSERT INTO tbAdmin(email,password)VALUES(@email,@password)", con);
                    cm.Parameters.AddWithValue("@email", txtRegEmail.Text);
                    cm.Parameters.AddWithValue("@password", txtRegPass.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your account has been successfully created!", "CONGRATULATIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRegEmail.Clear();
                    txtRegPass.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void IconLogin_Click(object sender, EventArgs e)
        {
            BeforeLoginForm beforeLoginForm = new();
            Hide();
            beforeLoginForm.ShowDialog();
            Close();
        }
        private void IconEye_Click(object sender, EventArgs e)
        {
            txtRegPass.UseSystemPasswordChar = true;
            iconEyeSlash.BringToFront();
        }
        private void IconEyeSlash_Click(object sender, EventArgs e)
        {
            txtRegPass.UseSystemPasswordChar = false;
            iconEye.BringToFront();
        }
    }
}
