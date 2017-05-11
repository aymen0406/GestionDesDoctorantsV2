namespace GestionDesDoctorantsV2
{
    partial class GestionCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCompte));
            this.panelTitre = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelEnregistrer = new System.Windows.Forms.Panel();
            this.btnModifier = new System.Windows.Forms.Panel();
            this.labelModifier = new System.Windows.Forms.Label();
            this.labelEnregistrer = new System.Windows.Forms.Label();
            this.panelAnnuler = new System.Windows.Forms.Panel();
            this.labelAnnuler = new System.Windows.Forms.Label();
            this.panelTitre.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelEnregistrer.SuspendLayout();
            this.btnModifier.SuspendLayout();
            this.panelAnnuler.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panelTitre.Controls.Add(this.panelClose);
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(558, 42);
            this.panelTitre.TabIndex = 111;
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.Transparent;
            this.panelClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelClose.BackgroundImage")));
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelClose.Location = new System.Drawing.Point(515, -1);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(42, 42);
            this.panelClose.TabIndex = 24;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            this.panelClose.MouseEnter += new System.EventHandler(this.panelClose_MouseEnter);
            this.panelClose.MouseLeave += new System.EventHandler(this.panelClose_MouseLeave);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(99, 119);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(239, 20);
            this.txtTelephone.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "Téléphone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelephone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNomPrenom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPseudo);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 153);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(99, 93);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(239, 20);
            this.txtNomPrenom.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Nom et Prénom";
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(99, 15);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(239, 20);
            this.txtPseudo.TabIndex = 104;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 20);
            this.txtEmail.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Pseudo";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(99, 41);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(239, 20);
            this.txtPwd.TabIndex = 105;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModifier);
            this.groupBox2.Controls.Add(this.panelEnregistrer);
            this.groupBox2.Controls.Add(this.panelAnnuler);
            this.groupBox2.Location = new System.Drawing.Point(373, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 153);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            // 
            // panelEnregistrer
            // 
            this.panelEnregistrer.BackColor = System.Drawing.Color.White;
            this.panelEnregistrer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnregistrer.BackgroundImage")));
            this.panelEnregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEnregistrer.Controls.Add(this.labelEnregistrer);
            this.panelEnregistrer.Location = new System.Drawing.Point(9, 14);
            this.panelEnregistrer.Name = "panelEnregistrer";
            this.panelEnregistrer.Size = new System.Drawing.Size(150, 40);
            this.panelEnregistrer.TabIndex = 0;
            this.panelEnregistrer.Visible = false;
//            this.panelEnregistrer.Click += new System.EventHandler(this.labelEnregistrer_Click);
            this.panelEnregistrer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEnregistrer_Paint);
            this.panelEnregistrer.MouseEnter += new System.EventHandler(this.panelEnregistrer_MouseEnter);
            this.panelEnregistrer.MouseLeave += new System.EventHandler(this.panelEnregistrer_MouseLeave);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.White;
            this.btnModifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModifier.BackgroundImage")));
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModifier.Controls.Add(this.labelModifier);
            this.btnModifier.Location = new System.Drawing.Point(9, 14);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(150, 40);
            this.btnModifier.TabIndex = 109;
            this.btnModifier.Click += new System.EventHandler(this.labelModifier_Click);
            this.btnModifier.Paint += new System.Windows.Forms.PaintEventHandler(this.btnModifier_Paint);
            this.btnModifier.MouseEnter += new System.EventHandler(this.btnModifier_MouseEnter);
            this.btnModifier.MouseLeave += new System.EventHandler(this.btnModifier_MouseLeave);
            // 
            // labelModifier
            // 
            this.labelModifier.AutoSize = true;
            this.labelModifier.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelModifier.Location = new System.Drawing.Point(68, 11);
            this.labelModifier.Name = "labelModifier";
            this.labelModifier.Size = new System.Drawing.Size(42, 16);
            this.labelModifier.TabIndex = 0;
            this.labelModifier.Text = "Editer";
            this.labelModifier.Click += new System.EventHandler(this.labelModifier_Click);
            // 
            // labelEnregistrer
            // 
            this.labelEnregistrer.AutoSize = true;
            this.labelEnregistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelEnregistrer.Location = new System.Drawing.Point(67, 13);
            this.labelEnregistrer.Name = "labelEnregistrer";
            this.labelEnregistrer.Size = new System.Drawing.Size(57, 13);
            this.labelEnregistrer.TabIndex = 82;
            this.labelEnregistrer.Text = "Enregistrer";
      //      this.labelEnregistrer.Click += new System.EventHandler(this.labelEnregistrer_Click);
            this.labelEnregistrer.MouseEnter += new System.EventHandler(this.panelEnregistrer_MouseEnter);
            this.labelEnregistrer.MouseLeave += new System.EventHandler(this.panelEnregistrer_MouseLeave);
            // 
            // panelAnnuler
            // 
            this.panelAnnuler.BackColor = System.Drawing.Color.White;
            this.panelAnnuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAnnuler.BackgroundImage")));
            this.panelAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAnnuler.Controls.Add(this.labelAnnuler);
            this.panelAnnuler.Location = new System.Drawing.Point(9, 67);
            this.panelAnnuler.Name = "panelAnnuler";
            this.panelAnnuler.Size = new System.Drawing.Size(150, 40);
            this.panelAnnuler.TabIndex = 1;
            this.panelAnnuler.Visible = false;
            this.panelAnnuler.Click += new System.EventHandler(this.panelAnnuler_Click_1);
            this.panelAnnuler.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAnnuler_Paint);
            this.panelAnnuler.MouseEnter += new System.EventHandler(this.panelAnnuler_MouseEnter);
            this.panelAnnuler.MouseLeave += new System.EventHandler(this.panelAnnuler_MouseLeave);
            // 
            // labelAnnuler
            // 
            this.labelAnnuler.AutoSize = true;
            this.labelAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelAnnuler.Location = new System.Drawing.Point(73, 13);
            this.labelAnnuler.Name = "labelAnnuler";
            this.labelAnnuler.Size = new System.Drawing.Size(43, 13);
            this.labelAnnuler.TabIndex = 81;
            this.labelAnnuler.Text = "Annuler";
            this.labelAnnuler.Click += new System.EventHandler(this.panelAnnuler_Click_1);
            this.labelAnnuler.MouseEnter += new System.EventHandler(this.panelAnnuler_MouseEnter);
            this.labelAnnuler.MouseLeave += new System.EventHandler(this.panelAnnuler_MouseLeave);
            // 
            // GestionCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 205);
            this.Controls.Add(this.panelTitre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionCompte";
            this.Load += new System.EventHandler(this.GestionCompte_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GestionCompte_Paint);
            this.panelTitre.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panelEnregistrer.ResumeLayout(false);
            this.panelEnregistrer.PerformLayout();
            this.btnModifier.ResumeLayout(false);
            this.btnModifier.PerformLayout();
            this.panelAnnuler.ResumeLayout(false);
            this.panelAnnuler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelEnregistrer;
        private System.Windows.Forms.Label labelEnregistrer;
        private System.Windows.Forms.Panel panelAnnuler;
        private System.Windows.Forms.Label labelAnnuler;
        private System.Windows.Forms.Panel btnModifier;
        private System.Windows.Forms.Label labelModifier;


    }
}