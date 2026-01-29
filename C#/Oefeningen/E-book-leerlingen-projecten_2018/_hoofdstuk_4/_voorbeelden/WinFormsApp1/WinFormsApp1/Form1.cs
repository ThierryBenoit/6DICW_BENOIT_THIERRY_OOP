namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        private BMIberekenen _bmiBerekenen;

        public Form1()
        {
            InitializeComponent();
            _bmiBerekenen = new BMIberekenen(1.78,65);
            textBox1.Text = _bmiBerekenen.Gewicht.ToString();
            textBox2.Text = _bmiBerekenen.Lengte.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = _bmiBerekenen.Gewicht.ToString();
            textBox2.Text = _bmiBerekenen.Lengte.ToString();
            textBox3.Text = _bmiBerekenen.BerekenBmi().ToString("0.00");
        }
    }
}
