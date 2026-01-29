namespace testRetry
{
    public partial class Form1 : Form
    {
        private Commedyshow _commedyshow;
        public Form1()
        {
            InitializeComponent();
             _commedyshow= new Commedyshow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _commedyshow.Add(textBox1.Text, Convert.ToDouble(textBox2.Text));
            textBox4.Text = _commedyshow.berekenGemiddelde().ToString("0.00");
            textBox5.Text = _commedyshow.Aantal.ToString();
            textBox3.Text = _commedyshow.Laatste;
        }
    }
}
