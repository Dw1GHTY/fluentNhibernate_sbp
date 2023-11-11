using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deathstar.Forme;

namespace Deathstar
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void btnSavezi_Click(object sender, EventArgs e)
        {
            SaveziForma p = new SaveziForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void btnPlanete_Click(object sender, EventArgs e)
        {
            PlaneteForma p = new PlaneteForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void btnIgraci_Click(object sender, EventArgs e)
        {
            IgraciForma p = new IgraciForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }


        private void btnZvezde_Click(object sender, EventArgs e)
        {
            ZvezdeForma p = new ZvezdeForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void btnPojave_Click(object sender, EventArgs e)
        {
            SpecPojaveForma p = new SpecPojaveForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }

        private void btnGalaksije_Click(object sender, EventArgs e)
        {
            GalaksijeForma p = new GalaksijeForma();

            this.Hide();
            Cursor.Current = Cursors.WaitCursor;
            p.ShowDialog();
            this.Close();
        }
    }
}
