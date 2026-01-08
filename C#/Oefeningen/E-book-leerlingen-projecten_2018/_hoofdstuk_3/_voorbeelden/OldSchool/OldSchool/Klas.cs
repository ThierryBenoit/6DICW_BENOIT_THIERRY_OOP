using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldSchool
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

        public String GetAfkorting()
        {
            return _afkorting;
        }

        public int GetJaar()
        {
            return _jaar;
        }

        public String GetRichting()
        {
            return _richting;
        }

        public String GetTitularis()
        {
            return _titularis;
        }

        public void SetTitularis(String titularis)
        {
            _titularis = titularis;
        }

        public int GetAantalLeerlingen()
        {
            return _aantalLeerlingen;
        }

        public void SetAantalLeerlingen(int aantalLeerlingen)
        {
            _aantalLeerlingen = aantalLeerlingen;
        }

    }
}
