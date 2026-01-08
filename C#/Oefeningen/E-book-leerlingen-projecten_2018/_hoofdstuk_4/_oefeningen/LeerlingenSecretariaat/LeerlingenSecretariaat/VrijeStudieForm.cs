using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeerlingenSecretariaat
{
    public partial class VrijeStudieForm : Form
    {
        private VrijeStudie _vrijeStudie;

        public VrijeStudieForm()
        {
            InitializeComponent();

            // veld _vrijeStudie initialiseren (vrije studie gaat door in lokaal KSZ, er zijn daar 40 plaatsen)
            _vrijeStudie = new VrijeStudie("KSZ", 40);

            // nodige informatie aan opvragen_vrijeStudie en weergeven in tekstvakken
            lokaalTextBox.Text = _vrijeStudie.Lokaal;
            capaciteitTextBox.Text = _vrijeStudie.Capaciteit.ToString();
            bezetTextBox.Text = _vrijeStudie.GereserveerdePlaatsen.ToString();
        }

        private void inschrijvenButton_Click(object sender, EventArgs e)
        {
            // nagaan hoeveel leerlingen willen inschrijven
            int aantal = Convert.ToInt32(aantalInschrijvenTextBox.Text);

            // object _vrijeStudie controleert of er nog plaats is voor deze leerlingen
            if (_vrijeStudie.IsErNogPlaats(aantal) == true)
            {
                // aantal bezette plaatsen bij _vrijeStudie bijwerken
                _vrijeStudie.GereserveerdePlaatsen += aantal;

                // nodige tekstvakken updaten
                boodschapTextBox.Text = "Inschrijving geslaagd";
                bezetTextBox.Text = _vrijeStudie.GereserveerdePlaatsen.ToString();
            }
            else
            {
                // boodschap tonen in tekstvak
                boodschapTextBox.Text = "ONVOLDOENDE capaciteit in lokaal " + _vrijeStudie.Lokaal;
            }

            // tekstvak met aantal in te schrijven leerlingen leegmaken
            aantalInschrijvenTextBox.Text = "";
        }
    }
}
