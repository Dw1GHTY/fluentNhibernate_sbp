namespace Deathstar.Forme
{
    partial class ZvezdeDodajForma
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
            this.txbTip = new System.Windows.Forms.TextBox();
            this.txbIme = new System.Windows.Forms.TextBox();
            this.cmdTip = new System.Windows.Forms.Label();
            this.cmdIme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodaj.Location = new System.Drawing.Point(141, 88);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(116, 45);
            this.cmdDodaj.TabIndex = 11;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.UseVisualStyleBackColor = false;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // txbTip
            // 
            this.txbTip.Location = new System.Drawing.Point(88, 47);
            this.txbTip.Name = "txbTip";
            this.txbTip.Size = new System.Drawing.Size(169, 20);
            this.txbTip.TabIndex = 10;
            // 
            // txbIme
            // 
            this.txbIme.Location = new System.Drawing.Point(88, 12);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(169, 20);
            this.txbIme.TabIndex = 9;
            // 
            // cmdTip
            // 
            this.cmdTip.AutoSize = true;
            this.cmdTip.Location = new System.Drawing.Point(8, 50);
            this.cmdTip.Name = "cmdTip";
            this.cmdTip.Size = new System.Drawing.Size(25, 13);
            this.cmdTip.TabIndex = 8;
            this.cmdTip.Text = "Tip:";
            // 
            // cmdIme
            // 
            this.cmdIme.AutoSize = true;
            this.cmdIme.Location = new System.Drawing.Point(8, 15);
            this.cmdIme.Name = "cmdIme";
            this.cmdIme.Size = new System.Drawing.Size(27, 13);
            this.cmdIme.TabIndex = 7;
            this.cmdIme.Text = "Ime:";
            // 
            // ZvezdeDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(262, 140);
            this.Controls.Add(this.cmdDodaj);
            this.Controls.Add(this.txbTip);
            this.Controls.Add(this.txbIme);
            this.Controls.Add(this.cmdTip);
            this.Controls.Add(this.cmdIme);
            this.Name = "ZvezdeDodajForma";
            this.Text = "ZvezdeDodajForma";
            this.Load += new System.EventHandler(this.ZvezdeDodajForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.TextBox txbTip;
        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.Label cmdTip;
        private System.Windows.Forms.Label cmdIme;
    }
}