using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using DataAccess;

namespace Presentation
{
    public partial class LangsteWandelrouteForm : Form
    {
        private String _naamLangsteWandelroute;
        private WandelrouteDA _wandelrouteDA;

        public LangsteWandelrouteForm()
        {
            InitializeComponent();

            // het veld _wandelrouteDA initialiseren
            _wandelrouteDA = new WandelrouteDA();

            // het veld _naamLangsteWandelroute instellen via ons data-accessobject
            _naamLangsteWandelroute = _wandelrouteDA.ReadLangsteWandelroute();

            // de naam van de langste wandelroute weergeven in het label
            langsteRouteLabel.Text = _naamLangsteWandelroute;
        }

    }
}
