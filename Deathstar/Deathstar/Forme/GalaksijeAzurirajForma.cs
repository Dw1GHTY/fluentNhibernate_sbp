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
    public partial class GalaksijeAzurirajForma : Form
    {
        public DTOGalaksija galaksija;

        public GalaksijeAzurirajForma()
        {
            InitializeComponent();
        }
        public GalaksijeAzurirajForma(DTOGalaksija galaksija)
        {
            InitializeComponent();
            this.galaksija = galaksija;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            GalaksijeForma p = new GalaksijeForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void GalaksijeAzurirajForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima() 
        {
            txbIme.Text = this.galaksija.Ime;
            txbDominantnaRasa.Text = this.galaksija.DominantnaRasa;
            txbBrPlaneta.Text = this.galaksija.ProcenjeniBrojPlaneta.ToString();
            txbBrZvezda.Text = this.galaksija.ProcenjeniBrojZvezda.ToString();
        }

        private void cmdAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmenu galaksije?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {

                this.galaksija.Ime = txbIme.Text;
                this.galaksija.DominantnaRasa = txbDominantnaRasa.Text;
                this.galaksija.ProcenjeniBrojPlaneta = Int32.Parse(txbBrPlaneta.Text);
                this.galaksija.ProcenjeniBrojZvezda = Int32.Parse(txbBrZvezda.Text);


                if (DTOManager.azurirajGalaksiju(this.galaksija) == 0)
                    MessageBox.Show("Azuriranje galaksije je uspesno izvrseno!");
                this.Close();
            }
        }
    }
}
