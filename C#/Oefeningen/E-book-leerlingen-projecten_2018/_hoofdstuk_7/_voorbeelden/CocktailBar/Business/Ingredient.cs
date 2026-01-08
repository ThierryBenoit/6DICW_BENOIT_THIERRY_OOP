using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Ingredient
    {
        private String _naam; // naam van het ingredient
        private int _hoeveelheid;  // hoeveel ml 
        private double _alcoholpercentage; // alcoholpercentage van het ingredient

        public Ingredient(String naam, int hoeveelheid, double alcoholpercentage)
        {
            _naam = naam;
            _hoeveelheid = hoeveelheid;
            _alcoholpercentage = alcoholpercentage;
        }

        public String Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public int Hoeveelheid
        {
            get { return _hoeveelheid; }
            set { _hoeveelheid = value; }
        }

        public double Alcoholpercentage
        {
            get { return _alcoholpercentage; }
            set { _alcoholpercentage = value; }
        }

        public bool IsAlcoholisch()
        {
            if (_alcoholpercentage > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            // Het kan als volgt korter (in één instructie)
            // return (_alcoholpercentage > 0);
        }
    }
}
