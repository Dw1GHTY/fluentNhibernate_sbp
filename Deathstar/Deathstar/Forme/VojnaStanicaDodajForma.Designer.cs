namespace Deathstar.Forme
{
    partial class VojnaStanicaDodajForma
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
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.txbNaziv = new System.Windows.Forms.TextBox();
            this.txbBrojLjudi = new System.Windows.Forms.TextBox();
            this.txbVelicina = new System.Windows.Forms.TextBox();
            this.txbUdaljenost = new System.Windows.Forms.TextBox();
            this.txbOruzjeZaSpisak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.Location = new System.Drawing.Point(162, 143);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(147, 51);
            this.cmdDodaj.TabIndex = 0;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.UseVisualStyleBackColor = true;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // txbNaziv
            // 
            this.txbNaziv.Location = new System.Drawing.Point(162, 13);
            this.txbNaziv.Name = "txbNaziv";
            this.txbNaziv.Size = new System.Drawing.Size(147, 20);
            this.txbNaziv.TabIndex = 1;
            // 
            // txbBrojLjudi
            // 
            this.txbBrojLjudi.Location = new System.Drawing.Point(162, 39);
            this.txbBrojLjudi.Name = "txbBrojLjudi";
            this.txbBrojLjudi.Size = new System.Drawing.Size(147, 20);
            this.txbBrojLjudi.TabIndex = 2;
            // 
            // txbVelicina
            // 
            this.txbVelicina.Location = new System.Drawing.Point(162, 65);
            this.txbVelicina.Name = "txbVelicina";
            this.txbVelicina.Size = new System.Drawing.Size(147, 20);
            this.txbVelicina.TabIndex = 3;
            // 
            // txbUdaljenost
            // 
            this.txbUdaljenost.Location = new System.Drawing.Point(162, 91);
            this.txbUdaljenost.Name = "txbUdaljenost";
            this.txbUdaljenost.Size = new System.Drawing.Size(147, 20);
            this.txbUdaljenost.TabIndex = 4;
            // 
            // txbOruzjeZaSpisak
            // 
            this.txbOruzjeZaSpisak.Location = new System.Drawing.Point(162, 117);
            this.txbOruzjeZaSpisak.Name = "txbOruzjeZaSpisak";
            this.txbOruzjeZaSpisak.Size = new System.Drawing.Size(147, 20);
            this.txbOruzjeZaSpisak.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Broj Ljud:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Velicina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Udaljenost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Oruzje za spisak:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // VojnaStanicaDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 219);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbOruzjeZaSpisak);
            this.Controls.Add(this.txbUdaljenost);
            this.Controls.Add(this.txbVelicina);
            this.Controls.Add(this.txbBrojLjudi);
            this.Controls.Add(this.txbNaziv);
            this.Controls.Add(this.cmdDodaj);
            this.Name = "VojnaStanicaDodajForma";
            this.Text = "VojnaStanicaDodajForma";
            this.Load += new System.EventHandler(this.VojnaStanicaDodajForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.TextBox txbNaziv;
        private System.Windows.Forms.TextBox txbBrojLjudi;
        private System.Windows.Forms.TextBox txbVelicina;
        private System.Windows.Forms.TextBox txbUdaljenost;
        private System.Windows.Forms.TextBox txbOruzjeZaSpisak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}