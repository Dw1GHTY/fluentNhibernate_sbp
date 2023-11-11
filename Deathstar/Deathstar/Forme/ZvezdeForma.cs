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
    public partial class ZvezdeForma : Form
    {
        public ZvezdeForma()
        {
            InitializeComponent();
        }

        private void ZvezdeForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            ListaZvezda.Items.Clear();
            List<DTOZvezda> zvezde = DTOManager.vratiSveZvezde();


            foreach (DTOZvezda p in zvezde)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Ime, p.Tip });
                ListaZvezda.Items.Add(item);

            }

            ListaZvezda.Refresh();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            GlavnaForma p = new GlavnaForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void btnZvezdeBlizuPlaneta_Click(object sender, EventArgs e)
        {
            ZvezdePlanetaBlizinaForma p = new ZvezdePlanetaBlizinaForma();


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ZvezdeDodajForma p = new ZvezdeDodajForma();


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

            popuniPodacima();

        }

        private void cmdAzuriraj_Click(object sender, EventArgs e)
        {

        }

        private void cmdBrisi_Click(object sender, EventArgs e)
        {
            if (ListaZvezda.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zvezdu koju zelite da obrisete!");
                return;
            }
            if (ListaZvezda.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednu zvezdu!");
                return;
            }

            int idZvezde = Int32.Parse(ListaZvezda.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabranu zvezdu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiZvezdu(idZvezde);
                MessageBox.Show("Brisanje zvezde je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }
    }
}
