namespace Deathstar.Forme
{
    partial class ProsirenjaSavezaDodajKolonizacijeForma
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.txbPlaneta = new System.Windows.Forms.TextBox();
            this.dateDatum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Planeta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Datum:";
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodaj.Location = new System.Drawing.Point(215, 64);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(200, 64);
            this.cmdDodaj.TabIndex = 36;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.UseVisualStyleBackColor = false;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // txbPlaneta
            // 
            this.txbPlaneta.Location = new System.Drawing.Point(215, 38);
            this.txbPlaneta.Name = "txbPlaneta";
            this.txbPlaneta.Size = new System.Drawing.Size(200, 20);
            this.txbPlaneta.TabIndex = 33;
            // 
            // dateDatum
            // 
            this.dateDatum.Location = new System.Drawing.Point(215, 12);
            this.dateDatum.Name = "dateDatum";
            this.dateDatum.Size = new System.Drawing.Size(200, 20);
            this.dateDatum.TabIndex = 40;
            // 
            // ProsirenjaSavezaDodajKolonizacijeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 135);
            this.Controls.Add(this.dateDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdDodaj);
            this.Controls.Add(this.txbPlaneta);
            this.Name = "ProsirenjaSavezaDodajKolonizacijeForma";
            this.Text = "ProsirenjaSavezaDodajKolonizacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.TextBox txbPlaneta;
        private System.Windows.Forms.DateTimePicker dateDatum;
    }
}