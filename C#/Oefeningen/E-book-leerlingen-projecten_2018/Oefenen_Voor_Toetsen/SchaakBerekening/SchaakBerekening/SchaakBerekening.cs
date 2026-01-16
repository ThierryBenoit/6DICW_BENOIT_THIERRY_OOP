using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_oefening
{
    internal class Schaakberekening
    {
        private double _yourElo;
        private double _opponentElo;
        private double _expectedScore;
        private double _actualScore;
        private int _Kfactor;
        private double _Newelo;

        public Schaakberekening(int yourElo, int opponentElo)
        {
            _yourElo = yourElo;
            _opponentElo = opponentElo;
            _Kfactor = 20;
        }
        public double YourElo
        {
            set { _yourElo = value; }
            get { return _yourElo; }

        }
        public double OpponentElo
        {
            set { _opponentElo = value; }
            get { return _opponentElo; }
        }
        public void ExpectedScore()
        {
            _expectedScore = 1 / (1 + Math.Pow(10.0, (_opponentElo - _yourElo) / 400.0));
        }
        public double NewEloCalculation()
        {
            double expected = 1 / (1 + Math.Pow(10.0, (_opponentElo - _yourElo) / 400.0));
            _yourElo = _yourElo + _Kfactor * (_actualScore - expected);
            return _yourElo;
        }

        public double SetNewElo()
        {
            return _yourElo;
        }
        public void Gewonnen()
        {
            _actualScore= 1;
        }
        public void Gelijk()
        {
            _actualScore = 0.5;
        }
        public void Verloren()
        {
            _actualScore = 0;
        }
    }
}
