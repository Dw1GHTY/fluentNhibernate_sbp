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
    public partial class SpecPojaveForma : Form
    {
        public SpecPojaveForma()
        {
            InitializeComponent();
        }

        private void SpecPojaveForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima() 
        {
            ListaSpecPojava.Items.Clear();
            List<DTOSpecPojava> pojave = DTOManager.vratiSveSpecPojave();


            foreach (DTOSpecPojava p in pojave)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Naziv, p.Tip, p.PotOpasnost });
                ListaSpecPojava.Items.Add(item);

            }

            ListaSpecPojava.Refresh();
        }


        private void Nazad_Click(object sender, EventArgs e)
        {
            GlavnaForma p = new GlavnaForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void btnPojavePlanete_Click(object sender, EventArgs e)
        {
            if (ListaSpecPojava.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste izabrali nijednu pojavu");
                return;
            }
            if (ListaSpecPojava.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednu pojavu");
                return;
            }

            int idPojave = Int32.Parse(ListaSpecPojava.SelectedItems[0].SubItems[0].Text);

            SpecPojavaPlanetaBlizinaForma p = new SpecPojavaPlanetaBlizinaForma(idPojave);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            SpecPojaveDodajForma p = new SpecPojaveDodajForma();


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

            popuniPodacima();
        }

        private void cmdBrisi_Click(object sender, EventArgs e)
        {
            if (ListaSpecPojava.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite specijalnu pojavu koju zelite da obrisete!");
                return;
            }
            if (ListaSpecPojava.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednu specijalnu pojavu!");
                return;
            }

            int idPojave = Int32.Parse(ListaSpecPojava.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabranu pojavu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiPojavu(idPojave);
                MessageBox.Show("Brisanje specijalne pojave je uspesno obavljeno!");
                this.popuniPodacima();//OVDE TI JE GRESKA
            }
        }

        
    }
}
