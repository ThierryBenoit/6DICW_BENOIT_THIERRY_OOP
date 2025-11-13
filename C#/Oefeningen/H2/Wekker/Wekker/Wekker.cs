using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wekker
{
    public class Wekker
    {
        private int uur;
        private int minuut;

        public Wekker()
        {
            uur = 0;
            minuut = 0;
        }

        public int getUur()
        {
            return uur;
        }

        public int getMinuut()
        {
            return minuut;
        }

        public void setUur(int uur)
        {
            this.uur = uur;
        }

        public void setMinuut(int minuut)
        {
            this.minuut = minuut;
        }

        public void urenPlus()
        {
            uur++;
            if (uur > 23)
            {
                uur = uur - 24;
            }
        }

        public void urenMin()
        {
            uur--;
            if (uur < 0)
            {
                uur = uur + 24;
            }
        }

        public void minutenPlus()
        {
            minuut++;
            if (minuut > 59)
            {
                minuut = minuut - 60;
            }
        }

        public void minutenMin()
        {
            minuut--;
            if (minuut < 0)
            {
                minuut = minuut + 60;
            }
        }

        public String alarmOm()
        {
            String minuutString;
            String uurString;

            minuutString = displayTweeCijfers(minuut);
            uurString = displayTweeCijfers(uur);

            return uurString + ":" + minuutString;
        }

        private String displayTweeCijfers(int getal)
        {
            String displayString;

            if (getal < 10)
            {
                displayString = "0" + getal.ToString();
            }
            else
            {
                displayString = getal.ToString();
            }

            return displayString;
        }

    }
}
