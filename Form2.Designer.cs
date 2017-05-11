namespace GestionDesDoctorantsV2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labeldate = new System.Windows.Forms.Label();
            this.labelTitre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelRubban = new System.Windows.Forms.Panel();
            this.labelTitreForm = new System.Windows.Forms.Label();
            this.MenuCompte = new System.Windows.Forms.Panel();
            this.MenuContactFr = new System.Windows.Forms.Panel();
            this.panelTitre = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuSoutenance = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.MenuParametres = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuInscription = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.MenuDoctorants = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuStatistique = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelRubban.SuspendLayout();
            this.panelTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuSoutenance.SuspendLayout();
            this.MenuParametres.SuspendLayout();
            this.MenuInscription.SuspendLayout();
            this.MenuDoctorants.SuspendLayout();
            this.MenuStatistique.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labeldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.labeldate.Location = new System.Drawing.Point(324, 12);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(57, 20);
            this.labeldate.TabIndex = 1;
            this.labeldate.Text = "label1";
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.labelTitre.Location = new System.Drawing.Point(21, 12);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(259, 25);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Gestion des Doctorants";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(15, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 82);
            this.panel1.TabIndex = 27;
            this.panel1.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(102, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(804, 406);
            this.panel4.TabIndex = 26;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panelRubban
            // 
            this.panelRubban.BackColor = System.Drawing.Color.White;
            this.panelRubban.Controls.Add(this.labelTitreForm);
            this.panelRubban.Controls.Add(this.MenuCompte);
            this.panelRubban.Controls.Add(this.MenuContactFr);
            this.panelRubban.Location = new System.Drawing.Point(119, 54);
            this.panelRubban.Name = "panelRubban";
            this.panelRubban.Size = new System.Drawing.Size(781, 63);
            this.panelRubban.TabIndex = 27;
            this.panelRubban.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRubban_Paint);
            // 
            // labelTitreForm
            // 
            this.labelTitreForm.AutoSize = true;
            this.labelTitreForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelTitreForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.labelTitreForm.Location = new System.Drawing.Point(30, 24);
            this.labelTitreForm.Name = "labelTitreForm";
            this.labelTitreForm.Size = new System.Drawing.Size(51, 16);
            this.labelTitreForm.TabIndex = 42;
            this.labelTitreForm.Text = "label1";
            this.labelTitreForm.Visible = false;
            // 
            // MenuCompte
            // 
            this.MenuCompte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuCompte.BackgroundImage")));
            this.MenuCompte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuCompte.Location = new System.Drawing.Point(714, 0);
            this.MenuCompte.Name = "MenuCompte";
            this.MenuCompte.Size = new System.Drawing.Size(64, 60);
            this.MenuCompte.TabIndex = 41;
            this.MenuCompte.Click += new System.EventHandler(this.MenuCompte_Click);
            this.MenuCompte.MouseEnter += new System.EventHandler(this.MenuCompteFr_MouseEnter);
            this.MenuCompte.MouseLeave += new System.EventHandler(this.MenuCompteFr_MouseLeave);
            // 
            // MenuContactFr
            // 
            this.MenuContactFr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuContactFr.BackgroundImage")));
            this.MenuContactFr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuContactFr.Location = new System.Drawing.Point(644, 0);
            this.MenuContactFr.Name = "MenuContactFr";
            this.MenuContactFr.Size = new System.Drawing.Size(64, 60);
            this.MenuContactFr.TabIndex = 40;
            this.MenuContactFr.MouseEnter += new System.EventHandler(this.MenuContactFr_MouseEnter);
            this.MenuContactFr.MouseLeave += new System.EventHandler(this.MenuContactFr_MouseLeave);
            // 
            // panelTitre
            // 
            this.panelTitre.Controls.Add(this.labelTitre);
            this.panelTitre.Controls.Add(this.labeldate);
            this.panelTitre.Location = new System.Drawing.Point(119, 1);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(692, 47);
            this.panelTitre.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 121);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // MenuSoutenance
            // 
            this.MenuSoutenance.BackgroundImage = global::GestionDesDoctorantsV2.Properties.Resources.soutenancefin1;
            this.MenuSoutenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuSoutenance.Controls.Add(this.label7);
            this.MenuSoutenance.Location = new System.Drawing.Point(8, 327);
            this.MenuSoutenance.Name = "MenuSoutenance";
            this.MenuSoutenance.Size = new System.Drawing.Size(80, 80);
            this.MenuSoutenance.TabIndex = 34;
            this.MenuSoutenance.Click += new System.EventHandler(this.MenuSoutenance_Click);
            this.MenuSoutenance.MouseEnter += new System.EventHandler(this.MenuSoutenance_MouseEnter);
            this.MenuSoutenance.MouseLeave += new System.EventHandler(this.MenuSoutenance_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.label7.Location = new System.Drawing.Point(5, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Soutenances";
            // 
            // MenuParametres
            // 
            this.MenuParametres.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuParametres.BackgroundImage")));
            this.MenuParametres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuParametres.Controls.Add(this.label2);
            this.MenuParametres.Location = new System.Drawing.Point(8, 517);
            this.MenuParametres.Name = "MenuParametres";
            this.MenuParametres.Size = new System.Drawing.Size(80, 80);
            this.MenuParametres.TabIndex = 32;
            this.MenuParametres.Click += new System.EventHandler(this.MenuParametresFr_Click);
            this.MenuParametres.MouseEnter += new System.EventHandler(this.MenuParametresFr_MouseEnter);
            this.MenuParametres.MouseLeave += new System.EventHandler(this.MenuParametresFr_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Paramètres";
            this.label2.Click += new System.EventHandler(this.MenuParametresFr_Click);
            this.label2.MouseEnter += new System.EventHandler(this.MenuParametresFr_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.MenuParametresFr_MouseLeave);
            // 
            // MenuInscription
            // 
            this.MenuInscription.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuInscription.BackgroundImage")));
            this.MenuInscription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuInscription.Controls.Add(this.label4);
            this.MenuInscription.Location = new System.Drawing.Point(8, 232);
            this.MenuInscription.Name = "MenuInscription";
            this.MenuInscription.Size = new System.Drawing.Size(80, 80);
            this.MenuInscription.TabIndex = 37;
            this.MenuInscription.Click += new System.EventHandler(this.MenuInscription_Click);
            this.MenuInscription.MouseEnter += new System.EventHandler(this.MenuInscription_MouseEnter);
            this.MenuInscription.MouseLeave += new System.EventHandler(this.MenuInscription_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.label4.Location = new System.Drawing.Point(13, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Inscriptions";
           
            // 
            // MenuDoctorants
            // 
            this.MenuDoctorants.BackgroundImage = global::GestionDesDoctorantsV2.Properties.Resources.doctorant;
            this.MenuDoctorants.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuDoctorants.Controls.Add(this.label1);
            this.MenuDoctorants.Location = new System.Drawing.Point(8, 137);
            this.MenuDoctorants.Name = "MenuDoctorants";
            this.MenuDoctorants.Size = new System.Drawing.Size(80, 80);
            this.MenuDoctorants.TabIndex = 29;
            this.MenuDoctorants.Click += new System.EventHandler(this.MenuDoctorants_Click);
            this.MenuDoctorants.MouseEnter += new System.EventHandler(this.MenuDoctorants_MouseEnter);
            this.MenuDoctorants.MouseLeave += new System.EventHandler(this.MenuDoctorants_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Doctorants";
            // 
            // MenuStatistique
            // 
            this.MenuStatistique.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuStatistique.BackgroundImage")));
            this.MenuStatistique.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuStatistique.Controls.Add(this.label3);
            this.MenuStatistique.Location = new System.Drawing.Point(8, 422);
            this.MenuStatistique.Name = "MenuStatistique";
            this.MenuStatistique.Size = new System.Drawing.Size(80, 80);
            this.MenuStatistique.TabIndex = 38;
            this.MenuStatistique.Click += new System.EventHandler(this.MenuStatistique_Click);
            this.MenuStatistique.MouseEnter += new System.EventHandler(this.MenuStatistiqueFr_MouseEnter);
            this.MenuStatistique.MouseLeave += new System.EventHandler(this.MenuStatistiqueFr_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Statistiques";
            this.label3.MouseEnter += new System.EventHandler(this.MenuStatistiqueFr_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.MenuStatistiqueFr_MouseLeave);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1009, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTitre);
            this.Controls.Add(this.MenuSoutenance);
            this.Controls.Add(this.MenuParametres);
            this.Controls.Add(this.panelRubban);
            this.Controls.Add(this.MenuInscription);
            this.Controls.Add(this.MenuDoctorants);
            this.Controls.Add(this.MenuStatistique);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelRubban.ResumeLayout(false);
            this.panelRubban.PerformLayout();
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuSoutenance.ResumeLayout(false);
            this.MenuSoutenance.PerformLayout();
            this.MenuParametres.ResumeLayout(false);
            this.MenuParametres.PerformLayout();
            this.MenuInscription.ResumeLayout(false);
            this.MenuInscription.PerformLayout();
            this.MenuDoctorants.ResumeLayout(false);
            this.MenuDoctorants.PerformLayout();
            this.MenuStatistique.ResumeLayout(false);
            this.MenuStatistique.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MenuDoctorants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MenuParametres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel MenuSoutenance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel MenuInscription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel MenuStatistique;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelRubban;
        private System.Windows.Forms.Panel MenuCompte;
        private System.Windows.Forms.Panel MenuContactFr;
        private System.Windows.Forms.Label labelTitreForm;
        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}