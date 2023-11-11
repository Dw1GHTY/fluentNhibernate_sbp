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
    public partial class GalaksijeDodajForma : Form
    {
        DTOGalaksija galaksija;

        public GalaksijeDodajForma()
        {
            InitializeComponent();
            galaksija = new DTOGalaksija();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            GalaksijeForma p = new GalaksijeForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void GalaksijeDodajForma_Load(object sender, EventArgs e)
        {

        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu galaksiju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {

                this.galaksija.Ime = txbIme.Text;
                this.galaksija.DominantnaRasa = txbDominantnaRasa.Text;
                this.galaksija.ProcenjeniBrojPlaneta = Int32.Parse(txbBrPlaneta.Text);
                this.galaksija.ProcenjeniBrojZvezda = Int32.Parse(txbBrZvezda.Text);


                DTOManager.dodajGalaksiju(this.galaksija);
                MessageBox.Show("Uspesno ste dodali novu galaksiju!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
