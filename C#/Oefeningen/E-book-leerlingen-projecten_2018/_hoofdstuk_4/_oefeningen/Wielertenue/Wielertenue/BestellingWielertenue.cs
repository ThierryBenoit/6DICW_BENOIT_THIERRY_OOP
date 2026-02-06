using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;

namespace Wielertenue
{
    class BestellingWielertenue
    {
        private int _aantal;  // hoeveel stuks bestel je
        private bool _waterdichtZakje;  // is er in het truitje een waterdicht GSM-opbergzakje voorzien
        private bool _broek;  // neem je ook de wielerbroek (of anders enkel het wielertruitje)
        private bool _superZeem; // is de wielerbroek voorzien van een zeem met hogere kwaliteit

        public BestellingWielertenue(int aantal, bool waterdichtZakje, bool broek, bool superZeem)
        {
            _aantal = aantal;
            _waterdichtZakje = waterdichtZakje;
            _broek = broek;
            _superZeem = superZeem;
        }

        public int Aantal
        {
            get { return _aantal; }
            set { _aantal = value; }
        }
        public bool WaterdichtZakje
        {
            get { return _waterdichtZakje; }
            set { _waterdichtZakje = value; }
        }
        public bool Broek
        {
            get { return _broek; }
            set { _broek = value; }
        }
        public bool SuperZeem
        {
            get { return _superZeem ; }
            set { _superZeem =value; }
        }
        public decimal GeefPrijs()
        {
            decimal _prijs = 45;
            if (_broek)
            {
                _prijs += 80;
            }
            if (_waterdichtZakje)
            {
                _prijs += Convert.ToDecimal(3.5);
            }
            if (_superZeem)
            {
                _prijs += Convert.ToDecimal(5.50);
            }
            if (_aantal <= 5)
            {
                _prijs = (_prijs / 100) * 90;
            }
            return _prijs;
        }


    }
}
