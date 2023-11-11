namespace Deathstar.Forme
{
    partial class ProsirenjaSaveza
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
            this.btnDodajKolonizacije = new System.Windows.Forms.Button();
            this.btnDodajOsvajanja = new System.Windows.Forms.Button();
            this.ListaKolonizacijaSaveza = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListaOsvajanjaSaveza = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(816, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kolonizacije";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Osvajanja";
            // 
            // btnDodajKolonizacije
            // 
            this.btnDodajKolonizacije.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodajKolonizacije.Location = new System.Drawing.Point(780, 454);
            this.btnDodajKolonizacije.Name = "btnDodajKolonizacije";
            this.btnDodajKolonizacije.Size = new System.Drawing.Size(117, 51);
            this.btnDodajKolonizacije.TabIndex = 24;
            this.btnDodajKolonizacije.Text = "Dodaj";
            this.btnDodajKolonizacije.UseVisualStyleBackColor = false;
            this.btnDodajKolonizacije.Click += new System.EventHandler(this.btnDodajKolonizacije_Click);
            // 
            // btnDodajOsvajanja
            // 
            this.btnDodajOsvajanja.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodajOsvajanja.Location = new System.Drawing.Point(82, 454);
            this.btnDodajOsvajanja.Name = "btnDodajOsvajanja";
            this.btnDodajOsvajanja.Size = new System.Drawing.Size(117, 51);
            this.btnDodajOsvajanja.TabIndex = 23;
            this.btnDodajOsvajanja.Text = "Dodaj";
            this.btnDodajOsvajanja.UseVisualStyleBackColor = false;
            this.btnDodajOsvajanja.Click += new System.EventHandler(this.btnDodajOsvajanja_Click);
            // 
            // ListaKolonizacijaSaveza
            // 
            this.ListaKolonizacijaSaveza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ListaKolonizacijaSaveza.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13});
            this.ListaKolonizacijaSaveza.FullRowSelect = true;
            this.ListaKolonizacijaSaveza.GridLines = true;
            this.ListaKolonizacijaSaveza.HideSelection = false;
            this.ListaKolonizacijaSaveza.Location = new System.Drawing.Point(780, 43);
            this.ListaKolonizacijaSaveza.Name = "ListaKolonizacijaSaveza";
            this.ListaKolonizacijaSaveza.Size = new System.Drawing.Size(224, 405);
            this.ListaKolonizacijaSaveza.TabIndex = 28;
            this.ListaKolonizacijaSaveza.UseCompatibleStateImageBehavior = false;
            this.ListaKolonizacijaSaveza.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Datum";
            this.columnHeader12.Width = 93;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Planeta";
            this.columnHeader13.Width = 125;
            // 
            // ListaOsvajanjaSaveza
            // 
            this.ListaOsvajanjaSaveza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ListaOsvajanjaSaveza.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6});
            this.ListaOsvajanjaSaveza.FullRowSelect = true;
            this.ListaOsvajanjaSaveza.GridLines = true;
            this.ListaOsvajanjaSaveza.HideSelection = false;
            this.ListaOsvajanjaSaveza.Location = new System.Drawing.Point(82, 43);
            this.ListaOsvajanjaSaveza.Name = "ListaOsvajanjaSaveza";
            this.ListaOsvajanjaSaveza.Size = new System.Drawing.Size(528, 405);
            this.ListaOsvajanjaSaveza.TabIndex = 27;
            this.ListaOsvajanjaSaveza.UseCompatibleStateImageBehavior = false;
            this.ListaOsvajanjaSaveza.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prethodni Vlasnik Igrac";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prethodni Vlasnik Savez";
            this.columnHeader3.Width = 133;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Uzeta Planeta";
            this.columnHeader6.Width = 201;
            // 
            // ProsirenjaSaveza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1113, 607);
            this.Controls.Add(this.ListaKolonizacijaSaveza);
            this.Controls.Add(this.ListaOsvajanjaSaveza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajKolonizacije);
            this.Controls.Add(this.btnDodajOsvajanja);
            this.Name = "ProsirenjaSaveza";
            this.Text = "ProsirenjaSaveza";
            this.Load += new System.EventHandler(this.ProsirenjaSaveza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajKolonizacije;
        private System.Windows.Forms.Button btnDodajOsvajanja;
        private System.Windows.Forms.ListView ListaKolonizacijaSaveza;
        private System.Windows.Forms.ListView ListaOsvajanjaSaveza;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
    }
}