namespace GestionDesDoctorantsV2
{
    partial class ChoixAjoutEncadrant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixAjoutEncadrant));
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitre = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelEnregistrer = new System.Windows.Forms.Panel();
            this.labelEnregistrer = new System.Windows.Forms.Label();
            this.panelAnnuler = new System.Windows.Forms.Panel();
            this.labelAnnuler = new System.Windows.Forms.Label();
            this.cmbxTypeEncadreur = new System.Windows.Forms.ComboBox();
            this.ErreurTypeEncadrant = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelprenom = new System.Windows.Forms.Label();
            this.txtNomEncadrant = new System.Windows.Forms.TextBox();
            this.txtPrenomEncadrant = new System.Windows.Forms.TextBox();
            this.ErreurNomEncad = new System.Windows.Forms.Label();
            this.ErreurPrenomEncad = new System.Windows.Forms.Label();
            this.panelTitre.SuspendLayout();
            this.panelEnregistrer.SuspendLayout();
            this.panelAnnuler.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Role";
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(209)))), ((int)(((byte)(216)))));
            this.panelTitre.Controls.Add(this.panelClose);
            this.panelTitre.Controls.Add(this.label2);
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(355, 43);
            this.panelTitre.TabIndex = 97;
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.Transparent;
            this.panelClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelClose.BackgroundImage")));
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelClose.Location = new System.Drawing.Point(311, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(43, 43);
            this.panelClose.TabIndex = 30;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            this.panelClose.MouseEnter += new System.EventHandler(this.panelClose_MouseEnter);
            this.panelClose.MouseLeave += new System.EventHandler(this.panelClose_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ajout enseignant chercheur";
            // 
            // panelEnregistrer
            // 
            this.panelEnregistrer.BackColor = System.Drawing.Color.White;
            this.panelEnregistrer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnregistrer.BackgroundImage")));
            this.panelEnregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEnregistrer.Controls.Add(this.labelEnregistrer);
            this.panelEnregistrer.Location = new System.Drawing.Point(179, 137);
            this.panelEnregistrer.Name = "panelEnregistrer";
            this.panelEnregistrer.Size = new System.Drawing.Size(150, 40);
            this.panelEnregistrer.TabIndex = 3;
            this.panelEnregistrer.Click += new System.EventHandler(this.panelEnregistrer_Click);
            this.panelEnregistrer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEnregistrer_Paint);
            this.panelEnregistrer.MouseEnter += new System.EventHandler(this.panelEnregistrer_MouseEnter);
            this.panelEnregistrer.MouseLeave += new System.EventHandler(this.panelEnregistrer_MouseLeave);
            // 
            // labelEnregistrer
            // 
            this.labelEnregistrer.AutoSize = true;
            this.labelEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnregistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelEnregistrer.Location = new System.Drawing.Point(68, 14);
            this.labelEnregistrer.Name = "labelEnregistrer";
            this.labelEnregistrer.Size = new System.Drawing.Size(51, 16);
            this.labelEnregistrer.TabIndex = 82;
            this.labelEnregistrer.Text = "Valider";
            this.labelEnregistrer.MouseEnter += new System.EventHandler(this.panelEnregistrer_MouseEnter);
            this.labelEnregistrer.MouseLeave += new System.EventHandler(this.panelEnregistrer_MouseLeave);
            // 
            // panelAnnuler
            // 
            this.panelAnnuler.BackColor = System.Drawing.Color.White;
            this.panelAnnuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAnnuler.BackgroundImage")));
            this.panelAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAnnuler.Controls.Add(this.labelAnnuler);
            this.panelAnnuler.Location = new System.Drawing.Point(17, 136);
            this.panelAnnuler.Name = "panelAnnuler";
            this.panelAnnuler.Size = new System.Drawing.Size(150, 40);
            this.panelAnnuler.TabIndex = 2;
            this.panelAnnuler.Click += new System.EventHandler(this.panelAnnuler_Click);
            this.panelAnnuler.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAnnuler_Paint);
            this.panelAnnuler.MouseEnter += new System.EventHandler(this.panelAnnuler_MouseEnter);
            this.panelAnnuler.MouseLeave += new System.EventHandler(this.panelAnnuler_MouseLeave);
            // 
            // labelAnnuler
            // 
            this.labelAnnuler.AutoSize = true;
            this.labelAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelAnnuler.Location = new System.Drawing.Point(65, 13);
            this.labelAnnuler.Name = "labelAnnuler";
            this.labelAnnuler.Size = new System.Drawing.Size(53, 16);
            this.labelAnnuler.TabIndex = 81;
            this.labelAnnuler.Text = "Annuler";
            this.labelAnnuler.Click += new System.EventHandler(this.panelAnnuler_Click);
            this.labelAnnuler.MouseEnter += new System.EventHandler(this.panelAnnuler_MouseEnter);
            this.labelAnnuler.MouseLeave += new System.EventHandler(this.panelAnnuler_MouseLeave);
            // 
            // cmbxTypeEncadreur
            // 
            this.cmbxTypeEncadreur.BackColor = System.Drawing.Color.White;
            this.cmbxTypeEncadreur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTypeEncadreur.ForeColor = System.Drawing.Color.Black;
            this.cmbxTypeEncadreur.FormattingEnabled = true;
            this.cmbxTypeEncadreur.Items.AddRange(new object[] {
            "Directeur de thèse",
            "Co-Encadrant",
            "Président de jury",
            "Rapporteur ",
            "Examinateur"});
            this.cmbxTypeEncadreur.Location = new System.Drawing.Point(104, 50);
            this.cmbxTypeEncadreur.Name = "cmbxTypeEncadreur";
            this.cmbxTypeEncadreur.Size = new System.Drawing.Size(225, 21);
            this.cmbxTypeEncadreur.TabIndex = 0;
            // 
            // ErreurTypeEncadrant
            // 
            this.ErreurTypeEncadrant.AutoSize = true;
            this.ErreurTypeEncadrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurTypeEncadrant.ForeColor = System.Drawing.Color.Red;
            this.ErreurTypeEncadrant.Location = new System.Drawing.Point(332, 51);
            this.ErreurTypeEncadrant.Name = "ErreurTypeEncadrant";
            this.ErreurTypeEncadrant.Size = new System.Drawing.Size(13, 16);
            this.ErreurTypeEncadrant.TabIndex = 98;
            this.ErreurTypeEncadrant.Text = "*";
            this.ErreurTypeEncadrant.Visible = false;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(17, 81);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 99;
            this.labelNom.Text = "Nom";
            // 
            // labelprenom
            // 
            this.labelprenom.AutoSize = true;
            this.labelprenom.Location = new System.Drawing.Point(17, 108);
            this.labelprenom.Name = "labelprenom";
            this.labelprenom.Size = new System.Drawing.Size(43, 13);
            this.labelprenom.TabIndex = 100;
            this.labelprenom.Text = "Prénom";
            // 
            // txtNomEncadrant
            // 
            this.txtNomEncadrant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomEncadrant.Location = new System.Drawing.Point(104, 76);
            this.txtNomEncadrant.Name = "txtNomEncadrant";
            this.txtNomEncadrant.Size = new System.Drawing.Size(225, 20);
            this.txtNomEncadrant.TabIndex = 101;
            // 
            // txtPrenomEncadrant
            // 
            this.txtPrenomEncadrant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenomEncadrant.Location = new System.Drawing.Point(104, 101);
            this.txtPrenomEncadrant.Name = "txtPrenomEncadrant";
            this.txtPrenomEncadrant.Size = new System.Drawing.Size(225, 20);
            this.txtPrenomEncadrant.TabIndex = 102;
            // 
            // ErreurNomEncad
            // 
            this.ErreurNomEncad.AutoSize = true;
            this.ErreurNomEncad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurNomEncad.ForeColor = System.Drawing.Color.Red;
            this.ErreurNomEncad.Location = new System.Drawing.Point(331, 77);
            this.ErreurNomEncad.Name = "ErreurNomEncad";
            this.ErreurNomEncad.Size = new System.Drawing.Size(13, 16);
            this.ErreurNomEncad.TabIndex = 103;
            this.ErreurNomEncad.Text = "*";
            this.ErreurNomEncad.Visible = false;
            // 
            // ErreurPrenomEncad
            // 
            this.ErreurPrenomEncad.AutoSize = true;
            this.ErreurPrenomEncad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurPrenomEncad.ForeColor = System.Drawing.Color.Red;
            this.ErreurPrenomEncad.Location = new System.Drawing.Point(332, 102);
            this.ErreurPrenomEncad.Name = "ErreurPrenomEncad";
            this.ErreurPrenomEncad.Size = new System.Drawing.Size(13, 16);
            this.ErreurPrenomEncad.TabIndex = 104;
            this.ErreurPrenomEncad.Text = "*";
            this.ErreurPrenomEncad.Visible = false;
            // 
            // ChoixAjoutEncadrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 203);
            this.Controls.Add(this.ErreurTypeEncadrant);
            this.Controls.Add(this.ErreurNomEncad);
            this.Controls.Add(this.ErreurPrenomEncad);
            this.Controls.Add(this.txtPrenomEncadrant);
            this.Controls.Add(this.txtNomEncadrant);
            this.Controls.Add(this.labelprenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.cmbxTypeEncadreur);
            this.Controls.Add(this.panelEnregistrer);
            this.Controls.Add(this.panelAnnuler);
            this.Controls.Add(this.panelTitre);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoixAjoutEncadrant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChoixAjoutEnseignant_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ChoixAjoutEncadrant_Paint);
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
            this.panelEnregistrer.ResumeLayout(false);
            this.panelEnregistrer.PerformLayout();
            this.panelAnnuler.ResumeLayout(false);
            this.panelAnnuler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Panel panelEnregistrer;
        private System.Windows.Forms.Label labelEnregistrer;
        private System.Windows.Forms.Panel panelAnnuler;
        private System.Windows.Forms.Label labelAnnuler;
        private System.Windows.Forms.ComboBox cmbxTypeEncadreur;
        private System.Windows.Forms.Label ErreurTypeEncadrant;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelprenom;
        private System.Windows.Forms.TextBox txtNomEncadrant;
        private System.Windows.Forms.TextBox txtPrenomEncadrant;
        private System.Windows.Forms.Label ErreurNomEncad;
        private System.Windows.Forms.Label ErreurPrenomEncad;
    }
}