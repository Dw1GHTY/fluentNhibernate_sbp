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
    public partial class ProsirenjaSavezaDodajKolonizacijeForma : Form
    {
        public DTOKolonizacija kolonizacija;
        public int ProsledjenId;
        public ProsirenjaSavezaDodajKolonizacijeForma()
        {
            InitializeComponent();
        }
        public ProsirenjaSavezaDodajKolonizacijeForma(int ProsledjenId)
        {
            InitializeComponent();
            this.ProsledjenId  = ProsledjenId;
            kolonizacija = new DTOKolonizacija();
        }


        private void btnNazad_Click(object sender, EventArgs e)
        {
            ProsirenjaSaveza p = new ProsirenjaSaveza();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            
            string poruka = "Da li zelite da dodate novu kolonizaciju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {

                this.kolonizacija.Datum = dateDatum.Value;
                this.kolonizacija.PlanetaKolonizuje_ImePlanete = txbPlaneta.Text;

                this.kolonizacija.SavezVrsi_ImeSaveza = this.ProsledjenId.ToString();
                this.kolonizacija.IgracVrsi_ImeIgraca = "";

                DTOManager.dodajKolonizaciju(this.kolonizacija);
                MessageBox.Show("Uspesno ste dodali novu kolonizaciju!");
                this.Close();
            
            }
            
        }
    }
}
