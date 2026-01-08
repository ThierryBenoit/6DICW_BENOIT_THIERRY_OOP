using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;


namespace Presentation
{
    public partial class WandelroutesWelkomForm : Form
    {
        public WandelroutesWelkomForm()
        {
            InitializeComponent();

            infoLabel.Text = "Alle gekende wandelroutes samen bieden je momenteel " +  "..." + " km wandelplezier aan!";            
        }
    }
}
