using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpDeWeegschaal
{
    public partial class BMIForm : Form

    {
        private WeightWatcher _weightWatcher;
        public BMIForm()
        {
            InitializeComponent();
            _weightWatcher = new WeightWatcher(44, 1.65);
            gewichtInKg.Text = _weightWatcher.Gewicht.ToString();
            LengteInMeter.Text = _weightWatcher.Grootte.ToString("0.00");
            BmiBerekend.Text = _weightWatcher.GeefBMI().ToString("0.00");
            Status.Text = _weightWatcher.Geefstatus();
        }
        private void UpdateForm()
        {

            gewichtInKg.Text = _weightWatcher.Gewicht.ToString();
            BmiBerekend.Text = _weightWatcher.GeefBMI().ToString("0.00");
            Status.Text = _weightWatcher.Geefstatus();
        }
        



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gewichtOmhoog_Click(object sender, EventArgs e)
        {
            _weightWatcher.Gewicht += 1;

            gewichtInKg.Text = _weightWatcher.Gewicht.ToString();
            BmiBerekend.Text = _weightWatcher.GeefBMI().ToString("0.00");
            Status.Text = _weightWatcher.Geefstatus();
        }
        private void gewichtOmlaag_Click(object sender, EventArgs e)
        {
            _weightWatcher.Gewicht -= 1;

            gewichtInKg.Text = _weightWatcher.Gewicht.ToString();
            BmiBerekend.Text = _weightWatcher.GeefBMI().ToString("0.00");
            Status.Text = _weightWatcher.Geefstatus();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
