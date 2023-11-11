using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deathstar.Forme
{
    public partial class ProsirenjaIgraca : Form
    {
        public int ProsledjenId;
        public ProsirenjaIgraca()
        {
            InitializeComponent();
        }

        public ProsirenjaIgraca(int ProsledjenId) 
        {
            InitializeComponent();
            this.ProsledjenId = ProsledjenId;
        }

        private void ProsirenjaIgraca_Load(object sender, EventArgs e)
        {
            popuniListu(this.ProsledjenId);
        }

        //popunjavanje kolonizacija i osvajanja
        public void popuniListu(int id) 
        {

            //KOLONIZACIJA
            ListaKolonizacijaIgraca.Items.Clear();
            List<DTOKolonizacija> igraci = DTOManager.vratiKolonizacijeIgraca(id);


            foreach (DTOKolonizacija p in igraci)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Datum.ToString(), p.PlanetaKolonizuje_ImePlanete });
                ListaKolonizacijaIgraca.Items.Add(item);

            }
            ListaKolonizacijaIgraca.Refresh();

            //OSVAJANJA
            ListaOsvajanjaIgraca.Items.Clear();
            List<DTOOsvajanje> osvajanja = DTOManager.vratiOsvajanjaIgraca(id);


            foreach (DTOOsvajanje p in osvajanja)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Datum.ToString(),
                                                                    p.PrethodniVlasnikIgrac, p.PrethodniVlasnikSavez,
                                                                    p.PlanetaOsvaja_ImePlanete});
                ListaOsvajanjaIgraca.Items.Add(item);

            }

            ListaOsvajanjaIgraca.Refresh();
        }


        private void Nazad_Click(object sender, EventArgs e)
        {
            IgraciForma p = new IgraciForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void btnDodajOsvajanje_Click(object sender, EventArgs e)
        {

            ProsirenjeIgracaDodajOsvajanjaForma p = new ProsirenjeIgracaDodajOsvajanjaForma(ProsledjenId);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            popuniListu(ProsledjenId);

        }

        private void btnDodajKolonizaciju_Click(object sender, EventArgs e)
        {


            ProsirenjeIgracaDodajKolonizacijeForma p = new ProsirenjeIgracaDodajKolonizacijeForma(ProsledjenId);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            popuniListu(ProsledjenId);

        }

        private void ListaOsvajanjaIgraca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
