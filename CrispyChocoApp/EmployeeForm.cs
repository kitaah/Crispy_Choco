using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // package pour accès et interaction à la base de données
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrispyChocoApp
{
    public partial class EmployeeForm : Form // Formulaire pour l'affichage des données relatifs aux salariés dans l'espace administrateur
    {
        private readonly SqlConnection con = new(@"Data Source=.\sqlexpress;Initial Catalog=db_crispy_choco;Integrated Security=True");
        private SqlCommand cm = new();
        private SqlDataReader? dr;
        public EmployeeForm()
        {
            InitializeComponent();
            LoadEmployee();
        }

        // Affichage de l'ensemble des données relatifs aux salariés
        private void LoadEmployee()
        {
            try
            {
            int i = 0;
            dgvAdminEmployee.Rows.Clear();
            cm = new SqlCommand("SELECT employeeId,firstName,lastName,landlinePhoneNumber,mobilePhoneNumber,email,departmentId,department,siteId,site FROM tbEmployee WHERE lastName LIKE '%" + txtSearch.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvAdminEmployee.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
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
        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            EmployeeModuleForm employeeModuleForm = new();
            employeeModuleForm.btnUpdate.Enabled = false;
            employeeModuleForm.ShowDialog();
            LoadEmployee();
        }

        // Affichage du formulaire avec les données relatifs à un salarié, sélectionné dans le data grid view, pour modification / Suppression des données
        private void DgvAdminDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvAdminEmployee.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                EmployeeModuleForm employeeModuleForm = new();
                employeeModuleForm.lblEid.Text = dgvAdminEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                employeeModuleForm.txtFName.Text = dgvAdminEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                employeeModuleForm.txtLName.Text = dgvAdminEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                employeeModuleForm.txtLPNumber.Text = dgvAdminEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                employeeModuleForm.txtMPNumber.Text = dgvAdminEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                employeeModuleForm.txtEmail.Text = dgvAdminEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
                employeeModuleForm.lblDId.Text = dgvAdminEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();
                employeeModuleForm.txtDepartment.Text = dgvAdminEmployee.Rows[e.RowIndex].Cells[7].Value.ToString();
                employeeModuleForm.lblSId.Text = dgvAdminEmployee.Rows[e.RowIndex].Cells[8].Value.ToString();
                employeeModuleForm.txtSite.Text = dgvAdminEmployee.Rows[e.RowIndex].Cells[9].Value.ToString();

                employeeModuleForm.btnSave.Enabled = false;
                employeeModuleForm.ShowDialog();
            }
            else if (colName == "Delete" && MessageBox.Show("Are you sure you want to delete this employee ?", "DELETE THE EMPLOYEE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbEmployee WHERE employeeId LIKE '" + dgvAdminEmployee.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("The employee has been successfully deleted!", "EMPLOYEE DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            LoadEmployee();
        }

        // Modification des données depuis la barre de recherche
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadEmployee();
        }
    }
}
