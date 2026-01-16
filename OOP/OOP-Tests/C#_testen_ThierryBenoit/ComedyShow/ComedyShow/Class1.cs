using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComedyShow
{
    internal class ComedyShow

    {
        private double _gemiddelde;
        private int _aantalShows;
        private double _somRatings;
        private string _naamShow;
        private double _scoreShow;

        public ComedyShow(string naamShow, double scoreShow)
        {
            _aantalShows = 0;
            _somRatings = 0;
            _naamShow = naamShow;
            _scoreShow = scoreShow;
        }
        public int AantalShows
        {
            get { return _aantalShows; }
        }
        public string NaamShow
        {
            get { return _naamShow; }
            set { _naamShow = value; }
        }
        public double ScoreShow
        {
            get { return _scoreShow; }
            set { _scoreShow = value; }
        }
        public void Add(string _naamShow,  double _scoreShow)
        {
            _somRatings = _somRatings + _scoreShow;
            _aantalShows++;

        }
        public double BerekenGemiddelde()
        {
            _gemiddelde = _somRatings / _aantalShows;
            return _gemiddelde;
        }
    }
}
