namespace Deathstar.Forme
{
    partial class GalaksijeDodajForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.txbBrZvezda = new System.Windows.Forms.TextBox();
            this.txbBrPlaneta = new System.Windows.Forms.TextBox();
            this.txbDominantnaRasa = new System.Windows.Forms.TextBox();
            this.txbIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Procenjeni broj zvezda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Procenjeni broj planeta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ime:";
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodaj.Location = new System.Drawing.Point(152, 113);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(166, 64);
            this.cmdDodaj.TabIndex = 22;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.UseVisualStyleBackColor = false;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // txbBrZvezda
            // 
            this.txbBrZvezda.Location = new System.Drawing.Point(152, 87);
            this.txbBrZvezda.Name = "txbBrZvezda";
            this.txbBrZvezda.Size = new System.Drawing.Size(166, 20);
            this.txbBrZvezda.TabIndex = 21;
            // 
            // txbBrPlaneta
            // 
            this.txbBrPlaneta.Location = new System.Drawing.Point(152, 61);
            this.txbBrPlaneta.Name = "txbBrPlaneta";
            this.txbBrPlaneta.Size = new System.Drawing.Size(166, 20);
            this.txbBrPlaneta.TabIndex = 20;
            // 
            // txbDominantnaRasa
            // 
            this.txbDominantnaRasa.Location = new System.Drawing.Point(152, 35);
            this.txbDominantnaRasa.Name = "txbDominantnaRasa";
            this.txbDominantnaRasa.Size = new System.Drawing.Size(166, 20);
            this.txbDominantnaRasa.TabIndex = 19;
            // 
            // txbIme
            // 
            this.txbIme.Location = new System.Drawing.Point(152, 9);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(166, 20);
            this.txbIme.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Dominantna rasa:";
            // 
            // GalaksijeDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(330, 193);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdDodaj);
            this.Controls.Add(this.txbBrZvezda);
            this.Controls.Add(this.txbBrPlaneta);
            this.Controls.Add(this.txbDominantnaRasa);
            this.Controls.Add(this.txbIme);
            this.Name = "GalaksijeDodajForma";
            this.Text = "GalaksijeDodajForma";
            this.Load += new System.EventHandler(this.GalaksijeDodajForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.TextBox txbBrZvezda;
        private System.Windows.Forms.TextBox txbBrPlaneta;
        private System.Windows.Forms.TextBox txbDominantnaRasa;
        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.Label label5;
    }
}