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
    public partial class CivilnaStanicaDodajForma : Form
    {
        public DTOCivilnaStanica civilnastanica;
        public int PrenesenId;

        public CivilnaStanicaDodajForma(int prenesenId)
        {
            InitializeComponent();
            civilnastanica = new DTOCivilnaStanica();
            PrenesenId = prenesenId;
        }



        private void CivilnaStanicaDodajForma_Load(object sender, EventArgs e)
        {

        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu civilnu stanicu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {

                this.civilnastanica.Naziv = txbNaziv.Text;
                this.civilnastanica.BrojLjudi = Int32.Parse(txbBrLjudi.Text);
                this.civilnastanica.Velicina = Int32.Parse(txbVelicina.Text);
                this.civilnastanica.Udaljenost = Int32.Parse(txbUdaljenost.Text);

                this.civilnastanica.ZaTrgovinu = "NE";
                if (NamenaNaucna.Checked)
                    this.civilnastanica.ZaNaucnaIstrazivanja = "DA";

                this.civilnastanica.PlanetaId_ImePlanete = PrenesenId.ToString();


                DTOManager.dodajCivilnuStanicu(this.civilnastanica);
                MessageBox.Show("Uspesno ste dodali novu civilnu stanicu!");
                this.Close();
            }
        }
    }
}
