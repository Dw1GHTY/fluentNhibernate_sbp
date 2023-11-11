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
    public partial class GalaksijeForma : Form
    {
        public GalaksijeForma()
        {
            InitializeComponent();
        }

        private void GalaksijeForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            ListaGalaksija.Items.Clear();
            List<DTOGalaksija> galaksije = DTOManager.vratiSveGalaksije();


            foreach (DTOGalaksija p in galaksije)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Ime, p.DominantnaRasa, p.ProcenjeniBrojPlaneta.ToString(),
                                                                    p.ProcenjeniBrojZvezda.ToString()});
                ListaGalaksija.Items.Add(item);

            }

            ListaGalaksija.Refresh();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            GlavnaForma p = new GlavnaForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void btnKvadranti_Click(object sender, EventArgs e)
        {
            if (ListaGalaksija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste izabrali nijednu galaksiju");
                return;
            }
            if (ListaGalaksija.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednu galaksiju");
                return;
            }

            int idKvadranta = Int32.Parse(ListaGalaksija.SelectedItems[0].SubItems[0].Text);

            KvadrantiForma p = new KvadrantiForma(idKvadranta);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            GalaksijeDodajForma p = new GalaksijeDodajForma();


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

            popuniPodacima();

        }

        private void cmdAzuriraj_Click(object sender, EventArgs e)
        {
            if (ListaGalaksija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite jednu galaksiju");
                return;
            }
            if (ListaGalaksija.SelectedItems.Count > 1)
            {
                MessageBox.Show("Izaberite samo jednou galaksiju");
                return;
            }

            int idGalaksije = Int32.Parse(ListaGalaksija.SelectedItems[0].SubItems[0].Text);
            DTOGalaksija ob = DTOManager.vratiGalaksiju(idGalaksije);

            GalaksijeAzurirajForma formaUpdate = new GalaksijeAzurirajForma(ob);
            formaUpdate.ShowDialog();
            this.popuniPodacima();

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdBrisi_Click(object sender, EventArgs e)
        {
            if (ListaGalaksija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite galaksiju koju zelite da obrisete!");
                return;
            }
            if (ListaGalaksija.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednu galaksiju!");
                return;
            }

            int idGalaksije = Int32.Parse(ListaGalaksija.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabranu galaksiju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiGalaksiju(idGalaksije);
                MessageBox.Show("Brisanje galaksije je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }

        private void btnPlanete_Click(object sender, EventArgs e)
        {
            if (ListaGalaksija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste izabrali nijednu galaksiju");
                return;
            }
            if (ListaGalaksija.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednu galaksiju");
                return;
            }

            int idGalaksije = Int32.Parse(ListaGalaksija.SelectedItems[0].SubItems[0].Text);
            GalaksijaPlaneteForma forma = new GalaksijaPlaneteForma(idGalaksije);
            forma.ShowDialog();

        }
    }
}
