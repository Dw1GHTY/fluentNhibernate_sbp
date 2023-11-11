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
    public partial class SaveziAzurirajForma : Form
    {
        public DTOSavez savez;
        public SaveziAzurirajForma()
        {
            InitializeComponent();
        }
        public SaveziAzurirajForma(DTOSavez savez)
        {
            InitializeComponent();
            this.savez = savez;
        }

        private void SaveziAzurirajForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima() 
        {
            txbNaziv.Text = this.savez.Naziv;
            dateDatumFormiranja.Value = this.savez.DatumFormiranja;
            //txbSavez.Text = this.savez.SavezId_Naziv;
        }

        private void cmdSnimi_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene saveza?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.savez.Naziv = txbNaziv.Text;
                this.savez.DatumFormiranja = dateDatumFormiranja.Value;
                this.savez.SavezId_Naziv = txbSavez.Text;
                

                DTOManager.azurirajSavez(this.savez);
                MessageBox.Show("Azuriranje saveza je uspesno izvrseno!");
                this.Close();
            }
        }
    }
}
