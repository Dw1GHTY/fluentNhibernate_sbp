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
    public partial class CivilneStaniceForma : Form
    {
        public int PrenesenId;
        public CivilneStaniceForma()
        {
            InitializeComponent();
        }

        public CivilneStaniceForma(int PrenesenId) 
        {
            InitializeComponent();
            this.PrenesenId = PrenesenId;
        }
        private void CivilneStaniceForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima() 
        {
            ListaCivilnihStanica.Items.Clear();
            List<DTOCivilnaStanica> civilneStanice = DTOManager.vratiCivilneStanicePlanete(this.PrenesenId);


            foreach (DTOCivilnaStanica p in civilneStanice)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Naziv, p.BrojLjudi.ToString(),
                                                                    p.Velicina.ToString(), p.Udaljenost.ToString(), 
                                                                    p.ZaTrgovinu, p.ZaNaucnaIstrazivanja });
                ListaCivilnihStanica.Items.Add(item);

            }

            ListaCivilnihStanica.Refresh();
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
            if (ListaCivilnihStanica.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vojnu stanicu koju zelite da obrisete!");
                return;
            }
            if (ListaCivilnihStanica.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednu vojnu stanicu!");
                return;
            }

            int idCivStanice = Int32.Parse(ListaCivilnihStanica.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabranu civilnu stanicu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiCivilnuStanicu(idCivStanice);
                MessageBox.Show("Brisanje civilne stanice je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            CivilnaStanicaDodajForma p = new CivilnaStanicaDodajForma(PrenesenId);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

            popuniPodacima();

        }

        
    }
}
