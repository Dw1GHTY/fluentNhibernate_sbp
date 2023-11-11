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
    public partial class ZvezdaPlanetaBlizinaDodajForma : Form
    {
        public DTOZvezdaPlanetaBlizina blizina;

        public ZvezdaPlanetaBlizinaDodajForma()
        {
            InitializeComponent();
            blizina = new DTOZvezdaPlanetaBlizina();
        }

        private void ZvezdaPlanetaBlizinaDodajForma_Load(object sender, EventArgs e)
        {

        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu blizinu izmedju planete i zvezde?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {

                this.blizina.PlanetaId_ImePlanete = textBox1.Text;
                this.blizina.ZvezdaId_ImeZvezde = textBox2.Text;


                DTOManager.dodajZvezdaPlanetaBlizina(this.blizina);
                MessageBox.Show("Uspesno ste dodali novu blizinu!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
