using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testDND_Benoit_Thierry;

namespace DNDBussines
{
    public class DND
    {
        private List<Karakter> _lstKarakters;

        public DND(List<Karakter> lstKarakters)
        {
            _lstKarakters = lstKarakters;
        }

        public List<Karakter> Karakters { get { return _lstKarakters; } }
        public bool Aanwezig(String naam)
        {
            bool _aanwezig = false;
            int i = 0;
            while(i<_lstKarakters.Count())
            {
                if (_lstKarakters[i].Naam == naam)
                {
                    _aanwezig=true;
                } 
            }
            return _aanwezig;
        }
        public Karakter GeefKarakter(String naam)
        {
            Karakter k = null;
            bool _aanwezig = false;
            int i = 0;
            while (i < _lstKarakters.Count())
            {
                if(_lstKarakters[i].Naam == naam)
                {
                    k = _lstKarakters[i];
                }
            }
            return k;
        }
        public void VoegToe(String naam,int _sterkte)
        {
            Karakter k = new Karakter(naam, _sterkte);
            _lstKarakters.Add(k);
        }
    }
}
