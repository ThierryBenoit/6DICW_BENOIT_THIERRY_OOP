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
            _vrijeStudie = new VrijeStudie("Assisi", 100);
            InitializeComponent();
            lokaalTextBox.Text = _vrijeStudie.Lokaal.ToString();
            capaciteitTextBox.Text = _vrijeStudie.Capaciteit.ToString();
            bezetTextBox.Text = _vrijeStudie.GereserveerdePlaatsen.ToString();

        }

        private void inschrijvenButton_Click(object sender, EventArgs e)
        {
            int aantal = Convert.ToInt32(aantalInschrijvenTextBox.Text);
            if (_vrijeStudie.IsErNogPlaats(aantal) == true)
            {
                _vrijeStudie.GereserveerdePlaatsen += aantal;
                boodschapTextBox.Text = "Inschrijving geslaagd";
                bezetTextBox.Text = _vrijeStudie.GereserveerdePlaatsen.ToString();
            }
            else
            {
                boodschapTextBox.Text = "ONV capaciteit in lokaal " + _vrijeStudie.Lokaal;
            }
            aantalInschrijvenTextBox.Text = "";
        }
    }
}