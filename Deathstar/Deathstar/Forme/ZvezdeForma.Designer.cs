namespace Deathstar.Forme
{
    partial class ZvezdeForma
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
            this.ListaZvezda = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazad = new System.Windows.Forms.Button();
            this.btnZvezdeBlizuPlaneta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdBrisi
            // 
            this.cmdBrisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdBrisi.Location = new System.Drawing.Point(364, 88);
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
            this.btnDodaj.Location = new System.Drawing.Point(364, 37);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(108, 45);
            this.btnDodaj.TabIndex = 23;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // ListaZvezda
            // 
            this.ListaZvezda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ListaZvezda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListaZvezda.FullRowSelect = true;
            this.ListaZvezda.GridLines = true;
            this.ListaZvezda.HideSelection = false;
            this.ListaZvezda.Location = new System.Drawing.Point(12, 37);
            this.ListaZvezda.Name = "ListaZvezda";
            this.ListaZvezda.Size = new System.Drawing.Size(334, 434);
            this.ListaZvezda.TabIndex = 22;
            this.ListaZvezda.UseCompatibleStateImageBehavior = false;
            this.ListaZvezda.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 131;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tip";
            this.columnHeader3.Width = 138;
            // 
            // Nazad
            // 
            this.Nazad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nazad.Location = new System.Drawing.Point(12, 6);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(108, 25);
            this.Nazad.TabIndex = 21;
            this.Nazad.Text = "<- Nazad";
            this.Nazad.UseVisualStyleBackColor = false;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // btnZvezdeBlizuPlaneta
            // 
            this.btnZvezdeBlizuPlaneta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnZvezdeBlizuPlaneta.Location = new System.Drawing.Point(364, 382);
            this.btnZvezdeBlizuPlaneta.Name = "btnZvezdeBlizuPlaneta";
            this.btnZvezdeBlizuPlaneta.Size = new System.Drawing.Size(108, 89);
            this.btnZvezdeBlizuPlaneta.TabIndex = 26;
            this.btnZvezdeBlizuPlaneta.Text = "Zvezde blizu planeta";
            this.btnZvezdeBlizuPlaneta.UseVisualStyleBackColor = false;
            this.btnZvezdeBlizuPlaneta.Click += new System.EventHandler(this.btnZvezdeBlizuPlaneta_Click);
            // 
            // ZvezdeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(492, 532);
            this.Controls.Add(this.btnZvezdeBlizuPlaneta);
            this.Controls.Add(this.cmdBrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.ListaZvezda);
            this.Controls.Add(this.Nazad);
            this.Name = "ZvezdeForma";
            this.Text = "ZvezdeForma";
            this.Load += new System.EventHandler(this.ZvezdeForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdBrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListView ListaZvezda;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button btnZvezdeBlizuPlaneta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}