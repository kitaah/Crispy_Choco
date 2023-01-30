using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrispyChocoApp
{
    public partial class BeforeRegistrationForm : Form
    {
        public BeforeRegistrationForm() => InitializeComponent();
        private void BtnNumber_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "")
            {
                MessageBox.Show("Please complete the field!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtNumber.Text == "138276")
            {
                RegistrationForm registrationForm = new();
                Hide();
                registrationForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong number!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Clear();
            }
        }
        private void BtnNumberZero_Click(object sender, EventArgs e)
        {
            txtNumber.Text += "0";
        }
        private void BtnNumberOne_Click(object sender, EventArgs e)
        {
            txtNumber.Text += "1";
        }
        private void BtnNumberTwo_Click(object sender, EventArgs e)
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
