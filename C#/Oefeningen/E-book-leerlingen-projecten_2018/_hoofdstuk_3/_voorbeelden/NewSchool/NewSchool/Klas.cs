using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSchool
{
    public class Klas
    {
        private String _afkorting;
        private int _jaar;
        private String _richting;
        private String _titularis;
        private int _aantalLeerlingen;

        public Klas(String afkorting, int jaar, String richting, String titularis,
                    int aantalLeerlingen)
        {
            _afkorting = afkorting;
            _jaar = jaar;
            _richting = richting;
            _titularis = titularis;
            _aantalLeerlingen = aantalLeerlingen;
        }

        public String Afkorting
        {
            get { return _afkorting; }
        }

        public int Jaar
        {
            get { return _jaar; }
        }

        public String Richting
        {
            get { return _richting; }
        }

        public String Titularis
        {
            get { return _titularis; }
            set { _titularis = value; }
        }

        public int AantalLeerlingen
        {
            get { return _aantalLeerlingen; }
            set { _aantalLeerlingen = value; }
        }
    }
}
