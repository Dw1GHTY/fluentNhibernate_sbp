namespace Deathstar.Forme
{
    partial class GradoviDodajForma
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
            this.txbNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.checkboxGlavni = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txbNaziv
            // 
            this.txbNaziv.Location = new System.Drawing.Point(65, 12);
            this.txbNaziv.Name = "txbNaziv";
            this.txbNaziv.Size = new System.Drawing.Size(144, 20);
            this.txbNaziv.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naziv:";
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodaj.Location = new System.Drawing.Point(92, 72);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(117, 48);
            this.cmdDodaj.TabIndex = 8;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.UseVisualStyleBackColor = false;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // checkboxGlavni
            // 
            this.checkboxGlavni.AutoSize = true;
            this.checkboxGlavni.Location = new System.Drawing.Point(149, 49);
            this.checkboxGlavni.Name = "checkboxGlavni";
            this.checkboxGlavni.Size = new System.Drawing.Size(56, 17);
            this.checkboxGlavni.TabIndex = 14;
            this.checkboxGlavni.Text = "Glavni";
            this.checkboxGlavni.UseVisualStyleBackColor = true;
            // 
            // GradoviDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(222, 135);
            this.Controls.Add(this.checkboxGlavni);
            this.Controls.Add(this.txbNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdDodaj);
            this.Name = "GradoviDodajForma";
            this.Text = "GradoviDodajForma";
            this.Load += new System.EventHandler(this.GradoviDodajForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.CheckBox checkboxGlavni;
    }
}