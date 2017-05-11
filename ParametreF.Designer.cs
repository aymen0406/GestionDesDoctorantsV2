namespace GestionDesDoctorantsV2
{
    partial class ParametreF
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelEncadrant = new System.Windows.Forms.Panel();
            this.panelinstitut = new System.Windows.Forms.Panel();
            this.panelStructRech = new System.Windows.Forms.Panel();
            this.panelTypeDoc = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelEncadrant);
            this.panel1.Controls.Add(this.panelinstitut);
            this.panel1.Controls.Add(this.panelStructRech);
            this.panel1.Controls.Add(this.panelTypeDoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 557);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 557);
            this.panel2.TabIndex = 26;
            // 
            // panelEncadrant
            // 
            this.panelEncadrant.BackColor = System.Drawing.Color.Transparent;
            this.panelEncadrant.BackgroundImage = global::GestionDesDoctorantsV2.Properties.Resources.MenuNew011;
            this.panelEncadrant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEncadrant.Location = new System.Drawing.Point(121, 79);
            this.panelEncadrant.Name = "panelEncadrant";
            this.panelEncadrant.Size = new System.Drawing.Size(250, 175);
            this.panelEncadrant.TabIndex = 7;
            this.panelEncadrant.Click += new System.EventHandler(this.panelEncadrant_Click_1);
            this.panelEncadrant.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEncadrant_Paint);
            // 
            // panelinstitut
            // 
            this.panelinstitut.BackColor = System.Drawing.Color.Transparent;
            this.panelinstitut.BackgroundImage = global::GestionDesDoctorantsV2.Properties.Resources.Menuasdasdadas;
            this.panelinstitut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelinstitut.Location = new System.Drawing.Point(400, 79);
            this.panelinstitut.Name = "panelinstitut";
            this.panelinstitut.Size = new System.Drawing.Size(250, 175);
            this.panelinstitut.TabIndex = 27;
            this.panelinstitut.Click += new System.EventHandler(this.panelinstitut_Click);
            // 
            // panelStructRech
            // 
            this.panelStructRech.BackColor = System.Drawing.Color.Transparent;
            this.panelStructRech.BackgroundImage = global::GestionDesDoctorantsV2.Properties.Resources.dsafdadw011;
            this.panelStructRech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelStructRech.Location = new System.Drawing.Point(681, 79);
            this.panelStructRech.Name = "panelStructRech";
            this.panelStructRech.Size = new System.Drawing.Size(250, 175);
            this.panelStructRech.TabIndex = 25;
            this.panelStructRech.Click += new System.EventHandler(this.panelStructRech_Click);
            // 
            // panelTypeDoc
            // 
            this.panelTypeDoc.BackColor = System.Drawing.Color.Transparent;
            this.panelTypeDoc.BackgroundImage = global::GestionDesDoctorantsV2.Properties.Resources.asdaasdqz1;
            this.panelTypeDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTypeDoc.Location = new System.Drawing.Point(121, 284);
            this.panelTypeDoc.Name = "panelTypeDoc";
            this.panelTypeDoc.Size = new System.Drawing.Size(250, 175);
            this.panelTypeDoc.TabIndex = 26;
            this.panelTypeDoc.Click += new System.EventHandler(this.panelTypeDoc_Click);
            // 
            // ParametreF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ParametreF";
            this.Size = new System.Drawing.Size(1076, 557);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelEncadrant;
        private System.Windows.Forms.Panel panelStructRech;
        private System.Windows.Forms.Panel panelTypeDoc;
        private System.Windows.Forms.Panel panelinstitut;
    }
}
