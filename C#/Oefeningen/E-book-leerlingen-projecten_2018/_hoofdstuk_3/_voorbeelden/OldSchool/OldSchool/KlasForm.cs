using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OldSchool
{
    public partial class KlasForm : Form
    {

        private Klas _mijnKlas;  // veld om klasgegevens op te slaan

        public KlasForm()
        {
            InitializeComponent();

            // het veld _mijnKlas initialiseren
            _mijnKlas = new Klas("5bi", 5, "Boekhouden Informatica", "Mevr. Mestdagh", 20);

            // methode om klasgegevens in de tekstvakken te tonen
            ToonKlasgegevens();
        }
        
        private void aantalLeerlingPlusButton_Click(object sender, EventArgs e)
        {
            // aantal leerlingen in het _mijnKlas-veld met eentje verhogen
            int aantal = _mijnKlas.GetAantalLeerlingen();
            _mijnKlas.SetAantalLeerlingen(aantal + 1);

            // methode om klasgegevens in tekstvakken te vernieuwen
            ToonKlasgegevens();
        }
         
        private void aantalLeerlingMinButton_Click(object sender, EventArgs e)
        {
            // aantal leerlingen in het _mijnKlas-veld met eentje verminderen
            int aantal = _mijnKlas.GetAantalLeerlingen();
            _mijnKlas.SetAantalLeerlingen(aantal - 1);

            // methode om klasgegevens in tekstvakken te vernieuwen
            ToonKlasgegevens();
        }

        private void wijzigTitularisButton_Click(object sender, EventArgs e)
        {
            // titularis in _mijnKlas-veld bijwerken op basis van de inhoud 
            //   van het tekstvak nieuweTitularisTextBox
            String nieuweTitularis = nieuweTitularisTextBox.Text;
            _mijnKlas.SetTitularis(nieuweTitularis);

            // methode om klasgegevens in tekstvakken te vernieuwen
            ToonKlasgegevens();

            // tekstvak nieuweTitularisTextBox weer leeg maken
            nieuweTitularisTextBox.Text = "";
        }

        private void ToonKlasgegevens()
        {
            // laat de gegevens van de klas weergeven in de tekstvakken
            afkortingTextBox.Text = _mijnKlas.GetAfkorting();
            jaarTextBox.Text = _mijnKlas.GetJaar().ToString();
            richtingTextBox.Text = _mijnKlas.GetRichting();
            titularisTextBox.Text = _mijnKlas.GetTitularis();
            aantalLeerlingenTextBox.Text = _mijnKlas.GetAantalLeerlingen().ToString();
        }
    }
}
