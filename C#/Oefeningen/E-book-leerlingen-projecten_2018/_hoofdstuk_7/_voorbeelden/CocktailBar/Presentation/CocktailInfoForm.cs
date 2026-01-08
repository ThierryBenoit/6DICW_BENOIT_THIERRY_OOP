using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business;

namespace Presentation
{
    public partial class CocktailInfoForm : Form
    {
        private Cocktail _cocktail;

        public CocktailInfoForm(Cocktail cocktail)
        {
            InitializeComponent();

            _cocktail = cocktail;

            naamTextBox.Text = _cocktail.Naam;
            kostprijsTextBox.Text = _cocktail.Kostprijs.ToString("C");
            inhoudTextBox.Text = _cocktail.InhoudCocktail().ToString();
            alcoholpercentageTextBox.Text = _cocktail.Alcoholpercentage().ToString("P0");
        }
        
        private void toonButton_Click(object sender, EventArgs e)
        {
        }

    }
}
