using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Deathstar.Forme
{
    public partial class PlaneteDodajForma : Form
    {
        public DTOPlaneta planeta;

        public PlaneteDodajForma()
        {
            InitializeComponent();
            planeta = new DTOPlaneta();
        }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlaneteDodajForma_Load(object sender, EventArgs e)
        {

        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu planetu?";
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

                this.planeta.IgracId_KorisnickoIme = txbIdGalaksije.Text;
                this.planeta.GalaksijaId_Ime = txbIdIgraca.Text;

                DTOManager.dodajPlanetu(this.planeta);
                MessageBox.Show("Uspesno ste dodali novu planetu!");
                this.Close();
            }
        }
    }
}
