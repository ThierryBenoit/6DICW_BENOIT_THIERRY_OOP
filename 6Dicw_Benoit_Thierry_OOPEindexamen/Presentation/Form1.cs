using Business;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private List<Personage> _personages;
        private List<Planeet> _planeten;
        private List<Schip> _vloot;
        private BSGData _BSGData;
        public Form1()
        {
            InitializeComponent();
            _BSGData = new BSGData();
            _personages = _BSGData.ReadPersonageTable();
            _planeten = _BSGData.ReadPlaneetTable();
            _vloot = _BSGData.ReadVlootTable();
        }

        private void CylonDetectButton_Click(object sender, EventArgs e)
        {
            int rij = dataGridViewPersonages.CurrentCell.RowIndex;
            String naam = dataGridViewPersonages.Rows[rij].Cells[0].Value.ToString();

            foreach (Personage personage in _personages)
            {
                if (personage.Naam == naam)
                {
                    if (personage.isCylon)
                    {
                        label1.ForeColor = Color.Red;
                    }
                    else
                    {
                        label1.ForeColor = Color.Green;
                    }
                }
            }
        }

        private void LaadVlootButton_Click(object sender, EventArgs e)
        {
            DataGridViewVloot.Columns.Add("Naam", "Naam");
            DataGridViewVloot.Columns.Add("Type", "Type");
            DataGridViewVloot.Columns.Add("Bouwjaar", "Bouwjaar");
            DataGridViewVloot.Columns.Add("AantalBemanning", "AantalBemanning");
            DataGridViewVloot.Columns.Add("Status", "Status");

            foreach (Schip schip in _vloot)
            {
                DataGridViewVloot.Rows.Add(
                    schip.Naam,
                    schip.Type,
                    schip.Bouwjaar,
                    schip.AantalBemanning,
                    schip.Status
                    );

            }
        }

        private void LaadPersonagesButton_Click(object sender, EventArgs e)
            //Laad de personen op het schip
        {
            dataGridViewPersonages.Columns.Add("Naam", "Naam");
            dataGridViewPersonages.Columns.Add("Rol", "Rol");
            dataGridViewPersonages.Columns.Add("Leeftijd", "Leeftijd");

            foreach (Personage personage in _personages)
            {
                dataGridViewPersonages.Rows.Add(
                personage.Naam,
                personage.Rol,
                personage.Leeftijd
                );
            }
        }

        private void HerlaadButton_Click(object sender, EventArgs e)
        {
            DataGridViewVloot.Columns.Add("Naam", "Naam");
            DataGridViewVloot.Columns.Add("Type", "Type");
            DataGridViewVloot.Columns.Add("Bouwjaar", "Bouwjaar");
            DataGridViewVloot.Columns.Add("AantalBemanning", "AantalBemanning");
            DataGridViewVloot.Columns.Add("Status", "Status");
            // Laad de schepen
            foreach (Schip schip in _vloot)
            {
                DataGridViewVloot.Rows.Add(
                    schip.Naam,
                    schip.Type,
                    schip.Bouwjaar,
                    schip.AantalBemanning,
                    schip.Status
                    );

            }

            dataGridViewPersonages.Columns.Add("Naam", "Naam");
            dataGridViewPersonages.Columns.Add("Rol", "Rol");
            dataGridViewPersonages.Columns.Add("Leeftijd", "Leeftijd");

            foreach (Personage personage in _personages)
            {
                dataGridViewPersonages.Rows.Add(
                personage.Naam,
                personage.Rol,
                personage.Leeftijd
                );
            }
            //Laad de planeten
            dataGridViewPlaneten.Columns.Add("Naam", "Naam");
            dataGridViewPlaneten.Columns.Add("Zonnestelsel", "Zonnestelsel");
            dataGridViewPlaneten.Columns.Add("Bewoonbaar", "Bewoonbaar");
            dataGridViewPlaneten.Columns.Add("LiterWater", "LiterWater");

            foreach (Planeet planeet in _planeten)
            {
                dataGridViewPlaneten.Rows.Add(
                    planeet.Naam,
                    planeet.Zonnestelsel,
                    planeet.Bewoonbaar,
                    planeet.WaterLiters);
            }
            label1.ForeColor = System.Drawing.Color.White;
        }

        private void LaadPlanetenButton_Click(object sender, EventArgs e)
        {
            dataGridViewPlaneten.Columns.Add("Naam", "Naam");
            dataGridViewPlaneten.Columns.Add("Zonnestelsel", "Zonnestelsel");
            dataGridViewPlaneten.Columns.Add("Bewoonbaar", "Bewoonbaar");
            dataGridViewPlaneten.Columns.Add("LiterWater", "LiterWater");

            foreach (Planeet planeet in _planeten)
            {
                dataGridViewPlaneten.Rows.Add(
                    planeet.Naam,
                    planeet.Zonnestelsel,
                    planeet.Bewoonbaar,
                    planeet.WaterLiters);
            }
        }

        private void DeleteCyclonButton_Click(object sender, EventArgs e)
        {
            int rij = dataGridViewPersonages.CurrentCell.RowIndex;
            String naam = dataGridViewPersonages.Rows[rij].Cells[0].Value.ToString();

            foreach (Personage personage in _personages)
            {
                if (personage.Naam == naam)
                {
                    if (personage.isCylon)
                    {
                        dataGridViewPersonages.Rows.RemoveAt(rij);
                        _BSGData.DeleteCyclon(naam);
                    }
                }
            }
        }
    }
}
