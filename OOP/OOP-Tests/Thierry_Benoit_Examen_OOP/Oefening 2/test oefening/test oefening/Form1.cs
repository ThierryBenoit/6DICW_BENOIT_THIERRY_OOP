namespace test_oefening
{
    public partial class Form1 : Form
    {
        private Lowie _lowie;
        public Form1()
        {
            _lowie = new Lowie();

            {

            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = _lowie.Leeftijd.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _lowie.JaartjeOuder();
            label1.Text = _lowie.Leeftijd.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _lowie.JaartjeJongerOpEenOfAndereManier();
            label1.Text = _lowie.Leeftijd.ToString() ;
        }
    }
}
