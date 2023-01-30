using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrispyChocoApp
{
    public partial class BeforeLoginForm : Form
    {
        public BeforeLoginForm() => InitializeComponent();
        private void BtnNumber_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "")
            {
                MessageBox.Show("Please complete the field!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtNumber.Text == "985743")
            {
                LoginForm loginForm = new();
                Hide();
                loginForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong number !", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Clear();
            }
        }
        private void IconRegistration_Click(object sender, EventArgs e)
        {
            BeforeRegistrationForm registrationForm = new();
            Hide();
            registrationForm.ShowDialog();
            Close();
        }
        private void BtnNumberZero_Click(object sender, EventArgs e)
        {
            txtNumber.Text += "0";
        }
        private void BtnNumberOne_Click(object sender, EventArgs e)
        {
            txtNumber.Text += "1";
        }
        private void btnNumberTwo_Click(object sender, EventArgs e)
        {
            txtNumber.Text += "2";
        }
        private void BtnNumberThree_Click(object sender, EventArgs e)
        {
            txtNumber.Text += "3";
        }
        private void BtnNumberFour_Click(object sender, EventArgs e)
        {
            txtNumber.Text += "4";
        }
        private void BtnNumberFive_Click(object sender, EventArgs e)
        {
            txtNumber.Text += "5";
        }
        private void BtnNumberSix_Click(object sender, EventArgs e)
        {
            txtNumber.Text += "6";
        }
        private void BtnNumberSeven_Click(object sender, EventArgs e)
        {
            txtNumber.Text += "7";
        }
        private void BtnNumberEight_Click(object sender, EventArgs e)
        {
            txtNumber.Text += "8";
        }
        private void BtnNumberNine_Click(object sender, EventArgs e)
        {
            txtNumber.Text += "9";
        }
        private void IconEye_Click(object sender, EventArgs e)
        {
            txtNumber.UseSystemPasswordChar = true;
            iconEyeSlash.BringToFront();
        }
        private void IconEyeSlash_Click(object sender, EventArgs e)
        {
            txtNumber.UseSystemPasswordChar = false;
            iconEye.BringToFront();
        }
    }
}
