namespace Deathstar.Forme
{
    partial class SpecPojaveForma
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
            this.btnPojavePlanete = new System.Windows.Forms.Button();
            this.cmdBrisi = new System.Windows.Forms.Button();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.ListaSpecPojava = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPojavePlanete
            // 
            this.btnPojavePlanete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPojavePlanete.Location = new System.Drawing.Point(448, 333);
            this.btnPojavePlanete.Name = "btnPojavePlanete";
            this.btnPojavePlanete.Size = new System.Drawing.Size(107, 65);
            this.btnPojavePlanete.TabIndex = 27;
            this.btnPojavePlanete.Text = "Planete u blizini";
            this.btnPojavePlanete.UseVisualStyleBackColor = false;
            this.btnPojavePlanete.Click += new System.EventHandler(this.btnPojavePlanete_Click);
            // 
            // cmdBrisi
            // 
            this.cmdBrisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdBrisi.Location = new System.Drawing.Point(448, 90);
            this.cmdBrisi.Name = "cmdBrisi";
            this.cmdBrisi.Size = new System.Drawing.Size(108, 45);
            this.cmdBrisi.TabIndex = 26;
            this.cmdBrisi.Text = "Obrisi";
            this.cmdBrisi.UseVisualStyleBackColor = false;
            this.cmdBrisi.Click += new System.EventHandler(this.cmdBrisi_Click);
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodaj.Location = new System.Drawing.Point(448, 39);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(108, 45);
            this.cmdDodaj.TabIndex = 24;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.UseVisualStyleBackColor = false;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // ListaSpecPojava
            // 
            this.ListaSpecPojava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ListaSpecPojava.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListaSpecPojava.FullRowSelect = true;
            this.ListaSpecPojava.GridLines = true;
            this.ListaSpecPojava.HideSelection = false;
            this.ListaSpecPojava.Location = new System.Drawing.Point(12, 39);
            this.ListaSpecPojava.Name = "ListaSpecPojava";
            this.ListaSpecPojava.Size = new System.Drawing.Size(409, 359);
            this.ListaSpecPojava.TabIndex = 23;
            this.ListaSpecPojava.UseCompatibleStateImageBehavior = false;
            this.ListaSpecPojava.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            this.columnHeader2.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tip";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Potencijalna opasnost";
            this.columnHeader4.Width = 149;
            // 
            // Nazad
            // 
            this.Nazad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nazad.Location = new System.Drawing.Point(12, 8);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(108, 25);
            this.Nazad.TabIndex = 22;
            this.Nazad.Text = "<- Nazad";
            this.Nazad.UseVisualStyleBackColor = false;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // SpecPojaveForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 431);
            this.Controls.Add(this.btnPojavePlanete);
            this.Controls.Add(this.cmdBrisi);
            this.Controls.Add(this.cmdDodaj);
            this.Controls.Add(this.ListaSpecPojava);
            this.Controls.Add(this.Nazad);
            this.Name = "SpecPojaveForma";
            this.Text = "SpecPojaveForma";
            this.Load += new System.EventHandler(this.SpecPojaveForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPojavePlanete;
        private System.Windows.Forms.Button cmdBrisi;
        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.ListView ListaSpecPojava;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button Nazad;
    }
}