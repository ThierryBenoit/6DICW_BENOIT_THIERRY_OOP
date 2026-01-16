using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_oefening
{
    internal class lowie

    {
        private int _leeftijd;
        public lowie()
        {
            _leeftijd = 44;
        }
        public int Leeftijd { get { return _leeftijd; } }

        public void JaartjeOuder()
        {
            _leeftijd++;
        }
        public void JaartjeJongerOpEenOfAndereManier()
        {
            _leeftijd--;
        }
    }
}

