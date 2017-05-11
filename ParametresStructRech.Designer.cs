namespace GestionDesDoctorantsV2
{
    partial class ParametresStructRech
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParametresStructRech));
            this.groupBoxRecherche = new System.Windows.Forms.Panel();
            this.groupBoxBoutton = new System.Windows.Forms.Panel();
            this.groupBoxGrid = new System.Windows.Forms.GroupBox();
            this.DGVStructRech = new System.Windows.Forms.DataGridView();
            this.CodeStructRech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomStructRech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtablissementStructRech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSupprimer = new System.Windows.Forms.Panel();
            this.labelSupprimer = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Panel();
            this.labelAjouter = new System.Windows.Forms.Label();
            this.btnImprimer = new System.Windows.Forms.Panel();
            this.labelImprimer = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Panel();
            this.labelModifier = new System.Windows.Forms.Label();
            this.groupBoxBoutton.SuspendLayout();
            this.groupBoxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStructRech)).BeginInit();
            this.btnSupprimer.SuspendLayout();
            this.btnAjouter.SuspendLayout();
            this.btnImprimer.SuspendLayout();
            this.btnModifier.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRecherche
            // 
            this.groupBoxRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.groupBoxRecherche.Location = new System.Drawing.Point(10, 10);
            this.groupBoxRecherche.Name = "groupBoxRecherche";
            this.groupBoxRecherche.Size = new System.Drawing.Size(701, 60);
            this.groupBoxRecherche.TabIndex = 31;
            this.groupBoxRecherche.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxRecherche_Paint);
            // 
            // groupBoxBoutton
            // 
            this.groupBoxBoutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.groupBoxBoutton.Controls.Add(this.btnSupprimer);
            this.groupBoxBoutton.Controls.Add(this.btnAjouter);
            this.groupBoxBoutton.Controls.Add(this.btnImprimer);
            this.groupBoxBoutton.Controls.Add(this.btnModifier);
            this.groupBoxBoutton.Location = new System.Drawing.Point(541, 85);
            this.groupBoxBoutton.Name = "groupBoxBoutton";
            this.groupBoxBoutton.Size = new System.Drawing.Size(170, 282);
            this.groupBoxBoutton.TabIndex = 32;
            this.groupBoxBoutton.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxBoutton_Paint);
            // 
            // groupBoxGrid
            // 
            this.groupBoxGrid.Controls.Add(this.DGVStructRech);
            this.groupBoxGrid.Location = new System.Drawing.Point(10, 79);
            this.groupBoxGrid.Name = "groupBoxGrid";
            this.groupBoxGrid.Size = new System.Drawing.Size(525, 289);
            this.groupBoxGrid.TabIndex = 30;
            this.groupBoxGrid.TabStop = false;
            // 
            // DGVStructRech
            // 
            this.DGVStructRech.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVStructRech.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVStructRech.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVStructRech.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVStructRech.BackgroundColor = System.Drawing.Color.White;
            this.DGVStructRech.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStructRech.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVStructRech.ColumnHeadersHeight = 40;
            this.DGVStructRech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVStructRech.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeStructRech,
            this.NomStructRech,
            this.EtablissementStructRech});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVStructRech.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVStructRech.EnableHeadersVisualStyles = false;
            this.DGVStructRech.Location = new System.Drawing.Point(10, 26);
            this.DGVStructRech.MultiSelect = false;
            this.DGVStructRech.Name = "DGVStructRech";
            this.DGVStructRech.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStructRech.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVStructRech.RowHeadersWidth = 25;
            this.DGVStructRech.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVStructRech.Size = new System.Drawing.Size(504, 244);
            this.DGVStructRech.TabIndex = 19;
            this.DGVStructRech.Paint += new System.Windows.Forms.PaintEventHandler(this.DGVGrade_Paint);
            // 
            // CodeStructRech
            // 
            this.CodeStructRech.HeaderText = "Code";
            this.CodeStructRech.Name = "CodeStructRech";
            this.CodeStructRech.ReadOnly = true;
            // 
            // NomStructRech
            // 
            this.NomStructRech.HeaderText = "Nom";
            this.NomStructRech.Name = "NomStructRech";
            this.NomStructRech.ReadOnly = true;
            // 
            // EtablissementStructRech
            // 
            this.EtablissementStructRech.HeaderText = "Etablissement";
            this.EtablissementStructRech.Name = "EtablissementStructRech";
            this.EtablissementStructRech.ReadOnly = true;
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
            this.btnSupprimer.TabIndex = 95;
            this.btnSupprimer.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSupprimer_Paint);
            this.btnSupprimer.MouseEnter += new System.EventHandler(this.btnSupprimer_MouseEnter);
            this.btnSupprimer.MouseLeave += new System.EventHandler(this.btnSupprimer_MouseLeave);
            // 
            // labelSupprimer
            // 
            this.labelSupprimer.AutoSize = true;
            this.labelSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelSupprimer.Location = new System.Drawing.Point(73, 15);
            this.labelSupprimer.Name = "labelSupprimer";
            this.labelSupprimer.Size = new System.Drawing.Size(54, 13);
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
            this.btnAjouter.TabIndex = 92;
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
            this.labelAjouter.Size = new System.Drawing.Size(40, 13);
            this.labelAjouter.TabIndex = 0;
            this.labelAjouter.Text = "Ajouter";
            this.labelAjouter.MouseEnter += new System.EventHandler(this.btnAjouter_MouseEnter);
            this.labelAjouter.MouseLeave += new System.EventHandler(this.btnAjouter_MouseLeave);
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
            this.btnImprimer.TabIndex = 94;
            this.btnImprimer.Paint += new System.Windows.Forms.PaintEventHandler(this.btnImprimer_Paint);
            this.btnImprimer.MouseEnter += new System.EventHandler(this.btnImprimer_MouseEnter);
            this.btnImprimer.MouseLeave += new System.EventHandler(this.btnImprimer_MouseLeave);
            // 
            // labelImprimer
            // 
            this.labelImprimer.AutoSize = true;
            this.labelImprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelImprimer.Location = new System.Drawing.Point(77, 13);
            this.labelImprimer.Name = "labelImprimer";
            this.labelImprimer.Size = new System.Drawing.Size(46, 13);
            this.labelImprimer.TabIndex = 0;
            this.labelImprimer.Text = "Imprimer";
            this.labelImprimer.MouseEnter += new System.EventHandler(this.btnImprimer_MouseEnter);
            this.labelImprimer.MouseLeave += new System.EventHandler(this.btnImprimer_MouseLeave);
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
            this.btnModifier.TabIndex = 93;
            this.btnModifier.Paint += new System.Windows.Forms.PaintEventHandler(this.btnModifier_Paint);
            this.btnModifier.MouseEnter += new System.EventHandler(this.btnModifier_MouseEnter);
            this.btnModifier.MouseLeave += new System.EventHandler(this.btnModifier_MouseLeave);
            // 
            // labelModifier
            // 
            this.labelModifier.AutoSize = true;
            this.labelModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelModifier.Location = new System.Drawing.Point(84, 13);
            this.labelModifier.Name = "labelModifier";
            this.labelModifier.Size = new System.Drawing.Size(34, 13);
            this.labelModifier.TabIndex = 0;
            this.labelModifier.Text = "Editer";
            this.labelModifier.MouseEnter += new System.EventHandler(this.btnModifier_MouseEnter);
            this.labelModifier.MouseLeave += new System.EventHandler(this.btnModifier_MouseLeave);
            // 
            // ParametresStructRech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBoxBoutton);
            this.Controls.Add(this.groupBoxRecherche);
            this.Controls.Add(this.groupBoxGrid);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ParametresStructRech";
            this.Size = new System.Drawing.Size(725, 383);
            this.Load += new System.EventHandler(this.ParametresGrade_Load);
            this.groupBoxBoutton.ResumeLayout(false);
            this.groupBoxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStructRech)).EndInit();
            this.btnSupprimer.ResumeLayout(false);
            this.btnSupprimer.PerformLayout();
            this.btnAjouter.ResumeLayout(false);
            this.btnAjouter.PerformLayout();
            this.btnImprimer.ResumeLayout(false);
            this.btnImprimer.PerformLayout();
            this.btnModifier.ResumeLayout(false);
            this.btnModifier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnSupprimer;
        private System.Windows.Forms.Label labelSupprimer;
        private System.Windows.Forms.Panel btnImprimer;
        private System.Windows.Forms.Label labelImprimer;
        private System.Windows.Forms.Panel btnModifier;
        private System.Windows.Forms.Label labelModifier;
        private System.Windows.Forms.Panel btnAjouter;
        private System.Windows.Forms.Label labelAjouter;
        private System.Windows.Forms.Panel groupBoxBoutton;
        private System.Windows.Forms.Panel groupBoxRecherche;
        private System.Windows.Forms.GroupBox groupBoxGrid;
        private System.Windows.Forms.DataGridView DGVStructRech;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeStructRech;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomStructRech;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtablissementStructRech;
    }
}
