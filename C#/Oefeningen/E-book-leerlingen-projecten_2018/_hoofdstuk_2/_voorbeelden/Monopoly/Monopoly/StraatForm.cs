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
            
            _straat = new MonopolyStraat("Veldstraat", "Gent", 28, 150,
 450, 1000, 1200, 1400);

            straatTextBox.Text = _straat.GetStraat();
            stadTextBox.Text = _straat.GetStad();
            
            UpdateBebouwingEnHuur();
        }

        private void straatTextBox_TextChanged(object sender, EventArgs e)
        {
            _straat.KoopHuis();

            aantalHuizenTextBox.Text=_straat.GetAantalHuizen().ToString();
            huurTextBox.Text = _straat.GeefHuur().ToString();
            UpdateBebouwingEnHuur();
        }

        private void StraatForm_Load(object sender, EventArgs e)
        {
            _straat.KoopHotel();

            aantalHuizenTextBox.Text = _straat.GetAantalHuizen().ToString();
            aantalHotelsTextBox.Text = _straat.GetAantalHotels().ToString();
            huurTextBox.Text = _straat.GeefHuur().ToString();
            UpdateBebouwingEnHuur();
        }
        private void UpdateBebouwingEnHuur()
        {
            aantalHuizenTextBox.Text = _straat.GetAantalHuizen().ToString();
            aantalHotelsTextBox.Text = _straat.GetAantalHotels().ToString();
            huurTextBox.Text = _straat.GeefHuur().ToString();
        }
    }
}
