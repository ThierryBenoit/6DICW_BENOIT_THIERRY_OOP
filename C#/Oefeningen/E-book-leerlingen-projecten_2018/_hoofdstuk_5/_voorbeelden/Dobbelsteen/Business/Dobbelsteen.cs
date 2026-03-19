using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Dobbelsteen
    {
        private int _aantalZijden;
        private Random _getalGenerator;

        public Dobbelsteen(int aantalZijden)
        {
            _aantalZijden = aantalZijden;
            _getalGenerator= new Random();
        }
        public int AantalZijden
        {
            get { return _aantalZijden;}
        }
        public int Werp()
        {
            return _getalGenerator.Next(_aantalZijden) + 1;
        }
    }
}
