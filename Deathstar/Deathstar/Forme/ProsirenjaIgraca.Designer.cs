namespace Deathstar.Forme
{
    partial class ProsirenjaIgraca
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
            this.ListaOsvajanjaIgraca = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListaKolonizacijaIgraca = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajOsvajanje = new System.Windows.Forms.Button();
            this.btnDodajKolonizaciju = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListaOsvajanjaIgraca
            // 
            this.ListaOsvajanjaIgraca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ListaOsvajanjaIgraca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader15});
            this.ListaOsvajanjaIgraca.FullRowSelect = true;
            this.ListaOsvajanjaIgraca.GridLines = true;
            this.ListaOsvajanjaIgraca.HideSelection = false;
            this.ListaOsvajanjaIgraca.Location = new System.Drawing.Point(55, 44);
            this.ListaOsvajanjaIgraca.Name = "ListaOsvajanjaIgraca";
            this.ListaOsvajanjaIgraca.Size = new System.Drawing.Size(532, 405);
            this.ListaOsvajanjaIgraca.TabIndex = 14;
            this.ListaOsvajanjaIgraca.UseCompatibleStateImageBehavior = false;
            this.ListaOsvajanjaIgraca.View = System.Windows.Forms.View.Details;
            this.ListaOsvajanjaIgraca.SelectedIndexChanged += new System.EventHandler(this.ListaOsvajanjaIgraca_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Datum";
            this.columnHeader8.Width = 95;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Prethdoni vlasnik Igrac";
            this.columnHeader9.Width = 130;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Prethodni vlasnik Savez";
            this.columnHeader10.Width = 139;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Planeta";
            this.columnHeader15.Width = 104;
            // 
            // ListaKolonizacijaIgraca
            // 
            this.ListaKolonizacijaIgraca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ListaKolonizacijaIgraca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader14});
            this.ListaKolonizacijaIgraca.FullRowSelect = true;
            this.ListaKolonizacijaIgraca.GridLines = true;
            this.ListaKolonizacijaIgraca.HideSelection = false;
            this.ListaKolonizacijaIgraca.Location = new System.Drawing.Point(762, 44);
            this.ListaKolonizacijaIgraca.Name = "ListaKolonizacijaIgraca";
            this.ListaKolonizacijaIgraca.Size = new System.Drawing.Size(236, 405);
            this.ListaKolonizacijaIgraca.TabIndex = 15;
            this.ListaKolonizacijaIgraca.UseCompatibleStateImageBehavior = false;
            this.ListaKolonizacijaIgraca.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Id";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Datum";
            this.columnHeader12.Width = 81;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Planeta";
            this.columnHeader14.Width = 91;
            // 
            // btnDodajOsvajanje
            // 
            this.btnDodajOsvajanje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodajOsvajanje.Location = new System.Drawing.Point(55, 455);
            this.btnDodajOsvajanje.Name = "btnDodajOsvajanje";
            this.btnDodajOsvajanje.Size = new System.Drawing.Size(117, 51);
            this.btnDodajOsvajanje.TabIndex = 16;
            this.btnDodajOsvajanje.Text = "Dodaj";
            this.btnDodajOsvajanje.UseVisualStyleBackColor = false;
            this.btnDodajOsvajanje.Click += new System.EventHandler(this.btnDodajOsvajanje_Click);
            // 
            // btnDodajKolonizaciju
            // 
            this.btnDodajKolonizaciju.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodajKolonizaciju.Location = new System.Drawing.Point(762, 455);
            this.btnDodajKolonizaciju.Name = "btnDodajKolonizaciju";
            this.btnDodajKolonizaciju.Size = new System.Drawing.Size(117, 51);
            this.btnDodajKolonizaciju.TabIndex = 17;
            this.btnDodajKolonizaciju.Text = "Dodaj";
            this.btnDodajKolonizaciju.UseVisualStyleBackColor = false;
            this.btnDodajKolonizaciju.Click += new System.EventHandler(this.btnDodajKolonizaciju_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Osvajanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(805, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kolonizacije";
            // 
            // ProsirenjaIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1126, 615);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajKolonizaciju);
            this.Controls.Add(this.btnDodajOsvajanje);
            this.Controls.Add(this.ListaKolonizacijaIgraca);
            this.Controls.Add(this.ListaOsvajanjaIgraca);
            this.Name = "ProsirenjaIgraca";
            this.Text = "ProsirenjaIgraca";
            this.Load += new System.EventHandler(this.ProsirenjaIgraca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ListaOsvajanjaIgraca;
        private System.Windows.Forms.ListView ListaKolonizacijaIgraca;
        private System.Windows.Forms.Button btnDodajOsvajanje;
        private System.Windows.Forms.Button btnDodajKolonizaciju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
    }
}