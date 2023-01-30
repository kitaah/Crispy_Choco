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
    public partial class VisitorsMenuForm : Form
    {
        public VisitorsMenuForm()
        {
            InitializeComponent();
        }

        private Form? activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainVisitorPanel.Controls.Add(childForm);
            mainVisitorPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void iconEmployeesLastName_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SearchEmployeeByLastNameForm());
        }

        private void iconEmployeesDepartments_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SearchEmployeeByDepartmentForm());
        }

        private void iconEmployeesSites_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SearchEmployeeBySiteForm());
        }
    }
}
