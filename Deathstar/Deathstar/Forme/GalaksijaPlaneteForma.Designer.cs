namespace Deathstar.Forme
{
    partial class GalaksijaPlaneteForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaPlaneta = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stanovnika = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dominantna_Rasa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Društveno_uređenje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trilijum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Berilijum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plutonijum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Z = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Matična = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime_Igrača = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListaPlaneta
            // 
            this.ListaPlaneta.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ListaPlaneta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ListaPlaneta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Naziv,
            this.Stanovnika,
            this.Dominantna_Rasa,
            this.Društveno_uređenje,
            this.Trilijum,
            this.Berilijum,
            this.Plutonijum,
            this.X,
            this.Y,
            this.Z,
            this.Matična,
            this.Ime_Igrača});
            this.ListaPlaneta.FullRowSelect = true;
            this.ListaPlaneta.GridLines = true;
            this.ListaPlaneta.HideSelection = false;
            this.ListaPlaneta.Location = new System.Drawing.Point(0, 0);
            this.ListaPlaneta.Name = "ListaPlaneta";
            this.ListaPlaneta.Size = new System.Drawing.Size(1005, 449);
            this.ListaPlaneta.TabIndex = 5;
            this.ListaPlaneta.UseCompatibleStateImageBehavior = false;
            this.ListaPlaneta.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 27;
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            this.Naziv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Naziv.Width = 63;
            // 
            // Stanovnika
            // 
            this.Stanovnika.Text = "Stanovnika";
            this.Stanovnika.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Stanovnika.Width = 72;
            // 
            // Dominantna_Rasa
            // 
            this.Dominantna_Rasa.Text = "Dominantna_Rasa";
            this.Dominantna_Rasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Dominantna_Rasa.Width = 104;
            // 
            // Društveno_uređenje
            // 
            this.Društveno_uređenje.Text = "Društveno_uređenje";
            this.Društveno_uređenje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Društveno_uređenje.Width = 115;
            // 
            // Trilijum
            // 
            this.Trilijum.Text = "Trilijum";
            this.Trilijum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Berilijum
            // 
            this.Berilijum.Text = "Berilijum";
            this.Berilijum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Plutonijum
            // 
            this.Plutonijum.Text = "Plutonijum";
            this.Plutonijum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Plutonijum.Width = 63;
            // 
            // X
            // 
            this.X.Text = "X";
            this.X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.X.Width = 38;
            // 
            // Y
            // 
            this.Y.Text = "Y";
            this.Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Y.Width = 35;
            // 
            // Z
            // 
            this.Z.Text = "Z";
            this.Z.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Z.Width = 43;
            // 
            // Matična
            // 
            this.Matična.Text = "Matična";
            this.Matična.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Matična.Width = 51;
            // 
            // Ime_Igrača
            // 
            this.Ime_Igrača.Text = "Ime_Igrača";
            this.Ime_Igrača.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ime_Igrača.Width = 67;
            // 
            // GalaksijaPlaneteForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.ListaPlaneta);
            this.Name = "GalaksijaPlaneteForma";
            this.Text = "GalaksijaPlaneteForma";
            this.Load += new System.EventHandler(this.GalaksijaPlaneteForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListaPlaneta;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Stanovnika;
        private System.Windows.Forms.ColumnHeader Dominantna_Rasa;
        private System.Windows.Forms.ColumnHeader Društveno_uređenje;
        private System.Windows.Forms.ColumnHeader Trilijum;
        private System.Windows.Forms.ColumnHeader Berilijum;
        private System.Windows.Forms.ColumnHeader Plutonijum;
        private System.Windows.Forms.ColumnHeader X;
        private System.Windows.Forms.ColumnHeader Y;
        private System.Windows.Forms.ColumnHeader Z;
        private System.Windows.Forms.ColumnHeader Matična;
        private System.Windows.Forms.ColumnHeader Ime_Igrača;
    }
}