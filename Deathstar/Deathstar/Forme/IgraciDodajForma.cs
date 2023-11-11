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
using Deathstar.Forme;

namespace Deathstar.Forme
{
    public partial class IgraciDodajForma : Form
    {
        DTOIgrac igrac;

        public IgraciDodajForma()
        {
            InitializeComponent();
            igrac = new DTOIgrac();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            IgraciForma p = new IgraciForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void IgraciDodajForma_Load(object sender, EventArgs e)
        {

        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog igraca?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.igrac.KorisnickoIme = txbKorisnickoIme.Text;
                this.igrac.DatumOtvaranjaNaloga = dateTimeDatumOtvaranjaNaloga.Value;
                this.igrac.LicnoIme = txbLicnoIme.Text;
                this.igrac.SrednjeSlovo = txbSrednjeSlovo.Text;
                this.igrac.Prezime = txbPrezime.Text;
                this.igrac.Email = txbEmail.Text;

                this.igrac.Pol = "M";
                if (radioZensko.Checked)
                    this.igrac.Pol = "Z";

                this.igrac.DatumRodjenja = dateTimeDatumRodjenja.Value;
                this.igrac.Drzava = txbDrzava.Text;
                this.igrac.TekstualniOpis = txbTekstualniOpis.Text;
                this.igrac.Slika = txbSlika.Text;
                this.igrac.SavezId_NazivSaveza = txbIdSaveza.Text;


                DTOManager.dodajIgraca(this.igrac);
                MessageBox.Show("Uspesno ste dodali novog igraca!");
                this.Close();

            }
            
            else
            {

            }
        }
    }
}
