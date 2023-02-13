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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private int startPoint = 0;
        protected internal int StartPoint
        {
            get { return startPoint; }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            progressBar1.Value = startPoint;
            if(progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                HomeForm homeForm = new();
                Hide();
                homeForm.ShowDialog();
                Close();
            }
        }
    }
}

// InitializeComponent = méthode générée automatiquement par le concepteur de Windows Form et qui défini tout ce qui visible, existant sur le formulaire
