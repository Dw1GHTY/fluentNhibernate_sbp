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
    public partial class PlaneteAzurirajForma : Form
    {
        DTOPlaneta planeta;


        public PlaneteAzurirajForma()
        {
            InitializeComponent();
        }
        public PlaneteAzurirajForma(DTOPlaneta planeta) 
        {
            InitializeComponent();
            this.planeta = planeta;
        }


        private void PlaneteAzurirajForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima() 
        {
            txbNaziv.Text = this.planeta.Naziv;
            txbBrojStanovnika.Text = this.planeta.BrojStanovnika.ToString();
            txbDominantnaRasa.Text = this.planeta.DominantnaRasa;
            txbDrustvenoUredjenje.Text = this.planeta.DrustvenoUredjenje;
            txbTrilijum.Text = this.planeta.Trilijum.ToString();
            txbBerilijum.Text = this.planeta.Berilijum.ToString();
            txbPlutonijum.Text = this.planeta.Plutonijum.ToString();
            txbX.Text = this.planeta.x.ToString();
            txbY.Text = this.planeta.y.ToString();
            txbZ.Text = this.planeta.z.ToString();
        }

        private void cmdSacuvaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmenu planete?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.planeta.Naziv = txbNaziv.Text;
                this.planeta.BrojStanovnika = Int32.Parse(txbBrojStanovnika.Text);
                this.planeta.DominantnaRasa = txbDominantnaRasa.Text;
                this.planeta.DrustvenoUredjenje = txbDrustvenoUredjenje.Text;
                this.planeta.Trilijum = Int32.Parse(txbTrilijum.Text);
                this.planeta.Berilijum = Int32.Parse(txbBerilijum.Text);
                this.planeta.Plutonijum = Int32.Parse(txbPlutonijum.Text);
                this.planeta.x = Int32.Parse(txbX.Text);
                this.planeta.y = Int32.Parse(txbY.Text);
                this.planeta.z = Int32.Parse(txbZ.Text);

                this.planeta.Maticna = "NE";
                if (checkboxMaticna.Checked)
                    this.planeta.Maticna = "DA";

                this.planeta.IgracId_KorisnickoIme = txbIgracId.Text;
                this.planeta.GalaksijaId_Ime = txbGalaksijaId.Text;

                if (DTOManager.azurirajPlanetu(this.planeta) == 0)
                    MessageBox.Show("Azuriranje planete je uspesno izvrseno!");
                this.Close();

            }
        }
    }
}
