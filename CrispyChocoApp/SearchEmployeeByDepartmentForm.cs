using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CrispyChocoApp
{
    public partial class SearchEmployeeByDepartmentForm : Form
    {
        private readonly SqlConnection con = new(@"Data Source=.\sqlexpress;Initial Catalog=db_crispy_choco;Integrated Security=True");
        private SqlCommand cm = new();
        private SqlDataReader? dr;
        public SearchEmployeeByDepartmentForm()
        {
            InitializeComponent();
            LoadEmployeeByDepartment();
            LoadDepartment();
        }
        private void LoadEmployeeByDepartment()
        {
            try
            {
                int i = 0;
                dgvEmployeeByDepartment.Rows.Clear();
                cm = new SqlCommand("SELECT employeeId,firstName,lastName,landlinePhoneNumber,mobilePhoneNumber,email,department,site FROM tbEmployee WHERE department LIKE '%" + comboDepartment.Text + "%'", con);
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dgvEmployeeByDepartment.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
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
        private void ComboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDepartment.Text == "")
            {
                dgvEmployeeByDepartment.Visible = false;
            }
            else
            {
                dgvEmployeeByDepartment.Visible = true;
            }
            LoadEmployeeByDepartment();
        }
        private void LoadDepartment()
        {
            try
            {
                int i = 0;
                comboDepartment.Items.Clear();
                cm = new SqlCommand("Select departmentName FROM tbDepartment", con);
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    comboDepartment.Items.Add(dr[0].ToString());
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
        private void DgvEmployeeByDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvEmployeeByDepartment.Columns[e.ColumnIndex].Name;
            if (colName == "Record")
            {
                EmployeeInfoVisitorForm employeeInfoVisitorForm = new();
                employeeInfoVisitorForm.lblEid.Text = dgvEmployeeByDepartment.Rows[e.RowIndex].Cells[0].Value.ToString();
                employeeInfoVisitorForm.iconFName.Text = dgvEmployeeByDepartment.Rows[e.RowIndex].Cells[1].Value.ToString();
                employeeInfoVisitorForm.iconLastName.Text = dgvEmployeeByDepartment.Rows[e.RowIndex].Cells[2].Value.ToString();
                employeeInfoVisitorForm.iconLPN.Text = dgvEmployeeByDepartment.Rows[e.RowIndex].Cells[3].Value.ToString();
                employeeInfoVisitorForm.iconMPN.Text = dgvEmployeeByDepartment.Rows[e.RowIndex].Cells[4].Value.ToString();
                employeeInfoVisitorForm.iconEmail.Text = dgvEmployeeByDepartment.Rows[e.RowIndex].Cells[5].Value.ToString();
                employeeInfoVisitorForm.iconDepartment.Text = dgvEmployeeByDepartment.Rows[e.RowIndex].Cells[6].Value.ToString();
                employeeInfoVisitorForm.iconSite.Text = dgvEmployeeByDepartment.Rows[e.RowIndex].Cells[7].Value.ToString();

                employeeInfoVisitorForm.ShowDialog();
            }
            LoadEmployeeByDepartment();
        }
    }
}
