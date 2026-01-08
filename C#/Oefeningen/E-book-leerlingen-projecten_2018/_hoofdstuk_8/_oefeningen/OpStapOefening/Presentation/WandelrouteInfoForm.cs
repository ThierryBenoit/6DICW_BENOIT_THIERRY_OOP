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
    public partial class WandelrouteInfoForm : Form
    {
        private Wandelroute _wandelroute;

        public WandelrouteInfoForm(Wandelroute wandelroute)
        {
            InitializeComponent();

            // laat het business-object _wandelroute wijzen naar de meegekregen parameter
            _wandelroute = wandelroute;

            // gegevens van het business-object _wandelroute in de tekstvakken tonen
            idTextBox.Text = _wandelroute.Id.ToString();
            naamTextBox.Text = _wandelroute.Naam;
            kmTextBox.Text = _wandelroute.Kilometers.ToString();
            gemeenteTextBox.Text = _wandelroute.Gemeente;
            provincieTextBox.Text = _wandelroute.Provincie;
        }

        private void opslaanSluitenButton_Click(object sender, EventArgs e)
        {
            // inhoud van de tekstvakken opslaan in het business-object _wandelroute
            _wandelroute.Naam = naamTextBox.Text;
            _wandelroute.Kilometers = Convert.ToInt32(kmTextBox.Text);
            _wandelroute.Gemeente = gemeenteTextBox.Text;
            _wandelroute.Provincie = provincieTextBox.Text;

            // laat het formulier sluiten
            Close();
        }

    }
}
