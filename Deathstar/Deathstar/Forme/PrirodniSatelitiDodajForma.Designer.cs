namespace Deathstar.Forme
{
    partial class PrirodniSatelitiDodajForma
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
            this.txbUdaljenost = new System.Windows.Forms.TextBox();
            this.txbNaziv = new System.Windows.Forms.TextBox();
            this.txbPrecnik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.checkboxNaseobine = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txbUdaljenost
            // 
            this.txbUdaljenost.Location = new System.Drawing.Point(79, 86);
            this.txbUdaljenost.Name = "txbUdaljenost";
            this.txbUdaljenost.Size = new System.Drawing.Size(177, 20);
            this.txbUdaljenost.TabIndex = 21;
            // 
            // txbNaziv
            // 
            this.txbNaziv.Location = new System.Drawing.Point(79, 11);
            this.txbNaziv.Name = "txbNaziv";
            this.txbNaziv.Size = new System.Drawing.Size(177, 20);
            this.txbNaziv.TabIndex = 19;
            // 
            // txbPrecnik
            // 
            this.txbPrecnik.Location = new System.Drawing.Point(79, 37);
            this.txbPrecnik.Name = "txbPrecnik";
            this.txbPrecnik.Size = new System.Drawing.Size(177, 20);
            this.txbPrecnik.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Udaljenost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Precnik:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naziv:";
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodaj.Location = new System.Drawing.Point(138, 121);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(119, 46);
            this.cmdDodaj.TabIndex = 12;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.UseVisualStyleBackColor = false;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // checkboxNaseobine
            // 
            this.checkboxNaseobine.AutoSize = true;
            this.checkboxNaseobine.Location = new System.Drawing.Point(180, 63);
            this.checkboxNaseobine.Name = "checkboxNaseobine";
            this.checkboxNaseobine.Size = new System.Drawing.Size(77, 17);
            this.checkboxNaseobine.TabIndex = 23;
            this.checkboxNaseobine.Text = "Naseobine";
            this.checkboxNaseobine.UseVisualStyleBackColor = true;
            // 
            // PrirodniSatelitiDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(266, 180);
            this.Controls.Add(this.checkboxNaseobine);
            this.Controls.Add(this.txbUdaljenost);
            this.Controls.Add(this.txbNaziv);
            this.Controls.Add(this.txbPrecnik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdDodaj);
            this.Name = "PrirodniSatelitiDodajForma";
            this.Text = "PrirodniSatelitiDodajForma";
            this.Load += new System.EventHandler(this.PrirodniSatelitiDodajForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbUdaljenost;
        private System.Windows.Forms.TextBox txbNaziv;
        private System.Windows.Forms.TextBox txbPrecnik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.CheckBox checkboxNaseobine;
    }
}