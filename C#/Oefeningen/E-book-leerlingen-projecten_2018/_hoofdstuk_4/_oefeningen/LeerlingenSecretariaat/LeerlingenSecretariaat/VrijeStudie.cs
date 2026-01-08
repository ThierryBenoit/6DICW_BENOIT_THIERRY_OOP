using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerlingenSecretariaat
{
    public class VrijeStudie
    {
        private String _lokaal;  // lokaal waar vrije studie doorgaat
        private int _capaciteit;  // hoeveel leerlingen kunnen in het lokaal 
        private int _gereserveerdePlaatsen; // hoeveel plaatsen werden al gereserveerd

        public VrijeStudie(String lokaal, int capaciteit)
        {
            _lokaal = lokaal;
            _capaciteit = capaciteit;
            _gereserveerdePlaatsen = 0;
        }

        public String Lokaal
        {
            get { return _lokaal; }
        }

        public int Capaciteit
        {
            get { return _capaciteit; }
        }

        public int GereserveerdePlaatsen
        {
            get { return _gereserveerdePlaatsen; }
            set { _gereserveerdePlaatsen = value; }
        }

        public bool IsErNogPlaats(int aantal)
        {
            bool isErNogPlaats = false;

            if (_gereserveerdePlaatsen + aantal <= _capaciteit)
            {
                isErNogPlaats = true;
            }

            return isErNogPlaats;
        }
    }
}
