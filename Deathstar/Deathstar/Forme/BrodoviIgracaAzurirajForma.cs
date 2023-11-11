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
    public partial class BrodoviIgracaAzurirajForma : Form
    {
        public DTOBrod brod;
        public BrodoviIgracaAzurirajForma()
        {
            InitializeComponent();
        }

        public BrodoviIgracaAzurirajForma(DTOBrod brod)
        {
            InitializeComponent();
            this.brod = brod;
        }

        private void BrodoviIgracaAzurirajForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            this.txbNaziv.Text = this.brod.Naziv;
            this.txbMaxWarp.Text = this.brod.MaxWarp.ToString();
            this.txbBrLaserskihTopova.Text = this.brod.BrojLaserskihTopova.ToString();

            //tropeda
            this.torpedaNE.Checked = true;
            if (this.brod.FotonskaTorpeda == "DA")
                this.torpedaDA.Checked = true;

            //tip broda
            this.comboBoxTip.SelectedIndex = 0;
            if (this.brod.Tip == "KRSTARICA")
                this.comboBoxTip.SelectedIndex = 0;
            if (this.brod.Tip == "RAZARAC")
                this.comboBoxTip.SelectedIndex = 1;
            if (this.brod.Tip == "FREGATA")
                this.comboBoxTip.SelectedIndex = 2;

            //oplata
            this.oplataNE.Checked = true;
            if (this.brod.ZastitnaOplata == "DA")
                this.oplataDA.Checked = true;

            this.txbNosivost.Text = this.brod.Nosivost.ToString();

            //vrsta broda
            this.vrstaBorbeni.Checked = true;
            if (this.brod.VrstaBroda == "TRANSPORTNI")
                this.vrstaTransportni.Checked = true;
            if (this.brod.VrstaBroda == "BORBENI")
                this.vrstaBorbeni.Checked = true;
            
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            BrodoviIgracaForma p = new BrodoviIgracaForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void torpedaDA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void torpedaNE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmdSacuvaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene broda?";
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

                this.brod.Tip = comboBoxTip.SelectedItem.ToString();

                this.brod.ZastitnaOplata = "NE";
                if (this.oplataDA.Checked)
                    this.brod.ZastitnaOplata = "DA";

                this.brod.Nosivost = Int32.Parse(txbNosivost.Text);
                this.brod.VrstaBroda = "TRANSPORTNI";
                if (vrstaBorbeni.Checked)
                    this.brod.VrstaBroda = "BORBENI";


                if (DTOManager.azurirajBrod(this.brod) == 0)
                    MessageBox.Show("Azuriranje broda je uspesno izvrseno!");

                this.Close();
            }
        }
    }
}
