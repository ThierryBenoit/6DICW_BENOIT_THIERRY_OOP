using Microsoft.VisualBasic.Logging;
using System;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace ProjectZonderNaam
{
    internal class ProjectZonderNaam
    {
        private string _voornaam;
        private string _familienaam;

        public ProjectZonderNaam(string voornaam, string familienaam)
        {
            _voornaam = voornaam;
            _familienaam = familienaam;
        }

        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public string Familienaam
        {
            get { return _familienaam; }
            set { _familienaam = value; }
        }
        public string Initialen()
        {
           return $"{char.ToUpper(_voornaam[0])}.{char.ToUpper(_familienaam[0])}";
        }


        private string AlfaNaam(string naam)
        {

            string resultaat = naam.Replace(" ", "").Replace("-", "");

            resultaat = resultaat.Replace("é", "e").Replace("è", "e");

            resultaat = resultaat.ToLower();

            return resultaat;
        }

        public string AlfaVoornaam()
        {
            return AlfaNaam(_voornaam);
        }

        public string AlfaFamilienaam()
        {
            return AlfaNaam(_familienaam);
        }
    }
}


