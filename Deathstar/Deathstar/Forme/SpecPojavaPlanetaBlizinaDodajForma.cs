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
    public partial class SpecPojavaPlanetaBlizinaDodajForma : Form
    {
        public DTOPlanetaPojavaBlizina planetapojavablizina;
        public int ProsledjenId;

        public SpecPojavaPlanetaBlizinaDodajForma(int prosledjenId)
        {
            InitializeComponent();
            planetapojavablizina = new DTOPlanetaPojavaBlizina();
            ProsledjenId = prosledjenId;
        }

        private void SpecPojavaPlanetaBlizinaDodajForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima() 
        {

        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu udaljenost izmedju planete i pojave?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.planetapojavablizina.PlanetaId_ImePlanete = txbIdPlanete.Text;
                this.planetapojavablizina.SpecPojavaId_ImePojave = this.ProsledjenId.ToString();
                this.planetapojavablizina.Udaljenost = Int32.Parse(txbUdaljenost.Text);


                DTOManager.dodajPojavaPlanetaBlizina(this.planetapojavablizina);
                MessageBox.Show("Uspesno ste dodali novu udaljenost!");
                this.Close();
            }
        }
    }
}
