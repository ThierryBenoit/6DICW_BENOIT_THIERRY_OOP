using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Activiteit
    {
        private int _activiteitID;
        private String _beschrijving;
        private DateTime _datumTijd;

        public Activiteit(int activiteitID, String beschrijving, DateTime datumTijd)
        {
            _activiteitID = activiteitID;
            _beschrijving = beschrijving;
            _datumTijd = datumTijd;
        }

        public int ActiviteitID
        {
            get { return _activiteitID; }
            set { _activiteitID = value; }
        }

        public String Beschrijving
        {
            get { return _beschrijving; }
            set { _beschrijving = value; }
        }

        public DateTime DatumTijd
        {
            get { return _datumTijd; }
            set { _datumTijd = value; }
        }

        public override String ToString()
        {
            return _beschrijving + " - " + _datumTijd.ToShortDateString();
        }

    }
}

