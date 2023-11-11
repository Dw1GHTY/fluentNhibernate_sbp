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
    public partial class VojneStaniceForma : Form
    {
        public int PrenesenId;
        public VojneStaniceForma()
        {
            InitializeComponent();
        }

        public VojneStaniceForma(int PrenesenId) 
        {
            InitializeComponent();
            this.PrenesenId = PrenesenId;
        }
        private void VojneStaniceForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima() 
        {
            ListaVojnihStanica.Items.Clear();
            List<DTOVojnaStanica> vojneStanice = DTOManager.vratiVojneStanicePlanete(this.PrenesenId);


            foreach (DTOVojnaStanica p in vojneStanice)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Naziv, p.BrojLjudi.ToString(), p.Velicina.ToString(),
                                                                    p.Udaljenost.ToString(), p.SpisakOruzja });
                ListaVojnihStanica.Items.Add(item);

            }

            ListaVojnihStanica.Refresh();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            PlaneteForma p = new PlaneteForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void cmdBrisi_Click(object sender, EventArgs e)
        {
            if (ListaVojnihStanica.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vojnu stanicu koju zelite da obrisete!");
                return;
            }
            if (ListaVojnihStanica.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednu vojnu stanicu!");
                return;
            }

            int idVojStanice = Int32.Parse(ListaVojnihStanica.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabranu vojnu stanicu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiVojnuStanicu(idVojStanice);
                MessageBox.Show("Brisanje vojne stanice je uspesno obavljeno!");
                this.popuniPodacima();
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            VojnaStanicaDodajForma p = new VojnaStanicaDodajForma(PrenesenId);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

            popuniPodacima();

        }

        
    }
}
