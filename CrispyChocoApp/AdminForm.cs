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
    public partial class AdminForm : Form
    {
        private readonly SqlConnection con = new(@"Data Source=.\sqlexpress;Initial Catalog=db_crispy_choco;Integrated Security=True");
        private SqlCommand cm = new();
        private SqlDataReader? dr;
        public AdminForm()
        {
            InitializeComponent();
            LoadAdmin();
        }
        private void LoadAdmin()
        {
            try
            {
                int i = 0;
                dgvAdminAccount.Rows.Clear();
                cm = new SqlCommand("SELECT adminId,email,password FROM tbAdmin", con);
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dgvAdminAccount.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
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

        private void DgvAdminAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvAdminAccount.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                AdminModuleForm adminModuleForm = new();
                adminModuleForm.lblAid.Text = dgvAdminAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
                adminModuleForm.txtEmail.Text = dgvAdminAccount.Rows[e.RowIndex].Cells[1].Value.ToString();
                adminModuleForm.txtPassword.Text = dgvAdminAccount.Rows[e.RowIndex].Cells[2].Value.ToString();
                adminModuleForm.ShowDialog();
            }
            else if (colName == "Delete" && MessageBox.Show("Are you sure you want to delete this user?", "DELETE THE USER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbAdmin WHERE adminId LIKE '" + dgvAdminAccount.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("The user has been successfully deleted!", "USER DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (con != null) con.Close();
                }
            }
            LoadAdmin();
        }
    }
}
