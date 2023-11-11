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
    public partial class ProsirenjaSaveza : Form
    {
        public int ProsledjenId;
        public ProsirenjaSaveza()
        {
            InitializeComponent();
        }

        public ProsirenjaSaveza(int ProslednjenId) 
        {
            InitializeComponent();
            this.ProsledjenId = ProslednjenId;
        }

        private void ProsirenjaSaveza_Load(object sender, EventArgs e)
        {
            popuniListu();
        }

        public void popuniListu() 
        {
            //KOLONIZACIJE
            ListaKolonizacijaSaveza.Items.Clear();
            List<DTOKolonizacija> savezi = DTOManager.vratiKolonizacijeSaveza(this.ProsledjenId);


            foreach (DTOKolonizacija p in savezi)
            {

                ListViewItem item = new ListViewItem(new string[] {p.Datum.ToString(), p.PlanetaKolonizuje_ImePlanete });
                ListaKolonizacijaSaveza.Items.Add(item);

            }

            ListaKolonizacijaSaveza.Refresh();

            //OSVAJANJA
            ListaOsvajanjaSaveza.Items.Clear();
            List<DTOOsvajanje> osvajanjaa = DTOManager.vratiOsvajanjaSaveza(this.ProsledjenId);


            foreach (DTOOsvajanje p in osvajanjaa)
            {

                ListViewItem item = new ListViewItem(new string[] {p.Datum.ToString(), p.PrethodniVlasnikIgrac,
                                                                   p.PrethodniVlasnikSavez, p.PlanetaOsvaja_ImePlanete});
                ListaOsvajanjaSaveza.Items.Add(item);

            }

            ListaOsvajanjaSaveza.Refresh();
        }



        private void btnDodajOsvajanja_Click(object sender, EventArgs e)
        {
            ProsirenjaSavezaDodajOsvajanjaForma p = new ProsirenjaSavezaDodajOsvajanjaForma(ProsledjenId);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            popuniListu();

        }

        private void btnDodajKolonizacije_Click(object sender, EventArgs e)
        {
            ProsirenjaSavezaDodajKolonizacijeForma p = new ProsirenjaSavezaDodajKolonizacijeForma(ProsledjenId);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            popuniListu();

        }

        
    }
}
