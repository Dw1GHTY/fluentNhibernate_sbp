namespace Deathstar.Forme
{
    partial class SaveziForma
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
            this.ListaSaveza = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajSavez = new System.Windows.Forms.Button();
            this.btnAzurirajSavez = new System.Windows.Forms.Button();
            this.cmdObrisiSavez = new System.Windows.Forms.Button();
            this.btnSaveziNazad = new System.Windows.Forms.Button();
            this.cmdBrodovi = new System.Windows.Forms.Button();
            this.btnProsirenjaSaveza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaSaveza
            // 
            this.ListaSaveza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ListaSaveza.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListaSaveza.FullRowSelect = true;
            this.ListaSaveza.GridLines = true;
            this.ListaSaveza.HideSelection = false;
            this.ListaSaveza.Location = new System.Drawing.Point(158, 12);
            this.ListaSaveza.Name = "ListaSaveza";
            this.ListaSaveza.Size = new System.Drawing.Size(437, 443);
            this.ListaSaveza.TabIndex = 0;
            this.ListaSaveza.UseCompatibleStateImageBehavior = false;
            this.ListaSaveza.View = System.Windows.Forms.View.Details;
            this.ListaSaveza.SelectedIndexChanged += new System.EventHandler(this.ListaSaveza_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DatumFormiranja";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nadsavez";
            this.columnHeader4.Width = 168;
            // 
            // btnDodajSavez
            // 
            this.btnDodajSavez.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodajSavez.Location = new System.Drawing.Point(601, 12);
            this.btnDodajSavez.Name = "btnDodajSavez";
            this.btnDodajSavez.Size = new System.Drawing.Size(115, 38);
            this.btnDodajSavez.TabIndex = 1;
            this.btnDodajSavez.Text = "Dodaj Savez";
            this.btnDodajSavez.UseVisualStyleBackColor = false;
            this.btnDodajSavez.Click += new System.EventHandler(this.btnDodajSavez_Click);
            // 
            // btnAzurirajSavez
            // 
            this.btnAzurirajSavez.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAzurirajSavez.Location = new System.Drawing.Point(601, 68);
            this.btnAzurirajSavez.Name = "btnAzurirajSavez";
            this.btnAzurirajSavez.Size = new System.Drawing.Size(115, 38);
            this.btnAzurirajSavez.TabIndex = 2;
            this.btnAzurirajSavez.Text = "Azuriraj";
            this.btnAzurirajSavez.UseVisualStyleBackColor = false;
            this.btnAzurirajSavez.Click += new System.EventHandler(this.btnAzurirajSavez_Click);
            // 
            // cmdObrisiSavez
            // 
            this.cmdObrisiSavez.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdObrisiSavez.Location = new System.Drawing.Point(601, 129);
            this.cmdObrisiSavez.Name = "cmdObrisiSavez";
            this.cmdObrisiSavez.Size = new System.Drawing.Size(115, 38);
            this.cmdObrisiSavez.TabIndex = 3;
            this.cmdObrisiSavez.Text = "Obrisi";
            this.cmdObrisiSavez.UseVisualStyleBackColor = false;
            this.cmdObrisiSavez.Click += new System.EventHandler(this.cmdObrisiSavez_Click);
            // 
            // btnSaveziNazad
            // 
            this.btnSaveziNazad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveziNazad.Location = new System.Drawing.Point(12, 12);
            this.btnSaveziNazad.Name = "btnSaveziNazad";
            this.btnSaveziNazad.Size = new System.Drawing.Size(107, 35);
            this.btnSaveziNazad.TabIndex = 4;
            this.btnSaveziNazad.Text = "<- Nazad";
            this.btnSaveziNazad.UseVisualStyleBackColor = false;
            this.btnSaveziNazad.Click += new System.EventHandler(this.btnSaveziNazad_Click);
            // 
            // cmdBrodovi
            // 
            this.cmdBrodovi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdBrodovi.Location = new System.Drawing.Point(609, 320);
            this.cmdBrodovi.Name = "cmdBrodovi";
            this.cmdBrodovi.Size = new System.Drawing.Size(107, 65);
            this.cmdBrodovi.TabIndex = 22;
            this.cmdBrodovi.Text = "Brodovi Izabranog Saveza";
            this.cmdBrodovi.UseVisualStyleBackColor = false;
            this.cmdBrodovi.Click += new System.EventHandler(this.cmdBrodovi_Click);
            // 
            // btnProsirenjaSaveza
            // 
            this.btnProsirenjaSaveza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProsirenjaSaveza.Location = new System.Drawing.Point(609, 391);
            this.btnProsirenjaSaveza.Name = "btnProsirenjaSaveza";
            this.btnProsirenjaSaveza.Size = new System.Drawing.Size(107, 64);
            this.btnProsirenjaSaveza.TabIndex = 23;
            this.btnProsirenjaSaveza.Text = "Prosirenja";
            this.btnProsirenjaSaveza.UseVisualStyleBackColor = false;
            this.btnProsirenjaSaveza.Click += new System.EventHandler(this.btnProsirenjaSaveza_Click);
            // 
            // SaveziForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 467);
            this.Controls.Add(this.btnProsirenjaSaveza);
            this.Controls.Add(this.cmdBrodovi);
            this.Controls.Add(this.btnSaveziNazad);
            this.Controls.Add(this.cmdObrisiSavez);
            this.Controls.Add(this.btnAzurirajSavez);
            this.Controls.Add(this.btnDodajSavez);
            this.Controls.Add(this.ListaSaveza);
            this.Name = "SaveziForma";
            this.Text = "SaveziForma";
            this.Load += new System.EventHandler(this.SaveziForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListaSaveza;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnDodajSavez;
        private System.Windows.Forms.Button btnAzurirajSavez;
        private System.Windows.Forms.Button cmdObrisiSavez;
        private System.Windows.Forms.Button btnSaveziNazad;
        private System.Windows.Forms.Button cmdBrodovi;
        private System.Windows.Forms.Button btnProsirenjaSaveza;
    }
}