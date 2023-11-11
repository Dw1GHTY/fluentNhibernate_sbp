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
    public partial class PrirodniSatelitiForma : Form
    {
        public int ProsledjenId;
        public PrirodniSatelitiForma()
        {
            
        }
        public PrirodniSatelitiForma(int ProsledjenId) 
        {
            InitializeComponent();
            this.ProsledjenId = ProsledjenId;
        }

        private void PrirodniSatelitiForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima() 
        {
            ListaPrirodnihSatelita.Items.Clear();
            List<DTOPrirodniSatelit> sateliti = DTOManager.vratiSatelitePlanete(this.ProsledjenId);


            foreach (DTOPrirodniSatelit p in sateliti)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Naziv, p.Precnik.ToString(), p.Naseobine, p.Udaljenost.ToString() });
                ListaPrirodnihSatelita.Items.Add(item);

            }

            ListaPrirodnihSatelita.Refresh();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            PlaneteForma p = new PlaneteForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            PrirodniSatelitiDodajForma p = new PrirodniSatelitiDodajForma(ProsledjenId);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

            popuniPodacima();

        }

        private void cmdBrisi_Click(object sender, EventArgs e)
        {
            if (ListaPrirodnihSatelita.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prirodan satelit koji zelite da obrisete!");
                return;
            }
            if (ListaPrirodnihSatelita.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jedan prirodni satelit!");
                return;
            }

            int idPrirSatelita = Int32.Parse(ListaPrirodnihSatelita.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabran prirodni satelit?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiPrirodniSatelit(idPrirSatelita);
                MessageBox.Show("Brisanje prirodnog satelita je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }
    }
}
