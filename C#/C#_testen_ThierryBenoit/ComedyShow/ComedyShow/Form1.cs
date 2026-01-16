namespace ComedyShow
{
    public partial class Form1 : Form
    {
        private ComedyShow _comedyShow;
        public Form1()

        {
            InitializeComponent();
            _comedyShow = new ComedyShow("bla", 95.0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5=_comedyShow.BerekenGemiddelde();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6 = _comedyShow.AantalShows.ToString();
        }
    }
}
