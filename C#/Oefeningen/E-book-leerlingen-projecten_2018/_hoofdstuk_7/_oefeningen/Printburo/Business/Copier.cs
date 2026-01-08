using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Copier
    {
        private int _teller;
        private List<Printopdracht> _wachtrij;

        public Copier()
        {
            _teller = 0;
            _wachtrij = new List<Printopdracht>();
        }
        
        public int Teller
        {
            get { return _teller; }
        }

        public List<Printopdracht> Wachtrij
        {
            get { return _wachtrij; }
        }

        // nog te programmeren ...
        // deze methode laat een nieuwe printopdracht op de wachtrij zetten
        // ----------------------------------------------------------------
        public void VoegPrintopdrachtToe(int aantalPaginas, int aantalExemplaren)
        {
        }

        // nog te programmeren ...
        // deze methode laat de eerste printopdracht in de wachtrij verwerken
        // ------------------------------------------------------------------
        public void Print()
        {
        }

    }
}
