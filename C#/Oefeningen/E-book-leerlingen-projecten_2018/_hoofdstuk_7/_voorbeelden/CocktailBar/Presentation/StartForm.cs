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
            Cocktail cocktail = new Cocktail("Bloody Mary", (decimal)8.25);
            cocktail.VoegIngredientToe(new Ingredient("tomatensap", 100, 0));
            cocktail.VoegIngredientToe(new Ingredient("wodka", 50, 0.45));
            cocktail.VoegIngredientToe(new Ingredient("citroensap", 8, 0));

            CocktailInfoForm formulier = new CocktailInfoForm(cocktail);
            formulier.Show();
        }

        private void cubaLibreButton_Click(object sender, EventArgs e)
        {
            Cocktail cocktail = new Cocktail("Cuba Libre", (decimal)7.50);
            cocktail.VoegIngredientToe(new Ingredient("cola", 100, 0));
            cocktail.VoegIngredientToe(new Ingredient("wodka", 50, 0.45));
            cocktail.VoegIngredientToe(new Ingredient("limoensap", 8, 0));

            CocktailInfoForm formulier = new CocktailInfoForm(cocktail);
            formulier.Show();
        }
    }
}
