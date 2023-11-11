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
    public partial class ZvezdeDodajForma : Form
    {
        public DTOZvezda zvezda;

        public ZvezdeDodajForma()
        {
            InitializeComponent();
            zvezda = new DTOZvezda();
        }

        private void ZvezdeDodajForma_Load(object sender, EventArgs e)
        {

        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu zvezdu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {

                this.zvezda.Ime = txbIme.Text;
                this.zvezda.Tip = txbTip.Text;


                DTOManager.dodajZvezdu(this.zvezda);
                MessageBox.Show("Uspesno ste dodali novu zvezdu!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
