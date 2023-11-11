namespace Deathstar.Forme
{
    partial class BrodoviIgracaForma
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
            this.cmdBrisi = new System.Windows.Forms.Button();
            this.cmdAzuriraj = new System.Windows.Forms.Button();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.ListaBrodovaIgraca = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmdBrisi
            // 
            this.cmdBrisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdBrisi.Location = new System.Drawing.Point(974, 114);
            this.cmdBrisi.Name = "cmdBrisi";
            this.cmdBrisi.Size = new System.Drawing.Size(108, 45);
            this.cmdBrisi.TabIndex = 20;
            this.cmdBrisi.Text = "Obrisi";
            this.cmdBrisi.UseVisualStyleBackColor = false;
            this.cmdBrisi.Click += new System.EventHandler(this.cmdBrisi_Click);
            // 
            // cmdAzuriraj
            // 
            this.cmdAzuriraj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdAzuriraj.Location = new System.Drawing.Point(974, 63);
            this.cmdAzuriraj.Name = "cmdAzuriraj";
            this.cmdAzuriraj.Size = new System.Drawing.Size(108, 45);
            this.cmdAzuriraj.TabIndex = 19;
            this.cmdAzuriraj.Text = "Azuriraj";
            this.cmdAzuriraj.UseVisualStyleBackColor = false;
            this.cmdAzuriraj.Click += new System.EventHandler(this.cmdAzuriraj_Click);
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodaj.Location = new System.Drawing.Point(974, 12);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(108, 45);
            this.cmdDodaj.TabIndex = 18;
            this.cmdDodaj.Text = "Dodaj";
            this.cmdDodaj.UseVisualStyleBackColor = false;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // ListaBrodovaIgraca
            // 
            this.ListaBrodovaIgraca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ListaBrodovaIgraca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader12});
            this.ListaBrodovaIgraca.FullRowSelect = true;
            this.ListaBrodovaIgraca.GridLines = true;
            this.ListaBrodovaIgraca.HideSelection = false;
            this.ListaBrodovaIgraca.Location = new System.Drawing.Point(12, 12);
            this.ListaBrodovaIgraca.Name = "ListaBrodovaIgraca";
            this.ListaBrodovaIgraca.Size = new System.Drawing.Size(956, 359);
            this.ListaBrodovaIgraca.TabIndex = 17;
            this.ListaBrodovaIgraca.UseCompatibleStateImageBehavior = false;
            this.ListaBrodovaIgraca.View = System.Windows.Forms.View.Details;
            this.ListaBrodovaIgraca.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "JBR";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Max Warp";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Broj topova";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fotonska torpeda";
            this.columnHeader5.Width = 109;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tip";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Zastitna oplata";
            this.columnHeader7.Width = 105;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nosivost";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Vrsta broda";
            this.columnHeader9.Width = 86;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Planeta izgradnje";
            this.columnHeader12.Width = 136;
            // 
            // BrodoviIgracaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1094, 395);
            this.Controls.Add(this.cmdBrisi);
            this.Controls.Add(this.cmdAzuriraj);
            this.Controls.Add(this.cmdDodaj);
            this.Controls.Add(this.ListaBrodovaIgraca);
            this.Name = "BrodoviIgracaForma";
            this.Text = "BrodoviIgracaForma";
            this.Load += new System.EventHandler(this.BrodoviIgracaForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdBrisi;
        private System.Windows.Forms.Button cmdAzuriraj;
        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.ListView ListaBrodovaIgraca;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}