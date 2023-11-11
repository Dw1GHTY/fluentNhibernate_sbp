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
    public partial class SpecPojavaPlanetaBlizinaForma : Form
    {
        public int ProsledjeniId;
        public SpecPojavaPlanetaBlizinaForma()
        {
            InitializeComponent();
        }
        public SpecPojavaPlanetaBlizinaForma(int ProsledjeniId) 
        {
            InitializeComponent();
            this.ProsledjeniId = ProsledjeniId;
        }


        private void SpecPojavaPlanetaBlizinaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima() 
        {
            ListaPojavaPlanetaBlizina.Items.Clear();
            List<DTOPlanetaPojavaBlizina> planetePojaveBlizine = DTOManager.vratiPlanetePojaveBlizine(this.ProsledjeniId);


            foreach (DTOPlanetaPojavaBlizina p in planetePojaveBlizine)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.PlanetaId_ImePlanete, p.Udaljenost.ToString(),});
                ListaPojavaPlanetaBlizina.Items.Add(item);

            }

            ListaPojavaPlanetaBlizina.Refresh();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            SpecPojaveForma p = new SpecPojaveForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            SpecPojavaPlanetaBlizinaDodajForma p = new SpecPojavaPlanetaBlizinaDodajForma(this.ProsledjeniId);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

            popuniPodacima();
        }



        private void cmdBrisi_Click(object sender, EventArgs e)
        {
            if (ListaPojavaPlanetaBlizina.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite pojavu blizu planete koju zelite da obrisete!");
                return;
            }
            if (ListaPojavaPlanetaBlizina.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednu pojavu blizu planete!");
                return;
            }

            int idBlizina = Int32.Parse(ListaPojavaPlanetaBlizina.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabranu pojavu blizu planete?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiPlanetaPojavaBlizina(idBlizina);
                MessageBox.Show("Brisanje pojave blizu planete je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }

        
    }
}
