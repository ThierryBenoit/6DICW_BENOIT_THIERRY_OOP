using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wielertenue
{

    public partial class BestellingForm : Form
    {
        private BestellingWielertenue _bestelling;

        public BestellingForm()
        {
            InitializeComponent();
            _bestelling = new BestellingWielertenue(1,false,false,false);
        }

        private void aantalNumericUpAndDown_ValueChanged(object sender, EventArgs e)
        {
            _bestelling.Aantal = Convert.ToInt16(aantalNumericUpAndDown.Value);
            PrijsTextBox.Text=_bestelling.GeefPrijs().ToString();

        }

        private void waterdichtZakjeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _bestelling.WaterdichtZakje = true;
            PrijsTextBox.Text = _bestelling.GeefPrijs().ToString();
        }

        private void broekCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_bestelling.Broek)
            {
                _bestelling.Broek = false;
            }
            else
            {
                _bestelling.Broek = true;
            }
            superzeemCheckBox.Visible = !superzeemCheckBox.Visible;
            PrijsTextBox.Text = _bestelling.GeefPrijs().ToString();
            wielertenuePictureBox.Visible = !wielertenuePictureBox.Visible;
            label4.Visible= !label4.Visible;
        }

        private void superzeemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _bestelling.Broek = true;
            PrijsTextBox.Text = _bestelling.GeefPrijs().ToString();
        }
    }
}
