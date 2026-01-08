using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wekker
{
    public partial class Form1 : Form

    {
        private Wekker _wekker;
        public Form1()
        {
            InitializeComponent();
            _wekker = new Wekker();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Black(object sender, EventArgs e)
        {

        }
    }
}
