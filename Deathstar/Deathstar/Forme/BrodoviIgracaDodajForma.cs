using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Deathstar.Forme
{
    public partial class BrodoviIgracaDodajForma : Form
    {
        public DTOBrod brod;
        public int ProsledjenId;

        public BrodoviIgracaDodajForma()
        {
            InitializeComponent();
        }

        public BrodoviIgracaDodajForma(int ProseldjenId) 
        {
            InitializeComponent();
            this.brod = new DTOBrod();
            this.ProsledjenId = ProseldjenId;
        }

        private void BrodoviIgracaDodajForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            BrodoviIgracaForma p = new BrodoviIgracaForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi brod?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {


                this.brod.Naziv = txbNaziv.Text;
                this.brod.MaxWarp = Int32.Parse(txbMaxWarp.Text);
                this.brod.BrojLaserskihTopova = Int32.Parse(txbBrLaserskihTopova.Text);

                this.brod.FotonskaTorpeda = "NE";
                if (this.torpedaDA.Checked)
                    this.brod.FotonskaTorpeda = "DA";

                TipBrodaComboBox.SelectedIndex = 1;
                if (this.TipBrodaComboBox.SelectedIndex == 0)
                    this.brod.Tip = "KRSTARICA";
                if (this.TipBrodaComboBox.SelectedIndex == 1)
                    this.brod.Tip = "RAZARAC";
                if (this.TipBrodaComboBox.SelectedIndex == 2)
                    this.brod.Tip = "FREGATA";

                this.brod.ZastitnaOplata = "NE";
                if (this.oplataDA.Checked)
                    this.brod.ZastitnaOplata = "DA";

                this.brod.Nosivost = Int32.Parse(txbNosivost.Text);
                this.brod.VrstaBroda = "TRANSPORTNI";
                if (vrstaBorbeni.Checked)
                    this.brod.VrstaBroda = "BORBENI";

                this.brod.PlanetaId_NazivPlanete = txbIdPlanete.Text;
                this.brod.SavezId_NazivSaveza = "";
                this.brod.IgracId_KorisnickoIme = this.ProsledjenId.ToString();

                DTOManager.dodajBrodIgracu(this.brod);
                MessageBox.Show("Uspesno ste dodali novi brod!");
                this.Close();
            }
            
        }
        public void popuniPodacima() 
        {
            this.TipBrodaComboBox.SelectedIndex = 1;
        }
    }
}
