namespace Deathstar.Forme
{
    partial class SpecPojavaPlanetaBlizinaForma
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
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.ListaPojavaPlanetaBlizina = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmdBrisi
            // 
            this.cmdBrisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdBrisi.Location = new System.Drawing.Point(350, 63);
            this.cmdBrisi.Name = "cmdBrisi";
            this.cmdBrisi.Size = new System.Drawing.Size(108, 45);
            this.cmdBrisi.TabIndex = 32;
            this.cmdBrisi.Text = "Obrisi";
            this.cmdBrisi.UseVisualStyleBackColor = false;
            this.cmdBrisi.Click += new System.EventHandler(this.cmdBrisi_Click);
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodaj.Location = new System.Drawing.Point(350, 12);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(108, 45);
            this.cmdDodaj.TabIndex = 30;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.UseVisualStyleBackColor = false;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // ListaPojavaPlanetaBlizina
            // 
            this.ListaPojavaPlanetaBlizina.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.ListaPojavaPlanetaBlizina.FullRowSelect = true;
            this.ListaPojavaPlanetaBlizina.GridLines = true;
            this.ListaPojavaPlanetaBlizina.HideSelection = false;
            this.ListaPojavaPlanetaBlizina.Location = new System.Drawing.Point(12, 12);
            this.ListaPojavaPlanetaBlizina.Name = "ListaPojavaPlanetaBlizina";
            this.ListaPojavaPlanetaBlizina.Size = new System.Drawing.Size(312, 359);
            this.ListaPojavaPlanetaBlizina.TabIndex = 29;
            this.ListaPojavaPlanetaBlizina.UseCompatibleStateImageBehavior = false;
            this.ListaPojavaPlanetaBlizina.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Planeta";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Udaljenost";
            this.columnHeader4.Width = 105;
            // 
            // SpecPojavaPlanetaBlizinaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 394);
            this.Controls.Add(this.cmdBrisi);
            this.Controls.Add(this.cmdDodaj);
            this.Controls.Add(this.ListaPojavaPlanetaBlizina);
            this.Name = "SpecPojavaPlanetaBlizinaForma";
            this.Text = "SpecPojavaPlanetaBlizinaForma";
            this.Load += new System.EventHandler(this.SpecPojavaPlanetaBlizinaForma_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdBrisi;
        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.ListView ListaPojavaPlanetaBlizina;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}