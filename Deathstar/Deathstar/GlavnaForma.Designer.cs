namespace Deathstar
{
    partial class GlavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.btnSavezi = new System.Windows.Forms.Button();
            this.btnPlanete = new System.Windows.Forms.Button();
            this.btnIgraci = new System.Windows.Forms.Button();
            this.btnZvezde = new System.Windows.Forms.Button();
            this.btnPojave = new System.Windows.Forms.Button();
            this.btnGalaksije = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSavezi
            // 
            this.btnSavezi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSavezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavezi.Location = new System.Drawing.Point(37, 401);
            this.btnSavezi.Name = "btnSavezi";
            this.btnSavezi.Size = new System.Drawing.Size(140, 52);
            this.btnSavezi.TabIndex = 0;
            this.btnSavezi.Text = "Savezi";
            this.btnSavezi.UseVisualStyleBackColor = false;
            this.btnSavezi.Click += new System.EventHandler(this.btnSavezi_Click);
            // 
            // btnPlanete
            // 
            this.btnPlanete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPlanete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanete.Location = new System.Drawing.Point(38, 24);
            this.btnPlanete.Name = "btnPlanete";
            this.btnPlanete.Size = new System.Drawing.Size(140, 52);
            this.btnPlanete.TabIndex = 1;
            this.btnPlanete.Text = "Planete";
            this.btnPlanete.UseVisualStyleBackColor = false;
            this.btnPlanete.Click += new System.EventHandler(this.btnPlanete_Click);
            // 
            // btnIgraci
            // 
            this.btnIgraci.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnIgraci.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgraci.Location = new System.Drawing.Point(37, 302);
            this.btnIgraci.Name = "btnIgraci";
            this.btnIgraci.Size = new System.Drawing.Size(140, 52);
            this.btnIgraci.TabIndex = 3;
            this.btnIgraci.Text = "Igraci";
            this.btnIgraci.UseVisualStyleBackColor = false;
            this.btnIgraci.Click += new System.EventHandler(this.btnIgraci_Click);
            // 
            // btnZvezde
            // 
            this.btnZvezde.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnZvezde.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZvezde.Location = new System.Drawing.Point(38, 116);
            this.btnZvezde.Name = "btnZvezde";
            this.btnZvezde.Size = new System.Drawing.Size(139, 51);
            this.btnZvezde.TabIndex = 4;
            this.btnZvezde.Text = "Zvezde";
            this.btnZvezde.UseVisualStyleBackColor = false;
            this.btnZvezde.Click += new System.EventHandler(this.btnZvezde_Click);
            // 
            // btnPojave
            // 
            this.btnPojave.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPojave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPojave.Location = new System.Drawing.Point(38, 205);
            this.btnPojave.Name = "btnPojave";
            this.btnPojave.Size = new System.Drawing.Size(139, 51);
            this.btnPojave.TabIndex = 5;
            this.btnPojave.Text = "Pojave";
            this.btnPojave.UseVisualStyleBackColor = false;
            this.btnPojave.Click += new System.EventHandler(this.btnPojave_Click);
            // 
            // btnGalaksije
            // 
            this.btnGalaksije.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGalaksije.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGalaksije.Location = new System.Drawing.Point(37, 489);
            this.btnGalaksije.Name = "btnGalaksije";
            this.btnGalaksije.Size = new System.Drawing.Size(140, 51);
            this.btnGalaksije.TabIndex = 6;
            this.btnGalaksije.Text = "Galaksije";
            this.btnGalaksije.UseVisualStyleBackColor = false;
            this.btnGalaksije.Click += new System.EventHandler(this.btnGalaksije_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1014, 581);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 575);
            this.Controls.Add(this.btnGalaksije);
            this.Controls.Add(this.btnPojave);
            this.Controls.Add(this.btnZvezde);
            this.Controls.Add(this.btnIgraci);
            this.Controls.Add(this.btnPlanete);
            this.Controls.Add(this.btnSavezi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GlavnaForma";
            this.Text = "GlavnaForma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSavezi;
        private System.Windows.Forms.Button btnPlanete;
        private System.Windows.Forms.Button btnIgraci;
        private System.Windows.Forms.Button btnZvezde;
        private System.Windows.Forms.Button btnPojave;
        private System.Windows.Forms.Button btnGalaksije;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}