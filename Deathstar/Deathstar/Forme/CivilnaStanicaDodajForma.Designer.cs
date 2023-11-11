namespace Deathstar.Forme
{
    partial class CivilnaStanicaDodajForma
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbUdaljenost = new System.Windows.Forms.TextBox();
            this.txbVelicina = new System.Windows.Forms.TextBox();
            this.txbBrLjudi = new System.Windows.Forms.TextBox();
            this.txbNaziv = new System.Windows.Forms.TextBox();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NamenaGrupa = new System.Windows.Forms.GroupBox();
            this.NamenaNaucna = new System.Windows.Forms.RadioButton();
            this.NamenaTrgovina = new System.Windows.Forms.RadioButton();
            this.NamenaGrupa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Udaljenost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Velicina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Broj Ljudi:";
            // 
            // txbUdaljenost
            // 
            this.txbUdaljenost.Location = new System.Drawing.Point(163, 179);
            this.txbUdaljenost.Name = "txbUdaljenost";
            this.txbUdaljenost.Size = new System.Drawing.Size(147, 20);
            this.txbUdaljenost.TabIndex = 15;
            // 
            // txbVelicina
            // 
            this.txbVelicina.Location = new System.Drawing.Point(163, 127);
            this.txbVelicina.Name = "txbVelicina";
            this.txbVelicina.Size = new System.Drawing.Size(147, 20);
            this.txbVelicina.TabIndex = 14;
            // 
            // txbBrLjudi
            // 
            this.txbBrLjudi.Location = new System.Drawing.Point(163, 70);
            this.txbBrLjudi.Name = "txbBrLjudi";
            this.txbBrLjudi.Size = new System.Drawing.Size(147, 20);
            this.txbBrLjudi.TabIndex = 13;
            // 
            // txbNaziv
            // 
            this.txbNaziv.Location = new System.Drawing.Point(163, 12);
            this.txbNaziv.Name = "txbNaziv";
            this.txbNaziv.Size = new System.Drawing.Size(147, 20);
            this.txbNaziv.TabIndex = 12;
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodaj.Location = new System.Drawing.Point(163, 329);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(147, 51);
            this.cmdDodaj.TabIndex = 11;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.UseVisualStyleBackColor = false;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Naziv:";
            // 
            // NamenaGrupa
            // 
            this.NamenaGrupa.Controls.Add(this.NamenaNaucna);
            this.NamenaGrupa.Controls.Add(this.NamenaTrgovina);
            this.NamenaGrupa.Location = new System.Drawing.Point(12, 226);
            this.NamenaGrupa.Name = "NamenaGrupa";
            this.NamenaGrupa.Size = new System.Drawing.Size(298, 97);
            this.NamenaGrupa.TabIndex = 26;
            this.NamenaGrupa.TabStop = false;
            this.NamenaGrupa.Text = "Namena:";
            // 
            // NamenaNaucna
            // 
            this.NamenaNaucna.AutoSize = true;
            this.NamenaNaucna.Location = new System.Drawing.Point(151, 54);
            this.NamenaNaucna.Name = "NamenaNaucna";
            this.NamenaNaucna.Size = new System.Drawing.Size(119, 17);
            this.NamenaNaucna.TabIndex = 28;
            this.NamenaNaucna.TabStop = true;
            this.NamenaNaucna.Text = "Naucna Istrazivanja";
            this.NamenaNaucna.UseVisualStyleBackColor = true;
            // 
            // NamenaTrgovina
            // 
            this.NamenaTrgovina.AutoSize = true;
            this.NamenaTrgovina.Location = new System.Drawing.Point(151, 19);
            this.NamenaTrgovina.Name = "NamenaTrgovina";
            this.NamenaTrgovina.Size = new System.Drawing.Size(67, 17);
            this.NamenaTrgovina.TabIndex = 27;
            this.NamenaTrgovina.TabStop = true;
            this.NamenaTrgovina.Text = "Trgovina";
            this.NamenaTrgovina.UseVisualStyleBackColor = true;
            // 
            // CivilnaStanicaDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(326, 396);
            this.Controls.Add(this.NamenaGrupa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbUdaljenost);
            this.Controls.Add(this.txbVelicina);
            this.Controls.Add(this.txbBrLjudi);
            this.Controls.Add(this.txbNaziv);
            this.Controls.Add(this.cmdDodaj);
            this.Name = "CivilnaStanicaDodajForma";
            this.Text = "CivilnaStanicaDodajForma";
            this.Load += new System.EventHandler(this.CivilnaStanicaDodajForma_Load);
            this.NamenaGrupa.ResumeLayout(false);
            this.NamenaGrupa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUdaljenost;
        private System.Windows.Forms.TextBox txbVelicina;
        private System.Windows.Forms.TextBox txbBrLjudi;
        private System.Windows.Forms.TextBox txbNaziv;
        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox NamenaGrupa;
        private System.Windows.Forms.RadioButton NamenaNaucna;
        private System.Windows.Forms.RadioButton NamenaTrgovina;
    }
}