using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DL;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private List<Wielrenner> _wielrenners;
        private Database _wielrennerDA;
        public Form1()
        {
            InitializeComponent();

            _wielrenners = new List<Wielrenner>();
            _wielrennerDA = new Database();
            _wielrenners = _wielrennerDA.ReadTable();


            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("name", "Name");
            dataGridView1.Columns.Add("nationality", "Nationality");
            dataGridView1.Columns.Add("birthdate", "Birthdate");
            dataGridView1.Columns.Add("gender", "Gender");
            dataGridView1.Columns.Add("wins", "Wins");
            dataGridView1.Columns.Add("points", "Points");
            dataGridView1.Columns.Add("ranking", "Ranking");

            foreach (Wielrenner w in _wielrenners)
            {
                dataGridView1.Rows.Add(
                    w.Rider_id,
                    w.Name,
                    w.Nationality,
                    w.Birthdate.ToShortDateString(),
                    w.Gender,
                    w.Total_wins,
                    w.Total_points,
                    w.Ranking
                );

            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            int riderID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            _wielrennerDA.DeleteRenner(riderID);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NieuweRennerToeveoegenForm frm = new NieuweRennerToeveoegenForm();
            frm.ShowDialog();
            
            Wielrenner w = frm.nieuweWielrenner();

            dataGridView1.Rows.Add(
                    w.Rider_id,
                    w.Name,
                    w.Nationality,
                    w.Birthdate.ToShortDateString(),
                    w.Gender,
                    w.Total_wins,
                    w.Total_points,
                    w.Ranking
                );

        }
    }
}
