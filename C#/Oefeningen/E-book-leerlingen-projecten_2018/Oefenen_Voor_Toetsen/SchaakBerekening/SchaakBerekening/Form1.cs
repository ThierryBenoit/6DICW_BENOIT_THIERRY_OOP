using test_oefening;

namespace SchaakBerekening
{
    public partial class Form1 : Form
    {
        private Schaakberekening _schaakberekening;
        public Form1()

        {

            InitializeComponent();
            _schaakberekening = new Schaakberekening(1535, 1734);
            textBox1.Text = _schaakberekening.YourElo.ToString();
            textBox2.Text = _schaakberekening.OpponentElo.ToString();

        }
        private void UpdateForm()
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            _schaakberekening.Gelijk();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _schaakberekening.Gewonnen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _schaakberekening.Verloren();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            _schaakberekening.NewEloCalculation();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Calculate and display new Elo
            double newElo = _schaakberekening.NewEloCalculation();
            textBox3.Text = newElo.ToString("0.00");
        }

    }
}
