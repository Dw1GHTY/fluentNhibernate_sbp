namespace Deathstar.Forme
{
    partial class SaveziAzurirajForma
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
            this.txbSavez = new System.Windows.Forms.TextBox();
            this.dateDatumFormiranja = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdSnimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNaziv
            // 
            this.txbNaziv.Location = new System.Drawing.Point(99, 12);
            this.txbNaziv.Name = "txbNaziv";
            this.txbNaziv.Size = new System.Drawing.Size(182, 20);
            this.txbNaziv.TabIndex = 0;
            // 
            // txbSavez
            // 
            this.txbSavez.Location = new System.Drawing.Point(100, 86);
            this.txbSavez.Name = "txbSavez";
            this.txbSavez.Size = new System.Drawing.Size(181, 20);
            this.txbSavez.TabIndex = 1;
            // 
            // dateDatumFormiranja
            // 
            this.dateDatumFormiranja.Location = new System.Drawing.Point(100, 50);
            this.dateDatumFormiranja.Name = "dateDatumFormiranja";
            this.dateDatumFormiranja.Size = new System.Drawing.Size(181, 20);
            this.dateDatumFormiranja.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum Formiranja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id podsaveza:";
            // 
            // cmdSnimi
            // 
            this.cmdSnimi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdSnimi.Location = new System.Drawing.Point(12, 144);
            this.cmdSnimi.Name = "cmdSnimi";
            this.cmdSnimi.Size = new System.Drawing.Size(269, 47);
            this.cmdSnimi.TabIndex = 6;
            this.cmdSnimi.Text = "Snimi";
            this.cmdSnimi.UseVisualStyleBackColor = false;
            this.cmdSnimi.Click += new System.EventHandler(this.cmdSnimi_Click);
            // 
            // SaveziAzurirajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 217);
            this.Controls.Add(this.cmdSnimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateDatumFormiranja);
            this.Controls.Add(this.txbSavez);
            this.Controls.Add(this.txbNaziv);
            this.Name = "SaveziAzurirajForma";
            this.Text = "SaveziAzurirajForma";
            this.Load += new System.EventHandler(this.SaveziAzurirajForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNaziv;
        private System.Windows.Forms.TextBox txbSavez;
        private System.Windows.Forms.DateTimePicker dateDatumFormiranja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdSnimi;
    }
}