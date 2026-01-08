using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class StraatForm : Form
    {
        private MonopolyStraat _straat;

        public StraatForm()
        {
            InitializeComponent();

            _straat = new MonopolyStraat("Veldstraat", "Gent", 22, 120, 360, 850, 1025, 1200);

            straatTextBox.Text = _straat.Straat;
            stadTextBox.Text = _straat.Stad;

            UpdateBebouwingEnHuur();
        }

        private void koopHuisButton_Click(object sender, EventArgs e)
        {
            _straat.KoopHuis();

            UpdateBebouwingEnHuur();
        }

        private void koopHotelButton_Click(object sender, EventArgs e)
        {
            _straat.KoopHotel();

            UpdateBebouwingEnHuur();
        }

        private void UpdateBebouwingEnHuur()
        {
            aantalHuizenTextBox.Text = _straat.AantalHuizen.ToString();
            aantalHotelsTextBox.Text = _straat.AantalHotels.ToString();
            huurTextBox.Text = _straat.GeefHuur().ToString("C");
        }
    }
}
