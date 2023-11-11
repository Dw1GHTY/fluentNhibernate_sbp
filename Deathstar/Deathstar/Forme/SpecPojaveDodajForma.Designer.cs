namespace Deathstar.Forme
{
    partial class SpecPojaveDodajForma
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
            this.txbPotOpasnostSpecPojave = new System.Windows.Forms.TextBox();
            this.txbTipSpecPojave = new System.Windows.Forms.TextBox();
            this.txbNazivSpecPojave = new System.Windows.Forms.TextBox();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbPotOpasnostSpecPojave
            // 
            this.txbPotOpasnostSpecPojave.Location = new System.Drawing.Point(154, 65);
            this.txbPotOpasnostSpecPojave.Name = "txbPotOpasnostSpecPojave";
            this.txbPotOpasnostSpecPojave.Size = new System.Drawing.Size(153, 20);
            this.txbPotOpasnostSpecPojave.TabIndex = 17;
            // 
            // txbTipSpecPojave
            // 
            this.txbTipSpecPojave.Location = new System.Drawing.Point(153, 38);
            this.txbTipSpecPojave.Name = "txbTipSpecPojave";
            this.txbTipSpecPojave.Size = new System.Drawing.Size(153, 20);
            this.txbTipSpecPojave.TabIndex = 16;
            // 
            // txbNazivSpecPojave
            // 
            this.txbNazivSpecPojave.Location = new System.Drawing.Point(153, 12);
            this.txbNazivSpecPojave.Name = "txbNazivSpecPojave";
            this.txbNazivSpecPojave.Size = new System.Drawing.Size(153, 20);
            this.txbNazivSpecPojave.TabIndex = 15;
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodaj.Location = new System.Drawing.Point(193, 106);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(114, 43);
            this.cmdDodaj.TabIndex = 14;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.UseVisualStyleBackColor = false;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Potencijalna opasnost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Naziv";
            // 
            // SpecPojaveDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 158);
            this.Controls.Add(this.txbPotOpasnostSpecPojave);
            this.Controls.Add(this.txbTipSpecPojave);
            this.Controls.Add(this.txbNazivSpecPojave);
            this.Controls.Add(this.cmdDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SpecPojaveDodajForma";
            this.Text = "SpecPojaveDodajForma";
            this.Load += new System.EventHandler(this.SpecPojaveDodajForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPotOpasnostSpecPojave;
        private System.Windows.Forms.TextBox txbTipSpecPojave;
        private System.Windows.Forms.TextBox txbNazivSpecPojave;
        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}