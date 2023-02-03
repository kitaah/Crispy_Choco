using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrispyChocoApp
{
    public partial class SiteModuleForm : Form
    {
        private readonly SqlConnection con = new(@"Data Source=.\sqlexpress;Initial Catalog=db_crispy_choco;Integrated Security=True");
        private SqlCommand cm = new();
        private SqlDataReader? dr;
        public SiteModuleForm() => InitializeComponent();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCity.Text != "")
                {
                    cm = new SqlCommand("SELECT city FROM tbSite WHERE city=@city", con);
                    cm.Parameters.AddWithValue("@city", txtCity.Text);
                    con.Open();
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("This city already exists!", "THIS CITY ALREADY EXISTS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCity.Clear();
                        return;
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }

            try
            {
                if (txtCity.Text == "")
                {
                    MessageBox.Show("Please, complete the field of the form!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cm = new SqlCommand("INSERT INTO tbSite(city)VALUES(@city)", con);
                    cm.Parameters.AddWithValue("@city", txtCity.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("The city has been successfully added!", " CITY ADDED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCity.Text != "")
                {
                    cm = new SqlCommand("SELECT city FROM tbSite WHERE city=@city", con);
                    cm.Parameters.AddWithValue("@city", txtCity.Text);
                    con.Open();
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("This city already exists!", "THIS CITY ALREADY EXISTS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCity.Clear();
                        return;
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }

            try
            {
                if (txtCity.Text == "")
                {
                    MessageBox.Show("Please, complete the field of the form!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cm = new SqlCommand("UPDATE tbSite SET city = @city WHERE siteId LIKE '" + lblSid.Text + "' ", con);
                    cm.Parameters.AddWithValue("@city", txtCity.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("The city has been successfully updated!", " CITY UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
