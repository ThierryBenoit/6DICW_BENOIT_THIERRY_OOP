using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNDPresentation
{
    public partial class MeerInfo : Form
    {
        private string _naam;
        private int _sterkte;
        public MeerInfo(String Naam, int Sterkte)
        {
            InitializeComponent();
            _naam = Naam;
            _sterkte = Sterkte;
        }

        private void MeerInfo_Load(object sender, EventArgs e)
        {
            textBox1.Text = _naam;
            textBox2.Text = _sterkte.ToString();
        }
    }
}
