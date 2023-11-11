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
    public partial class PrirodniSatelitiDodajForma : Form
    {
        DTOPrirodniSatelit prirsatelit;
        public int PrenesenId;

        public PrirodniSatelitiDodajForma(int PrenesenId)
        {
            InitializeComponent();
            prirsatelit = new DTOPrirodniSatelit();
            this.PrenesenId = PrenesenId;
        }

        private void PrirodniSatelitiDodajForma_Load(object sender, EventArgs e)
        {

        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi prirodni sateit?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {

                this.prirsatelit.Naziv = txbNaziv.Text;
                this.prirsatelit.Precnik = Int32.Parse(txbPrecnik.Text);

                this.prirsatelit.Naseobine = "NE";
                if (checkboxNaseobine.Checked)
                    this.prirsatelit.Naseobine = "DA";
                this.prirsatelit.Udaljenost = Int32.Parse(txbUdaljenost.Text);

                this.prirsatelit.PlanetaId_ImePlanete = PrenesenId.ToString();

                DTOManager.dodajPrirodniSatelit(this.prirsatelit);
                MessageBox.Show("Uspesno ste dodali novi prirodni satelit!");
                this.Close();
            }
        }
    }
}
