using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reisbureau
{
    public class Groepsreis
    {
        private String _bestemming;
        private int _maxDeelnemers;
        private int _inschrijvingen;
        private double _PrijsPerPersoon;
        private bool _kinderenToegelaten;
        private char _klasseVerblijf;

        public Groepsreis(double _PrijsPerPersoon, bool _kinderenToegelaten, char _klasseVerblijf)
        {
            _bestemming = "Evergem";
            _maxDeelnemers = 6;
            _inschrijvingen = 1;
            this._PrijsPerPersoon = _PrijsPerPersoon;
            this._kinderenToegelaten = _kinderenToegelaten;
            this._klasseVerblijf = _klasseVerblijf;

        }
        public void VolwasseneInschrijven(int _inschrijvingen, int _maxDeelnemers)
        {
            if (_inschrijvingen < _maxDeelnemers)
            {
                _inschrijvingen++;
            }
        }
        public void KinderenInschrijven(int aantalKinderen)
        {
            if (_kinderenToegelaten)
            {
                if (_inschrijvingen + aantalKinderen <= _maxDeelnemers)
                {
                    _inschrijvingen += aantalKinderen;
                }
            }

        }
    }
}


