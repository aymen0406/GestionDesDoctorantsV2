namespace GestionDesDoctorantsV2
{
    partial class AffchInscriptionInf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffchInscriptionInf));
            this.PanelAffInscription = new System.Windows.Forms.Panel();
            this.GroupBoxInscription = new System.Windows.Forms.GroupBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.DGVConge = new System.Windows.Forms.DataGridView();
            this.Anne_univ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Niveau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commentaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label49 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Panel();
            this.labelAjouter = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.PanelAffInscription.SuspendLayout();
            this.GroupBoxInscription.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConge)).BeginInit();
            this.panel16.SuspendLayout();
            this.btnAjouter.SuspendLayout();
            this.panel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAffInscription
            // 
            this.PanelAffInscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.PanelAffInscription.Controls.Add(this.GroupBoxInscription);
            this.PanelAffInscription.Controls.Add(this.panel16);
            this.PanelAffInscription.Controls.Add(this.btnAjouter);
            this.PanelAffInscription.Controls.Add(this.panel17);
            this.PanelAffInscription.Location = new System.Drawing.Point(65, 75);
            this.PanelAffInscription.Name = "PanelAffInscription";
            this.PanelAffInscription.Size = new System.Drawing.Size(655, 243);
            this.PanelAffInscription.TabIndex = 118;
            // 
            // GroupBoxInscription
            // 
            this.GroupBoxInscription.Controls.Add(this.panel14);
            this.GroupBoxInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxInscription.Location = new System.Drawing.Point(9, 17);
            this.GroupBoxInscription.Name = "GroupBoxInscription";
            this.GroupBoxInscription.Size = new System.Drawing.Size(469, 199);
            this.GroupBoxInscription.TabIndex = 423;
            this.GroupBoxInscription.TabStop = false;
            this.GroupBoxInscription.Text = "Inscriptions";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Controls.Add(this.DGVConge);
            this.panel14.Location = new System.Drawing.Point(6, 30);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(457, 134);
            this.panel14.TabIndex = 419;
            // 
            // DGVConge
            // 
            this.DGVConge.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVConge.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVConge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVConge.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVConge.BackgroundColor = System.Drawing.Color.White;
            this.DGVConge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVConge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVConge.ColumnHeadersHeight = 40;
            this.DGVConge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVConge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anne_univ,
            this.Niveau,
            this.Commentaire});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVConge.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVConge.EnableHeadersVisualStyles = false;
            this.DGVConge.Location = new System.Drawing.Point(8, 7);
            this.DGVConge.MultiSelect = false;
            this.DGVConge.Name = "DGVConge";
            this.DGVConge.RowHeadersWidth = 25;
            this.DGVConge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVConge.Size = new System.Drawing.Size(443, 79);
            this.DGVConge.TabIndex = 302;
            // 
            // Anne_univ
            // 
            this.Anne_univ.HeaderText = "Année Universitaire";
            this.Anne_univ.Name = "Anne_univ";
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
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel16.BackgroundImage")));
            this.panel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel16.Controls.Add(this.label49);
            this.panel16.Location = new System.Drawing.Point(490, 140);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(150, 40);
            this.panel16.TabIndex = 422;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.label49.Location = new System.Drawing.Point(73, 15);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(54, 13);
            this.label49.TabIndex = 80;
            this.label49.Text = "Supprimer";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.White;
            this.btnAjouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjouter.BackgroundImage")));
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouter.Controls.Add(this.labelAjouter);
            this.btnAjouter.Location = new System.Drawing.Point(490, 47);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(150, 40);
            this.btnAjouter.TabIndex = 420;
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
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel17.BackgroundImage")));
            this.panel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel17.Controls.Add(this.label50);
            this.panel17.Location = new System.Drawing.Point(490, 93);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(150, 40);
            this.panel17.TabIndex = 421;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.label50.Location = new System.Drawing.Point(84, 13);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(34, 13);
            this.label50.TabIndex = 0;
            this.label50.Text = "Editer";
            // 
            // AffchInscriptionInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelAffInscription);
            this.Name = "AffchInscriptionInf";
            this.Size = new System.Drawing.Size(784, 392);
            this.PanelAffInscription.ResumeLayout(false);
            this.GroupBoxInscription.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVConge)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.btnAjouter.ResumeLayout(false);
            this.btnAjouter.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAffInscription;
        private System.Windows.Forms.GroupBox GroupBoxInscription;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.DataGridView DGVConge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anne_univ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Niveau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commentaire;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Panel btnAjouter;
        private System.Windows.Forms.Label labelAjouter;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label50;
    }
}
