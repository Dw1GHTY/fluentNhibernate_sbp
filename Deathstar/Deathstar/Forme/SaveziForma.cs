using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deathstar;

namespace Deathstar.Forme
{
    public partial class SaveziForma : Form
    {
        public SaveziForma()
        {
            InitializeComponent();
        }

        private void SaveziForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima() 
        {
            ListaSaveza.Items.Clear();
            List<DTOSavez> savezi = DTOManager.vratiSveSaveze();


            foreach (DTOSavez p in savezi)
            {              

                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Naziv, p.DatumFormiranja.ToString(), p.SavezId_Naziv});
                ListaSaveza.Items.Add(item);

            }

            ListaSaveza.Refresh();
        }

        private void ListaSaveza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajSavez_Click(object sender, EventArgs e)
        {
            SaveziDodajForma p = new SaveziDodajForma();


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

            popuniPodacima();

        }

        private void btnAzurirajSavez_Click(object sender, EventArgs e)
        {
            if (ListaSaveza.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite jedan savez");
                return;
            }
            if (ListaSaveza.SelectedItems.Count > 1)
            {
                MessageBox.Show("Izaberite samo jedan savez");
                return;
            }

            int idSaveza = Int32.Parse(ListaSaveza.SelectedItems[0].SubItems[0].Text);
            DTOSavez ob = DTOManager.vratiSavez(idSaveza);

            SaveziAzurirajForma formaUpdate = new SaveziAzurirajForma(ob);
            formaUpdate.ShowDialog();

            Cursor.Current = Cursors.WaitCursor;
            //p.ShowDialog();
            this.popuniPodacima();

        }

        private void cmdObrisiSavez_Click(object sender, EventArgs e)
        {
            if (ListaSaveza.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite savez koji zelite da obrisete!");
                return;
            }
            if (ListaSaveza.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jedan savez!");
                return;
            }

            int idSaveza = Int32.Parse(ListaSaveza.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabran savez?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiSavez(idSaveza);
                MessageBox.Show("Brisanje saveza je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }

        private void btnSaveziNazad_Click(object sender, EventArgs e)
        {
            GlavnaForma p = new GlavnaForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void cmdBrodovi_Click(object sender, EventArgs e)
        {
            if (ListaSaveza.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste izabrali nijedan savez");
                return;
            }
            if (ListaSaveza.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jedan savez");
                return;
            }

            int idSaveza = Int32.Parse(ListaSaveza.SelectedItems[0].SubItems[0].Text);
            BrodoviSavezaForma p = new BrodoviSavezaForma(idSaveza);

            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

        }

        private void btnProsirenjaSaveza_Click(object sender, EventArgs e)
        {
            if (ListaSaveza.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste izabrali nijedan savez");
                return;
            }
            if (ListaSaveza.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jedan savez");
                return;
            }

            int idSaveza = Int32.Parse(ListaSaveza.SelectedItems[0].SubItems[0].Text);

            ProsirenjaSaveza p = new ProsirenjaSaveza(idSaveza);

            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

        }
    }
}
