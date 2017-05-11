namespace GestionDesDoctorantsV2
{
    partial class HistoriqueStatutFr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoriqueStatutFr));
            this.DGVStatutAdministratif = new System.Windows.Forms.DataGridView();
            this.EtatThese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDeb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat_Dossier_inscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitre = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Panel();
            this.labelSupprimer = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Panel();
            this.labelModifier = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Panel();
            this.labelAjouter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblEtatDossierInscAc = new System.Windows.Forms.Label();
            this.ErreurStatutFr = new System.Windows.Forms.Label();
            this.ErreurDateDebutFr = new System.Windows.Forms.Label();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.txtDebut = new System.Windows.Forms.TextBox();
            this.CalenderFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panelEnregistrer = new System.Windows.Forms.Panel();
            this.labelEnregistrer = new System.Windows.Forms.Label();
            this.panelAnnuler = new System.Windows.Forms.Panel();
            this.labelAnnuler = new System.Windows.Forms.Label();
            this.CalenderDebut = new System.Windows.Forms.DateTimePicker();
            this.cmbStatut = new System.Windows.Forms.ComboBox();
            this.labelDateDebutFr = new System.Windows.Forms.Label();
            this.labelEtatThèse = new System.Windows.Forms.Label();
            this.labelObservationFr = new System.Windows.Forms.Label();
            this.txtObservation = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStatutAdministratif)).BeginInit();
            this.panelTitre.SuspendLayout();
            this.panel2.SuspendLayout();
            this.btnSupprimer.SuspendLayout();
            this.btnModifier.SuspendLayout();
            this.btnAjouter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelEnregistrer.SuspendLayout();
            this.panelAnnuler.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVStatutAdministratif
            // 
            this.DGVStatutAdministratif.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVStatutAdministratif.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVStatutAdministratif.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVStatutAdministratif.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVStatutAdministratif.BackgroundColor = System.Drawing.Color.White;
            this.DGVStatutAdministratif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStatutAdministratif.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVStatutAdministratif.ColumnHeadersHeight = 40;
            this.DGVStatutAdministratif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVStatutAdministratif.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EtatThese,
            this.DateDeb,
            this.Column1,
            this.Etat_Dossier_inscription});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVStatutAdministratif.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVStatutAdministratif.EnableHeadersVisualStyles = false;
            this.DGVStatutAdministratif.Location = new System.Drawing.Point(17, 14);
            this.DGVStatutAdministratif.MultiSelect = false;
            this.DGVStatutAdministratif.Name = "DGVStatutAdministratif";
            this.DGVStatutAdministratif.RowHeadersWidth = 25;
            this.DGVStatutAdministratif.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVStatutAdministratif.Size = new System.Drawing.Size(554, 162);
            this.DGVStatutAdministratif.TabIndex = 302;
            this.DGVStatutAdministratif.Paint += new System.Windows.Forms.PaintEventHandler(this.DGVStatutAdministratif_Paint);
            // 
            // EtatThese
            // 
            this.EtatThese.HeaderText = "Etat thèse";
            this.EtatThese.Name = "EtatThese";
            // 
            // DateDeb
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateDeb.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateDeb.HeaderText = "Date Début";
            this.DateDeb.Name = "DateDeb";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date Fin";
            this.Column1.Name = "Column1";
            // 
            // Etat_Dossier_inscription
            // 
            this.Etat_Dossier_inscription.HeaderText = "Etat Dossier inscription";
            this.Etat_Dossier_inscription.Name = "Etat_Dossier_inscription";
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panelTitre.Controls.Add(this.panelClose);
            this.panelTitre.Location = new System.Drawing.Point(3, 0);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(562, 42);
            this.panelTitre.TabIndex = 425;
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.Transparent;
            this.panelClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelClose.BackgroundImage")));
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelClose.Location = new System.Drawing.Point(521, -1);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(40, 42);
            this.panelClose.TabIndex = 28;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            this.panelClose.MouseEnter += new System.EventHandler(this.panelClose_MouseEnter);
            this.panelClose.MouseLeave += new System.EventHandler(this.panelClose_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSupprimer);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnModifier);
            this.panel2.Controls.Add(this.btnAjouter);
            this.panel2.Controls.Add(this.DGVStatutAdministratif);
            this.panel2.Location = new System.Drawing.Point(12, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 267);
            this.panel2.TabIndex = 424;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.White;
            this.btnSupprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.BackgroundImage")));
            this.btnSupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupprimer.Controls.Add(this.labelSupprimer);
            this.btnSupprimer.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnSupprimer.Location = new System.Drawing.Point(382, 208);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(140, 40);
            this.btnSupprimer.TabIndex = 431;
            this.btnSupprimer.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSupprimer_Paint);
            this.btnSupprimer.MouseEnter += new System.EventHandler(this.btnSupprimer_MouseEnter);
            this.btnSupprimer.MouseLeave += new System.EventHandler(this.btnSupprimer_MouseLeave);
            // 
            // labelSupprimer
            // 
            this.labelSupprimer.AutoSize = true;
            this.labelSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelSupprimer.Location = new System.Drawing.Point(70, 13);
            this.labelSupprimer.Name = "labelSupprimer";
            this.labelSupprimer.Size = new System.Drawing.Size(67, 16);
            this.labelSupprimer.TabIndex = 80;
            this.labelSupprimer.Text = "Supprimer";
            this.labelSupprimer.MouseEnter += new System.EventHandler(this.btnSupprimer_MouseEnter);
            this.labelSupprimer.MouseLeave += new System.EventHandler(this.btnSupprimer_MouseLeave);
            // 
            // btnModifier
            // 
            this.btnModifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModifier.BackgroundImage")));
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModifier.Controls.Add(this.labelModifier);
            this.btnModifier.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnModifier.Location = new System.Drawing.Point(202, 208);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(140, 40);
            this.btnModifier.TabIndex = 430;
            this.btnModifier.Paint += new System.Windows.Forms.PaintEventHandler(this.btnModifier_Paint);
            this.btnModifier.MouseEnter += new System.EventHandler(this.btnModifier_MouseEnter);
            this.btnModifier.MouseLeave += new System.EventHandler(this.btnModifier_MouseLeave);
            // 
            // labelModifier
            // 
            this.labelModifier.AutoSize = true;
            this.labelModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelModifier.Location = new System.Drawing.Point(81, 13);
            this.labelModifier.Name = "labelModifier";
            this.labelModifier.Size = new System.Drawing.Size(42, 16);
            this.labelModifier.TabIndex = 0;
            this.labelModifier.Text = "Editer";
            this.labelModifier.MouseEnter += new System.EventHandler(this.btnModifier_MouseEnter);
            this.labelModifier.MouseLeave += new System.EventHandler(this.btnModifier_MouseLeave);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjouter.BackgroundImage")));
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouter.Controls.Add(this.labelAjouter);
            this.btnAjouter.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnAjouter.Location = new System.Drawing.Point(18, 208);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(140, 40);
            this.btnAjouter.TabIndex = 429;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            this.btnAjouter.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAjouter_Paint);
            this.btnAjouter.MouseEnter += new System.EventHandler(this.btnAjouter_MouseEnter);
            this.btnAjouter.MouseLeave += new System.EventHandler(this.btnAjouter_MouseLeave);
            // 
            // labelAjouter
            // 
            this.labelAjouter.AutoSize = true;
            this.labelAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelAjouter.Location = new System.Drawing.Point(84, 13);
            this.labelAjouter.Name = "labelAjouter";
            this.labelAjouter.Size = new System.Drawing.Size(49, 16);
            this.labelAjouter.TabIndex = 0;
            this.labelAjouter.Text = "Ajouter";
            this.labelAjouter.Click += new System.EventHandler(this.btnAddStatut_Click);
            this.labelAjouter.MouseEnter += new System.EventHandler(this.btnAjouter_MouseEnter);
            this.labelAjouter.MouseLeave += new System.EventHandler(this.btnAjouter_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblEtatDossierInscAc);
            this.panel1.Controls.Add(this.ErreurStatutFr);
            this.panel1.Controls.Add(this.ErreurDateDebutFr);
            this.panel1.Controls.Add(this.txtFin);
            this.panel1.Controls.Add(this.txtDebut);
            this.panel1.Controls.Add(this.CalenderFin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelEnregistrer);
            this.panel1.Controls.Add(this.panelAnnuler);
            this.panel1.Controls.Add(this.CalenderDebut);
            this.panel1.Controls.Add(this.cmbStatut);
            this.panel1.Controls.Add(this.labelDateDebutFr);
            this.panel1.Controls.Add(this.labelEtatThèse);
            this.panel1.Controls.Add(this.labelObservationFr);
            this.panel1.Controls.Add(this.txtObservation);
            this.panel1.Location = new System.Drawing.Point(9, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 270);
            this.panel1.TabIndex = 432;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(518, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 426;
            this.label1.Text = "*";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Paiement",
            "Inscrit"});
            this.comboBox1.Location = new System.Drawing.Point(205, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 21);
            this.comboBox1.TabIndex = 425;
            // 
            // lblEtatDossierInscAc
            // 
            this.lblEtatDossierInscAc.AutoSize = true;
            this.lblEtatDossierInscAc.Location = new System.Drawing.Point(24, 97);
            this.lblEtatDossierInscAc.Name = "lblEtatDossierInscAc";
            this.lblEtatDossierInscAc.Size = new System.Drawing.Size(175, 13);
            this.lblEtatDossierInscAc.TabIndex = 424;
            this.lblEtatDossierInscAc.Text = "Etat du dossier d\'inscription actuelle";
            // 
            // ErreurStatutFr
            // 
            this.ErreurStatutFr.AutoSize = true;
            this.ErreurStatutFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurStatutFr.ForeColor = System.Drawing.Color.Red;
            this.ErreurStatutFr.Location = new System.Drawing.Point(518, 18);
            this.ErreurStatutFr.Name = "ErreurStatutFr";
            this.ErreurStatutFr.Size = new System.Drawing.Size(14, 16);
            this.ErreurStatutFr.TabIndex = 412;
            this.ErreurStatutFr.Text = "*";
            // 
            // ErreurDateDebutFr
            // 
            this.ErreurDateDebutFr.AutoSize = true;
            this.ErreurDateDebutFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurDateDebutFr.ForeColor = System.Drawing.Color.Red;
            this.ErreurDateDebutFr.Location = new System.Drawing.Point(518, 41);
            this.ErreurDateDebutFr.Name = "ErreurDateDebutFr";
            this.ErreurDateDebutFr.Size = new System.Drawing.Size(14, 16);
            this.ErreurDateDebutFr.TabIndex = 413;
            this.ErreurDateDebutFr.Text = "*";
            // 
            // txtFin
            // 
            this.txtFin.BackColor = System.Drawing.Color.White;
            this.txtFin.ForeColor = System.Drawing.Color.Black;
            this.txtFin.Location = new System.Drawing.Point(205, 66);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(288, 20);
            this.txtFin.TabIndex = 423;
            // 
            // txtDebut
            // 
            this.txtDebut.BackColor = System.Drawing.Color.White;
            this.txtDebut.ForeColor = System.Drawing.Color.Black;
            this.txtDebut.Location = new System.Drawing.Point(205, 40);
            this.txtDebut.Name = "txtDebut";
            this.txtDebut.Size = new System.Drawing.Size(288, 20);
            this.txtDebut.TabIndex = 422;
            // 
            // CalenderFin
            // 
            this.CalenderFin.CalendarForeColor = System.Drawing.Color.Black;
            this.CalenderFin.CalendarMonthBackground = System.Drawing.Color.White;
            this.CalenderFin.Location = new System.Drawing.Point(493, 66);
            this.CalenderFin.Name = "CalenderFin";
            this.CalenderFin.Size = new System.Drawing.Size(19, 20);
            this.CalenderFin.TabIndex = 421;
            this.CalenderFin.ValueChanged += new System.EventHandler(this.CalenderFin_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 419;
            this.label2.Text = "Date Fin";
            // 
            // panelEnregistrer
            // 
            this.panelEnregistrer.BackColor = System.Drawing.Color.White;
            this.panelEnregistrer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnregistrer.BackgroundImage")));
            this.panelEnregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEnregistrer.Controls.Add(this.labelEnregistrer);
            this.panelEnregistrer.Location = new System.Drawing.Point(372, 211);
            this.panelEnregistrer.Name = "panelEnregistrer";
            this.panelEnregistrer.Size = new System.Drawing.Size(140, 40);
            this.panelEnregistrer.TabIndex = 418;
            this.panelEnregistrer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEnregistrer_Paint);
            this.panelEnregistrer.MouseEnter += new System.EventHandler(this.panelEnregistrer_MouseEnter);
            this.panelEnregistrer.MouseLeave += new System.EventHandler(this.panelEnregistrer_MouseLeave);
            // 
            // labelEnregistrer
            // 
            this.labelEnregistrer.AutoSize = true;
            this.labelEnregistrer.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelEnregistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelEnregistrer.Location = new System.Drawing.Point(64, 11);
            this.labelEnregistrer.Name = "labelEnregistrer";
            this.labelEnregistrer.Size = new System.Drawing.Size(71, 16);
            this.labelEnregistrer.TabIndex = 82;
            this.labelEnregistrer.Text = "Enregistrer";
            this.labelEnregistrer.MouseEnter += new System.EventHandler(this.panelEnregistrer_MouseEnter);
            this.labelEnregistrer.MouseLeave += new System.EventHandler(this.panelEnregistrer_MouseLeave);
            // 
            // panelAnnuler
            // 
            this.panelAnnuler.BackColor = System.Drawing.Color.White;
            this.panelAnnuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAnnuler.BackgroundImage")));
            this.panelAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAnnuler.Controls.Add(this.labelAnnuler);
            this.panelAnnuler.Location = new System.Drawing.Point(205, 211);
            this.panelAnnuler.Name = "panelAnnuler";
            this.panelAnnuler.Size = new System.Drawing.Size(140, 40);
            this.panelAnnuler.TabIndex = 417;
            this.panelAnnuler.Click += new System.EventHandler(this.panelAnnuler_Click);
            this.panelAnnuler.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAnnuler_Paint);
            this.panelAnnuler.MouseEnter += new System.EventHandler(this.panelAnnuler_MouseEnter);
            this.panelAnnuler.MouseLeave += new System.EventHandler(this.panelAnnuler_MouseLeave);
            // 
            // labelAnnuler
            // 
            this.labelAnnuler.AutoSize = true;
            this.labelAnnuler.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelAnnuler.Location = new System.Drawing.Point(81, 11);
            this.labelAnnuler.Name = "labelAnnuler";
            this.labelAnnuler.Size = new System.Drawing.Size(52, 16);
            this.labelAnnuler.TabIndex = 81;
            this.labelAnnuler.Text = "Annuler";
            this.labelAnnuler.Click += new System.EventHandler(this.panelAnnuler_Click);
            this.labelAnnuler.MouseEnter += new System.EventHandler(this.panelAnnuler_MouseEnter);
            this.labelAnnuler.MouseLeave += new System.EventHandler(this.panelAnnuler_MouseLeave);
            // 
            // CalenderDebut
            // 
            this.CalenderDebut.CalendarForeColor = System.Drawing.Color.Black;
            this.CalenderDebut.CalendarMonthBackground = System.Drawing.Color.White;
            this.CalenderDebut.Location = new System.Drawing.Point(493, 40);
            this.CalenderDebut.Name = "CalenderDebut";
            this.CalenderDebut.Size = new System.Drawing.Size(19, 20);
            this.CalenderDebut.TabIndex = 415;
            this.CalenderDebut.ValueChanged += new System.EventHandler(this.CalenderDebut_ValueChanged);
            // 
            // cmbStatut
            // 
            this.cmbStatut.BackColor = System.Drawing.Color.White;
            this.cmbStatut.ForeColor = System.Drawing.Color.Black;
            this.cmbStatut.FormattingEnabled = true;
            this.cmbStatut.Items.AddRange(new object[] {
            "En Cours",
            "Soutenue",
            "Déposé"});
            this.cmbStatut.Location = new System.Drawing.Point(205, 13);
            this.cmbStatut.Name = "cmbStatut";
            this.cmbStatut.Size = new System.Drawing.Size(307, 21);
            this.cmbStatut.TabIndex = 36;
            // 
            // labelDateDebutFr
            // 
            this.labelDateDebutFr.AutoSize = true;
            this.labelDateDebutFr.Location = new System.Drawing.Point(24, 45);
            this.labelDateDebutFr.Name = "labelDateDebutFr";
            this.labelDateDebutFr.Size = new System.Drawing.Size(62, 13);
            this.labelDateDebutFr.TabIndex = 20;
            this.labelDateDebutFr.Text = "Date Début";
            // 
            // labelEtatThèse
            // 
            this.labelEtatThèse.AutoSize = true;
            this.labelEtatThèse.Location = new System.Drawing.Point(24, 18);
            this.labelEtatThèse.Name = "labelEtatThèse";
            this.labelEtatThèse.Size = new System.Drawing.Size(70, 13);
            this.labelEtatThèse.TabIndex = 22;
            this.labelEtatThèse.Text = "Etat de thèse";
            // 
            // labelObservationFr
            // 
            this.labelObservationFr.AutoSize = true;
            this.labelObservationFr.Location = new System.Drawing.Point(25, 128);
            this.labelObservationFr.Name = "labelObservationFr";
            this.labelObservationFr.Size = new System.Drawing.Size(64, 13);
            this.labelObservationFr.TabIndex = 23;
            this.labelObservationFr.Text = "Observation";
            // 
            // txtObservation
            // 
            this.txtObservation.BackColor = System.Drawing.Color.White;
            this.txtObservation.ForeColor = System.Drawing.Color.Black;
            this.txtObservation.Location = new System.Drawing.Point(205, 128);
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(307, 52);
            this.txtObservation.TabIndex = 28;
            this.txtObservation.Text = "";
            // 
            // HistoriqueStatutFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 315);
            this.Controls.Add(this.panelTitre);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoriqueStatutFr";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoriqueStatutFr";
            this.Load += new System.EventHandler(this.HistoriqueStatutFr_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HistoriqueStatutFr_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStatutAdministratif)).EndInit();
            this.panelTitre.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.btnSupprimer.ResumeLayout(false);
            this.btnSupprimer.PerformLayout();
            this.btnModifier.ResumeLayout(false);
            this.btnModifier.PerformLayout();
            this.btnAjouter.ResumeLayout(false);
            this.btnAjouter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEnregistrer.ResumeLayout(false);
            this.panelEnregistrer.PerformLayout();
            this.panelAnnuler.ResumeLayout(false);
            this.panelAnnuler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVStatutAdministratif;
        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Panel btnSupprimer;
        private System.Windows.Forms.Label labelSupprimer;
        private System.Windows.Forms.Panel btnModifier;
        private System.Windows.Forms.Label labelModifier;
        private System.Windows.Forms.Panel btnAjouter;
        private System.Windows.Forms.Label labelAjouter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelEnregistrer;
        private System.Windows.Forms.Label labelEnregistrer;
        private System.Windows.Forms.Panel panelAnnuler;
        private System.Windows.Forms.Label labelAnnuler;
        private System.Windows.Forms.DateTimePicker CalenderDebut;
        private System.Windows.Forms.Label ErreurDateDebutFr;
        private System.Windows.Forms.Label ErreurStatutFr;
        private System.Windows.Forms.ComboBox cmbStatut;
        private System.Windows.Forms.Label labelDateDebutFr;
        private System.Windows.Forms.Label labelEtatThèse;
        private System.Windows.Forms.Label labelObservationFr;
        private System.Windows.Forms.RichTextBox txtObservation;
        private System.Windows.Forms.DateTimePicker CalenderFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.TextBox txtDebut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblEtatDossierInscAc;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtatThese;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat_Dossier_inscription;

    }
}