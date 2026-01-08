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
    public partial class ActiviteitenStartForm : Form
    {
        public ActiviteitenStartForm()
        {
            InitializeComponent();
        }

        private void activiteitenBekijkenButton_Click(object sender, EventArgs e)
        {
            ActiviteitenForm formulier = new ActiviteitenForm();
            formulier.Show();
        }

        private void activiteitToevoegenButton_Click(object sender, EventArgs e)
        {
            ActiviteitToevoegenForm formulier = new ActiviteitToevoegenForm();
            formulier.Show();
        }
    }
}
