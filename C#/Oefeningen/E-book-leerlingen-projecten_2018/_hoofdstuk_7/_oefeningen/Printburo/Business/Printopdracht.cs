using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Printopdracht
    {
        private int _paginasOrigineel;
        private int _aantalExemplaren;

        public Printopdracht(int paginasOrigineel, int aantalExemplaren)
        {
            _paginasOrigineel = paginasOrigineel;
            _aantalExemplaren = aantalExemplaren;
        }

        public int PaginasOrigineel
        {
            get { return _paginasOrigineel; }
        }

        public int AantalExemplaren
        {
            get { return _aantalExemplaren; }
        } 
       
    }
}
