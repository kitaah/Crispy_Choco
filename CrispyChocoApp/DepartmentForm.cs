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
    public partial class DepartmentForm : Form
    {
        private readonly SqlConnection con = new(@"Data Source=.\sqlexpress;Initial Catalog=db_crispy_choco;Integrated Security=True");
        private SqlCommand cm = new();
        private SqlDataReader? dr;
        public DepartmentForm()
        {
            InitializeComponent();
            LoadDepartment();
        }
        private void LoadDepartment()
        {
            try {
                int i = 0;
                dgvAdminDepartment.Rows.Clear();
                cm = new SqlCommand("SELECT departmentId,departmentName FROM tbDepartment", con);
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dgvAdminDepartment.Rows.Add(dr[0].ToString(), dr[1].ToString());
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
            DepartmentModuleForm departmentModuleForm = new();
            departmentModuleForm.btnUpdate.Enabled = false;
            departmentModuleForm.ShowDialog();
            LoadDepartment();
        }
        private void DgvAdminDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvAdminDepartment.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                DepartmentModuleForm departmentModuleForm = new();
                departmentModuleForm.lblDid.Text = dgvAdminDepartment.Rows[e.RowIndex].Cells[0].Value.ToString();
                departmentModuleForm.txtDepartmentName.Text = dgvAdminDepartment.Rows[e.RowIndex].Cells[1].Value.ToString();

                departmentModuleForm.btnSave.Enabled = false;
                departmentModuleForm.ShowDialog();
            }
            else if (colName == "Delete" && MessageBox.Show("Are you sure you want to delete this department? You can't delete a department where at least one employee belongs to!", "DELETE THE DEPARTMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbDepartment WHERE departmentId LIKE '" + dgvAdminDepartment.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("The department has been successfully deleted!", "DEPARTMENT DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (con != null) con.Close();
                }
            }
            LoadDepartment();
        }
    }
}
