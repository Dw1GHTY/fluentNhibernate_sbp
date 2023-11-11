namespace Deathstar.Forme
{
    partial class PrirodniSatelitiForma
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.ListaPrirodnihSatelita = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmdBrisi
            // 
            this.cmdBrisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdBrisi.Location = new System.Drawing.Point(381, 63);
            this.cmdBrisi.Name = "cmdBrisi";
            this.cmdBrisi.Size = new System.Drawing.Size(108, 45);
            this.cmdBrisi.TabIndex = 25;
            this.cmdBrisi.Text = "Obrisi";
            this.cmdBrisi.UseVisualStyleBackColor = false;
            this.cmdBrisi.Click += new System.EventHandler(this.cmdBrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodaj.Location = new System.Drawing.Point(381, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(108, 45);
            this.btnDodaj.TabIndex = 23;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // ListaPrirodnihSatelita
            // 
            this.ListaPrirodnihSatelita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ListaPrirodnihSatelita.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.ListaPrirodnihSatelita.FullRowSelect = true;
            this.ListaPrirodnihSatelita.GridLines = true;
            this.ListaPrirodnihSatelita.HideSelection = false;
            this.ListaPrirodnihSatelita.Location = new System.Drawing.Point(12, 12);
            this.ListaPrirodnihSatelita.Name = "ListaPrirodnihSatelita";
            this.ListaPrirodnihSatelita.Size = new System.Drawing.Size(340, 359);
            this.ListaPrirodnihSatelita.TabIndex = 22;
            this.ListaPrirodnihSatelita.UseCompatibleStateImageBehavior = false;
            this.ListaPrirodnihSatelita.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            this.columnHeader5.Width = 46;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Naziv";
            this.columnHeader6.Width = 76;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Precnik";
            this.columnHeader7.Width = 58;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Naseobine";
            this.columnHeader8.Width = 74;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Udaljenost";
            this.columnHeader9.Width = 83;
            // 
            // PrirodniSatelitiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(501, 438);
            this.Controls.Add(this.cmdBrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.ListaPrirodnihSatelita);
            this.Name = "PrirodniSatelitiForma";
            this.Text = "PrirodniSatelitiForma";
            this.Load += new System.EventHandler(this.PrirodniSatelitiForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdBrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListView ListaPrirodnihSatelita;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}