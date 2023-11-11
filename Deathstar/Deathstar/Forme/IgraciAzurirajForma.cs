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
    public partial class IgraciAzurirajForma : Form
    {
        public DTOIgrac igrac;
        public IgraciAzurirajForma()
        {
            InitializeComponent();

        }
        public IgraciAzurirajForma(DTOIgrac igrac)
        {
            InitializeComponent();
            this.igrac = igrac; 
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            IgraciForma p = new IgraciForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void IgraciAzurirajForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima() 
        {
            txbKorisnickoIme.Text = this.igrac.KorisnickoIme;
            dateTimeDatumOtvaranjaNaloga.Value = this.igrac.DatumOtvaranjaNaloga;
            txbLicnoIme.Text = this.igrac.LicnoIme;
            txbSrednjeSlovo.Text = this.igrac.SrednjeSlovo;
            txbPrezime.Text = this.igrac.Prezime;
            txbEmail.Text = this.igrac.Email;

            radioMusko.Checked = true;
            if(this.igrac.Pol == "Z")
                radioZensko.Checked = true;

            dateTimeDatumRodjenja.Value = this.igrac.DatumRodjenja;
            txbDrzava.Text = this.igrac.Drzava;
            txbTekstualniOpis.Text = this.igrac.TekstualniOpis;
            txbIdSaveza.Text = this.igrac.SavezId_NazivSaveza;

        }

        private void cmdAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmenu igraca?";
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
                this.igrac.SavezId_NazivSaveza = txbIdSaveza.Text;

                if (DTOManager.azurirajIgraca(this.igrac) == 0)
                    MessageBox.Show("Azuriranje igraca je uspesno izvrseno!");
                this.Close();

            }
        }
    }   
}
