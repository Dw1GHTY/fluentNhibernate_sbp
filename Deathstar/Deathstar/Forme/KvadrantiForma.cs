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
    public partial class KvadrantiForma : Form
    {
        public int PrenesenId;
        public KvadrantiForma()
        {
            InitializeComponent();
        }
        public KvadrantiForma(int PrenesenId) 
        {
            InitializeComponent();
            this.PrenesenId = PrenesenId;
        }

        private void KvadrantiForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima() 
        {
            ListaKvadranta.Items.Clear();
            List<DTOKvadrant> kvadranti = DTOManager.vratiKvadranteIzGalaksije(this.PrenesenId);


            foreach (DTOKvadrant p in kvadranti)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.ProcenjeniPrecnik.ToString(), p.RedniBroj.ToString() });
                ListaKvadranta.Items.Add(item);

            }

            ListaKvadranta.Refresh();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            GalaksijeForma p = new GalaksijeForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KvadrantiDodajForma p = new KvadrantiDodajForma(PrenesenId);

            
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

            popuniPodacima();

        }
    }
}
