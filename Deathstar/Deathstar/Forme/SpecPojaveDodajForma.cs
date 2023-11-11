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
    public partial class SpecPojaveDodajForma : Form
    {
        public DTOSpecPojava specpojava;

        public SpecPojaveDodajForma()
        {
            InitializeComponent();
            specpojava = new DTOSpecPojava();
        }

        private void SpecPojaveDodajForma_Load(object sender, EventArgs e)
        {

        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu spec pojavu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.specpojava.Naziv = txbNazivSpecPojave.Text;
                this.specpojava.Tip = txbTipSpecPojave.Text;
                this.specpojava.PotOpasnost = txbPotOpasnostSpecPojave.Text;


                DTOManager.dodajSpecPojavu(this.specpojava);
                MessageBox.Show("Uspesno ste dodali novu specijalnu pojavu!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
