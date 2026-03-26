using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailBar
{
    internal class Cocktail
    {
        private string _naam;
        private decimal _kostPrijs;
        private List<Ingredient> _cocktail;

        public Cocktail(string naam, decimal kostPrijs, List<Ingredient> menu)
        {
            _naam = naam;
            _kostPrijs = kostPrijs;
            _cocktail = menu;
        }
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public decimal KostPrijs
        {
            get { return _kostPrijs; }
            set { _kostPrijs = value; }
        }

        public List<Ingredient> Ingredienten
        {
            get { return _cocktail; }
        }

        public void VoegIngredientenToe(Ingredient ingredient)
        {
            _cocktail.Add(ingredient);
        }
        public int HoeveelheidIngredienten(Ingredient ingredient)
        {
            return _cocktail.Count();
        }
        public int InhoudCocktail(Ingredient ingredient)
        {
            int som = 0;
            foreach (Ingredient ingredient1 in _cocktail) { 
                som += ingredient.Hoeveelheid;
            }
            return som;
        }

        public int HoeveelAlcoholischeIngredienten()
        {
            int teller = 0;
            foreach(Ingredient ingredient in _cocktail)
            {
                if(ingredient.IsAlcoholisch() == true)
                {
                    teller += 1;
                }
                
            }
            return teller;
        }
        public bool Isalcocholish()
        {
            int teller=HoeveelAlcoholischeIngredienten();
            if (teller != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public String AlleIngredienten()
        {
            foreach (Ingredient ingredient in _cocktail)
            {
                return ingredient.Hoeveelheid + ingredient.Naam + ";";
            }
            return "";
        }
        
        public Ingredient GeefIngredient(int plaats)
        {
            return _cocktail[plaats];
        }

        public String GeefNaamIngredient(int plaats)
        {
            return _cocktail[plaats].Naam;
        }
        public void VerwijderIngredient(int plaats)
        {
            _cocktail.RemoveAt(plaats);
        }
        public void MaakAlcoholvrij(decimal prijs)
        {
            for (int i = _cocktail.Count - 1; i >= 0; i--)
            {
                if (_cocktail[i].IsAlcoholisch())
                {
                    _cocktail.RemoveAt(i);
                }
            }

            _kostPrijs = prijs;
            _naam += " - alcoholvrij";
        }
        public double Alcoholpercentage()
        {
            double _alcocholPercentage = 0.0;
            foreach(Ingredient ingredient in _cocktail)
            {
                _alcocholPercentage += ingredient.AlcocholPercentage;
            }
            return _alcocholPercentage;
        }
        public List<Ingredient> AlcoholischeIngredienten()
        {
            List<Ingredient> resultaat = new List<Ingredient>();

            foreach (Ingredient ingredient in _cocktail)
            {
                if (ingredient.IsAlcoholisch())
                {
                    resultaat.Add(ingredient);
                }
            }
            return resultaat;
        }
        
        public List<Ingredient> NietAlcoholischeIngredienten()
        {
            List<Ingredient> resultaat = new List<Ingredient>();

            foreach (Ingredient ingredient in _cocktail)
            {
                if (!ingredient.IsAlcoholisch())
                {
                    resultaat.Add(ingredient);
                }
            }

            return resultaat;
        }
    }
}