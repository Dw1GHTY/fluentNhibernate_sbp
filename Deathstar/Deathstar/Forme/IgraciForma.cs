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
    public partial class IgraciForma : Form
    {
        public IgraciForma()
        {
            InitializeComponent();
        }

        private void IgraciForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }


        public void popuniPodacima()
        {
            ListaIgraca.Items.Clear();
            List<DTOIgrac> igraci = DTOManager.vratiSveIgrace();


            foreach (DTOIgrac p in igraci)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.KorisnickoIme, p.DatumOtvaranjaNaloga.ToString(), p.LicnoIme, p.SrednjeSlovo, p.Prezime, p.Email,
                                                         p.Pol, p.DatumRodjenja.ToString(), p.Drzava, p.TekstualniOpis, p.Slika, p.SavezId_NazivSaveza});
                ListaIgraca.Items.Add(item);

            }

            ListaIgraca.Refresh();
        }


        private void Nazad_Click(object sender, EventArgs e)
        {
            GlavnaForma p = new GlavnaForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void cmdBrodovi_Click(object sender, EventArgs e)
        {
            BrodoviIgracaForma p = new BrodoviIgracaForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            IgraciDodajForma p = new IgraciDodajForma();


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            popuniPodacima();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (ListaIgraca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite jednog igraca");
                return;
            }
            if (ListaIgraca.SelectedItems.Count > 1)
            {
                MessageBox.Show("Izaberite samo jednog igraca");
                return;
            }

            int idIgraca = Int32.Parse(ListaIgraca.SelectedItems[0].SubItems[0].Text);
            DTOIgrac ob = DTOManager.vratiIgraca(idIgraca);

            IgraciAzurirajForma formaUpdate = new IgraciAzurirajForma(ob);
            formaUpdate.ShowDialog();
            this.popuniPodacima();

        }

        private void cmdBrisi_Click(object sender, EventArgs e)
        {
            if (ListaIgraca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite igraca koga zelite da obrisete!");
                return;
            }
            if (ListaIgraca.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednog igraca");
                return;
            }

            int idProdavnice = Int32.Parse(ListaIgraca.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabranog igraca?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiIgraca(idProdavnice);
                MessageBox.Show("Brisanje prodavnice je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }

        public void cmdBrodovi_Click_1(object sender, EventArgs e)
        {
            if (ListaIgraca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste izabrali nijednog igrača");
                return;
            }
            if (ListaIgraca.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednog igrača");
                return;
            }

            int idIgraca = Int32.Parse(ListaIgraca.SelectedItems[0].SubItems[0].Text);

            BrodoviIgracaForma p = new BrodoviIgracaForma(idIgraca);
           
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
           
        }

        private void btnProsirenjaIgraca_Click(object sender, EventArgs e)
        {
            if (ListaIgraca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste izabrali nijednog igraca");
                return;
            }
            if (ListaIgraca.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednog igraca");
                return;
            }

            int idIgraca = Int32.Parse(ListaIgraca.SelectedItems[0].SubItems[0].Text);

            ProsirenjaIgraca p = new ProsirenjaIgraca(idIgraca);

            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
        }
    }
}
