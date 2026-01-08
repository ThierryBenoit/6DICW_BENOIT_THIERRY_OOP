using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Cocktail
    {
        String _naam;  // naam van de cocktail
        decimal _kostprijs; // hoeveel kost de cocktail
        List<Ingredient> _ingredienten;  // lijst met alle ingredienten om de cocktail samen te stellen

        public Cocktail(String naam, decimal kostprijs)
        {
            _naam = naam;
            _kostprijs = kostprijs;
            _ingredienten = new List<Ingredient>();
        }

        public String Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public decimal Kostprijs
        {
            get { return _kostprijs; }
            set { _kostprijs = value; }
        }

        public List<Ingredient> Ingredienten
        {
            get { return _ingredienten; }
        }

        public void VoegIngredientToe(Ingredient ingredient)
        {
            _ingredienten.Add(ingredient);
        }

        public int HoeveelIngredienten()
        {
            return _ingredienten.Count;
        }

        public int InhoudCocktail()
        {
            int inhoud = 0;

            foreach(Ingredient ingredient in _ingredienten)
            {
                inhoud = inhoud + ingredient.Hoeveelheid;
            }

            return inhoud;
        }

        public int HoeveelAlcoholischeIngredienten()
        {
            int aantal = 0;

            foreach (Ingredient ingredient in _ingredienten)
            {
                if (ingredient.IsAlcoholisch() == true)
                {
                    aantal++;
                }
            }

            return aantal;
        }

        public bool IsAlcoholisch()
        {
            if (HoeveelAlcoholischeIngredienten() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            // Het kan als volgt korter (in één instructie)
            // return (HoeveelAlcoholischeIngredienten() > 0);
        }

        public String AlleIngredienten()
        {
            String uitvoer = "";

            foreach (Ingredient ingredient in _ingredienten)
            {
                uitvoer = uitvoer + ingredient.Hoeveelheid + " ml " + ingredient.Naam + "; ";
            }

            return uitvoer;
        }

        public Ingredient GeefIngredient(int indexnummer)
        { 
            if (indexnummer >= 0 && indexnummer < HoeveelIngredienten())
            {
                return _ingredienten[indexnummer];
            }
            else
            {
                return null;
            }
        }

        public String GeefNaamIngredient(int indexnummer)
        {
            if (indexnummer >= 0 && indexnummer < HoeveelIngredienten())
            {
                return _ingredienten[indexnummer].Naam;
            }
            else
            {
                return "#Fout";
            }
        }

        public void VerwijderIngredient(int indexnummer)
        {
            if (indexnummer >= 0 && indexnummer < HoeveelIngredienten())
            {
                _ingredienten.RemoveAt(indexnummer);
            }
        }

        public void MaakAlcoholVrij(decimal nieuwePrijs)
        {
            for (int i = HoeveelIngredienten() - 1; i >= 0; i--)
            {
                if (_ingredienten[i].IsAlcoholisch() == true)
                {
                    _ingredienten.RemoveAt(i);
                }
            }

            _kostprijs = nieuwePrijs;
            _naam = _naam + " - alcoholvrij";
        }

        public double Alcoholpercentage()
        {
            double hoeveelheidAlcohol=0;
            double alcoholpercentage;

            foreach (Ingredient ingredient in _ingredienten)
            {
                hoeveelheidAlcohol += ingredient.Hoeveelheid * ingredient.Alcoholpercentage;
            }

            alcoholpercentage = hoeveelheidAlcohol / InhoudCocktail();

            return alcoholpercentage;

        }

        public List<Ingredient> AlcoholischeIngredienten()
        {
            List<Ingredient> alcoholischeIngredienten = new List<Ingredient>();

            foreach (Ingredient ingredient in _ingredienten)
            {
                if (ingredient.IsAlcoholisch() == true)
                {
                    alcoholischeIngredienten.Add(ingredient);
                }
            }

            return alcoholischeIngredienten;
        }

        public List<Ingredient> NietAlcoholischeIngredienten()
        {
            List<Ingredient> nietAlcoholischeIngredienten = new List<Ingredient>();

            foreach (Ingredient ingredient in _ingredienten)
            {
                if (ingredient.IsAlcoholisch() == false)
                {
                    nietAlcoholischeIngredienten.Add(ingredient);
                }
            }

            return nietAlcoholischeIngredienten;
        }

        public void MaakPittiger()
        {
            foreach (Ingredient ingredient in _ingredienten)
            {
                if (ingredient.IsAlcoholisch() == true)
                {
                    ingredient.Hoeveelheid = (int)((double)ingredient.Hoeveelheid * 1.10);
                }
                else
                {
                    ingredient.Hoeveelheid = (int)((double)ingredient.Hoeveelheid * 0.90);
                }
            }
        }
    }
}
