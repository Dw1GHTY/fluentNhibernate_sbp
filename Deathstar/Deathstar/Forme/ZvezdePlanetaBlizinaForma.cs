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
    public partial class ZvezdePlanetaBlizinaForma : Form
    {
        public ZvezdePlanetaBlizinaForma()
        {
            InitializeComponent();
        }

        private void ZvezdePlanetaBlizinaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima() 
        {
            ListaZvezdaPlanetaBlizina.Items.Clear();
            List<DTOZvezdaPlanetaBlizina> ZPBovi = DTOManager.vratiSveZPB();


            foreach (DTOZvezdaPlanetaBlizina p in ZPBovi)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.PlanetaId_ImePlanete, p.ZvezdaId_ImeZvezde });
                ListaZvezdaPlanetaBlizina.Items.Add(item);

            }

            ListaZvezdaPlanetaBlizina.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ZvezdaPlanetaBlizinaDodajForma p = new ZvezdaPlanetaBlizinaDodajForma();


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

            popuniPodacima();
        }

       
        private void cmdBrisi_Click(object sender, EventArgs e)
        {
            if (ListaZvezdaPlanetaBlizina.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite blizinu koju zelite da obrisete!");
                return;
            }
            if (ListaZvezdaPlanetaBlizina.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednu blizinu!");
                return;
            }

            int idBlizine = Int32.Parse(ListaZvezdaPlanetaBlizina.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabranu blizinu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiZvezdaPlanetaBlizina(idBlizine);
                MessageBox.Show("Brisanje blizine je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }
    }
}
