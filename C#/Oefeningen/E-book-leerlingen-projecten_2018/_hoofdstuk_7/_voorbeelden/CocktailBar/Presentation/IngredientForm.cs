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
    public partial class IngredientForm : Form
    {
        private Ingredient _ingredient;

        public IngredientForm(Ingredient ingredient)
        {
            InitializeComponent();

            _ingredient = ingredient;

            naamTextBox.Text = _ingredient.Naam;
            hoeveelheidTextBox.Text = _ingredient.Hoeveelheid.ToString();
            alcoholpercentageTextBox.Text = _ingredient.Alcoholpercentage.ToString("P0");
        }
    }
}
