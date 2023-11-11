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
    public partial class VojnaStanicaDodajForma : Form
    {
        public DTOVojnaStanica vojnaStanica;
        public int PrenesenId;
        public VojnaStanicaDodajForma(int prenesenId)
        {
            InitializeComponent();
            vojnaStanica = new DTOVojnaStanica();
            PrenesenId = prenesenId;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void VojnaStanicaDodajForma_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu vojnu stanicu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.vojnaStanica.Naziv= txbNaziv.Text;
                this.vojnaStanica.BrojLjudi = Int32.Parse(txbBrojLjudi.Text);
                this.vojnaStanica.Velicina = Int32.Parse(txbVelicina.Text);
                this.vojnaStanica.Udaljenost = Int32.Parse(txbUdaljenost.Text);
                this.vojnaStanica.SpisakOruzja = txbOruzjeZaSpisak.Text;
                this.vojnaStanica.PlanetaId_ImePlanete = PrenesenId.ToString();


                DTOManager.dodajVojnuStanicu(this.vojnaStanica);
                MessageBox.Show("Uspesno ste dodali novu vojnu stanicu!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
