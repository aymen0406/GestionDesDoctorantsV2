namespace GestionDesDoctorantsV2
{
    partial class FormAddEtab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEtab));
            this.panelTitre = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelEnregistrer = new System.Windows.Forms.Panel();
            this.labelEnregistrer = new System.Windows.Forms.Label();
            this.panelAnnuler = new System.Windows.Forms.Panel();
            this.labelAnnuler = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtEtablissement = new System.Windows.Forms.TextBox();
            this.labelEtab = new System.Windows.Forms.Label();
            this.ErreurIntituleFr = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.labelPays = new System.Windows.Forms.Label();
            this.ErreurIntituleFr1 = new System.Windows.Forms.Label();
            this.panelTitre.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelEnregistrer.SuspendLayout();
            this.panelAnnuler.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panelTitre.Controls.Add(this.panelClose);
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(569, 43);
            this.panelTitre.TabIndex = 98;
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.Transparent;
            this.panelClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelClose.BackgroundImage")));
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelClose.Location = new System.Drawing.Point(514, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(43, 43);
            this.panelClose.TabIndex = 26;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelEnregistrer);
            this.groupBox1.Controls.Add(this.panelAnnuler);
            this.groupBox1.Location = new System.Drawing.Point(389, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 110);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            // 
            // panelEnregistrer
            // 
            this.panelEnregistrer.BackColor = System.Drawing.Color.White;
            this.panelEnregistrer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnregistrer.BackgroundImage")));
            this.panelEnregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEnregistrer.Controls.Add(this.labelEnregistrer);
            this.panelEnregistrer.Location = new System.Drawing.Point(10, 16);
            this.panelEnregistrer.Name = "panelEnregistrer";
            this.panelEnregistrer.Size = new System.Drawing.Size(150, 40);
            this.panelEnregistrer.TabIndex = 99;
            this.panelEnregistrer.Click += new System.EventHandler(this.panelEnregistrer_Click);
            this.panelEnregistrer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEnregistrer_Paint);
            // 
            // labelEnregistrer
            // 
            this.labelEnregistrer.AutoSize = true;
            this.labelEnregistrer.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelEnregistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelEnregistrer.Location = new System.Drawing.Point(68, 13);
            this.labelEnregistrer.Name = "labelEnregistrer";
            this.labelEnregistrer.Size = new System.Drawing.Size(71, 16);
            this.labelEnregistrer.TabIndex = 82;
            this.labelEnregistrer.Text = "Enregistrer";
            // 
            // panelAnnuler
            // 
            this.panelAnnuler.BackColor = System.Drawing.Color.White;
            this.panelAnnuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAnnuler.BackgroundImage")));
            this.panelAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAnnuler.Controls.Add(this.labelAnnuler);
            this.panelAnnuler.Location = new System.Drawing.Point(10, 62);
            this.panelAnnuler.Name = "panelAnnuler";
            this.panelAnnuler.Size = new System.Drawing.Size(150, 40);
            this.panelAnnuler.TabIndex = 98;
            this.panelAnnuler.Click += new System.EventHandler(this.panelAnnuler_Click);
            this.panelAnnuler.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAnnuler_Paint);
            // 
            // labelAnnuler
            // 
            this.labelAnnuler.AutoSize = true;
            this.labelAnnuler.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelAnnuler.Location = new System.Drawing.Point(82, 12);
            this.labelAnnuler.Name = "labelAnnuler";
            this.labelAnnuler.Size = new System.Drawing.Size(52, 16);
            this.labelAnnuler.TabIndex = 81;
            this.labelAnnuler.Text = "Annuler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVille);
            this.groupBox2.Controls.Add(this.txtEtablissement);
            this.groupBox2.Controls.Add(this.labelEtab);
            this.groupBox2.Controls.Add(this.ErreurIntituleFr);
            this.groupBox2.Controls.Add(this.labelVille);
            this.groupBox2.Controls.Add(this.txtPays);
            this.groupBox2.Controls.Add(this.labelPays);
            this.groupBox2.Controls.Add(this.ErreurIntituleFr1);
            this.groupBox2.Location = new System.Drawing.Point(8, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 110);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(126, 75);
            this.txtVille.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(223, 20);
            this.txtVille.TabIndex = 71;
            // 
            // txtEtablissement
            // 
            this.txtEtablissement.ForeColor = System.Drawing.Color.Black;
            this.txtEtablissement.Location = new System.Drawing.Point(126, 21);
            this.txtEtablissement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEtablissement.Name = "txtEtablissement";
            this.txtEtablissement.Size = new System.Drawing.Size(223, 20);
            this.txtEtablissement.TabIndex = 65;
            // 
            // labelEtab
            // 
            this.labelEtab.AutoSize = true;
            this.labelEtab.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelEtab.Location = new System.Drawing.Point(15, 24);
            this.labelEtab.Name = "labelEtab";
            this.labelEtab.Size = new System.Drawing.Size(91, 16);
            this.labelEtab.TabIndex = 66;
            this.labelEtab.Text = "Etablissement";
            // 
            // ErreurIntituleFr
            // 
            this.ErreurIntituleFr.AutoSize = true;
            this.ErreurIntituleFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurIntituleFr.ForeColor = System.Drawing.Color.Red;
            this.ErreurIntituleFr.Location = new System.Drawing.Point(352, 22);
            this.ErreurIntituleFr.Name = "ErreurIntituleFr";
            this.ErreurIntituleFr.Size = new System.Drawing.Size(15, 20);
            this.ErreurIntituleFr.TabIndex = 67;
            this.ErreurIntituleFr.Text = "*";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelVille.Location = new System.Drawing.Point(15, 78);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(33, 16);
            this.labelVille.TabIndex = 72;
            this.labelVille.Text = "Ville";
            // 
            // txtPays
            // 
            this.txtPays.Location = new System.Drawing.Point(126, 48);
            this.txtPays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(223, 20);
            this.txtPays.TabIndex = 68;
            // 
            // labelPays
            // 
            this.labelPays.AutoSize = true;
            this.labelPays.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelPays.Location = new System.Drawing.Point(15, 51);
            this.labelPays.Name = "labelPays";
            this.labelPays.Size = new System.Drawing.Size(38, 16);
            this.labelPays.TabIndex = 69;
            this.labelPays.Text = "Pays";
            // 
            // ErreurIntituleFr1
            // 
            this.ErreurIntituleFr1.AutoSize = true;
            this.ErreurIntituleFr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurIntituleFr1.ForeColor = System.Drawing.Color.Red;
            this.ErreurIntituleFr1.Location = new System.Drawing.Point(352, 49);
            this.ErreurIntituleFr1.Name = "ErreurIntituleFr1";
            this.ErreurIntituleFr1.Size = new System.Drawing.Size(15, 20);
            this.ErreurIntituleFr1.TabIndex = 70;
            this.ErreurIntituleFr1.Text = "*";
            // 
            // FormAddEtab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 168);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddEtab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddEtab";
            this.Load += new System.EventHandler(this.FormAddEtab_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormAddEtab_Paint);
            this.panelTitre.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panelEnregistrer.ResumeLayout(false);
            this.panelEnregistrer.PerformLayout();
            this.panelAnnuler.ResumeLayout(false);
            this.panelAnnuler.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelEnregistrer;
        private System.Windows.Forms.Label labelEnregistrer;
        private System.Windows.Forms.Panel panelAnnuler;
        private System.Windows.Forms.Label labelAnnuler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtEtablissement;
        private System.Windows.Forms.Label labelEtab;
        private System.Windows.Forms.Label ErreurIntituleFr;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.Label labelPays;
        private System.Windows.Forms.Label ErreurIntituleFr1;
    }
}