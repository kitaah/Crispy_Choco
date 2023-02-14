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
    public partial class SearchEmployeeByLastNameForm : Form //Formulaire pour la recherche des employés
    {
        private readonly SqlConnection con = new(@"Data Source=.\sqlexpress;Initial Catalog=db_crispy_choco;Integrated Security=True");
        private SqlCommand cm = new();
        private SqlDataReader? dr;
        public SearchEmployeeByLastNameForm()
        {
            InitializeComponent();
            LoadEmployeeByLastName();
        }

        // Affichage des données relatives aux salariés en fonction de la barre de recherche associée (prise en compte du nom de famille)
        private void LoadEmployeeByLastName()
        {
            try
            {
                int i = 0;
                dgvEmployeeByLastName.Rows.Clear();
                cm = new SqlCommand("SELECT employeeId,firstName,lastName,landlinePhoneNumber,mobilePhoneNumber,email,department,site FROM tbEmployee WHERE lastName LIKE '%" + txtSearch.Text + "%'", con);
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dgvEmployeeByLastName.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
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

        // Data grid view invisible de base si la barre de recherche est vide
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgvEmployeeByLastName.Visible = false;
            }
            else
            {
                dgvEmployeeByLastName.Visible = true;
            }
            LoadEmployeeByLastName();
        }

        // Affichage de chaque fiche salarié propre à chaque salarié
        private void DgvEmployeeByLastName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvEmployeeByLastName.Columns[e.ColumnIndex].Name;
            if (colName == "Record")
            {
                EmployeeInfoVisitorForm employeeInfoVisitorForm = new();
                employeeInfoVisitorForm.lblEid.Text = dgvEmployeeByLastName.Rows[e.RowIndex].Cells[0].Value.ToString();
                employeeInfoVisitorForm.iconFName.Text = dgvEmployeeByLastName.Rows[e.RowIndex].Cells[1].Value.ToString();
                employeeInfoVisitorForm.iconLastName.Text = dgvEmployeeByLastName.Rows[e.RowIndex].Cells[2].Value.ToString();
                employeeInfoVisitorForm.iconLPN.Text = dgvEmployeeByLastName.Rows[e.RowIndex].Cells[3].Value.ToString();
                employeeInfoVisitorForm.iconMPN.Text = dgvEmployeeByLastName.Rows[e.RowIndex].Cells[4].Value.ToString();
                employeeInfoVisitorForm.iconEmail.Text = dgvEmployeeByLastName.Rows[e.RowIndex].Cells[5].Value.ToString();
                employeeInfoVisitorForm.iconDepartment.Text = dgvEmployeeByLastName.Rows[e.RowIndex].Cells[6].Value.ToString();
                employeeInfoVisitorForm.iconSite.Text = dgvEmployeeByLastName.Rows[e.RowIndex].Cells[7].Value.ToString();

                employeeInfoVisitorForm.ShowDialog();
            }
            LoadEmployeeByLastName();
        }
    }
}
