using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deathstar.Forme;

namespace Deathstar.Forme
{
    public partial class BrodoviIgracaForma : Form
    {
        public int ProsledjeniId;

        public BrodoviIgracaForma(int id) 
        {
            InitializeComponent();
            this.ProsledjeniId = id;
        }

        public BrodoviIgracaForma()
        {
            InitializeComponent();
        }

        private void BrodoviIgracaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
  
        public void popuniPodacima() 
        {

            ListaBrodovaIgraca.Items.Clear();

            List<DTOBrod> brodovi = DTOManager.vratiSveBrodoveZaIgraca(this.ProsledjeniId);


            foreach (DTOBrod p in brodovi)
            {

                ListViewItem item = new ListViewItem(new string[] { p.JedinstveniBroj.ToString(), p.Naziv, p.MaxWarp.ToString(),
                                                                    p.BrojLaserskihTopova.ToString(), p.FotonskaTorpeda,
                                                                    p.Tip, p.ZastitnaOplata, p.Nosivost.ToString(),
                                                                    p.VrstaBroda, p.PlanetaId_NazivPlanete});
                ListaBrodovaIgraca.Items.Add(item);

            }

            ListaBrodovaIgraca.Refresh();
        }


        private void Nazad_Click(object sender, EventArgs e)
        {
            IgraciForma p = new IgraciForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {

            BrodoviIgracaDodajForma p = new BrodoviIgracaDodajForma(this.ProsledjeniId);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

            popuniPodacima();

        }

        private void cmdAzuriraj_Click(object sender, EventArgs e)
        {
            if (ListaBrodovaIgraca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite jedan brod");
                return;
            }
            if (ListaBrodovaIgraca.SelectedItems.Count > 1)
            {
                MessageBox.Show("Izaberite samo jedan brod");
                return;
            }

            int idBroda = Int32.Parse(ListaBrodovaIgraca.SelectedItems[0].SubItems[0].Text);
            DTOBrod ob = DTOManager.vratiBrod(idBroda);

            BrodoviIgracaAzurirajForma formaUpdate = new BrodoviIgracaAzurirajForma(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();         

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdBrisi_Click(object sender, EventArgs e)
        {
            if (ListaBrodovaIgraca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite brod koji zelite da obrisete!");
                return;
            }
            if (ListaBrodovaIgraca.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jedan brod!");
                return;
            }

            int idBroda = Int32.Parse(ListaBrodovaIgraca.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabran brod?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiBrodoveIgraca(idBroda);
                MessageBox.Show("Brisanje broda je uspesno obavljeno!");
                this.popuniPodacima();
            }


        }
    }
}
