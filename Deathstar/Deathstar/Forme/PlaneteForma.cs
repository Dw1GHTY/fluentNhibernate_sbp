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
    public partial class PlaneteForma : Form
    {
        public PlaneteForma()
        {
            InitializeComponent();
        }
        private void PlaneteForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            ListaPlaneta.Items.Clear();
            List<DTOPlaneta> planete = DTOManager.vratiSvePlanete();

            foreach (DTOPlaneta p in planete)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Naziv, p.BrojStanovnika.ToString(), p.DominantnaRasa, p.DrustvenoUredjenje,
                                                                    p.Trilijum.ToString(), p.Berilijum.ToString(), p.Plutonijum.ToString(),
                                                                    p.x.ToString(), p.y.ToString(), p.z.ToString(), p.Maticna, p.IgracId_KorisnickoIme, p.GalaksijaId_Ime});
                ListaPlaneta.Items.Add(item);

            }

            ListaPlaneta.Refresh();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            GlavnaForma p = new GlavnaForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void btnGradovi_Click(object sender, EventArgs e)
        {
            if (ListaPlaneta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste izabrali nijednu planetu");
                return;
            }
            if (ListaPlaneta.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednu planetu");
                return;
            }

            int idGrada = Int32.Parse(ListaPlaneta.SelectedItems[0].SubItems[0].Text);

            GradoviForma p = new GradoviForma(idGrada);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

        }

        private void btnBrodovi_Click(object sender, EventArgs e)
        {
            if (ListaPlaneta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste izabrali nijednu planetu");
                return;
            }
            if (ListaPlaneta.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednu planetu");
                return;
            }

            int idBroda = Int32.Parse(ListaPlaneta.SelectedItems[0].SubItems[0].Text);

            BrodoviPlaneteForma p = new BrodoviPlaneteForma(idBroda);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

        }

        private void btnPrirodniSateliti_Click(object sender, EventArgs e)
        {
            if (ListaPlaneta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste izabrali nijednu planetu");
                return;
            }
            if (ListaPlaneta.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednu planetu");
                return;
            }

            int idSatelita = Int32.Parse(ListaPlaneta.SelectedItems[0].SubItems[0].Text);

            PrirodniSatelitiForma p = new PrirodniSatelitiForma(idSatelita);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

        }

        private void btnVojneStanice_Click(object sender, EventArgs e)
        {
            if (ListaPlaneta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste izabrali nijednu planetu");
                return;
            }
            if (ListaPlaneta.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednu planetu");
                return;
            }

            int idStanice = Int32.Parse(ListaPlaneta.SelectedItems[0].SubItems[0].Text);

            VojneStaniceForma p = new VojneStaniceForma(idStanice);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

        }

        private void btnCivilneStanice_Click(object sender, EventArgs e)
        {
            if (ListaPlaneta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste izabrali nijednu planetu");
                return;
            }
            if (ListaPlaneta.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednu planetu");
                return;
            }

            int idStanice = Int32.Parse(ListaPlaneta.SelectedItems[0].SubItems[0].Text);

            CivilneStaniceForma p = new CivilneStaniceForma(idStanice);


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            PlaneteDodajForma p = new PlaneteDodajForma();


            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();

            this.popuniPodacima();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (ListaPlaneta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite jednu planetu");
                return;
            }
            if (ListaPlaneta.SelectedItems.Count > 1)
            {
                MessageBox.Show("Izaberite samo jednu planetu");
                return;
            }

            int idPlanete = Int32.Parse(ListaPlaneta.SelectedItems[0].SubItems[0].Text);
            DTOPlaneta ob = DTOManager.vratiPlanetu(idPlanete);

            PlaneteAzurirajForma formaUpdate = new PlaneteAzurirajForma(ob);
            formaUpdate.ShowDialog();
            this.popuniPodacima();

        }

        private void cmdObrisi_Click(object sender, EventArgs e)
        {
            if (ListaPlaneta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite planetu koju zelite da obrisete!");
                return;
            }
            if (ListaPlaneta.SelectedItems.Count > 1)
            {
                MessageBox.Show("Morate da izaberete samo jednu planetu!");
                return;
            }

            int idPlanete = Int32.Parse(ListaPlaneta.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabranu planetu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiPlanetu(idPlanete);
                MessageBox.Show("Brisanje planete je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }
    }
}
