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
    public partial class StartOpStapForm : Form
    {
        public StartOpStapForm()
        {
            InitializeComponent();
        }

        private void wandelroutesButton_Click(object sender, EventArgs e)
        {
            WandelroutesForm formulier = new WandelroutesForm();
            formulier.Show();
        }

        private void zoekenOpProvincieButton_Click(object sender, EventArgs e)
        {
            WandelroutesFilterForm formulier = new WandelroutesFilterForm();
            formulier.Show();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            WandelroutesWelkomForm formulier = new WandelroutesWelkomForm();
            formulier.Show();
        }
    }
}
