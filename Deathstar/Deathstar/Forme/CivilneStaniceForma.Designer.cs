namespace Deathstar.Forme
{
    partial class CivilneStaniceForma
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
            this.ListaCivilnihStanica = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmdBrisi
            // 
            this.cmdBrisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdBrisi.Location = new System.Drawing.Point(616, 63);
            this.cmdBrisi.Name = "cmdBrisi";
            this.cmdBrisi.Size = new System.Drawing.Size(108, 45);
            this.cmdBrisi.TabIndex = 30;
            this.cmdBrisi.Text = "Obrisi";
            this.cmdBrisi.UseVisualStyleBackColor = false;
            this.cmdBrisi.Click += new System.EventHandler(this.cmdBrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodaj.Location = new System.Drawing.Point(616, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(108, 45);
            this.btnDodaj.TabIndex = 28;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // ListaCivilnihStanica
            // 
            this.ListaCivilnihStanica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ListaCivilnihStanica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.ListaCivilnihStanica.FullRowSelect = true;
            this.ListaCivilnihStanica.GridLines = true;
            this.ListaCivilnihStanica.HideSelection = false;
            this.ListaCivilnihStanica.Location = new System.Drawing.Point(10, 12);
            this.ListaCivilnihStanica.Name = "ListaCivilnihStanica";
            this.ListaCivilnihStanica.Size = new System.Drawing.Size(589, 359);
            this.ListaCivilnihStanica.TabIndex = 27;
            this.ListaCivilnihStanica.UseCompatibleStateImageBehavior = false;
            this.ListaCivilnihStanica.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Broj Ljudi";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Velicina";
            this.columnHeader4.Width = 71;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Udaljenost";
            this.columnHeader5.Width = 67;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Za Trgovinu";
            this.columnHeader6.Width = 87;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Za Naucna Istrazivanja";
            this.columnHeader7.Width = 139;
            // 
            // CivilneStaniceForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(736, 463);
            this.Controls.Add(this.cmdBrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.ListaCivilnihStanica);
            this.Name = "CivilneStaniceForma";
            this.Text = "CivilneStaniceForma";
            this.Load += new System.EventHandler(this.CivilneStaniceForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdBrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListView ListaCivilnihStanica;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}