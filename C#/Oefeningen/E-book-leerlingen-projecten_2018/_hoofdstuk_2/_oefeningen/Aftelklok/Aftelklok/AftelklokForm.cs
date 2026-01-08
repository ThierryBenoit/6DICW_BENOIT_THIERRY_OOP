using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Aftelklok
{
    public partial class AftelklokForm : Form
    {
        private Aftelklok _klokje;

        public AftelklokForm()
        {
            InitializeComponent();
            _klokje = new Aftelklok(1, 30);
        }

        private void AftelklokForm_Load(object sender, EventArgs e)
        {
            displayTextBox.Text = _klokje.ResterendeTijd();

            aftelklokTimer.Start();
        }

        private void aftelklokTimer_Tick(object sender, EventArgs e)
        {
            _klokje.Aftellen();
            displayTextBox.Text = _klokje.ResterendeTijd();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}