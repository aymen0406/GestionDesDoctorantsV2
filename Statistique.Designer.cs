namespace GestionDesDoctorantsV2
{
    partial class Statistique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistique));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Télephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.cmbSexeFr = new System.Windows.Forms.ComboBox();
            this.labelSexe = new System.Windows.Forms.Label();
            this.cmbStatutFr = new System.Windows.Forms.ComboBox();
            this.labelStatut = new System.Windows.Forms.Label();
            this.cmbGradeFr = new System.Windows.Forms.ComboBox();
            this.labelGrade = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Département = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDepartementFr = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDepartement = new System.Windows.Forms.Label();
            this.CIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExporter = new System.Windows.Forms.Panel();
            this.labelExporter = new System.Windows.Forms.Label();
            this.btnImprimer = new System.Windows.Forms.Panel();
            this.labelImprimer = new System.Windows.Forms.Label();
            this.btnChercher = new System.Windows.Forms.Panel();
            this.labelChercher = new System.Windows.Forms.Label();
            this.Sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVStatistique = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.btnExporter.SuspendLayout();
            this.btnImprimer.SuspendLayout();
            this.btnChercher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStatistique)).BeginInit();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom et Prénom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Matricule
            // 
            this.Matricule.HeaderText = "Matricule";
            this.Matricule.Name = "Matricule";
            this.Matricule.ReadOnly = true;
            // 
            // Télephone
            // 
            this.Télephone.HeaderText = "Télephone";
            this.Télephone.Name = "Télephone";
            this.Télephone.ReadOnly = true;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.ForeColor = System.Drawing.Color.Black;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Permanent",
            "Contractuel",
            "Vacataire",
            "Expert"});
            this.cmbType.Location = new System.Drawing.Point(10, 201);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(150, 21);
            this.cmbType.TabIndex = 1;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(10, 183);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(81, 13);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Type Admission";
            // 
            // cmbSexeFr
            // 
            this.cmbSexeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexeFr.FormattingEnabled = true;
            this.cmbSexeFr.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cmbSexeFr.Location = new System.Drawing.Point(10, 157);
            this.cmbSexeFr.Name = "cmbSexeFr";
            this.cmbSexeFr.Size = new System.Drawing.Size(150, 21);
            this.cmbSexeFr.TabIndex = 1;
            // 
            // labelSexe
            // 
            this.labelSexe.AutoSize = true;
            this.labelSexe.Location = new System.Drawing.Point(10, 139);
            this.labelSexe.Name = "labelSexe";
            this.labelSexe.Size = new System.Drawing.Size(31, 13);
            this.labelSexe.TabIndex = 0;
            this.labelSexe.Text = "Sexe";
            // 
            // cmbStatutFr
            // 
            this.cmbStatutFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatutFr.ForeColor = System.Drawing.Color.Black;
            this.cmbStatutFr.FormattingEnabled = true;
            this.cmbStatutFr.Location = new System.Drawing.Point(10, 113);
            this.cmbStatutFr.Name = "cmbStatutFr";
            this.cmbStatutFr.Size = new System.Drawing.Size(150, 21);
            this.cmbStatutFr.TabIndex = 1;
            // 
            // labelStatut
            // 
            this.labelStatut.AutoSize = true;
            this.labelStatut.Location = new System.Drawing.Point(10, 95);
            this.labelStatut.Name = "labelStatut";
            this.labelStatut.Size = new System.Drawing.Size(35, 13);
            this.labelStatut.TabIndex = 0;
            this.labelStatut.Text = "Statut";
            // 
            // cmbGradeFr
            // 
            this.cmbGradeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradeFr.FormattingEnabled = true;
            this.cmbGradeFr.Location = new System.Drawing.Point(10, 69);
            this.cmbGradeFr.Name = "cmbGradeFr";
            this.cmbGradeFr.Size = new System.Drawing.Size(150, 21);
            this.cmbGradeFr.TabIndex = 1;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(10, 51);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(36, 13);
            this.labelGrade.TabIndex = 0;
            this.labelGrade.Text = "Grade";
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // Département
            // 
            this.Département.HeaderText = "Département";
            this.Département.Name = "Département";
            this.Département.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // Statut
            // 
            this.Statut.HeaderText = "Statut";
            this.Statut.Name = "Statut";
            this.Statut.ReadOnly = true;
            // 
            // cmbDepartementFr
            // 
            this.cmbDepartementFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartementFr.ForeColor = System.Drawing.Color.Black;
            this.cmbDepartementFr.FormattingEnabled = true;
            this.cmbDepartementFr.Location = new System.Drawing.Point(10, 25);
            this.cmbDepartementFr.Name = "cmbDepartementFr";
            this.cmbDepartementFr.Size = new System.Drawing.Size(150, 21);
            this.cmbDepartementFr.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Type Admission";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // labelDepartement
            // 
            this.labelDepartement.AutoSize = true;
            this.labelDepartement.Location = new System.Drawing.Point(10, 7);
            this.labelDepartement.Name = "labelDepartement";
            this.labelDepartement.Size = new System.Drawing.Size(68, 13);
            this.labelDepartement.TabIndex = 0;
            this.labelDepartement.Text = "Département";
            // 
            // CIN
            // 
            this.CIN.HeaderText = "CIN";
            this.CIN.Name = "CIN";
            this.CIN.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.btnExporter);
            this.panel1.Controls.Add(this.btnImprimer);
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Controls.Add(this.labelType);
            this.panel1.Controls.Add(this.cmbSexeFr);
            this.panel1.Controls.Add(this.labelSexe);
            this.panel1.Controls.Add(this.cmbStatutFr);
            this.panel1.Controls.Add(this.labelStatut);
            this.panel1.Controls.Add(this.cmbGradeFr);
            this.panel1.Controls.Add(this.labelGrade);
            this.panel1.Controls.Add(this.cmbDepartementFr);
            this.panel1.Controls.Add(this.btnChercher);
            this.panel1.Controls.Add(this.labelDepartement);
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 438);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnExporter
            // 
            this.btnExporter.BackColor = System.Drawing.Color.White;
            this.btnExporter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExporter.BackgroundImage")));
            this.btnExporter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExporter.Controls.Add(this.labelExporter);
            this.btnExporter.Location = new System.Drawing.Point(10, 329);
            this.btnExporter.Name = "btnExporter";
            this.btnExporter.Size = new System.Drawing.Size(150, 40);
            this.btnExporter.TabIndex = 76;
            this.btnExporter.Paint += new System.Windows.Forms.PaintEventHandler(this.btnExporter_Paint);
            this.btnExporter.MouseEnter += new System.EventHandler(this.btnExporter_MouseEnter);
            this.btnExporter.MouseLeave += new System.EventHandler(this.btnExporter_MouseLeave);
            // 
            // labelExporter
            // 
            this.labelExporter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExporter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelExporter.Location = new System.Drawing.Point(66, 10);
            this.labelExporter.Name = "labelExporter";
            this.labelExporter.Size = new System.Drawing.Size(59, 18);
            this.labelExporter.TabIndex = 0;
            this.labelExporter.Text = "Exporter";
            this.labelExporter.Click += new System.EventHandler(this.labelExporter_Click);
            this.labelExporter.MouseEnter += new System.EventHandler(this.btnExporter_MouseEnter);
            this.labelExporter.MouseLeave += new System.EventHandler(this.btnExporter_MouseLeave);
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.Color.White;
            this.btnImprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimer.BackgroundImage")));
            this.btnImprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimer.Controls.Add(this.labelImprimer);
            this.btnImprimer.Location = new System.Drawing.Point(10, 283);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(150, 40);
            this.btnImprimer.TabIndex = 75;
    //        this.btnImprimer.Click += new System.EventHandler(this.labelImprimer_Click);
            this.btnImprimer.Paint += new System.Windows.Forms.PaintEventHandler(this.btnImprimer_Paint);
            this.btnImprimer.MouseEnter += new System.EventHandler(this.btnImprimer_MouseEnter);
            this.btnImprimer.MouseLeave += new System.EventHandler(this.btnImprimer_MouseLeave);
            // 
            // labelImprimer
            // 
            this.labelImprimer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelImprimer.Location = new System.Drawing.Point(65, 10);
            this.labelImprimer.Name = "labelImprimer";
            this.labelImprimer.Size = new System.Drawing.Size(59, 18);
            this.labelImprimer.TabIndex = 0;
            this.labelImprimer.Text = "Imprimer";
        //    this.labelImprimer.Click += new System.EventHandler(this.labelImprimer_Click);
            this.labelImprimer.MouseEnter += new System.EventHandler(this.btnImprimer_MouseEnter);
            this.labelImprimer.MouseLeave += new System.EventHandler(this.btnImprimer_MouseLeave);
            // 
            // btnChercher
            // 
            this.btnChercher.BackColor = System.Drawing.Color.White;
            this.btnChercher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChercher.BackgroundImage")));
            this.btnChercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChercher.Controls.Add(this.labelChercher);
            this.btnChercher.Location = new System.Drawing.Point(10, 237);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(150, 40);
            this.btnChercher.TabIndex = 19;
         //   this.btnChercher.Click += new System.EventHandler(this.labelChercher_Click);
            this.btnChercher.Paint += new System.Windows.Forms.PaintEventHandler(this.btnChercher_Paint);
            this.btnChercher.MouseEnter += new System.EventHandler(this.btnChercher_MouseEnter);
            this.btnChercher.MouseLeave += new System.EventHandler(this.btnChercher_MouseLeave);
            // 
            // labelChercher
            // 
            this.labelChercher.AutoSize = true;
            this.labelChercher.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelChercher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelChercher.Location = new System.Drawing.Point(63, 11);
            this.labelChercher.Name = "labelChercher";
            this.labelChercher.Size = new System.Drawing.Size(60, 16);
            this.labelChercher.TabIndex = 0;
            this.labelChercher.Text = "Chercher";
   //         this.labelChercher.Click += new System.EventHandler(this.labelChercher_Click);
            this.labelChercher.MouseEnter += new System.EventHandler(this.btnChercher_MouseEnter);
            this.labelChercher.MouseLeave += new System.EventHandler(this.btnChercher_MouseLeave);
            // 
            // Sexe
            // 
            this.Sexe.HeaderText = "Sexe";
            this.Sexe.Name = "Sexe";
            this.Sexe.ReadOnly = true;
            // 
            // DGVStatistique
            // 
            this.DGVStatistique.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVStatistique.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVStatistique.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVStatistique.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVStatistique.BackgroundColor = System.Drawing.Color.White;
            this.DGVStatistique.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStatistique.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVStatistique.ColumnHeadersHeight = 40;
            this.DGVStatistique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVStatistique.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.CIN,
            this.Matricule,
            this.Télephone,
            this.Mail,
            this.Département,
            this.Grade,
            this.Statut,
            this.Sexe,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVStatistique.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVStatistique.EnableHeadersVisualStyles = false;
            this.DGVStatistique.Location = new System.Drawing.Point(192, 23);
            this.DGVStatistique.MultiSelect = false;
            this.DGVStatistique.Name = "DGVStatistique";
            this.DGVStatistique.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStatistique.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVStatistique.RowHeadersWidth = 25;
            this.DGVStatistique.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVStatistique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVStatistique.Size = new System.Drawing.Size(633, 438);
            this.DGVStatistique.TabIndex = 16;
            this.DGVStatistique.Paint += new System.Windows.Forms.PaintEventHandler(this.DGVStatistique_Paint);
            // 
            // Statistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGVStatistique);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Statistique";
            this.Size = new System.Drawing.Size(840, 483);
            this.Load += new System.EventHandler(this.Statistiques_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.btnExporter.ResumeLayout(false);
            this.btnImprimer.ResumeLayout(false);
            this.btnChercher.ResumeLayout(false);
            this.btnChercher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStatistique)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Télephone;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox cmbSexeFr;
        private System.Windows.Forms.Label labelSexe;
        private System.Windows.Forms.ComboBox cmbStatutFr;
        private System.Windows.Forms.Label labelStatut;
        private System.Windows.Forms.ComboBox cmbGradeFr;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Département;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;
        private System.Windows.Forms.ComboBox cmbDepartementFr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel btnChercher;
        private System.Windows.Forms.Label labelChercher;
        private System.Windows.Forms.Label labelDepartement;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexe;
        private System.Windows.Forms.DataGridView DGVStatistique;
        private System.Windows.Forms.Panel btnExporter;
        private System.Windows.Forms.Label labelExporter;
        private System.Windows.Forms.Panel btnImprimer;
        private System.Windows.Forms.Label labelImprimer;
    }
}
