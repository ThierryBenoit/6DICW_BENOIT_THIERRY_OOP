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
    public partial class WandelroutesForm : Form
    {
        private List<Wandelroute> _wandelroutesLijst;
        private WandelrouteDA _wandelrouteDA;

        public WandelroutesForm()
        {
            InitializeComponent();

            // het veld _wandelroutesLijst initialiseren
            _wandelroutesLijst = new List<Wandelroute>();

            // het veld _wandelrouteDA initialiseren
            _wandelrouteDA = new WandelrouteDA();

            // de lijst met wandelroutes opvullen via ons data-accessobject
            _wandelroutesLijst = _wandelrouteDA.ReadTable();

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

            // de (gewijzigde) wandelroute wegschrijven naar de databank
            _wandelrouteDA.UpdateRecord(wandelroute);

            // misschien heeft gebruiker gegevens van de wandelroute veranderd 
            // --> ListBox vernieuwen
            wandelroutesListBox.DataSource = null;
            wandelroutesListBox.DataSource = _wandelroutesLijst;
        }

        private void verwijderButton_Click(object sender, EventArgs e)
        {
            // de geselecteerde wandelroute opvragen
            Wandelroute wandelroute = (Wandelroute) wandelroutesListBox.SelectedItem;
            
             // de geselecteerde wandelroute uit de lijst laten verwijderen           
            _wandelroutesLijst.Remove(wandelroute);

            // de wandelroute verwijderen uit de tabel
            _wandelrouteDA.DeleteRecord(wandelroute.Id);

            // De listbox laten vernieuwen
            wandelroutesListBox.DataSource = null;
            wandelroutesListBox.DataSource = _wandelroutesLijst;
        }

        private void nieuwButton_Click(object sender, EventArgs e)
        {
            // nieuw Wandelroute-object aanmaken
            Wandelroute wandelroute = new Wandelroute(0, "", 0, "", "");

            // het formulier WandelrouteInfoForm openen 
            // we geven de nieuwe wandelroute mee als parameter
            WandelrouteInfoForm formulier = new WandelrouteInfoForm(wandelroute);
            formulier.ShowDialog();

            // de (nieuwe) wandelroute toevoegen aan de tabel
            _wandelrouteDA.CreateRecord(wandelroute);

            // de lijst met wandelroutes terug inlezen uit de databank
            _wandelroutesLijst = _wandelrouteDA.ReadTable();

            // de listbox vernieuwen
            wandelroutesListBox.DataSource = null;
            wandelroutesListBox.DataSource = _wandelroutesLijst;
        }
    }
}
