namespace GestionDesDoctorantsV2
{
    partial class HistoriqueCursusUniv
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoriqueCursusUniv));
            this.DGVResponsabilite = new System.Windows.Forms.DataGridView();
            this.Année = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diplome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mention = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Institution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Panel();
            this.labelSupprimer = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Panel();
            this.labelModifier = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Panel();
            this.labelAjouter = new System.Windows.Forms.Label();
            this.panelTitre = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInstitution = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnnee = new System.Windows.Forms.ComboBox();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.txtSpecialite = new System.Windows.Forms.TextBox();
            this.lblSpecialite = new System.Windows.Forms.Label();
            this.cmbMention = new System.Windows.Forms.ComboBox();
            this.lblMention = new System.Windows.Forms.Label();
            this.cmbDiplome = new System.Windows.Forms.ComboBox();
            this.lblDiplome = new System.Windows.Forms.Label();
            this.panelEnregistrer = new System.Windows.Forms.Panel();
            this.labelEnregistrer = new System.Windows.Forms.Label();
            this.panelAnnuler = new System.Windows.Forms.Panel();
            this.labelAnnuler = new System.Windows.Forms.Label();
            this.ErreurDateDebutFr = new System.Windows.Forms.Label();
            this.ErreurResponsabiliteFr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVResponsabilite)).BeginInit();
            this.panel2.SuspendLayout();
            this.btnSupprimer.SuspendLayout();
            this.btnModifier.SuspendLayout();
            this.btnAjouter.SuspendLayout();
            this.panelTitre.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelEnregistrer.SuspendLayout();
            this.panelAnnuler.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVResponsabilite
            // 
            this.DGVResponsabilite.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVResponsabilite.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVResponsabilite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVResponsabilite.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVResponsabilite.BackgroundColor = System.Drawing.Color.White;
            this.DGVResponsabilite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVResponsabilite.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVResponsabilite.ColumnHeadersHeight = 40;
            this.DGVResponsabilite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVResponsabilite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Année,
            this.Diplome,
            this.Specialite,
            this.Mention,
            this.Institution});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVResponsabilite.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVResponsabilite.EnableHeadersVisualStyles = false;
            this.DGVResponsabilite.Location = new System.Drawing.Point(3, 0);
            this.DGVResponsabilite.MultiSelect = false;
            this.DGVResponsabilite.Name = "DGVResponsabilite";
            this.DGVResponsabilite.RowHeadersWidth = 25;
            this.DGVResponsabilite.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVResponsabilite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVResponsabilite.Size = new System.Drawing.Size(616, 139);
            this.DGVResponsabilite.TabIndex = 302;
            this.DGVResponsabilite.Paint += new System.Windows.Forms.PaintEventHandler(this.DGVResponsabilite_Paint);
            this.DGVResponsabilite.DoubleClick += new System.EventHandler(this.btnModifyResponsabilite_Click);
            // 
            // Année
            // 
            this.Année.HeaderText = "Année";
            this.Année.Name = "Année";
            // 
            // Diplome
            // 
            this.Diplome.HeaderText = "Diplôme";
            this.Diplome.Name = "Diplome";
            // 
            // Specialite
            // 
            this.Specialite.HeaderText = "Spécialité";
            this.Specialite.Name = "Specialite";
            // 
            // Mention
            // 
            this.Mention.HeaderText = "Mention";
            this.Mention.Name = "Mention";
            // 
            // Institution
            // 
            this.Institution.HeaderText = "Institution";
            this.Institution.Name = "Institution";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSupprimer);
            this.panel2.Controls.Add(this.btnModifier);
            this.panel2.Controls.Add(this.btnAjouter);
            this.panel2.Controls.Add(this.DGVResponsabilite);
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 204);
            this.panel2.TabIndex = 418;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.White;
            this.btnSupprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.BackgroundImage")));
            this.btnSupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupprimer.Controls.Add(this.labelSupprimer);
            this.btnSupprimer.Location = new System.Drawing.Point(461, 153);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(150, 40);
            this.btnSupprimer.TabIndex = 425;
            this.btnSupprimer.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSupprimer_Paint);
            this.btnSupprimer.MouseEnter += new System.EventHandler(this.btnSupprimer_MouseEnter);
            this.btnSupprimer.MouseLeave += new System.EventHandler(this.btnSupprimer_MouseLeave);
            // 
            // labelSupprimer
            // 
            this.labelSupprimer.AutoSize = true;
            this.labelSupprimer.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelSupprimer.Location = new System.Drawing.Point(79, 11);
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
            this.btnModifier.Location = new System.Drawing.Point(305, 153);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(150, 40);
            this.btnModifier.TabIndex = 424;
            this.btnModifier.Click += new System.EventHandler(this.btnModifyResponsabilite_Click);
            this.btnModifier.Paint += new System.Windows.Forms.PaintEventHandler(this.btnModifier_Paint);
            this.btnModifier.MouseEnter += new System.EventHandler(this.btnModifier_MouseEnter);
            this.btnModifier.MouseLeave += new System.EventHandler(this.btnModifier_MouseLeave);
            // 
            // labelModifier
            // 
            this.labelModifier.AutoSize = true;
            this.labelModifier.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelModifier.Location = new System.Drawing.Point(90, 11);
            this.labelModifier.Name = "labelModifier";
            this.labelModifier.Size = new System.Drawing.Size(42, 16);
            this.labelModifier.TabIndex = 0;
            this.labelModifier.Text = "Editer";
            this.labelModifier.Click += new System.EventHandler(this.btnModifyResponsabilite_Click);
            this.labelModifier.MouseEnter += new System.EventHandler(this.btnModifier_MouseEnter);
            this.labelModifier.MouseLeave += new System.EventHandler(this.btnModifier_MouseLeave);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjouter.BackgroundImage")));
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouter.Controls.Add(this.labelAjouter);
            this.btnAjouter.Location = new System.Drawing.Point(149, 153);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(150, 40);
            this.btnAjouter.TabIndex = 423;
            this.btnAjouter.Click += new System.EventHandler(this.btnAddResponsabilite_Click);
            this.btnAjouter.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAjouter_Paint);
            this.btnAjouter.MouseEnter += new System.EventHandler(this.btnAjouter_MouseEnter);
            this.btnAjouter.MouseLeave += new System.EventHandler(this.btnAjouter_MouseLeave);
            // 
            // labelAjouter
            // 
            this.labelAjouter.AutoSize = true;
            this.labelAjouter.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelAjouter.Location = new System.Drawing.Point(90, 11);
            this.labelAjouter.Name = "labelAjouter";
            this.labelAjouter.Size = new System.Drawing.Size(49, 16);
            this.labelAjouter.TabIndex = 0;
            this.labelAjouter.Text = "Ajouter";
            this.labelAjouter.Click += new System.EventHandler(this.btnAddResponsabilite_Click);
            this.labelAjouter.MouseEnter += new System.EventHandler(this.btnAjouter_MouseEnter);
            this.labelAjouter.MouseLeave += new System.EventHandler(this.btnAjouter_MouseLeave);
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panelTitre.Controls.Add(this.panelClose);
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(622, 42);
            this.panelTitre.TabIndex = 417;
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.Transparent;
            this.panelClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelClose.BackgroundImage")));
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelClose.Location = new System.Drawing.Point(581, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(40, 42);
            this.panelClose.TabIndex = 26;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            this.panelClose.MouseEnter += new System.EventHandler(this.panelClose_MouseEnter);
            this.panelClose.MouseLeave += new System.EventHandler(this.panelClose_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtInstitution);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbAnnee);
            this.panel1.Controls.Add(this.lblAnnee);
            this.panel1.Controls.Add(this.txtSpecialite);
            this.panel1.Controls.Add(this.lblSpecialite);
            this.panel1.Controls.Add(this.cmbMention);
            this.panel1.Controls.Add(this.lblMention);
            this.panel1.Controls.Add(this.cmbDiplome);
            this.panel1.Controls.Add(this.lblDiplome);
            this.panel1.Controls.Add(this.panelEnregistrer);
            this.panel1.Controls.Add(this.panelAnnuler);
            this.panel1.Controls.Add(this.ErreurDateDebutFr);
            this.panel1.Controls.Add(this.ErreurResponsabiliteFr);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 204);
            this.panel1.TabIndex = 419;
            this.panel1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(285, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 433;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(285, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 432;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(583, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 431;
            this.label2.Text = "*";
            // 
            // txtInstitution
            // 
            this.txtInstitution.Location = new System.Drawing.Point(75, 81);
            this.txtInstitution.Name = "txtInstitution";
            this.txtInstitution.Size = new System.Drawing.Size(505, 20);
            this.txtInstitution.TabIndex = 430;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 429;
            this.label1.Text = "Institution";
            // 
            // cmbAnnee
            // 
            this.cmbAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnnee.FormattingEnabled = true;
            this.cmbAnnee.Location = new System.Drawing.Point(378, 51);
            this.cmbAnnee.Name = "cmbAnnee";
            this.cmbAnnee.Size = new System.Drawing.Size(202, 21);
            this.cmbAnnee.TabIndex = 428;
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Location = new System.Drawing.Point(322, 60);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(38, 13);
            this.lblAnnee.TabIndex = 427;
            this.lblAnnee.Text = "Année";
            // 
            // txtSpecialite
            // 
            this.txtSpecialite.Location = new System.Drawing.Point(378, 25);
            this.txtSpecialite.Name = "txtSpecialite";
            this.txtSpecialite.Size = new System.Drawing.Size(202, 20);
            this.txtSpecialite.TabIndex = 426;
            // 
            // lblSpecialite
            // 
            this.lblSpecialite.AutoSize = true;
            this.lblSpecialite.Location = new System.Drawing.Point(322, 28);
            this.lblSpecialite.Name = "lblSpecialite";
            this.lblSpecialite.Size = new System.Drawing.Size(56, 13);
            this.lblSpecialite.TabIndex = 425;
            this.lblSpecialite.Text = "Spécialité ";
            // 
            // cmbMention
            // 
            this.cmbMention.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMention.FormattingEnabled = true;
            this.cmbMention.Items.AddRange(new object[] {
            "Passable",
            "Assez bien",
            "Bien",
            "Très bien",
            "Excellent"});
            this.cmbMention.Location = new System.Drawing.Point(75, 52);
            this.cmbMention.Name = "cmbMention";
            this.cmbMention.Size = new System.Drawing.Size(204, 21);
            this.cmbMention.TabIndex = 424;
            // 
            // lblMention
            // 
            this.lblMention.AutoSize = true;
            this.lblMention.Location = new System.Drawing.Point(17, 59);
            this.lblMention.Name = "lblMention";
            this.lblMention.Size = new System.Drawing.Size(45, 13);
            this.lblMention.TabIndex = 423;
            this.lblMention.Text = "Mention";
            // 
            // cmbDiplome
            // 
            this.cmbDiplome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiplome.FormattingEnabled = true;
            this.cmbDiplome.Items.AddRange(new object[] {
            "Licence fondamentale",
            "Licence appliquée",
            "Maitrise",
            "Master de recherche",
            "Master professionnel",
            "Inginiérie",
            "Doctorat",
            "Habilitation"});
            this.cmbDiplome.Location = new System.Drawing.Point(75, 25);
            this.cmbDiplome.Name = "cmbDiplome";
            this.cmbDiplome.Size = new System.Drawing.Size(204, 21);
            this.cmbDiplome.TabIndex = 422;
            // 
            // lblDiplome
            // 
            this.lblDiplome.AutoSize = true;
            this.lblDiplome.Location = new System.Drawing.Point(17, 32);
            this.lblDiplome.Name = "lblDiplome";
            this.lblDiplome.Size = new System.Drawing.Size(45, 13);
            this.lblDiplome.TabIndex = 421;
            this.lblDiplome.Text = "Diplome";
            // 
            // panelEnregistrer
            // 
            this.panelEnregistrer.BackColor = System.Drawing.Color.White;
            this.panelEnregistrer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnregistrer.BackgroundImage")));
            this.panelEnregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEnregistrer.Controls.Add(this.labelEnregistrer);
            this.panelEnregistrer.Location = new System.Drawing.Point(457, 153);
            this.panelEnregistrer.Name = "panelEnregistrer";
            this.panelEnregistrer.Size = new System.Drawing.Size(150, 40);
            this.panelEnregistrer.TabIndex = 420;
            this.panelEnregistrer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEnregistrer_Paint);
            this.panelEnregistrer.MouseEnter += new System.EventHandler(this.panelEnregistrer_MouseEnter);
            this.panelEnregistrer.MouseLeave += new System.EventHandler(this.panelEnregistrer_MouseLeave);
            // 
            // labelEnregistrer
            // 
            this.labelEnregistrer.AutoSize = true;
            this.labelEnregistrer.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelEnregistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelEnregistrer.Location = new System.Drawing.Point(72, 12);
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
            this.panelAnnuler.Location = new System.Drawing.Point(283, 153);
            this.panelAnnuler.Name = "panelAnnuler";
            this.panelAnnuler.Size = new System.Drawing.Size(150, 40);
            this.panelAnnuler.TabIndex = 419;
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
            this.labelAnnuler.Location = new System.Drawing.Point(92, 12);
            this.labelAnnuler.Name = "labelAnnuler";
            this.labelAnnuler.Size = new System.Drawing.Size(52, 16);
            this.labelAnnuler.TabIndex = 81;
            this.labelAnnuler.Text = "Annuler";
            this.labelAnnuler.Click += new System.EventHandler(this.panelAnnuler_Click);
            this.labelAnnuler.MouseEnter += new System.EventHandler(this.panelAnnuler_MouseEnter);
            this.labelAnnuler.MouseLeave += new System.EventHandler(this.panelAnnuler_MouseLeave);
            // 
            // ErreurDateDebutFr
            // 
            this.ErreurDateDebutFr.AutoSize = true;
            this.ErreurDateDebutFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurDateDebutFr.ForeColor = System.Drawing.Color.Red;
            this.ErreurDateDebutFr.Location = new System.Drawing.Point(582, 53);
            this.ErreurDateDebutFr.Name = "ErreurDateDebutFr";
            this.ErreurDateDebutFr.Size = new System.Drawing.Size(14, 16);
            this.ErreurDateDebutFr.TabIndex = 413;
            this.ErreurDateDebutFr.Text = "*";
            // 
            // ErreurResponsabiliteFr
            // 
            this.ErreurResponsabiliteFr.AutoSize = true;
            this.ErreurResponsabiliteFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurResponsabiliteFr.ForeColor = System.Drawing.Color.Red;
            this.ErreurResponsabiliteFr.Location = new System.Drawing.Point(582, 25);
            this.ErreurResponsabiliteFr.Name = "ErreurResponsabiliteFr";
            this.ErreurResponsabiliteFr.Size = new System.Drawing.Size(14, 16);
            this.ErreurResponsabiliteFr.TabIndex = 412;
            this.ErreurResponsabiliteFr.Text = "*";
            // 
            // HistoriqueResponsabiliteFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 250);
            this.Controls.Add(this.panelTitre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoriqueResponsabiliteFr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoriqueResponsabiliteFr";
            this.Load += new System.EventHandler(this.HistoriqueResponsabiliteFr_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HistoriqueResponsabiliteFr_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.DGVResponsabilite)).EndInit();
            this.panel2.ResumeLayout(false);
            this.btnSupprimer.ResumeLayout(false);
            this.btnSupprimer.PerformLayout();
            this.btnModifier.ResumeLayout(false);
            this.btnModifier.PerformLayout();
            this.btnAjouter.ResumeLayout(false);
            this.btnAjouter.PerformLayout();
            this.panelTitre.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEnregistrer.ResumeLayout(false);
            this.panelEnregistrer.PerformLayout();
            this.panelAnnuler.ResumeLayout(false);
            this.panelAnnuler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVResponsabilite;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTitre;
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
        private System.Windows.Forms.Label ErreurDateDebutFr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Année;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diplome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mention;
        private System.Windows.Forms.DataGridViewTextBoxColumn Institution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInstitution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnnee;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.TextBox txtSpecialite;
        private System.Windows.Forms.Label lblSpecialite;
        private System.Windows.Forms.ComboBox cmbMention;
        private System.Windows.Forms.Label lblMention;
        private System.Windows.Forms.ComboBox cmbDiplome;
        private System.Windows.Forms.Label lblDiplome;
        private System.Windows.Forms.Label ErreurResponsabiliteFr;
    }
}