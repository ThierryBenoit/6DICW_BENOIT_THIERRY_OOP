using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailBar
{
    internal class Ingredient
    {
        private string _naam;
        private int _hoeveelheid;
        private double _alcocholPercentage; 
    
    public Ingredient(string naam, int hoeveelheid, double alcocholpercentage)
        {
            _naam = naam;
            _hoeveelheid = hoeveelheid;
            _alcocholPercentage = alcocholpercentage;
        }

        public String Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public int Hoeveelheid {
            get { return _hoeveelheid; }
            set { _hoeveelheid = value; }

        }
        public double AlcocholPercentage {
            get { return _alcocholPercentage; }
            set { _alcocholPercentage = value; }
        }
        public bool IsAlcoholisch()
        {
            if (_alcocholPercentage > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

        