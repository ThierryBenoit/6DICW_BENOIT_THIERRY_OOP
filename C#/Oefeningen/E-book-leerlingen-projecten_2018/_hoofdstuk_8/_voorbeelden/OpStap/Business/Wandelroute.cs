using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Wandelroute
    {
        private int _id;
        private String _naam;
        private int _kilometers;
        private String _gemeente;
        private String _provincie;

        public Wandelroute(int id, String naam, int kilometers, String gemeente, String provincie)
        {
            _id = id;
            _naam = naam;
            _kilometers = kilometers;
            _gemeente = gemeente;
            _provincie = provincie;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public int Kilometers
        {
            get { return _kilometers; }
            set { _kilometers = value; }
        }

        public String Gemeente
        {
            get { return _gemeente; }
            set { _gemeente = value; }
        }

        public String Provincie
        {
            get { return _provincie; }
            set { _provincie = value; }
        }

        public override string ToString()
        {
            return _naam + " in " + _gemeente + " (" + _provincie + ") - " + _kilometers.ToString() + " km";
        }
    }
}
