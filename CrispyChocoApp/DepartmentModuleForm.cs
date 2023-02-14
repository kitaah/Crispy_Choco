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
    public partial class DepartmentModuleForm : Form // Formulaire pour l'ajout/mise à jour des services
    {
        private readonly SqlConnection con = new(@"Data Source=.\sqlexpress;Initial Catalog=db_crispy_choco;Integrated Security=True");
        private SqlCommand cm = new();
        private SqlDataReader? dr;
        public DepartmentModuleForm() => InitializeComponent();

        // Ajout d'un service avec vérification de l'existence du service
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDepartmentName.Text != "")
                {
                    cm = new SqlCommand("SELECT departmentName FROM tbDepartment WHERE departmentName=@departmentName", con);
                    cm.Parameters.AddWithValue("@departmentName", txtDepartmentName.Text);
                    con.Open();
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("This department already exists!", "THIS DEPARTMENT NAME ALREADY EXISTS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDepartmentName.Clear();
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
                if (txtDepartmentName.Text == "")
                {
                    MessageBox.Show("Please, complete the field of the form!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cm = new SqlCommand("INSERT INTO tbDepartment(departmentName)VALUES(@departmentName)", con);
                    cm.Parameters.AddWithValue("@departmentName", txtDepartmentName.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("The department has been successfully added!", "DEPARTMENT ADDED", MessageBoxButtons.OK);
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
                if (txtDepartmentName.Text != "")
                {
                    cm = new SqlCommand("SELECT departmentName FROM tbDepartment WHERE departmentName=@departmentName", con);
                    cm.Parameters.AddWithValue("@departmentName", txtDepartmentName.Text);
                    con.Open();
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("This department already exists!", "THIS DEPARTMENT NAME ALREADY EXISTS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDepartmentName.Clear();
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
                if (txtDepartmentName.Text == "")
                {
                    MessageBox.Show("Please, complete the field of the form!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cm = new SqlCommand("UPDATE tbDepartment SET departmentName = @departmentName WHERE departmentId LIKE '" + lblDid.Text + "' ", con);
                    cm.Parameters.AddWithValue("@departmentName", txtDepartmentName.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("The department has been successfully updated!", " DEPARTMENT UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
