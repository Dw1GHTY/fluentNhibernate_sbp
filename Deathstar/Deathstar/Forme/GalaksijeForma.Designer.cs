namespace Deathstar.Forme
{
    partial class GalaksijeForma
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
            this.cmdBrisi = new System.Windows.Forms.Button();
            this.cmdAzuriraj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.ListaGalaksija = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazad = new System.Windows.Forms.Button();
            this.btnKvadranti = new System.Windows.Forms.Button();
            this.btnPlanete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdBrisi
            // 
            this.cmdBrisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdBrisi.Location = new System.Drawing.Point(612, 143);
            this.cmdBrisi.Name = "cmdBrisi";
            this.cmdBrisi.Size = new System.Drawing.Size(108, 45);
            this.cmdBrisi.TabIndex = 25;
            this.cmdBrisi.Text = "Obrisi";
            this.cmdBrisi.UseVisualStyleBackColor = false;
            this.cmdBrisi.Click += new System.EventHandler(this.cmdBrisi_Click);
            // 
            // cmdAzuriraj
            // 
            this.cmdAzuriraj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdAzuriraj.Location = new System.Drawing.Point(612, 92);
            this.cmdAzuriraj.Name = "cmdAzuriraj";
            this.cmdAzuriraj.Size = new System.Drawing.Size(108, 45);
            this.cmdAzuriraj.TabIndex = 24;
            this.cmdAzuriraj.Text = "Azuriraj";
            this.cmdAzuriraj.UseVisualStyleBackColor = false;
            this.cmdAzuriraj.Click += new System.EventHandler(this.cmdAzuriraj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodaj.Location = new System.Drawing.Point(612, 41);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(108, 45);
            this.btnDodaj.TabIndex = 23;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // ListaGalaksija
            // 
            this.ListaGalaksija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ListaGalaksija.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.ListaGalaksija.FullRowSelect = true;
            this.ListaGalaksija.GridLines = true;
            this.ListaGalaksija.HideSelection = false;
            this.ListaGalaksija.Location = new System.Drawing.Point(12, 41);
            this.ListaGalaksija.Name = "ListaGalaksija";
            this.ListaGalaksija.Size = new System.Drawing.Size(567, 379);
            this.ListaGalaksija.TabIndex = 22;
            this.ListaGalaksija.UseCompatibleStateImageBehavior = false;
            this.ListaGalaksija.View = System.Windows.Forms.View.Details;
            this.ListaGalaksija.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            this.columnHeader6.Width = 41;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ime";
            this.columnHeader7.Width = 134;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Dominantna Rasa";
            this.columnHeader8.Width = 119;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Procenjeni broj Planeta";
            this.columnHeader9.Width = 136;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Procenjeni broj Zvezda";
            this.columnHeader10.Width = 133;
            // 
            // Nazad
            // 
            this.Nazad.Location = new System.Drawing.Point(12, 10);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(108, 25);
            this.Nazad.TabIndex = 21;
            this.Nazad.Text = "<- Nazad";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // btnKvadranti
            // 
            this.btnKvadranti.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKvadranti.Location = new System.Drawing.Point(612, 342);
            this.btnKvadranti.Name = "btnKvadranti";
            this.btnKvadranti.Size = new System.Drawing.Size(107, 77);
            this.btnKvadranti.TabIndex = 26;
            this.btnKvadranti.Text = "Kvadranti izabrane galaksije";
            this.btnKvadranti.UseVisualStyleBackColor = false;
            this.btnKvadranti.Click += new System.EventHandler(this.btnKvadranti_Click);
            // 
            // btnPlanete
            // 
            this.btnPlanete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlanete.Location = new System.Drawing.Point(612, 260);
            this.btnPlanete.Name = "btnPlanete";
            this.btnPlanete.Size = new System.Drawing.Size(106, 73);
            this.btnPlanete.TabIndex = 27;
            this.btnPlanete.Text = "Planete u galaksiji";
            this.btnPlanete.UseVisualStyleBackColor = false;
            this.btnPlanete.Click += new System.EventHandler(this.btnPlanete_Click);
            // 
            // GalaksijeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(735, 456);
            this.Controls.Add(this.btnPlanete);
            this.Controls.Add(this.btnKvadranti);
            this.Controls.Add(this.cmdBrisi);
            this.Controls.Add(this.cmdAzuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.ListaGalaksija);
            this.Controls.Add(this.Nazad);
            this.Name = "GalaksijeForma";
            this.Text = "GalaksijeForma";
            this.Load += new System.EventHandler(this.GalaksijeForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdBrisi;
        private System.Windows.Forms.Button cmdAzuriraj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListView ListaGalaksija;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button btnKvadranti;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnPlanete;
    }
}