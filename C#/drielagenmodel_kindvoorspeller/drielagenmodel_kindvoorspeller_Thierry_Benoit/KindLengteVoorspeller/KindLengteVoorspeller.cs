using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindLengteVoorspeller
{
    internal class KindLengteVoorspeller
    {
        private double _LengteMan;
        private double _LengteVrouw;
        private int _AantalVoorspellingen;

        public KindLengteVoorspeller()
        {
            _AantalVoorspellingen= 0;
            _LengteMan= 0;
            _LengteVrouw= 0;
        }
        public double LengteMan
        {
            get { return _LengteMan; }
            set { _LengteMan = value; }
        }
        public double LengteVrouw
        {
            get { return _LengteVrouw;}
            set { _LengteVrouw = value;}
        }
        public int AantalVoorspellingen
        {
            get { return _AantalVoorspellingen;}
        }
        public double GemiddeldeOuders(double _LengteMan, double _LengteVrouw)
        {
            return (_LengteMan + _LengteVrouw) / 2;
        }
        public double BerekenDochter(double _LengteMan, double LengteVrouw)
        {
            double _LenteDochter = (GemiddeldeOuders(_LengteMan, LengteVrouw) - 6.5);
            _AantalVoorspellingen++;
            return _LenteDochter;

        }
        public double BerekenZoon(double _LengteMan, double LengteVrouw)
        {
            double _LengteZoon = (GemiddeldeOuders(_LengteMan, LengteVrouw) + 6.5);
            _AantalVoorspellingen++;
            return _LengteZoon;
        }
    }
}
