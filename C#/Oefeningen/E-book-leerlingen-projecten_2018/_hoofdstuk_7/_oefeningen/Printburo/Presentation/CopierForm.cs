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

namespace Presentation
{
    public partial class CopierForm : Form
    {
        private int _teller;
        private List<Printopdracht> _wachtrij;
        private int _paginasOrigineel;
        private int _aantalExemplaren;
        private Copier _copier;

        public CopierForm()
        {
            InitializeComponent();
            _teller = 0;
            _wachtrij = new List<Printopdracht>();
            _copier = new Copier();

        }

        private void CopierForm_Load(object sender, EventArgs e)
        {

        }

        private void paginasNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void inWachtrijButton_Click(object sender, EventArgs e)
        {
            _paginasOrigineel=(int) Convert.ToInt64(paginasNumericUpDown.Value);
            _aantalExemplaren = (int)Convert.ToInt64(kopiesNumericUpDown.Value);
            Printopdracht _printOpdracht = new Printopdracht(_paginasOrigineel, _aantalExemplaren);
            _wachtrij.Add(_printOpdracht);
            wachtrijListBox.Items.Add(_printOpdracht).ToString();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            _copier.Print();
        }
    }
}
