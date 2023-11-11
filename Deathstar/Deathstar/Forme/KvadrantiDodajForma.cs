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
    public partial class KvadrantiDodajForma : Form
    {
        public int ProsledjenId;
        public DTOKvadrant kvadrant;

        public KvadrantiDodajForma(int ProsledjenId)
        {
            InitializeComponent();
            kvadrant = new DTOKvadrant();
            this.ProsledjenId = ProsledjenId;
        }

        private void KvadrantiDodajForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi kvadrant galaksiji?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {

                this.kvadrant.ProcenjeniPrecnik = Int32.Parse(txbProcenjeniPrecnik.Text);                      
                this.kvadrant.RedniBroj = Int32.Parse(comboRedniBroj.SelectedItem.ToString());
                this.kvadrant.GalaksijaId_ImeGalaksije = ProsledjenId.ToString();

                DTOManager.dodajKvadrant(this.kvadrant);
                MessageBox.Show("Uspesno ste dodali novi kvadrant!");
                this.Close();

               
            }
        }
        public void popuniPodacima() 
        {
            this.comboRedniBroj.SelectedIndex = 0;
        }
    }
}
