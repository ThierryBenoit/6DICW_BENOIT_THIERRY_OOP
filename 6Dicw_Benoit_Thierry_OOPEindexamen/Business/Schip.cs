using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Schip
    {
        private int _id;
        private string _naam;
        private string _type;
        private int _bouwjaar;
        private int _aantalBemanning;
        private string _status;

        public Schip(int id, string naam, string type, int bouwjaar,
            int aantalBemanning, string status)
        {
            _id = id;
            _naam = naam;
            _type = type;
            _bouwjaar = bouwjaar;
            _aantalBemanning = aantalBemanning;
            _status = status;
        }
        public int Id { get { return _id; } }
        public string Naam { get { return _naam; } }
        public string Type { get { return _type; } }
        public int Bouwjaar { get { return _bouwjaar; } }
        public int AantalBemanning { get { return _aantalBemanning; } }
        public string Status { get { return _status; } }



    }
}
