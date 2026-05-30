using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class NieuweRennerToeveoegenForm : Form
    {
        public NieuweRennerToeveoegenForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public Wielrenner nieuweWielrenner()
        {
            int id = 21;
            String name = textBox1.Text;
            String nationality = textBox2.Text;
            DateTime birthdate = dateTimePicker1.Value;
            String gender = textBox4.Text;
            int wins = Convert.ToInt32(textBox5.Text);
            decimal points = Convert.ToDecimal(textBox6.Text);
            int ranking = Convert.ToInt32(textBox7.Text);

            Wielrenner wielrenner = new Wielrenner(id, name, nationality, birthdate, gender, wins, points, ranking);
            id++;
            return wielrenner;
        }

        public Wielrenner NieuweRenner { get; private set; }

        private void Voegtoe_Click(object sender, EventArgs e)
        {
            NieuweRenner = new Wielrenner(
                21,
                textBox1.Text,
                textBox2.Text,
                dateTimePicker1.Value,
                textBox4.Text,
                Convert.ToInt32(textBox5.Text),
                Convert.ToDecimal(textBox6.Text),
                Convert.ToInt32(textBox7.Text)
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

