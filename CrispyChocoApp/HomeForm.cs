using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrispyChocoApp
{
    public partial class HomeForm : Form // Formulaire d'accueil : accès à l'espace administrateur et à tout visiteur
    {
        public HomeForm() => InitializeComponent();
        private void IconAdministrators_Click(object sender, EventArgs e)
        {
            BeforeLoginForm beforeLoginForm = new();
            Hide();
            beforeLoginForm.ShowDialog();
            Close();
        }
        private void IconVisitors_Click(object sender, EventArgs e)
        {
            VisitorsMenuForm visitorsMenuForm = new();
            Hide();
            visitorsMenuForm.ShowDialog();
            Close();
        }
    }
}
