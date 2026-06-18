using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Personage
    {
        private int _id;
        private string _naam;
        private int _planeetId;
        private int _schipId;
        private bool _isCylon;
        private String _rol;
        private int _leeftijd;

        public Personage(int id, string naam, int planeetId, int schipId, bool isCylon, string rol, int leeftijd)
        {
            _id = id;
            _naam = naam;
            _planeetId = planeetId;
            _schipId = schipId;
            _isCylon = isCylon;
            _rol = rol;
            _leeftijd = leeftijd;
        }

        public int Id { get { return _id; } }
        public string Naam { get { return _naam; } }
        public int PlaneetId { get { return _planeetId; } }
        public int SchipId { get { return _schipId; } }
        public bool isCylon { get { return _isCylon; } }
        public string Rol { get { return _rol; } }
        public int Leeftijd { get { return _leeftijd; } }

    }
}
