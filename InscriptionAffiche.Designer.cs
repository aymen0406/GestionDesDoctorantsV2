namespace GestionDesDoctorantsV2
{
    partial class InscriptionAffiche
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscriptionAffiche));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxBoutton = new System.Windows.Forms.Panel();
            this.groupBoxRecherche = new System.Windows.Forms.Panel();
            this.labelCritere = new System.Windows.Forms.Label();
            this.cmbValeurFr = new System.Windows.Forms.ComboBox();
            this.cmbCritereFr = new System.Windows.Forms.ComboBox();
            this.labelValeur = new System.Windows.Forms.Label();
            this.DGVInscription = new System.Windows.Forms.DataGridView();
            this.btnSupprimer = new System.Windows.Forms.Panel();
            this.labelSupprimer = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Panel();
            this.labelAjouter = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Panel();
            this.labelModifier = new System.Windows.Forms.Label();
            this.btnImprimer = new System.Windows.Forms.Panel();
            this.labelImprimer = new System.Windows.Forms.Label();
            this.btnChercher = new System.Windows.Forms.Panel();
            this.CIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnneUniv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Niveau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commentaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBoxBoutton.SuspendLayout();
            this.groupBoxRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInscription)).BeginInit();
            this.btnSupprimer.SuspendLayout();
            this.btnAjouter.SuspendLayout();
            this.btnModifier.SuspendLayout();
            this.btnImprimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBoxBoutton);
            this.panel1.Controls.Add(this.groupBoxRecherche);
            this.panel1.Controls.Add(this.DGVInscription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 533);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxBoutton
            // 
            this.groupBoxBoutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.groupBoxBoutton.Controls.Add(this.btnSupprimer);
            this.groupBoxBoutton.Controls.Add(this.btnAjouter);
            this.groupBoxBoutton.Controls.Add(this.btnModifier);
            this.groupBoxBoutton.Controls.Add(this.btnImprimer);
            this.groupBoxBoutton.Location = new System.Drawing.Point(761, 22);
            this.groupBoxBoutton.Name = "groupBoxBoutton";
            this.groupBoxBoutton.Size = new System.Drawing.Size(170, 409);
            this.groupBoxBoutton.TabIndex = 37;
            this.groupBoxBoutton.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxBoutton_Paint);
            // 
            // groupBoxRecherche
            // 
            this.groupBoxRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.groupBoxRecherche.Controls.Add(this.btnChercher);
            this.groupBoxRecherche.Controls.Add(this.labelCritere);
            this.groupBoxRecherche.Controls.Add(this.cmbValeurFr);
            this.groupBoxRecherche.Controls.Add(this.cmbCritereFr);
            this.groupBoxRecherche.Controls.Add(this.labelValeur);
            this.groupBoxRecherche.Location = new System.Drawing.Point(3, 22);
            this.groupBoxRecherche.Name = "groupBoxRecherche";
            this.groupBoxRecherche.Size = new System.Drawing.Size(752, 60);
            this.groupBoxRecherche.TabIndex = 36;
            this.groupBoxRecherche.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxRecherche_Paint);
            // 
            // labelCritere
            // 
            this.labelCritere.AutoSize = true;
            this.labelCritere.Location = new System.Drawing.Point(24, 22);
            this.labelCritere.Name = "labelCritere";
            this.labelCritere.Size = new System.Drawing.Size(61, 13);
            this.labelCritere.TabIndex = 8;
            this.labelCritere.Text = "Afficher par";
            // 
            // cmbValeurFr
            // 
            this.cmbValeurFr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbValeurFr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbValeurFr.BackColor = System.Drawing.Color.White;
            this.cmbValeurFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValeurFr.ForeColor = System.Drawing.Color.Black;
            this.cmbValeurFr.FormattingEnabled = true;
            this.cmbValeurFr.Location = new System.Drawing.Point(376, 18);
            this.cmbValeurFr.Name = "cmbValeurFr";
            this.cmbValeurFr.Size = new System.Drawing.Size(209, 21);
            this.cmbValeurFr.TabIndex = 10;
            // 
            // cmbCritereFr
            // 
            this.cmbCritereFr.AutoCompleteCustomSource.AddRange(new string[] {
            "CIN",
            "Nom",
            "Prénom"});
            this.cmbCritereFr.BackColor = System.Drawing.Color.White;
            this.cmbCritereFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCritereFr.ForeColor = System.Drawing.Color.Black;
            this.cmbCritereFr.FormattingEnabled = true;
            this.cmbCritereFr.Items.AddRange(new object[] {
            "Tous",
            "CIN",
            "NomPrénom",
            "Niveau",
            "Année universitaire"});
            this.cmbCritereFr.Location = new System.Drawing.Point(94, 18);
            this.cmbCritereFr.Name = "cmbCritereFr";
            this.cmbCritereFr.Size = new System.Drawing.Size(197, 21);
            this.cmbCritereFr.TabIndex = 7;
            // 
            // labelValeur
            // 
            this.labelValeur.AutoSize = true;
            this.labelValeur.Location = new System.Drawing.Point(333, 21);
            this.labelValeur.Name = "labelValeur";
            this.labelValeur.Size = new System.Drawing.Size(37, 13);
            this.labelValeur.TabIndex = 9;
            this.labelValeur.Text = "Valeur";
            // 
            // DGVInscription
            // 
            this.DGVInscription.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVInscription.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVInscription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVInscription.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVInscription.BackgroundColor = System.Drawing.Color.White;
            this.DGVInscription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVInscription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVInscription.ColumnHeadersHeight = 40;
            this.DGVInscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVInscription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIN,
            this.NomPrenom,
            this.AnneUniv,
            this.Niveau,
            this.Commentaire});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVInscription.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGVInscription.EnableHeadersVisualStyles = false;
            this.DGVInscription.GridColor = System.Drawing.Color.Silver;
            this.DGVInscription.Location = new System.Drawing.Point(3, 94);
            this.DGVInscription.MultiSelect = false;
            this.DGVInscription.Name = "DGVInscription";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVInscription.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGVInscription.RowHeadersWidth = 24;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.DGVInscription.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVInscription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVInscription.Size = new System.Drawing.Size(752, 412);
            this.DGVInscription.TabIndex = 35;
            this.DGVInscription.Paint += new System.Windows.Forms.PaintEventHandler(this.DGVEnseignant_Paint);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.White;
            this.btnSupprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.BackgroundImage")));
            this.btnSupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupprimer.Controls.Add(this.labelSupprimer);
            this.btnSupprimer.Location = new System.Drawing.Point(10, 102);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(150, 40);
            this.btnSupprimer.TabIndex = 108;
            this.btnSupprimer.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSupprimer_Paint);
            this.btnSupprimer.MouseEnter += new System.EventHandler(this.btnSupprimer_MouseEnter);
            this.btnSupprimer.MouseLeave += new System.EventHandler(this.btnSupprimer_MouseLeave);
            // 
            // labelSupprimer
            // 
            this.labelSupprimer.AutoSize = true;
            this.labelSupprimer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelSupprimer.Location = new System.Drawing.Point(73, 13);
            this.labelSupprimer.Name = "labelSupprimer";
            this.labelSupprimer.Size = new System.Drawing.Size(67, 16);
            this.labelSupprimer.TabIndex = 80;
            this.labelSupprimer.Text = "Supprimer";
            this.labelSupprimer.MouseEnter += new System.EventHandler(this.btnSupprimer_MouseEnter);
            this.labelSupprimer.MouseLeave += new System.EventHandler(this.btnSupprimer_MouseLeave);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.White;
            this.btnAjouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjouter.BackgroundImage")));
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouter.Controls.Add(this.labelAjouter);
            this.btnAjouter.Location = new System.Drawing.Point(10, 10);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(150, 40);
            this.btnAjouter.TabIndex = 69;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            this.btnAjouter.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAjouter_Paint);
            this.btnAjouter.MouseEnter += new System.EventHandler(this.btnAjouter_MouseEnter);
            this.btnAjouter.MouseLeave += new System.EventHandler(this.btnAjouter_MouseLeave);
            // 
            // labelAjouter
            // 
            this.labelAjouter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelAjouter.Location = new System.Drawing.Point(88, 9);
            this.labelAjouter.Name = "labelAjouter";
            this.labelAjouter.Size = new System.Drawing.Size(52, 23);
            this.labelAjouter.TabIndex = 0;
            this.labelAjouter.Text = "Ajouter";
            this.labelAjouter.MouseEnter += new System.EventHandler(this.btnAjouter_MouseEnter);
            this.labelAjouter.MouseLeave += new System.EventHandler(this.btnAjouter_MouseLeave);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.White;
            this.btnModifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModifier.BackgroundImage")));
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModifier.Controls.Add(this.labelModifier);
            this.btnModifier.Location = new System.Drawing.Point(10, 56);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(150, 40);
            this.btnModifier.TabIndex = 70;
            this.btnModifier.Paint += new System.Windows.Forms.PaintEventHandler(this.btnModifier_Paint);
            this.btnModifier.MouseEnter += new System.EventHandler(this.btnModifier_MouseEnter);
            this.btnModifier.MouseLeave += new System.EventHandler(this.btnModifier_MouseLeave);
            // 
            // labelModifier
            // 
            this.labelModifier.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelModifier.Location = new System.Drawing.Point(96, 9);
            this.labelModifier.Name = "labelModifier";
            this.labelModifier.Size = new System.Drawing.Size(44, 18);
            this.labelModifier.TabIndex = 0;
            this.labelModifier.Text = "Editer";
            this.labelModifier.MouseEnter += new System.EventHandler(this.btnModifier_MouseEnter);
            this.labelModifier.MouseLeave += new System.EventHandler(this.btnModifier_MouseLeave);
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.Color.White;
            this.btnImprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimer.BackgroundImage")));
            this.btnImprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimer.Controls.Add(this.labelImprimer);
            this.btnImprimer.Location = new System.Drawing.Point(10, 148);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(150, 40);
            this.btnImprimer.TabIndex = 72;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            this.btnImprimer.Paint += new System.Windows.Forms.PaintEventHandler(this.btnImprimer_Paint);
            this.btnImprimer.MouseEnter += new System.EventHandler(this.btnImprimer_MouseEnter);
            this.btnImprimer.MouseLeave += new System.EventHandler(this.btnImprimer_MouseLeave);
            // 
            // labelImprimer
            // 
            this.labelImprimer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelImprimer.Location = new System.Drawing.Point(81, 10);
            this.labelImprimer.Name = "labelImprimer";
            this.labelImprimer.Size = new System.Drawing.Size(59, 18);
            this.labelImprimer.TabIndex = 0;
            this.labelImprimer.Text = "Imprimer";
            this.labelImprimer.MouseEnter += new System.EventHandler(this.btnImprimer_MouseEnter);
            this.labelImprimer.MouseLeave += new System.EventHandler(this.btnImprimer_MouseLeave);
            // 
            // btnChercher
            // 
            this.btnChercher.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChercher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChercher.BackgroundImage")));
            this.btnChercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChercher.Location = new System.Drawing.Point(635, 18);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(75, 21);
            this.btnChercher.TabIndex = 18;
            this.btnChercher.Paint += new System.Windows.Forms.PaintEventHandler(this.btnChercher_Paint);
            this.btnChercher.MouseEnter += new System.EventHandler(this.btnChercher_MouseEnter);
            this.btnChercher.MouseLeave += new System.EventHandler(this.btnChercher_MouseLeave);
            // 
            // CIN
            // 
            this.CIN.HeaderText = "CIN";
            this.CIN.Name = "CIN";
            // 
            // NomPrenom
            // 
            this.NomPrenom.HeaderText = "Nom et prénom";
            this.NomPrenom.Name = "NomPrenom";
            // 
            // AnneUniv
            // 
            this.AnneUniv.HeaderText = "Année universitaire";
            this.AnneUniv.Name = "AnneUniv";
            // 
            // Niveau
            // 
            this.Niveau.HeaderText = "Niveau";
            this.Niveau.Name = "Niveau";
            // 
            // Commentaire
            // 
            this.Commentaire.HeaderText = "Commentaire";
            this.Commentaire.Name = "Commentaire";
            // 
            // InscriptionAffiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "InscriptionAffiche";
            this.Size = new System.Drawing.Size(938, 533);
            this.Load += new System.EventHandler(this.InscriptionAffiche_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxBoutton.ResumeLayout(false);
            this.groupBoxRecherche.ResumeLayout(false);
            this.groupBoxRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInscription)).EndInit();
            this.btnSupprimer.ResumeLayout(false);
            this.btnSupprimer.PerformLayout();
            this.btnAjouter.ResumeLayout(false);
            this.btnModifier.ResumeLayout(false);
            this.btnImprimer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVInscription;
        private System.Windows.Forms.Panel btnImprimer;
        private System.Windows.Forms.Label labelImprimer;
        private System.Windows.Forms.Panel btnModifier;
        private System.Windows.Forms.Label labelModifier;
        private System.Windows.Forms.Panel btnAjouter;
        private System.Windows.Forms.Label labelAjouter;
        private System.Windows.Forms.Panel btnSupprimer;
        private System.Windows.Forms.Label labelSupprimer;
        private System.Windows.Forms.Panel btnChercher;
        private System.Windows.Forms.Panel groupBoxRecherche;
        private System.Windows.Forms.Panel groupBoxBoutton;
        private System.Windows.Forms.Label labelCritere;
        private System.Windows.Forms.ComboBox cmbValeurFr;
        private System.Windows.Forms.ComboBox cmbCritereFr;
        private System.Windows.Forms.Label labelValeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnneUniv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Niveau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commentaire;
    }
}
