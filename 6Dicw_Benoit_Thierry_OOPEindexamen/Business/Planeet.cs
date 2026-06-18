using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Planeet
    {
        private int _id;
        private string _naam;
        private string _zonnestelsel;
        private int _waterLiters;
        private bool _bewoonbaar;

        public Planeet(int id, string naam, string zonnestelsel, int waterLiters, bool bewoonbaar)
        {
            _id = id;
            _naam = naam;
            _zonnestelsel = zonnestelsel;
            _waterLiters = waterLiters;
            _bewoonbaar = bewoonbaar;
        }

        public int Id { get { return _id; } }
        public string Naam { get { return _naam; } }
        public string Zonnestelsel { get { return _zonnestelsel; } }
        public int WaterLiters { get { return _waterLiters; } }
        public bool Bewoonbaar { get { return _bewoonbaar; } }

    }
}
