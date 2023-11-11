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
    public partial class BrodoviPlaneteForma : Form
    {
        public int ProsledjenId;
        public BrodoviPlaneteForma()
        {
            InitializeComponent();
        }

        public BrodoviPlaneteForma(int ProsledjenId) 
        {
            InitializeComponent();
            this.ProsledjenId = ProsledjenId;
        }


        private void BrodoviPlaneteForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            ListaBrodovaPlanete.Items.Clear();
            List<DTOBrod> brodovi = DTOManager.vratiBrodovePlanete(this.ProsledjenId);


            foreach (DTOBrod p in brodovi)
            {

                ListViewItem item = new ListViewItem(new string[] {p.JedinstveniBroj.ToString(), p.Naziv, p.MaxWarp.ToString(), 
                                                                   p.BrojLaserskihTopova.ToString(), p.FotonskaTorpeda, p.Tip,
                                                                   p.ZastitnaOplata, p.Nosivost.ToString(), p.VrstaBroda, 
                                                                   p.IgracId_KorisnickoIme, p.SavezId_NazivSaveza});
                ListaBrodovaPlanete.Items.Add(item);

            }

            ListaBrodovaPlanete.Refresh();
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
            BrodoviPlaneteDodajForma p = new BrodoviPlaneteDodajForma(ProsledjenId);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

            popuniPodacima();

        }

        private void cmdBrisi_Click(object sender, EventArgs e)
        {
            if (ListaBrodovaPlanete.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite brod koji zelite da obrisete!");
                return;
            }
            if (ListaBrodovaPlanete.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jedan brod!");
                return;
            }

            int idBroda = Int32.Parse(ListaBrodovaPlanete.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabran brod?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiBrodPlanete(idBroda);
                MessageBox.Show("Brisanje broda je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }
    }
}
