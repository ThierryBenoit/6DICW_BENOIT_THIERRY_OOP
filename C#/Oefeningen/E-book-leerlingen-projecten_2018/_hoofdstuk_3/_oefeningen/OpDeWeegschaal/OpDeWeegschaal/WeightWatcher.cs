using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpDeWeegschaal
{
    public class WeightWatcher
    {
        private int _gewicht;
        private double _grootte;

        public WeightWatcher(int gewicht, double grootte)
        {
            _gewicht = gewicht;
            _grootte = grootte;
        }
        public int Gewicht
        {
            get { return _gewicht; }
            set { _gewicht = value; }
        }
        public double Grootte
        {
            get { return _grootte; }
        }
        public double GeefBMI()
        {
            return _gewicht / (_grootte * _grootte);
        }
        public String Geefstatus()
        {
            if (GeefBMI() < 20)
            {
                return "ondergewicht";
            }else if (GeefBMI() > 20 && GeefBMI() < 25)
            {
                return "ok";
            }else if(GeefBMI() > 25 && GeefBMI() < 30)
            {
                return "overgewicht";
            }
            else
            {
                return "obees";
            }
        }

    }   
}

