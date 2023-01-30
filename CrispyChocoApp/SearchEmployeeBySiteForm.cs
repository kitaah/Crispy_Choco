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
    public partial class SearchEmployeeBySiteForm : Form
    {
        private readonly SqlConnection con = new(@"Data Source=.\sqlexpress;Initial Catalog=db_crispy_choco;Integrated Security=True");
        private SqlCommand cm = new();
        private SqlDataReader? dr;
        public SearchEmployeeBySiteForm()
        {
            InitializeComponent();
            LoadEmployee();
            LoadEmployeeBySite();
        }
        private void LoadEmployeeBySite()
        {
            try
            {
                int i = 0;
                dgvEmployeeBySite.Rows.Clear();
                cm = new SqlCommand("SELECT employeeId,firstName,lastName,landlinePhoneNumber,mobilePhoneNumber,email,department,site FROM tbEmployee WHERE site LIKE '%" + comboSite.Text + "%'", con);
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dgvEmployeeBySite.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
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
        private void LoadEmployee()
        {
            try
            {
                int i = 0;
                comboSite.Items.Clear();
                cm = new SqlCommand("Select city FROM tbSite", con);
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    comboSite.Items.Add(dr[0].ToString());
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
        private void comboSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSite.Text == "")
            {
                dgvEmployeeBySite.Visible = false;
            }
            else
            {
                dgvEmployeeBySite.Visible = true;
            }
            LoadEmployeeBySite();
        }
        private void DgvEmployeeBySite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvEmployeeBySite.Columns[e.ColumnIndex].Name;
            if (colName == "Record")
            {
                EmployeeInfoVisitorForm employeeInfoVisitorForm = new();
                employeeInfoVisitorForm.lblEid.Text = dgvEmployeeBySite.Rows[e.RowIndex].Cells[0].Value.ToString();
                employeeInfoVisitorForm.iconFName.Text = dgvEmployeeBySite.Rows[e.RowIndex].Cells[1].Value.ToString();
                employeeInfoVisitorForm.iconLastName.Text = dgvEmployeeBySite.Rows[e.RowIndex].Cells[2].Value.ToString();
                employeeInfoVisitorForm.iconLPN.Text = dgvEmployeeBySite.Rows[e.RowIndex].Cells[3].Value.ToString();
                employeeInfoVisitorForm.iconMPN.Text = dgvEmployeeBySite.Rows[e.RowIndex].Cells[4].Value.ToString();
                employeeInfoVisitorForm.iconEmail.Text = dgvEmployeeBySite.Rows[e.RowIndex].Cells[5].Value.ToString();
                employeeInfoVisitorForm.iconDepartment.Text = dgvEmployeeBySite.Rows[e.RowIndex].Cells[6].Value.ToString();
                employeeInfoVisitorForm.iconSite.Text = dgvEmployeeBySite.Rows[e.RowIndex].Cells[7].Value.ToString();

                employeeInfoVisitorForm.ShowDialog();
            }
            LoadEmployeeBySite();
        }
    }
}
