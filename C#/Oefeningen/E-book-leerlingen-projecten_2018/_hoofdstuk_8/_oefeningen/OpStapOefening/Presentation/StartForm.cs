using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void wandelroutesButton_Click(object sender, EventArgs e)
        {
            WandelroutesForm formulier = new WandelroutesForm();
            formulier.Show();
        }

        private void oef1Button_Click(object sender, EventArgs e)
        {
            WandelroutesFilter1Form formulier = new WandelroutesFilter1Form();
            formulier.Show();
        }

        private void oef2Button_Click(object sender, EventArgs e)
        {
            WandelroutesFilter2Form formulier = new WandelroutesFilter2Form();
            formulier.Show();
        }

        private void oef3Button_Click(object sender, EventArgs e)
        {
            VerwijderWandelroutesGemeenteForm formulier = new VerwijderWandelroutesGemeenteForm();
            formulier.Show();
        }

        private void oef4Button_Click(object sender, EventArgs e)
        {
            LangsteWandelrouteForm formulier = new LangsteWandelrouteForm();
            formulier.Show();
        }
    }
}
