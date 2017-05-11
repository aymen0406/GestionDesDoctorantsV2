namespace GestionDesDoctorantsV2
{
    partial class Inscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscription));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitre = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGVConge = new System.Windows.Forms.DataGridView();
            this.NomPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbResponsabilite = new System.Windows.Forms.ComboBox();
            this.labelResponsabiliteFr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTypeDocument = new System.Windows.Forms.ComboBox();
            this.LabelObservation = new System.Windows.Forms.Label();
            this.richTextBoxObservation = new System.Windows.Forms.RichTextBox();
            this.panelAnnuler = new System.Windows.Forms.Panel();
            this.labelAnnuler = new System.Windows.Forms.Label();
            this.panelEnregistrer = new System.Windows.Forms.Panel();
            this.labelEnregistrer = new System.Windows.Forms.Label();
            this.ErreurResponsabiliteFr = new System.Windows.Forms.Label();
            this.ErreurTypeDocument = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelTitre.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConge)).BeginInit();
            this.panelAnnuler.SuspendLayout();
            this.panelEnregistrer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panelTitre.Controls.Add(this.panelClose);
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(529, 42);
            this.panelTitre.TabIndex = 419;
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.Transparent;
            this.panelClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelClose.BackgroundImage")));
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelClose.Location = new System.Drawing.Point(488, 0);
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cmbResponsabilite);
            this.panel1.Controls.Add(this.labelResponsabiliteFr);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbTypeDocument);
            this.panel1.Controls.Add(this.LabelObservation);
            this.panel1.Controls.Add(this.richTextBoxObservation);
            this.panel1.Controls.Add(this.panelAnnuler);
            this.panel1.Controls.Add(this.panelEnregistrer);
            this.panel1.Controls.Add(this.ErreurResponsabiliteFr);
            this.panel1.Controls.Add(this.ErreurTypeDocument);
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 233);
            this.panel1.TabIndex = 418;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.DGVConge);
            this.panel2.Location = new System.Drawing.Point(3, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 227);
            this.panel2.TabIndex = 418;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVConge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVConge.ColumnHeadersHeight = 40;
            this.DGVConge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVConge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomPrenom,
            this.Specialite});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVConge.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVConge.EnableHeadersVisualStyles = false;
            this.DGVConge.Location = new System.Drawing.Point(6, 69);
            this.DGVConge.MultiSelect = false;
            this.DGVConge.Name = "DGVConge";
            this.DGVConge.RowHeadersWidth = 25;
            this.DGVConge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVConge.Size = new System.Drawing.Size(462, 155);
            this.DGVConge.TabIndex = 302;
            this.DGVConge.DoubleClick += new System.EventHandler(this.DGVConge_DoubleClick);
            // 
            // NomPrenom
            // 
            this.NomPrenom.HeaderText = "Nom et prenom";
            this.NomPrenom.Name = "NomPrenom";
            // 
            // Specialite
            // 
            this.Specialite.HeaderText = "Spécialité";
            this.Specialite.Name = "Specialite";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 434;
            this.label3.Text = "Niveau";
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
            // LabelObservation
            // 
            this.LabelObservation.AutoSize = true;
            this.LabelObservation.Location = new System.Drawing.Point(28, 89);
            this.LabelObservation.Name = "LabelObservation";
            this.LabelObservation.Size = new System.Drawing.Size(68, 13);
            this.LabelObservation.TabIndex = 417;
            this.LabelObservation.Text = "Commentaire";
            // 
            // richTextBoxObservation
            // 
            this.richTextBoxObservation.Location = new System.Drawing.Point(138, 83);
            this.richTextBoxObservation.Name = "richTextBoxObservation";
            this.richTextBoxObservation.Size = new System.Drawing.Size(253, 49);
            this.richTextBoxObservation.TabIndex = 420;
            this.richTextBoxObservation.Text = "";
            // 
            // panelAnnuler
            // 
            this.panelAnnuler.BackColor = System.Drawing.Color.White;
            this.panelAnnuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAnnuler.BackgroundImage")));
            this.panelAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAnnuler.Controls.Add(this.labelAnnuler);
            this.panelAnnuler.Location = new System.Drawing.Point(73, 156);
            this.panelAnnuler.Name = "panelAnnuler";
            this.panelAnnuler.Size = new System.Drawing.Size(150, 40);
            this.panelAnnuler.TabIndex = 421;
            this.panelAnnuler.Click += new System.EventHandler(this.panelAnnuler_Click);
            this.panelAnnuler.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAnnuler_Paint);
            this.panelAnnuler.MouseEnter += new System.EventHandler(this.panelAnnuler_MouseEnter);
            this.panelAnnuler.MouseLeave += new System.EventHandler(this.panelAnnuler_MouseLeave);
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
            this.labelAnnuler.Click += new System.EventHandler(this.panelAnnuler_Click);
            this.labelAnnuler.MouseEnter += new System.EventHandler(this.panelAnnuler_MouseEnter);
            this.labelAnnuler.MouseLeave += new System.EventHandler(this.panelAnnuler_MouseLeave);
            // 
            // panelEnregistrer
            // 
            this.panelEnregistrer.BackColor = System.Drawing.Color.White;
            this.panelEnregistrer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnregistrer.BackgroundImage")));
            this.panelEnregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEnregistrer.Controls.Add(this.labelEnregistrer);
            this.panelEnregistrer.Location = new System.Drawing.Point(240, 156);
            this.panelEnregistrer.Name = "panelEnregistrer";
            this.panelEnregistrer.Size = new System.Drawing.Size(150, 40);
            this.panelEnregistrer.TabIndex = 422;
            this.panelEnregistrer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEnregistrer_Paint);
            this.panelEnregistrer.MouseEnter += new System.EventHandler(this.panelEnregistrer_MouseEnter);
            this.panelEnregistrer.MouseLeave += new System.EventHandler(this.panelEnregistrer_MouseLeave);
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
            this.labelEnregistrer.MouseEnter += new System.EventHandler(this.panelEnregistrer_MouseEnter);
            this.labelEnregistrer.MouseLeave += new System.EventHandler(this.panelEnregistrer_MouseLeave);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(461, 21);
            this.comboBox1.TabIndex = 303;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 20);
            this.textBox1.TabIndex = 304;
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 291);
            this.Controls.Add(this.panelTitre);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoriqueCongeFr";
            this.Load += new System.EventHandler(this.Inscription_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Inscription_Paint);
            this.panelTitre.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConge)).EndInit();
            this.panelAnnuler.ResumeLayout(false);
            this.panelAnnuler.PerformLayout();
            this.panelEnregistrer.ResumeLayout(false);
            this.panelEnregistrer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbResponsabilite;
        private System.Windows.Forms.Label labelResponsabiliteFr;
        private System.Windows.Forms.RichTextBox richTextBoxObservation;
        private System.Windows.Forms.Label LabelObservation;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Panel panelEnregistrer;
        private System.Windows.Forms.Label labelEnregistrer;
        private System.Windows.Forms.Panel panelAnnuler;
        private System.Windows.Forms.Label labelAnnuler;
        private System.Windows.Forms.Label ErreurTypeDocument;
        private System.Windows.Forms.ComboBox cmbTypeDocument;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ErreurResponsabiliteFr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVConge;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialite;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}