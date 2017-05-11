namespace GestionDesDoctorantsV2
{
    partial class GestionDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDocument));
            this.panelModifDoc = new System.Windows.Forms.Panel();
            this.txtNomAr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ErreurDocument = new System.Windows.Forms.Label();
            this.ErreurNomFr = new System.Windows.Forms.Label();
            this.ErreurTypeDocument = new System.Windows.Forms.Label();
            this.panelEnregistrer = new System.Windows.Forms.Panel();
            this.labelEnregistrer = new System.Windows.Forms.Label();
            this.panelAnnuler = new System.Windows.Forms.Panel();
            this.labelAnnuler = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCommentaire = new System.Windows.Forms.RichTextBox();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.txtNomFr = new System.Windows.Forms.TextBox();
            this.cmbTypeDocument = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitre = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panelModifDoc.SuspendLayout();
            this.panelEnregistrer.SuspendLayout();
            this.panelAnnuler.SuspendLayout();
            this.panelTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelModifDoc
            // 
            this.panelModifDoc.Controls.Add(this.txtNomAr);
            this.panelModifDoc.Controls.Add(this.label3);
            this.panelModifDoc.Controls.Add(this.ErreurDocument);
            this.panelModifDoc.Controls.Add(this.ErreurNomFr);
            this.panelModifDoc.Controls.Add(this.ErreurTypeDocument);
            this.panelModifDoc.Controls.Add(this.panelEnregistrer);
            this.panelModifDoc.Controls.Add(this.panelAnnuler);
            this.panelModifDoc.Controls.Add(this.button1);
            this.panelModifDoc.Controls.Add(this.txtCommentaire);
            this.panelModifDoc.Controls.Add(this.txtDocument);
            this.panelModifDoc.Controls.Add(this.txtNomFr);
            this.panelModifDoc.Controls.Add(this.cmbTypeDocument);
            this.panelModifDoc.Controls.Add(this.label5);
            this.panelModifDoc.Controls.Add(this.label4);
            this.panelModifDoc.Controls.Add(this.label2);
            this.panelModifDoc.Controls.Add(this.label1);
            this.panelModifDoc.Location = new System.Drawing.Point(3, 48);
            this.panelModifDoc.Name = "panelModifDoc";
            this.panelModifDoc.Size = new System.Drawing.Size(595, 199);
            this.panelModifDoc.TabIndex = 1;
            this.panelModifDoc.Visible = false;
            // 
            // txtNomAr
            // 
            this.txtNomAr.BackColor = System.Drawing.Color.White;
            this.txtNomAr.ForeColor = System.Drawing.Color.Black;
            this.txtNomAr.Location = new System.Drawing.Point(374, 36);
            this.txtNomAr.Name = "txtNomAr";
            this.txtNomAr.Size = new System.Drawing.Size(201, 20);
            this.txtNomAr.TabIndex = 425;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 424;
            this.label3.Text = "Nom (Ar)";
            // 
            // ErreurDocument
            // 
            this.ErreurDocument.AutoSize = true;
            this.ErreurDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurDocument.ForeColor = System.Drawing.Color.Red;
            this.ErreurDocument.Location = new System.Drawing.Point(576, 10);
            this.ErreurDocument.Name = "ErreurDocument";
            this.ErreurDocument.Size = new System.Drawing.Size(14, 16);
            this.ErreurDocument.TabIndex = 423;
            this.ErreurDocument.Text = "*";
            this.ErreurDocument.Visible = false;
            // 
            // ErreurNomFr
            // 
            this.ErreurNomFr.AutoSize = true;
            this.ErreurNomFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurNomFr.ForeColor = System.Drawing.Color.Red;
            this.ErreurNomFr.Location = new System.Drawing.Point(303, 39);
            this.ErreurNomFr.Name = "ErreurNomFr";
            this.ErreurNomFr.Size = new System.Drawing.Size(14, 16);
            this.ErreurNomFr.TabIndex = 422;
            this.ErreurNomFr.Text = "*";
            this.ErreurNomFr.Visible = false;
            // 
            // ErreurTypeDocument
            // 
            this.ErreurTypeDocument.AutoSize = true;
            this.ErreurTypeDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurTypeDocument.ForeColor = System.Drawing.Color.Red;
            this.ErreurTypeDocument.Location = new System.Drawing.Point(303, 11);
            this.ErreurTypeDocument.Name = "ErreurTypeDocument";
            this.ErreurTypeDocument.Size = new System.Drawing.Size(14, 16);
            this.ErreurTypeDocument.TabIndex = 421;
            this.ErreurTypeDocument.Text = "*";
            this.ErreurTypeDocument.Visible = false;
            // 
            // panelEnregistrer
            // 
            this.panelEnregistrer.BackColor = System.Drawing.Color.White;
            this.panelEnregistrer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnregistrer.BackgroundImage")));
            this.panelEnregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEnregistrer.Controls.Add(this.labelEnregistrer);
            this.panelEnregistrer.Location = new System.Drawing.Point(439, 146);
            this.panelEnregistrer.Name = "panelEnregistrer";
            this.panelEnregistrer.Size = new System.Drawing.Size(150, 40);
            this.panelEnregistrer.TabIndex = 420;
            this.panelEnregistrer.Click += new System.EventHandler(this.panelEnregistrer_Click);
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
            this.panelAnnuler.Location = new System.Drawing.Point(283, 146);
            this.panelAnnuler.Name = "panelAnnuler";
            this.panelAnnuler.Size = new System.Drawing.Size(150, 40);
            this.panelAnnuler.TabIndex = 419;
            this.panelAnnuler.Click += new System.EventHandler(this.labelAnnuler_Click);
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
            this.labelAnnuler.Click += new System.EventHandler(this.labelAnnuler_Click);
            this.labelAnnuler.MouseEnter += new System.EventHandler(this.panelAnnuler_MouseEnter);
            this.labelAnnuler.MouseLeave += new System.EventHandler(this.panelAnnuler_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 10;
            this.button1.Text = ". . .";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.BackColor = System.Drawing.Color.White;
            this.txtCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommentaire.ForeColor = System.Drawing.Color.Black;
            this.txtCommentaire.Location = new System.Drawing.Point(99, 62);
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(490, 78);
            this.txtCommentaire.TabIndex = 9;
            this.txtCommentaire.Text = "";
            // 
            // txtDocument
            // 
            this.txtDocument.BackColor = System.Drawing.Color.White;
            this.txtDocument.ForeColor = System.Drawing.Color.Black;
            this.txtDocument.Location = new System.Drawing.Point(374, 8);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(179, 20);
            this.txtDocument.TabIndex = 8;
            // 
            // txtNomFr
            // 
            this.txtNomFr.BackColor = System.Drawing.Color.White;
            this.txtNomFr.ForeColor = System.Drawing.Color.Black;
            this.txtNomFr.Location = new System.Drawing.Point(100, 36);
            this.txtNomFr.Name = "txtNomFr";
            this.txtNomFr.Size = new System.Drawing.Size(201, 20);
            this.txtNomFr.TabIndex = 6;
            // 
            // cmbTypeDocument
            // 
            this.cmbTypeDocument.BackColor = System.Drawing.Color.White;
            this.cmbTypeDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeDocument.ForeColor = System.Drawing.Color.Black;
            this.cmbTypeDocument.FormattingEnabled = true;
            this.cmbTypeDocument.Location = new System.Drawing.Point(100, 8);
            this.cmbTypeDocument.Name = "cmbTypeDocument";
            this.cmbTypeDocument.Size = new System.Drawing.Size(201, 21);
            this.cmbTypeDocument.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Commentaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Document";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Document";
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panelTitre.Controls.Add(this.panelClose);
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(604, 42);
            this.panelTitre.TabIndex = 420;
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.Transparent;
            this.panelClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelClose.BackgroundImage")));
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelClose.Location = new System.Drawing.Point(561, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(42, 42);
            this.panelClose.TabIndex = 26;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            this.panelClose.MouseEnter += new System.EventHandler(this.panelClose_MouseEnter);
            this.panelClose.MouseLeave += new System.EventHandler(this.panelClose_MouseLeave);
            // 
            // GestionDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 252);
            this.Controls.Add(this.panelTitre);
            this.Controls.Add(this.panelModifDoc);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionDocument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionDocument";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GestionDocument_Paint);
            this.panelModifDoc.ResumeLayout(false);
            this.panelModifDoc.PerformLayout();
            this.panelEnregistrer.ResumeLayout(false);
            this.panelEnregistrer.PerformLayout();
            this.panelAnnuler.ResumeLayout(false);
            this.panelAnnuler.PerformLayout();
            this.panelTitre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelModifDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtCommentaire;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.TextBox txtNomFr;
        private System.Windows.Forms.ComboBox cmbTypeDocument;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelEnregistrer;
        private System.Windows.Forms.Label labelEnregistrer;
        private System.Windows.Forms.Panel panelAnnuler;
        private System.Windows.Forms.Label labelAnnuler;
        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Label ErreurDocument;
        private System.Windows.Forms.Label ErreurNomFr;
        private System.Windows.Forms.Label ErreurTypeDocument;
        private System.Windows.Forms.TextBox txtNomAr;
        private System.Windows.Forms.Label label3;
    }
}