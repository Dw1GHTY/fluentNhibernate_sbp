namespace Deathstar.Forme
{
    partial class PlaneteForma
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
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.cmdObrisi = new System.Windows.Forms.Button();
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
            this.Ime_Galaksije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGradovi = new System.Windows.Forms.Button();
            this.btnPrirodniSateliti = new System.Windows.Forms.Button();
            this.btnVojneStanice = new System.Windows.Forms.Button();
            this.btnBrodovi = new System.Windows.Forms.Button();
            this.btnCivilneStanice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNazad.Location = new System.Drawing.Point(12, 12);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(93, 23);
            this.btnNazad.TabIndex = 0;
            this.btnNazad.Text = "<- Nazad";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodaj.Location = new System.Drawing.Point(1019, 57);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(88, 39);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj Planetu";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAzuriraj.Location = new System.Drawing.Point(1019, 113);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(88, 39);
            this.btnAzuriraj.TabIndex = 2;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // cmdObrisi
            // 
            this.cmdObrisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdObrisi.Location = new System.Drawing.Point(1019, 170);
            this.cmdObrisi.Name = "cmdObrisi";
            this.cmdObrisi.Size = new System.Drawing.Size(88, 39);
            this.cmdObrisi.TabIndex = 3;
            this.cmdObrisi.Text = "Obrisi";
            this.cmdObrisi.UseVisualStyleBackColor = false;
            this.cmdObrisi.Click += new System.EventHandler(this.cmdObrisi_Click);
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
            this.Ime_Igrača,
            this.Ime_Galaksije});
            this.ListaPlaneta.FullRowSelect = true;
            this.ListaPlaneta.GridLines = true;
            this.ListaPlaneta.HideSelection = false;
            this.ListaPlaneta.Location = new System.Drawing.Point(12, 57);
            this.ListaPlaneta.Name = "ListaPlaneta";
            this.ListaPlaneta.Size = new System.Drawing.Size(972, 317);
            this.ListaPlaneta.TabIndex = 4;
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
            // Ime_Galaksije
            // 
            this.Ime_Galaksije.Text = "Ime_Galaksije";
            this.Ime_Galaksije.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ime_Galaksije.Width = 137;
            // 
            // btnGradovi
            // 
            this.btnGradovi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGradovi.Location = new System.Drawing.Point(60, 426);
            this.btnGradovi.Name = "btnGradovi";
            this.btnGradovi.Size = new System.Drawing.Size(131, 64);
            this.btnGradovi.TabIndex = 5;
            this.btnGradovi.Text = "Gradovi";
            this.btnGradovi.UseVisualStyleBackColor = false;
            this.btnGradovi.Click += new System.EventHandler(this.btnGradovi_Click);
            // 
            // btnPrirodniSateliti
            // 
            this.btnPrirodniSateliti.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrirodniSateliti.Location = new System.Drawing.Point(269, 426);
            this.btnPrirodniSateliti.Name = "btnPrirodniSateliti";
            this.btnPrirodniSateliti.Size = new System.Drawing.Size(131, 64);
            this.btnPrirodniSateliti.TabIndex = 6;
            this.btnPrirodniSateliti.Text = "Prirodni Sateliti";
            this.btnPrirodniSateliti.UseVisualStyleBackColor = false;
            this.btnPrirodniSateliti.Click += new System.EventHandler(this.btnPrirodniSateliti_Click);
            // 
            // btnVojneStanice
            // 
            this.btnVojneStanice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVojneStanice.Location = new System.Drawing.Point(482, 384);
            this.btnVojneStanice.Name = "btnVojneStanice";
            this.btnVojneStanice.Size = new System.Drawing.Size(131, 64);
            this.btnVojneStanice.TabIndex = 7;
            this.btnVojneStanice.Text = "Vojne svemirske stanice";
            this.btnVojneStanice.UseVisualStyleBackColor = false;
            this.btnVojneStanice.Click += new System.EventHandler(this.btnVojneStanice_Click);
            // 
            // btnBrodovi
            // 
            this.btnBrodovi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBrodovi.Location = new System.Drawing.Point(685, 426);
            this.btnBrodovi.Name = "btnBrodovi";
            this.btnBrodovi.Size = new System.Drawing.Size(131, 64);
            this.btnBrodovi.TabIndex = 8;
            this.btnBrodovi.Text = "Brodovi na planeti";
            this.btnBrodovi.UseVisualStyleBackColor = false;
            this.btnBrodovi.Click += new System.EventHandler(this.btnBrodovi_Click);
            // 
            // btnCivilneStanice
            // 
            this.btnCivilneStanice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCivilneStanice.Location = new System.Drawing.Point(482, 454);
            this.btnCivilneStanice.Name = "btnCivilneStanice";
            this.btnCivilneStanice.Size = new System.Drawing.Size(131, 64);
            this.btnCivilneStanice.TabIndex = 9;
            this.btnCivilneStanice.Text = "Civilne svemirske stanice";
            this.btnCivilneStanice.UseVisualStyleBackColor = false;
            this.btnCivilneStanice.Click += new System.EventHandler(this.btnCivilneStanice_Click);
            // 
            // PlaneteForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1119, 530);
            this.Controls.Add(this.btnCivilneStanice);
            this.Controls.Add(this.btnBrodovi);
            this.Controls.Add(this.btnVojneStanice);
            this.Controls.Add(this.btnPrirodniSateliti);
            this.Controls.Add(this.btnGradovi);
            this.Controls.Add(this.ListaPlaneta);
            this.Controls.Add(this.cmdObrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnNazad);
            this.Name = "PlaneteForma";
            this.Text = "PlaneteForma";
            this.Load += new System.EventHandler(this.PlaneteForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button cmdObrisi;
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
        private System.Windows.Forms.ColumnHeader Ime_Galaksije;
        private System.Windows.Forms.Button btnGradovi;
        private System.Windows.Forms.Button btnPrirodniSateliti;
        private System.Windows.Forms.Button btnVojneStanice;
        private System.Windows.Forms.Button btnBrodovi;
        private System.Windows.Forms.Button btnCivilneStanice;
    }
}