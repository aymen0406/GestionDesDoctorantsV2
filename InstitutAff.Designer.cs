namespace GestionDesDoctorantsV2
{
    partial class InstitutAff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstitutAff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGVInstitut = new System.Windows.Forms.DataGridView();
            this.NomEtablissement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxRecherche = new System.Windows.Forms.Panel();
            this.btnChercher = new System.Windows.Forms.Panel();
            this.labelCritere = new System.Windows.Forms.Label();
            this.cmbValeurFr = new System.Windows.Forms.ComboBox();
            this.cmbCritereFr = new System.Windows.Forms.ComboBox();
            this.labelValeur = new System.Windows.Forms.Label();
            this.groupBoxBoutton = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Panel();
            this.labelSupprimer = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Panel();
            this.labelAjouter = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Panel();
            this.labelModifier = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInstitut)).BeginInit();
            this.groupBoxRecherche.SuspendLayout();
            this.groupBoxBoutton.SuspendLayout();
            this.btnSupprimer.SuspendLayout();
            this.btnAjouter.SuspendLayout();
            this.btnModifier.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGVInstitut);
            this.panel1.Controls.Add(this.groupBoxRecherche);
            this.panel1.Controls.Add(this.groupBoxBoutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 533);
            this.panel1.TabIndex = 0;
            // 
            // DGVInstitut
            // 
            this.DGVInstitut.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVInstitut.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVInstitut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVInstitut.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVInstitut.BackgroundColor = System.Drawing.Color.White;
            this.DGVInstitut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVInstitut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVInstitut.ColumnHeadersHeight = 40;
            this.DGVInstitut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVInstitut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomEtablissement,
            this.Pays,
            this.Ville});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVInstitut.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVInstitut.EnableHeadersVisualStyles = false;
            this.DGVInstitut.GridColor = System.Drawing.Color.Silver;
            this.DGVInstitut.Location = new System.Drawing.Point(3, 94);
            this.DGVInstitut.MultiSelect = false;
            this.DGVInstitut.Name = "DGVInstitut";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVInstitut.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVInstitut.RowHeadersWidth = 24;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.DGVInstitut.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVInstitut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVInstitut.Size = new System.Drawing.Size(752, 412);
            this.DGVInstitut.TabIndex = 110;
            this.DGVInstitut.Paint += new System.Windows.Forms.PaintEventHandler(this.DGVInstitut_Paint);
            // 
            // NomEtablissement
            // 
            this.NomEtablissement.HeaderText = "Nom Etablissement";
            this.NomEtablissement.Name = "NomEtablissement";
            // 
            // Pays
            // 
            this.Pays.HeaderText = "Pays Etablissement";
            this.Pays.Name = "Pays";
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville Etablissement";
            this.Ville.Name = "Ville";
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
            this.groupBoxRecherche.TabIndex = 109;
            this.groupBoxRecherche.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxRecherche_Paint);
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
            // groupBoxBoutton
            // 
            this.groupBoxBoutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.groupBoxBoutton.Controls.Add(this.btnSupprimer);
            this.groupBoxBoutton.Controls.Add(this.btnAjouter);
            this.groupBoxBoutton.Controls.Add(this.btnModifier);
            this.groupBoxBoutton.Location = new System.Drawing.Point(761, 22);
            this.groupBoxBoutton.Name = "groupBoxBoutton";
            this.groupBoxBoutton.Size = new System.Drawing.Size(170, 409);
            this.groupBoxBoutton.TabIndex = 38;
            this.groupBoxBoutton.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxBoutton_Paint);
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
            // 
            // InstitutAff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "InstitutAff";
            this.Size = new System.Drawing.Size(938, 533);
            this.Load += new System.EventHandler(this.InstitutAff_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVInstitut)).EndInit();
            this.groupBoxRecherche.ResumeLayout(false);
            this.groupBoxRecherche.PerformLayout();
            this.groupBoxBoutton.ResumeLayout(false);
            this.btnSupprimer.ResumeLayout(false);
            this.btnSupprimer.PerformLayout();
            this.btnAjouter.ResumeLayout(false);
            this.btnModifier.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel groupBoxBoutton;
        private System.Windows.Forms.Panel btnSupprimer;
        private System.Windows.Forms.Label labelSupprimer;
        private System.Windows.Forms.Panel btnAjouter;
        private System.Windows.Forms.Label labelAjouter;
        private System.Windows.Forms.Panel btnModifier;
        private System.Windows.Forms.Label labelModifier;
        private System.Windows.Forms.Panel groupBoxRecherche;
        private System.Windows.Forms.Panel btnChercher;
        private System.Windows.Forms.Label labelCritere;
        private System.Windows.Forms.ComboBox cmbValeurFr;
        private System.Windows.Forms.ComboBox cmbCritereFr;
        private System.Windows.Forms.Label labelValeur;
        private System.Windows.Forms.DataGridView DGVInstitut;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEtablissement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
    }
}
