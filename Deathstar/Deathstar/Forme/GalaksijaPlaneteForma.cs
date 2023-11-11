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
    public partial class GalaksijaPlaneteForma : Form
    {
        public int ProsledjenId;
        public GalaksijaPlaneteForma()
        {
            InitializeComponent();
        }
        public GalaksijaPlaneteForma(int ProsledjenId) 
        {
            InitializeComponent();
            this.ProsledjenId = ProsledjenId;
        }



        private void GalaksijaPlaneteForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima() 
        {
            ListaPlaneta.Items.Clear();
            List<DTOPlaneta> planete = DTOManager.vratiPlaneteizGalaksije(ProsledjenId);


            foreach (DTOPlaneta p in planete)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Naziv, p.BrojStanovnika.ToString(), 
                                                                    p.DominantnaRasa, p.DrustvenoUredjenje, p.Trilijum.ToString(), 
                                                                    p.Berilijum.ToString(), p.Plutonijum.ToString(),
                                                                    p.x.ToString(), p.y.ToString(), p.z.ToString(), p.Maticna, 
                                                                    p.IgracId_KorisnickoIme});
                ListaPlaneta.Items.Add(item);

            }

            ListaPlaneta.Refresh();
        }
    }
}
