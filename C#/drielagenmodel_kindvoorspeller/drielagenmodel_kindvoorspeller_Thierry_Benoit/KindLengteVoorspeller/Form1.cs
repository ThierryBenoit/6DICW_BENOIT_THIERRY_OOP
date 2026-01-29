namespace KindLengteVoorspeller
{

    public partial class Form1 : Form
    {
        private KindLengteVoorspeller _kindLengteVoorspeller;
        public Form1()
        {
            InitializeComponent();
            _kindLengteVoorspeller = new();
            AantalPogingen.Text = "Nog geen voorspelling";

        }

        private void LengteDochterKnop_Click(object sender, EventArgs e)
        {
            _kindLengteVoorspeller.GemiddeldeOuders(Convert.ToDouble(LengteManTxT.Text), Convert.ToDouble(LengteVrouwTxT.Text));
            GroteKind.Text = _kindLengteVoorspeller.BerekenDochter(Convert.ToDouble(LengteManTxT.Text), Convert.ToDouble(LengteVrouwTxT.Text)).ToString("0.00");
            AantalPogingen.Text = _kindLengteVoorspeller.AantalVoorspellingen.ToString();
        }

        private void LengteZoonKnop_Click(object sender, EventArgs e)
        {
            _kindLengteVoorspeller.GemiddeldeOuders(Convert.ToDouble(LengteManTxT.Text), Convert.ToDouble(LengteVrouwTxT.Text));
            GroteKind.Text = _kindLengteVoorspeller.BerekenZoon(Convert.ToDouble(LengteManTxT.Text), Convert.ToDouble(LengteVrouwTxT.Text)).ToString("0.00");
            AantalPogingen.Text = _kindLengteVoorspeller.AantalVoorspellingen.ToString();
        }
    }
}
