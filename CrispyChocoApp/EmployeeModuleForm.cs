using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrispyChocoApp
{
    public partial class EmployeeModuleForm : Form
    {
        private readonly SqlConnection con = new(@"Data Source=.\sqlexpress;Initial Catalog=db_crispy_choco;Integrated Security=True");
        private SqlCommand cm = new();
        private SqlDataReader? dr;
        public EmployeeModuleForm()
        {
            InitializeComponent();
            LoadDepartment();
            LoadSite();
        }
        private void LoadDepartment()
        {
            try
            {
                int i = 0;
                dgvAdminChooseDepartment.Rows.Clear();
                cm = new SqlCommand("SELECT departmentId,departmentName FROM tbDepartment", con);
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dgvAdminChooseDepartment.Rows.Add(dr[0].ToString(), dr[1].ToString());
                    i++;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadSite()
        {
            try
            {
                int i = 0;
                dgvAdminChooseSite.Rows.Clear();
                cm = new SqlCommand("SELECT siteId,city FROM tbSite", con);
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dgvAdminChooseSite.Rows.Add(dr[0].ToString(), dr[1].ToString());
                    i++;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text != "")
                {
                    cm = new SqlCommand("SELECT email FROM tbEmployee WHERE email=@email", con);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    con.Open();
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("This user already exists!", "THIS USER ALREADY EXISTS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtFName.Clear();
                        txtLName.Clear();
                        txtLPNumber.Clear();
                        txtMPNumber.Clear();
                        txtEmail.Clear();
                        txtDepartment.Clear();
                        txtSite.Clear();
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
                if (txtFName.Text == "" || txtLName.Text == "" || txtLPNumber.Text == "" || txtMPNumber.Text == "" || txtEmail.Text == "" || txtDepartment.Text == "" || txtSite.Text == "")
                {
                    MessageBox.Show("Please, complete all the fields of the form!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Regex.Match(txtLPNumber.Text, "^[2-9]\\d{2}-\\d{3}-\\d{4}$").Success)
                {
                    MessageBox.Show("Invalid landline phone number format!", "INVALID LANDLINE PHONE NUMBER FORMAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Regex.Match(txtMPNumber.Text, "^[2-9]\\d{2}-\\d{3}-\\d{4}$").Success)
                {
                    MessageBox.Show("Invalid mobile phone number format!", "INVALID MOBILE PHONE NUMBER FORMAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Regex.Match(txtEmail.Text, "^[^@\\s]+@[^@\\s]+\\.(com)$").Success)
                {
                    MessageBox.Show("Invalid email format!", "INVALID EMAIL FORMAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cm = new SqlCommand("INSERT INTO tbEmployee(firstName,lastName,landlinePhoneNumber,mobilePhoneNumber,email,departmentId,department,siteId,site)VALUES(@firstName,@lastName,@landlinePhoneNumber,@mobilePhoneNumber,@email,@departmentId,@department,@siteId,@site)", con);
                    cm.Parameters.AddWithValue("@firstName", txtFName.Text);
                    cm.Parameters.AddWithValue("@lastName", txtLName.Text);
                    cm.Parameters.AddWithValue("@landlinePhoneNumber", txtLPNumber.Text);
                    cm.Parameters.AddWithValue("@mobilePhoneNumber", txtMPNumber.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@departmentId", lblDId.Text);
                    cm.Parameters.AddWithValue("@department", txtDepartment.Text);
                    cm.Parameters.AddWithValue("@siteId", lblSId.Text);
                    cm.Parameters.AddWithValue("@site", txtSite.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("The employee has been successfully added!", "EMPLOYEE ADDED", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (txtFName.Text == "" || txtLName.Text == "" || txtLPNumber.Text == "" || txtMPNumber.Text == "" || txtEmail.Text == "" || txtDepartment.Text == "" || txtSite.Text == "")
                {
                    MessageBox.Show("Please, complete the field of the form!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Regex.Match(txtLPNumber.Text, "^[2-9]\\d{2}-\\d{3}-\\d{4}$").Success)
                {
                    MessageBox.Show("Invalid landline phone number format!", "INVALID LANDLINE PHONE NUMBER FORMAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Regex.Match(txtMPNumber.Text, "^[2-9]\\d{2}-\\d{3}-\\d{4}$").Success)
                {
                    MessageBox.Show("Invalid mobile phone number format!", "INVALID MOBILE PHONE NUMBER FORMAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Regex.Match(txtEmail.Text, "^[^@\\s]+@[^@\\s]+\\.(com)$").Success)
                {
                    MessageBox.Show("Invalid email format!", "INVALID EMAIL FORMAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cm = new SqlCommand("UPDATE tbEmployee SET firstName = @firstName,lastName = @lastName,landlinePhoneNumber = @landlinePhoneNumber,mobilePhoneNumber = @mobilePhoneNumber,email = @email,@departmentid = @departmentId ,department = @department,siteId = @siteId ,site = @site WHERE employeeId LIKE '" + lblEid.Text + "' ", con);
                    cm.Parameters.AddWithValue("@firstName", txtFName.Text);
                    cm.Parameters.AddWithValue("@lastName", txtLName.Text);
                    cm.Parameters.AddWithValue("@landlinePhoneNumber", txtLPNumber.Text);
                    cm.Parameters.AddWithValue("@mobilePhoneNumber", txtMPNumber.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@departmentId", lblDId.Text);
                    cm.Parameters.AddWithValue("@department", txtDepartment.Text);
                    cm.Parameters.AddWithValue("@siteId", lblSId.Text);
                    cm.Parameters.AddWithValue("@site", txtSite.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("The employee has been successfully updated!", " EMPLOYEE UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvAdminChooseDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDId.Text = dgvAdminChooseDepartment.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDepartment.Text = dgvAdminChooseDepartment.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void dgvAdminChooseSite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSId.Text = dgvAdminChooseSite.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSite.Text = dgvAdminChooseSite.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
