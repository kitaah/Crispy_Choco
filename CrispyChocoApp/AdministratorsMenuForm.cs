using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrispyChocoApp
{
    public partial class AdministratorsMenuForm : Form // Tableau de bord principal pour l'espace administrateur
    {
        public AdministratorsMenuForm() => InitializeComponent();

        // Apparition des formulaires dits "enfants" en fonction des icônes sélectionnées
        private Form? activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainAdminPanel.Controls.Add(childForm);
            mainAdminPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void IconSites_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SiteForm());
        }
        private void IconDepartments_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DepartmentForm());
        }
        private void IconEmployees_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeForm());
        }
        private void IconHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new();
            helpForm.ShowDialog();
        }
        private void IconLogout_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new();
            Hide();
            homeForm.ShowDialog();
            Close();
        }
        private void IconUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForm());
        }
    }
}
