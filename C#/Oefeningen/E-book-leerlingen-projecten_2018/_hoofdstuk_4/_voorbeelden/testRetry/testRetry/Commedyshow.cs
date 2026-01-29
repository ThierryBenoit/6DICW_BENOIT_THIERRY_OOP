using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testRetry
{
    internal class Commedyshow
    {
        private String _laatste;
        private int _aantal;
        private double _totaalscore;

        public Commedyshow()
        {
            _laatste = "";
            _aantal = 0;
            _totaalscore = 0;
        }
        public String Laatste
        {
            get { return _laatste; }
            set { _laatste = value; }
        }
        public int Aantal
        {
            get { return _aantal; }

        }
        public void Add(String naam, double score)
        {
            _laatste += naam;
            _aantal++;
            _totaalscore += score;
        }
        public double berekenGemiddelde()
        {
            return _totaalscore / _aantal;
        }


    }
}
