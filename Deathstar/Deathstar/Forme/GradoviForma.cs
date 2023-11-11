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
    public partial class GradoviForma : Form
    {
        public int ProsledjenId;
        public GradoviForma()
        {
            InitializeComponent();
        }
        public GradoviForma(int ProsledjenId) 
        {
            InitializeComponent();
            this.ProsledjenId = ProsledjenId;
        }

        private void GradoviForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima() 
        {
            ListaGradova.Items.Clear();
            List<DTOGrad> gradovi = DTOManager.vratiGradovePlanete(this.ProsledjenId);


            foreach (DTOGrad p in gradovi)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Naziv, p.Glavni });
                ListaGradova.Items.Add(item);

            }

            ListaGradova.Refresh();
        }
 
        private void btnDodaj_Click(object sender, EventArgs e)
        {

            GradoviDodajForma p = new GradoviDodajForma(ProsledjenId);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

            popuniPodacima();

        }

        private void cmdBrisi_Click(object sender, EventArgs e)
        {
            if (ListaGradova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite grad koju zelite da obrisete!");
                return;
            }
            if (ListaGradova.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jedan grad!");
                return;
            }

            int idGrada = Int32.Parse(ListaGradova.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabran grad?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiGrad(idGrada);
                MessageBox.Show("Brisanje grada je uspesno obavljeno!");
                this.popuniPodacima();
            }


        }    
    }
}
