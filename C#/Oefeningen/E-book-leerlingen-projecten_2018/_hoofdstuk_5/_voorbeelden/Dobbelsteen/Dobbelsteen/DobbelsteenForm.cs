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

namespace Dobbelsteen
{
    public partial class DobbelsteenForm : Form
    {
        private Business.Dobbelsteen _dobbelsteen;
        public DobbelsteenForm(int aantalZijden)
        {
            InitializeComponent();
            _dobbelsteen = new Business.Dobbelsteen(aantalZijden);
            dobbelsteenTextBox.Text = _dobbelsteen.Werp().ToString();
        }
        private void werpenButton_Click(object sender, EventArgs e)
        {
            dobbelsteenTextBox.Text = _dobbelsteen.Werp().ToString();
        }
    }
}
