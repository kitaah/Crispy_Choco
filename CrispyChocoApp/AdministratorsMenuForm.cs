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
    public partial class AdministratorsMenuForm : Form
    {
        public AdministratorsMenuForm() => InitializeComponent();

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
    }
}
