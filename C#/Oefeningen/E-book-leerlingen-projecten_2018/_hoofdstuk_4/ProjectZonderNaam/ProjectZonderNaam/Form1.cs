using System.Security.AccessControl;

namespace ProjectZonderNaam
{
    public partial class Form1 : Form
    {
        private ProjectZonderNaam _projectZonderNaam;
        public Form1()
        {

            InitializeComponent();
            _projectZonderNaam = new ProjectZonderNaam("Lars", "de Vérmeulen");
        }

        private void VolledigeNaam_TextChanged(object sender, EventArgs e)
        {
            VolledigeNaam.Text = _projectZonderNaam.Initialen();
        }

        private void Voornaam_TextChanged(object sender, EventArgs e)
        {
            Voornaam.Text = _projectZonderNaam.AlfaVoornaam();
        }

        private void Achternaam_TextChanged(object sender, EventArgs e)
        {
            Achternaam.Text = _projectZonderNaam.AlfaFamilienaam();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VolledigeNaam.Text = _projectZonderNaam.Initialen();
            Voornaam.Text = _projectZonderNaam.AlfaVoornaam();
            Achternaam.Text = _projectZonderNaam.AlfaFamilienaam();
        }
    }
}
