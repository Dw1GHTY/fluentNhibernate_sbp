namespace Deathstar.Forme
{
    partial class KvadrantiDodajForma
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
            this.txbProcenjeniPrecnik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboRedniBroj = new System.Windows.Forms.ComboBox();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbProcenjeniPrecnik
            // 
            this.txbProcenjeniPrecnik.Location = new System.Drawing.Point(122, 46);
            this.txbProcenjeniPrecnik.Name = "txbProcenjeniPrecnik";
            this.txbProcenjeniPrecnik.Size = new System.Drawing.Size(122, 20);
            this.txbProcenjeniPrecnik.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Procenjeni Precnik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Redni Broj:";
            // 
            // comboRedniBroj
            // 
            this.comboRedniBroj.FormattingEnabled = true;
            this.comboRedniBroj.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboRedniBroj.Location = new System.Drawing.Point(122, 87);
            this.comboRedniBroj.Name = "comboRedniBroj";
            this.comboRedniBroj.Size = new System.Drawing.Size(122, 21);
            this.comboRedniBroj.TabIndex = 3;
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodaj.Location = new System.Drawing.Point(122, 126);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(122, 56);
            this.cmdDodaj.TabIndex = 4;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.UseVisualStyleBackColor = false;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // KvadrantiDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(263, 235);
            this.Controls.Add(this.cmdDodaj);
            this.Controls.Add(this.comboRedniBroj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbProcenjeniPrecnik);
            this.Name = "KvadrantiDodajForma";
            this.Text = "KvadrantiDodajForma";
            this.Load += new System.EventHandler(this.KvadrantiDodajForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbProcenjeniPrecnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboRedniBroj;
        private System.Windows.Forms.Button cmdDodaj;
    }
}