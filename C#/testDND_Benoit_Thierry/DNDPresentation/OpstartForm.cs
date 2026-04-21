using DNDBussines;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using testDND_Benoit_Thierry;
namespace DNDPresentation

{
    public partial class OpstartForm : Form
    {

        public OpstartForm()
        {

            InitializeComponent();


        }
        private List<Karakter> _lstKarakters;
        private void VoegToeButton_Click(object sender, EventArgs e)
        {
            Karakter k = new Karakter(Convert.ToString(NaamBox), Convert.ToInt32(Sterktebox));
            _lstKarakters.Add(k);
            comboBox1.DataContext = null;
            comboBox1.DataContext = _lstKarakters;
        }

        private void ToonFormulierButton_Click(object sender, EventArgs e)
        {
            MeerInfo formulier = new MeerInfo(Convert.ToString(NaamBox), Convert.ToInt32(Sterktebox));
            formulier.Show();
            
        }

        private void ToonHierButton_Click(object sender, EventArgs e)
        {
            NaamEnLeeftijd.Text = _lstKarakters.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
