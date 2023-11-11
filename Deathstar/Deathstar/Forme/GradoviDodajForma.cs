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
    public partial class GradoviDodajForma : Form
    {
        public DTOGrad grad;
        public int ProsledjenId;

        public GradoviDodajForma(int prosledjenId)
        {
            InitializeComponent();
            grad = new DTOGrad();
            ProsledjenId = prosledjenId;
        }

        private void GradoviDodajForma_Load(object sender, EventArgs e)
        {

        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi grad planeti?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {

                this.grad.Naziv = txbNaziv.Text;

                this.grad.Glavni = "NE";
                if (checkboxGlavni.Checked)
                    this.grad.Glavni = "DA";

                this.grad.PlanetaId_ImePlanete = this.ProsledjenId.ToString();

                DTOManager.dodajGradPlaneti(this.grad);
                MessageBox.Show("Uspesno ste dodali novi grad!");
                this.Close();
            }
        }
    }
}
