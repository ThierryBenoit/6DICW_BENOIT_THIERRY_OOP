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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void bloodyMaryButton_Click(object sender, EventArgs e)
        {
            Cocktail cocktail = new Cocktail("Bloody Mary", (decimal) 8.25);

            Ingredient i1 = new Ingredient("tomatensap", 100, 0);
            cocktail.VoegIngredientToe(i1);

            Ingredient i2 = new Ingredient("wodka", 50, 0.45);
            cocktail.VoegIngredientToe(i2);

            Ingredient i3 = new Ingredient("citroensap", 8, 0);
            cocktail.VoegIngredientToe(i3);

            CocktailInfoForm formulier = new CocktailInfoForm(cocktail);
            formulier.Show();
        }

        private void cubaLibreButton_Click(object sender, EventArgs e)
        {
        }
    }
}
