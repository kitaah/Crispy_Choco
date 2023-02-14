using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; //package pour accès et interaction avec la base de données
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CrispyChocoApp
{
    public partial class SiteForm : Form //Formulaire pour les sites de l'espace administrateur
    {
        private SqlConnection con = new(@"Data Source=.\sqlexpress;Initial Catalog=db_crispy_choco;Integrated Security=True");
        private SqlCommand cm = new();
        private SqlDataReader? dr;
        public SiteForm()
        {
            InitializeComponent();
            LoadSite();
        }

        // Sélection et affichage des données relatifs au nom de la ville propre à chaque site
        private void LoadSite()
        {
            try
            {
            int i = 0;
            dgvAdminSite.Rows.Clear();
            cm = new SqlCommand("SELECT siteId, city FROM tbSite", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvAdminSite.Rows.Add(dr[0].ToString(), dr[1].ToString());
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

        // Bouton update inactif lors de l'ajout de données
        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            SiteModuleForm siteModuleForm = new();
            siteModuleForm.btnUpdate.Enabled = false;
            siteModuleForm.ShowDialog();
            LoadSite();
        }

        // Affichage du formulaire avec les données relatifs à la ville des sites associés, sélectionné dans le data grid view, pour modification / Suppression des données
        private void DgvAdminSite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvAdminSite.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                SiteModuleForm siteModuleForm = new();
                siteModuleForm.lblSid.Text = dgvAdminSite.Rows[e.RowIndex].Cells[0].Value.ToString();
                siteModuleForm.txtCity.Text = dgvAdminSite.Rows[e.RowIndex].Cells[1].Value.ToString();

                siteModuleForm.btnSave.Enabled = false;
                siteModuleForm.ShowDialog();
            }
            else if (colName == "Delete" && MessageBox.Show("Are you sure you want to delete this city? You can't delete a city where at least one employee belongs to!", "DELETE THE CITY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbSite WHERE siteId LIKE '" + dgvAdminSite.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("The city has been successfully deleted!", "CITY DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            LoadSite();
        }
    }
}
