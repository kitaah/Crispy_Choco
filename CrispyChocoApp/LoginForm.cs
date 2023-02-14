using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Package pour accès et interaction avec la bade de données
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CrispyChocoApp
{
    public partial class LoginForm : Form // Formulaire de login
    {
        private readonly SqlConnection con = new(@"Data Source=.\sqlexpress;Initial Catalog=db_crispy_choco;Integrated Security=True");
        private SqlCommand cm = new();
        private SqlDataReader? dr;
        public LoginForm() => InitializeComponent();
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLoginEmail.Text == "" || txtLoginPass.Text == "")
                {
                    MessageBox.Show("Please, complete all the fields of the login form!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cm = new SqlCommand("SELECT email,password FROM tbAdmin WHERE email=@email AND password=@password", con);
                    cm.Parameters.AddWithValue("@email", txtLoginEmail.Text);
                    cm.Parameters.AddWithValue("@password", txtLoginPass.Text);
                    con.Open();
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Welcome " + dr["email"].ToString() + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdministratorsMenuForm administratorsMenuForm = new();
                        Hide();
                        administratorsMenuForm.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void IconEye_Click(object sender, EventArgs e)
        {
            txtLoginPass.UseSystemPasswordChar = true;
            iconEyeSlash.BringToFront();
        }
        private void IconEyeSlash_Click(object sender, EventArgs e)
        {
            txtLoginPass.UseSystemPasswordChar = false;
            iconEye.BringToFront();
        }
    }
}
