namespace GestionDesDoctorantsV2
{
    partial class CompteFr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompteFr));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxBoutton = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Panel();
            this.labelSupprimer = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Panel();
            this.labelAjouter = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Panel();
            this.labelModifier = new System.Windows.Forms.Label();
            this.groupBoxRecherche = new System.Windows.Forms.Panel();
            this.groupBoxGrid = new System.Windows.Forms.GroupBox();
            this.DGVComptes = new System.Windows.Forms.DataGridView();
            this.IntituleAbrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntituleFr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntituleAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxBoutton.SuspendLayout();
            this.btnSupprimer.SuspendLayout();
            this.btnAjouter.SuspendLayout();
            this.btnModifier.SuspendLayout();
            this.groupBoxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVComptes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBoutton
            // 
            this.groupBoxBoutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.groupBoxBoutton.Controls.Add(this.btnSupprimer);
            this.groupBoxBoutton.Controls.Add(this.btnAjouter);
            this.groupBoxBoutton.Controls.Add(this.btnModifier);
            this.groupBoxBoutton.Location = new System.Drawing.Point(661, 14);
            this.groupBoxBoutton.Name = "groupBoxBoutton";
            this.groupBoxBoutton.Size = new System.Drawing.Size(170, 362);
            this.groupBoxBoutton.TabIndex = 57;
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
            this.btnSupprimer.TabIndex = 79;
       //     this.btnSupprimer.Click += new System.EventHandler(this.labelSupprimer_Click);
            this.btnSupprimer.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSupprimer_Paint);
            this.btnSupprimer.MouseEnter += new System.EventHandler(this.btnSupprimer_MouseEnter);
            this.btnSupprimer.MouseLeave += new System.EventHandler(this.btnSupprimer_MouseLeave);
            // 
            // labelSupprimer
            // 
            this.labelSupprimer.AutoSize = true;
            this.labelSupprimer.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelSupprimer.Location = new System.Drawing.Point(73, 11);
            this.labelSupprimer.Name = "labelSupprimer";
            this.labelSupprimer.Size = new System.Drawing.Size(67, 16);
            this.labelSupprimer.TabIndex = 80;
            this.labelSupprimer.Text = "Supprimer";
    //        this.labelSupprimer.Click += new System.EventHandler(this.labelSupprimer_Click);
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
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Click += new System.EventHandler(this.labelAjouter_Click);
            this.btnAjouter.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAjouter_Paint);
            this.btnAjouter.MouseEnter += new System.EventHandler(this.btnAjouter_MouseEnter);
            this.btnAjouter.MouseLeave += new System.EventHandler(this.btnAjouter_MouseLeave);
            // 
            // labelAjouter
            // 
            this.labelAjouter.AutoSize = true;
            this.labelAjouter.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelAjouter.Location = new System.Drawing.Point(73, 11);
            this.labelAjouter.Name = "labelAjouter";
            this.labelAjouter.Size = new System.Drawing.Size(49, 16);
            this.labelAjouter.TabIndex = 0;
            this.labelAjouter.Text = "Ajouter";
            this.labelAjouter.Click += new System.EventHandler(this.labelAjouter_Click);
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
            this.btnModifier.TabIndex = 1;
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
            this.labelModifier.Location = new System.Drawing.Point(73, 11);
            this.labelModifier.Name = "labelModifier";
            this.labelModifier.Size = new System.Drawing.Size(42, 16);
            this.labelModifier.TabIndex = 0;
            this.labelModifier.Text = "Editer";
            this.labelModifier.Click += new System.EventHandler(this.labelModifier_Click);
            this.labelModifier.MouseEnter += new System.EventHandler(this.btnModifier_MouseEnter);
            this.labelModifier.MouseLeave += new System.EventHandler(this.btnModifier_MouseLeave);
            // 
            // groupBoxRecherche
            // 
            this.groupBoxRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.groupBoxRecherche.ForeColor = System.Drawing.Color.Black;
            this.groupBoxRecherche.Location = new System.Drawing.Point(14, 14);
            this.groupBoxRecherche.Name = "groupBoxRecherche";
            this.groupBoxRecherche.Size = new System.Drawing.Size(641, 60);
            this.groupBoxRecherche.TabIndex = 56;
            this.groupBoxRecherche.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxRecherche_Paint);
            // 
            // groupBoxGrid
            // 
            this.groupBoxGrid.Controls.Add(this.DGVComptes);
            this.groupBoxGrid.ForeColor = System.Drawing.Color.Black;
            this.groupBoxGrid.Location = new System.Drawing.Point(17, 79);
            this.groupBoxGrid.Name = "groupBoxGrid";
            this.groupBoxGrid.Size = new System.Drawing.Size(638, 297);
            this.groupBoxGrid.TabIndex = 55;
            this.groupBoxGrid.TabStop = false;
            // 
            // DGVComptes
            // 
            this.DGVComptes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVComptes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVComptes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVComptes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVComptes.BackgroundColor = System.Drawing.Color.White;
            this.DGVComptes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVComptes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVComptes.ColumnHeadersHeight = 40;
            this.DGVComptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVComptes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IntituleAbrg,
            this.IntituleFr,
            this.IntituleAr,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVComptes.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVComptes.EnableHeadersVisualStyles = false;
            this.DGVComptes.Location = new System.Drawing.Point(21, 26);
            this.DGVComptes.MultiSelect = false;
            this.DGVComptes.Name = "DGVComptes";
            this.DGVComptes.ReadOnly = true;
            this.DGVComptes.RowHeadersWidth = 30;
            this.DGVComptes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVComptes.Size = new System.Drawing.Size(600, 228);
            this.DGVComptes.TabIndex = 31;
            this.DGVComptes.Paint += new System.Windows.Forms.PaintEventHandler(this.DGVComptes_Paint);
            // 
            // IntituleAbrg
            // 
            this.IntituleAbrg.HeaderText = "Pseudo";
            this.IntituleAbrg.Name = "IntituleAbrg";
            this.IntituleAbrg.ReadOnly = true;
            // 
            // IntituleFr
            // 
            this.IntituleFr.HeaderText = "Email";
            this.IntituleFr.Name = "IntituleFr";
            this.IntituleFr.ReadOnly = true;
            // 
            // IntituleAr
            // 
            this.IntituleAr.HeaderText = "Nom et Prénom";
            this.IntituleAr.Name = "IntituleAr";
            this.IntituleAr.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Téléphone";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // CompteFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBoxBoutton);
            this.Controls.Add(this.groupBoxRecherche);
            this.Controls.Add(this.groupBoxGrid);
            this.Name = "CompteFr";
            this.Size = new System.Drawing.Size(860, 410);
            this.Load += new System.EventHandler(this.CompteFr_Load);
            this.groupBoxBoutton.ResumeLayout(false);
            this.btnSupprimer.ResumeLayout(false);
            this.btnSupprimer.PerformLayout();
            this.btnAjouter.ResumeLayout(false);
            this.btnAjouter.PerformLayout();
            this.btnModifier.ResumeLayout(false);
            this.btnModifier.PerformLayout();
            this.groupBoxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVComptes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel groupBoxBoutton;
        private System.Windows.Forms.Panel btnSupprimer;
        private System.Windows.Forms.Label labelSupprimer;
        private System.Windows.Forms.Panel btnAjouter;
        private System.Windows.Forms.Label labelAjouter;
        private System.Windows.Forms.Panel btnModifier;
        private System.Windows.Forms.Label labelModifier;
        private System.Windows.Forms.Panel groupBoxRecherche;
        private System.Windows.Forms.GroupBox groupBoxGrid;
        private System.Windows.Forms.DataGridView DGVComptes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntituleAbrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntituleFr;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntituleAr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;

    }
}
