namespace Deathstar.Forme
{
    partial class SpecPojavaPlanetaBlizinaDodajForma
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
            this.txbIdPlanete = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbUdaljenost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbIdPlanete
            // 
            this.txbIdPlanete.Location = new System.Drawing.Point(114, 12);
            this.txbIdPlanete.Name = "txbIdPlanete";
            this.txbIdPlanete.Size = new System.Drawing.Size(128, 20);
            this.txbIdPlanete.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Udaljenost:";
            // 
            // txbUdaljenost
            // 
            this.txbUdaljenost.Location = new System.Drawing.Point(114, 47);
            this.txbUdaljenost.Name = "txbUdaljenost";
            this.txbUdaljenost.Size = new System.Drawing.Size(128, 20);
            this.txbUdaljenost.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID planete:";
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodaj.Location = new System.Drawing.Point(154, 89);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(88, 33);
            this.cmdDodaj.TabIndex = 8;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.UseVisualStyleBackColor = false;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // SpecPojavaPlanetaBlizinaDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 135);
            this.Controls.Add(this.txbIdPlanete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbUdaljenost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdDodaj);
            this.Name = "SpecPojavaPlanetaBlizinaDodajForma";
            this.Text = "SpecPojavaPlanetaBlizinaDodajForma";
            this.Load += new System.EventHandler(this.SpecPojavaPlanetaBlizinaDodajForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbIdPlanete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbUdaljenost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDodaj;
    }
}