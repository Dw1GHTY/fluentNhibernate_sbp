namespace Deathstar.Forme
{
    partial class IgraciForma
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
            this.ListaIgraca = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazad = new System.Windows.Forms.Button();
            this.cmdBrodovi = new System.Windows.Forms.Button();
            this.btnProsirenjaIgraca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdBrisi
            // 
            this.cmdBrisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdBrisi.Location = new System.Drawing.Point(1152, 142);
            this.cmdBrisi.Name = "cmdBrisi";
            this.cmdBrisi.Size = new System.Drawing.Size(108, 45);
            this.cmdBrisi.TabIndex = 20;
            this.cmdBrisi.Text = "Obrisi";
            this.cmdBrisi.UseVisualStyleBackColor = false;
            this.cmdBrisi.Click += new System.EventHandler(this.cmdBrisi_Click);
            // 
            // cmdAzuriraj
            // 
            this.cmdAzuriraj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdAzuriraj.Location = new System.Drawing.Point(1152, 91);
            this.cmdAzuriraj.Name = "cmdAzuriraj";
            this.cmdAzuriraj.Size = new System.Drawing.Size(108, 45);
            this.cmdAzuriraj.TabIndex = 19;
            this.cmdAzuriraj.Text = "Azuriraj";
            this.cmdAzuriraj.UseVisualStyleBackColor = false;
            this.cmdAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodaj.Location = new System.Drawing.Point(1152, 40);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(108, 45);
            this.btnDodaj.TabIndex = 18;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // ListaIgraca
            // 
            this.ListaIgraca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ListaIgraca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.ListaIgraca.FullRowSelect = true;
            this.ListaIgraca.GridLines = true;
            this.ListaIgraca.HideSelection = false;
            this.ListaIgraca.Location = new System.Drawing.Point(12, 40);
            this.ListaIgraca.Name = "ListaIgraca";
            this.ListaIgraca.Size = new System.Drawing.Size(1134, 359);
            this.ListaIgraca.TabIndex = 17;
            this.ListaIgraca.UseCompatibleStateImageBehavior = false;
            this.ListaIgraca.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 51;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Korisnicko Ime";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Datum otvaranja naloga";
            this.columnHeader3.Width = 134;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "LIme";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SSlovo";
            this.columnHeader5.Width = 49;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Prezime";
            this.columnHeader6.Width = 84;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            this.columnHeader7.Width = 94;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Pol";
            this.columnHeader8.Width = 35;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Datum rodjenja";
            this.columnHeader9.Width = 96;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Drzava";
            this.columnHeader10.Width = 86;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tekstualni opis";
            this.columnHeader11.Width = 124;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Slika";
            this.columnHeader12.Width = 93;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Savez";
            this.columnHeader13.Width = 132;
            // 
            // Nazad
            // 
            this.Nazad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nazad.Location = new System.Drawing.Point(12, 9);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(108, 25);
            this.Nazad.TabIndex = 16;
            this.Nazad.Text = "<- Nazad";
            this.Nazad.UseVisualStyleBackColor = false;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // cmdBrodovi
            // 
            this.cmdBrodovi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdBrodovi.Location = new System.Drawing.Point(1152, 334);
            this.cmdBrodovi.Name = "cmdBrodovi";
            this.cmdBrodovi.Size = new System.Drawing.Size(107, 65);
            this.cmdBrodovi.TabIndex = 21;
            this.cmdBrodovi.Text = "Brodovi Izabranog Igraca";
            this.cmdBrodovi.UseVisualStyleBackColor = false;
            this.cmdBrodovi.Click += new System.EventHandler(this.cmdBrodovi_Click_1);
            // 
            // btnProsirenjaIgraca
            // 
            this.btnProsirenjaIgraca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProsirenjaIgraca.Location = new System.Drawing.Point(1152, 405);
            this.btnProsirenjaIgraca.Name = "btnProsirenjaIgraca";
            this.btnProsirenjaIgraca.Size = new System.Drawing.Size(107, 67);
            this.btnProsirenjaIgraca.TabIndex = 22;
            this.btnProsirenjaIgraca.Text = "Prosirenja";
            this.btnProsirenjaIgraca.UseVisualStyleBackColor = false;
            this.btnProsirenjaIgraca.Click += new System.EventHandler(this.btnProsirenjaIgraca_Click);
            // 
            // IgraciForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1272, 484);
            this.Controls.Add(this.btnProsirenjaIgraca);
            this.Controls.Add(this.cmdBrodovi);
            this.Controls.Add(this.cmdBrisi);
            this.Controls.Add(this.cmdAzuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.ListaIgraca);
            this.Controls.Add(this.Nazad);
            this.Name = "IgraciForma";
            this.Text = "IgraciForma";
            this.Load += new System.EventHandler(this.IgraciForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdBrisi;
        private System.Windows.Forms.Button cmdAzuriraj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListView ListaIgraca;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button cmdBrodovi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Button btnProsirenjaIgraca;
    }
}