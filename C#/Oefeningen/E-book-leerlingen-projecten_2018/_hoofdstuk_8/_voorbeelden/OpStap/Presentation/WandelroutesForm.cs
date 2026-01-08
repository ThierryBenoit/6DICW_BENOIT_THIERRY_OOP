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
    public partial class WandelroutesForm : Form
    {

        private List<Wandelroute> _wandelroutesLijst;

      
        public WandelroutesForm()
        {
            InitializeComponent();

            // het veld _wandelroutesLijst initialiseren
            _wandelroutesLijst = new List<Wandelroute>();

            // via de hulpmethode LijstOpvullen() laten we het veld _wandelroutesLijst opvullen met enkele wandelroutes
            LijstOpvullen();

            // de lijst met wandelroutes weergeven in de listbox
            wandelroutesListBox.DataSource = _wandelroutesLijst;            
        }

        private void toonButton_Click(object sender, EventArgs e)
        {
            // de geselecteerde wandelroute in de ListBox opvragen
            Wandelroute wandelroute = (Wandelroute) wandelroutesListBox.SelectedItem;

            // het formulier WandelrouteInfoForm openen met de geselecteerde wandelroute
            WandelrouteInfoForm formulier = new WandelrouteInfoForm(wandelroute);
            formulier.ShowDialog();

            // misschien heeft gebruiker gegevens van de wandelroute veranderd 
            // --> ListBox vernieuwen
            wandelroutesListBox.DataSource = null;
            wandelroutesListBox.DataSource = _wandelroutesLijst;
        }


        private void LijstOpvullen()
        {
            // wandelroutes aanmaken en aan de lijst _wandelroutesLijst toevoegen           
            Wandelroute w1 = new Wandelroute(1, "Rotemwandeling", 11, "Budingen", "Vlaams-Brabant");
            Wandelroute w2 = new Wandelroute(2, "Monnikenwandeling", 4, "Zoutleeuw", "Vlaams-Brabant");
            Wandelroute w3 = new Wandelroute(3, "Argendaalpad", 13, "Sint-Denijs", "West-Vlaanderen");
            Wandelroute w4 = new Wandelroute(4, "Bevergemroute", 9, "Sint-Denijs", "West-Vlaanderen");
            Wandelroute w5 = new Wandelroute(5, "Doornpannewandelroute", 8, "Koksijde", "West-Vlaanderen");
            Wandelroute w6 = new Wandelroute(6, "Hoge Blokkerroute", 9, "Koksijde", "West-Vlaanderen");
            Wandelroute w7 = new Wandelroute(7, "Poelbergwandeling", 6, "Tielt", "West-Vlaanderen");
            Wandelroute w8 = new Wandelroute(8, "Vlaskoorde", 15, "Sint-Baafs-Vijve", "West-Vlaanderen");
            _wandelroutesLijst.Add(w1);
            _wandelroutesLijst.Add(w2);
            _wandelroutesLijst.Add(w3);
            _wandelroutesLijst.Add(w4);
            _wandelroutesLijst.Add(w5);
            _wandelroutesLijst.Add(w6);
            _wandelroutesLijst.Add(w7);
            _wandelroutesLijst.Add(w8);
        }

        private void verwijderButton_Click(object sender, EventArgs e)
        {
            // de geselecteerde wandelroute opvragen
            Wandelroute wandelroute = (Wandelroute) wandelroutesListBox.SelectedItem;
            
             // de geselecteerde wandelroute uit de lijst laten verwijderen           
            _wandelroutesLijst.Remove(wandelroute);

            // De listbox laten vernieuwen
            wandelroutesListBox.DataSource = null;
            wandelroutesListBox.DataSource = _wandelroutesLijst;
        }

        private void nieuwButton_Click(object sender, EventArgs e)
        {
            // wat is het hoogste ID van een wandelroute in de lijst _wandelroutesLijst
            int maxId = _wandelroutesLijst.Max(x => x.Id);

            // nieuw Wandelroute-object aanmaken
            Wandelroute wandelroute = new Wandelroute(maxId+1, "", 0, "", "");

            // nieuwe wandelroute toevoegen aan lijst wandelroutes
            _wandelroutesLijst.Add(wandelroute);

            // het formulier WandelrouteInfoForm openen 
            // we geven de nieuwe wandelroute mee als parameter
            WandelrouteInfoForm formulier = new WandelrouteInfoForm(wandelroute);
            formulier.ShowDialog();

            // de listbox vernieuwen
            wandelroutesListBox.DataSource = null;
            wandelroutesListBox.DataSource = _wandelroutesLijst;
        }
    }
}
