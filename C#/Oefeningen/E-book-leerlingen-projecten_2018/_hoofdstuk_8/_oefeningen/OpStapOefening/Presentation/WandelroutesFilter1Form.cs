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
using DataAccess;

namespace Presentation
{
    public partial class WandelroutesFilter1Form : Form
    {
        private WandelrouteDA _wandelrouteDA;
        private List<Wandelroute> _wandelroutesLijst;

        public WandelroutesFilter1Form()
        {
            InitializeComponent();

            // het veld _wandelrouteDA initialiseren
            _wandelrouteDA = new WandelrouteDA();

            // het veld met de lijst initialiseren
            _wandelroutesLijst = new List<Wandelroute>();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            // waarde uit tekstvakken ophalen
            int max = Convert.ToInt32(maxKmTextBox.Text);

            // de lijst op basis van filter opvullen via ons data-accessobject 
            _wandelroutesLijst = _wandelrouteDA.ReadTableFilterMaxAfstand(max);

            // de lijst met wandelroutes vernieuwen in de listbox
            wandelroutesListBox.DataSource = null;
            wandelroutesListBox.DataSource = _wandelroutesLijst;

        }
    }
}
