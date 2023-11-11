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
    public partial class ProsirenjeIgracaDodajOsvajanjaForma : Form
    {
        public DTOOsvajanje osvajanje;
        public int ProsledjenId;
        public ProsirenjeIgracaDodajOsvajanjaForma()
        {
            InitializeComponent();
        }
        public ProsirenjeIgracaDodajOsvajanjaForma(int ProsledjenId)
        {
            InitializeComponent();
            this.ProsledjenId = ProsledjenId;
            osvajanje = new DTOOsvajanje();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            ProsirenjaIgraca p = new ProsirenjaIgraca();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novo osvajanje?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {

                this.osvajanje.Datum = dateDatum.Value;

                this.osvajanje.PrethodniVlasnikSavez = "";
                this.osvajanje.PrethodniVlasnikIgrac = "";

                this.osvajanje.PlanetaOsvaja_ImePlanete = txbPlaneta.Text;
                this.osvajanje.SavezVrsi_ImeSaveza = "";
                this.osvajanje.IgracVrsi_ImeIgraca = ProsledjenId.ToString();
                


                DTOManager.dodajOsvajanje(this.osvajanje);
                MessageBox.Show("Uspesno ste dodali novo osvajanje!");
                this.Close();
            }
        }
    }
}
