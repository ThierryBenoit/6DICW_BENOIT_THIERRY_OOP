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
    public partial class VerwijderWandelroutesGemeenteForm : Form
    {
        private WandelrouteDA _wandelrouteDA;

        public VerwijderWandelroutesGemeenteForm()
        {
            InitializeComponent();

            // het veld _wandelrouteDA initialiseren
            _wandelrouteDA = new WandelrouteDA();
        }

        private void verwijderButton_Click(object sender, EventArgs e)
        {
            // opvragen van welke gemeente je de wandelroutes wil wissen
            String gemeente = gemeenteTextBox.Text;

            // wandelroutes laten wissen via het data-accessobject
            _wandelrouteDA.DeleteRecordsGemeente(gemeente);
        }
    }
}
