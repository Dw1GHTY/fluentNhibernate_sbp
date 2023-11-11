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
    public partial class BrodoviSavezaForma : Form
    {
        public int ProsledjeniId;


        public BrodoviSavezaForma(int Id) 
        {
            InitializeComponent();
            this.ProsledjeniId = Id;
        }


        public BrodoviSavezaForma()
        {
            InitializeComponent();
        }
        
        private void BrodoviSavezaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {

            ListaBrodovaSaveza.Items.Clear();

            List<DTOBrod> brodovi = DTOManager.vratiSveBrodoveZaSavez(this.ProsledjeniId);


            foreach (DTOBrod p in brodovi)
            {

                ListViewItem item = new ListViewItem(new string[] { p.JedinstveniBroj.ToString(), p.Naziv, p.MaxWarp.ToString(),
                                                                    p.BrojLaserskihTopova.ToString(), p.FotonskaTorpeda,
                                                                    p.Tip, p.ZastitnaOplata, p.Nosivost.ToString(),
                                                                    p.VrstaBroda, p.PlanetaId_NazivPlanete});
                ListaBrodovaSaveza.Items.Add(item);

            }

            ListaBrodovaSaveza.Refresh();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            SaveziForma p = new SaveziForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        
    }
}
