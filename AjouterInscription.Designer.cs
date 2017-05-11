namespace GestionDesDoctorantsV2
{
    partial class AjouterInscription
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterInscription));
            this.phdDbFinalDataSet2 = new GestionDesDoctorantsV2.phdDbFinalDataSet2();
            this.doctorantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorantTableAdapter = new GestionDesDoctorantsV2.phdDbFinalDataSet2TableAdapters.DoctorantTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTypeDocument = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelEnregistrer = new System.Windows.Forms.Panel();
            this.labelEnregistrer = new System.Windows.Forms.Label();
            this.panelAnnuler = new System.Windows.Forms.Panel();
            this.labelAnnuler = new System.Windows.Forms.Label();
            this.richTextBoxObservation = new System.Windows.Forms.RichTextBox();
            this.LabelObservation = new System.Windows.Forms.Label();
            this.ErreurResponsabiliteFr = new System.Windows.Forms.Label();
            this.cmbResponsabilite = new System.Windows.Forms.ComboBox();
            this.labelResponsabiliteFr = new System.Windows.Forms.Label();
            this.ErreurTypeDocument = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phdDbFinalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorantBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelEnregistrer.SuspendLayout();
            this.panelAnnuler.SuspendLayout();
            this.SuspendLayout();
            // 
            // phdDbFinalDataSet2
            // 
            this.phdDbFinalDataSet2.DataSetName = "phdDbFinalDataSet2";
            this.phdDbFinalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorantBindingSource
            // 
            this.doctorantBindingSource.DataMember = "Doctorant";
            this.doctorantBindingSource.DataSource = this.phdDbFinalDataSet2;
            // 
            // doctorantTableAdapter
            // 
            this.doctorantTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmbTypeDocument);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.richTextBoxObservation);
            this.panel1.Controls.Add(this.LabelObservation);
            this.panel1.Controls.Add(this.ErreurResponsabiliteFr);
            this.panel1.Controls.Add(this.cmbResponsabilite);
            this.panel1.Controls.Add(this.labelResponsabiliteFr);
            this.panel1.Controls.Add(this.ErreurTypeDocument);
            this.panel1.Location = new System.Drawing.Point(89, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 228);
            this.panel1.TabIndex = 419;
            this.panel1.Visible = false;
            // 
            // cmbTypeDocument
            // 
            this.cmbTypeDocument.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTypeDocument.FormattingEnabled = true;
            this.cmbTypeDocument.Location = new System.Drawing.Point(137, 56);
            this.cmbTypeDocument.Name = "cmbTypeDocument";
            this.cmbTypeDocument.Size = new System.Drawing.Size(253, 21);
            this.cmbTypeDocument.TabIndex = 435;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 434;
            this.label3.Text = "Niveau";
            // 
            // panelEnregistrer
            // 
            this.panelEnregistrer.BackColor = System.Drawing.Color.White;
            this.panelEnregistrer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnregistrer.BackgroundImage")));
            this.panelEnregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEnregistrer.Controls.Add(this.labelEnregistrer);
            this.panelEnregistrer.Location = new System.Drawing.Point(883, 120);
            this.panelEnregistrer.Name = "panelEnregistrer";
            this.panelEnregistrer.Size = new System.Drawing.Size(150, 40);
            this.panelEnregistrer.TabIndex = 422;
            // 
            // labelEnregistrer
            // 
            this.labelEnregistrer.AutoSize = true;
            this.labelEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnregistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelEnregistrer.Location = new System.Drawing.Point(68, 12);
            this.labelEnregistrer.Name = "labelEnregistrer";
            this.labelEnregistrer.Size = new System.Drawing.Size(73, 16);
            this.labelEnregistrer.TabIndex = 82;
            this.labelEnregistrer.Text = "Enregistrer";
            // 
            // panelAnnuler
            // 
            this.panelAnnuler.BackColor = System.Drawing.Color.White;
            this.panelAnnuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAnnuler.BackgroundImage")));
            this.panelAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAnnuler.Controls.Add(this.labelAnnuler);
            this.panelAnnuler.Location = new System.Drawing.Point(883, 166);
            this.panelAnnuler.Name = "panelAnnuler";
            this.panelAnnuler.Size = new System.Drawing.Size(150, 40);
            this.panelAnnuler.TabIndex = 421;
            // 
            // labelAnnuler
            // 
            this.labelAnnuler.AutoSize = true;
            this.labelAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelAnnuler.Location = new System.Drawing.Point(74, 12);
            this.labelAnnuler.Name = "labelAnnuler";
            this.labelAnnuler.Size = new System.Drawing.Size(53, 16);
            this.labelAnnuler.TabIndex = 81;
            this.labelAnnuler.Text = "Annuler";
            // 
            // richTextBoxObservation
            // 
            this.richTextBoxObservation.Location = new System.Drawing.Point(138, 83);
            this.richTextBoxObservation.Name = "richTextBoxObservation";
            this.richTextBoxObservation.Size = new System.Drawing.Size(253, 49);
            this.richTextBoxObservation.TabIndex = 420;
            this.richTextBoxObservation.Text = "";
            // 
            // LabelObservation
            // 
            this.LabelObservation.AutoSize = true;
            this.LabelObservation.Location = new System.Drawing.Point(28, 89);
            this.LabelObservation.Name = "LabelObservation";
            this.LabelObservation.Size = new System.Drawing.Size(68, 13);
            this.LabelObservation.TabIndex = 417;
            this.LabelObservation.Text = "Commentaire";
            // 
            // ErreurResponsabiliteFr
            // 
            this.ErreurResponsabiliteFr.AutoSize = true;
            this.ErreurResponsabiliteFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurResponsabiliteFr.ForeColor = System.Drawing.Color.Red;
            this.ErreurResponsabiliteFr.Location = new System.Drawing.Point(393, 29);
            this.ErreurResponsabiliteFr.Name = "ErreurResponsabiliteFr";
            this.ErreurResponsabiliteFr.Size = new System.Drawing.Size(14, 16);
            this.ErreurResponsabiliteFr.TabIndex = 412;
            this.ErreurResponsabiliteFr.Text = "*";
            // 
            // cmbResponsabilite
            // 
            this.cmbResponsabilite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbResponsabilite.FormattingEnabled = true;
            this.cmbResponsabilite.Location = new System.Drawing.Point(137, 29);
            this.cmbResponsabilite.Name = "cmbResponsabilite";
            this.cmbResponsabilite.Size = new System.Drawing.Size(253, 21);
            this.cmbResponsabilite.TabIndex = 49;
            // 
            // labelResponsabiliteFr
            // 
            this.labelResponsabiliteFr.AutoSize = true;
            this.labelResponsabiliteFr.Location = new System.Drawing.Point(27, 33);
            this.labelResponsabiliteFr.Name = "labelResponsabiliteFr";
            this.labelResponsabiliteFr.Size = new System.Drawing.Size(99, 13);
            this.labelResponsabiliteFr.TabIndex = 39;
            this.labelResponsabiliteFr.Text = "Année Universitaire";
            // 
            // ErreurTypeDocument
            // 
            this.ErreurTypeDocument.AutoSize = true;
            this.ErreurTypeDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurTypeDocument.ForeColor = System.Drawing.Color.Red;
            this.ErreurTypeDocument.Location = new System.Drawing.Point(393, 56);
            this.ErreurTypeDocument.Name = "ErreurTypeDocument";
            this.ErreurTypeDocument.Size = new System.Drawing.Size(14, 16);
            this.ErreurTypeDocument.TabIndex = 436;
            this.ErreurTypeDocument.Text = "*";
            // 
            // AjouterInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelEnregistrer);
            this.Controls.Add(this.panelAnnuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjouterInscription";
            this.Text = "AjouterInscription";
            this.Load += new System.EventHandler(this.AjouterInscription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phdDbFinalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorantBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEnregistrer.ResumeLayout(false);
            this.panelEnregistrer.PerformLayout();
            this.panelAnnuler.ResumeLayout(false);
            this.panelAnnuler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private phdDbFinalDataSet2 phdDbFinalDataSet2;
        private System.Windows.Forms.BindingSource doctorantBindingSource;
        private phdDbFinalDataSet2TableAdapters.DoctorantTableAdapter doctorantTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTypeDocument;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelEnregistrer;
        private System.Windows.Forms.Label labelEnregistrer;
        private System.Windows.Forms.Panel panelAnnuler;
        private System.Windows.Forms.Label labelAnnuler;
        private System.Windows.Forms.RichTextBox richTextBoxObservation;
        private System.Windows.Forms.Label LabelObservation;
        private System.Windows.Forms.Label ErreurResponsabiliteFr;
        private System.Windows.Forms.ComboBox cmbResponsabilite;
        private System.Windows.Forms.Label labelResponsabiliteFr;
        private System.Windows.Forms.Label ErreurTypeDocument;
    }
}