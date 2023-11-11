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
    public partial class SaveziDodajForma : Form
    {
        public DTOSavez savez;
        public SaveziDodajForma()
        {
            InitializeComponent();
            savez = new DTOSavez();
        }

        private void SaveziDodajForma_Load(object sender, EventArgs e)
        {

        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi savez?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {

                this.savez.Naziv = txbNaziv.Text;
                this.savez.DatumFormiranja = dateDatumFormiranja.Value;
                this.savez.SavezId_Naziv = txbNazivPodsaveza.Text;



                DTOManager.dodajSavez(this.savez);
                MessageBox.Show("Uspesno ste dodali novi savez!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
