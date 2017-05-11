namespace GestionDesDoctorantsV2
{
    partial class GestSout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestSout));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitre = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Panel();
            this.labelSupprimer = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Panel();
            this.labelModifier = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Panel();
            this.labelAjouter = new System.Windows.Forms.Label();
            this.DGVGrade = new System.Windows.Forms.DataGridView();
            this.Date_Sout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sujet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.President = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rapporteur1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rapporteur2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Examinateur1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Examinateur2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalenderAffectation = new System.Windows.Forms.DateTimePicker();
            this.ErreurDateAffectationFr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExam2 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblExam1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblRapporteur1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPresidJury = new System.Windows.Forms.Label();
            this.ErreurTypeDocument = new System.Windows.Forms.Label();
            this.lblRapporteur2 = new System.Windows.Forms.Label();
            this.cmbTypeDocument = new System.Windows.Forms.ComboBox();
            this.txtDateAffectation = new System.Windows.Forms.TextBox();
            this.panelEnregistrer = new System.Windows.Forms.Panel();
            this.labelEnregistrer = new System.Windows.Forms.Label();
            this.panelAnnuler = new System.Windows.Forms.Panel();
            this.labelAnnuler = new System.Windows.Forms.Label();
            this.ErreurGradeFr = new System.Windows.Forms.Label();
            this.labelDateSoutenance = new System.Windows.Forms.Label();
            this.panelTitre.SuspendLayout();
            this.panel2.SuspendLayout();
            this.btnSupprimer.SuspendLayout();
            this.btnModifier.SuspendLayout();
            this.btnAjouter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGrade)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelEnregistrer.SuspendLayout();
            this.panelAnnuler.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panelTitre.Controls.Add(this.panelClose);
            this.panelTitre.Location = new System.Drawing.Point(1, 0);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(839, 42);
            this.panelTitre.TabIndex = 426;
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.Transparent;
            this.panelClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelClose.BackgroundImage")));
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelClose.Location = new System.Drawing.Point(797, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(40, 42);
            this.panelClose.TabIndex = 27;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            this.panelClose.MouseEnter += new System.EventHandler(this.panelClose_MouseEnter);
            this.panelClose.MouseLeave += new System.EventHandler(this.panelClose_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnModifier);
            this.panel2.Controls.Add(this.btnAjouter);
            this.panel2.Controls.Add(this.DGVGrade);
            this.panel2.Controls.Add(this.btnSupprimer);
            this.panel2.Location = new System.Drawing.Point(1, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 254);
            this.panel2.TabIndex = 425;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.White;
            this.btnSupprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.BackgroundImage")));
            this.btnSupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupprimer.Controls.Add(this.labelSupprimer);
            this.btnSupprimer.Location = new System.Drawing.Point(673, 198);
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
            this.labelSupprimer.Location = new System.Drawing.Point(77, 12);
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
            this.btnModifier.Location = new System.Drawing.Point(508, 199);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(150, 40);
            this.btnModifier.TabIndex = 424;
            this.btnModifier.Paint += new System.Windows.Forms.PaintEventHandler(this.btnModifier_Paint);
            this.btnModifier.MouseEnter += new System.EventHandler(this.btnModifier_MouseEnter);
            this.btnModifier.MouseLeave += new System.EventHandler(this.btnModifier_MouseLeave);
            // 
            // labelModifier
            // 
            this.labelModifier.AutoSize = true;
            this.labelModifier.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelModifier.Location = new System.Drawing.Point(90, 12);
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
            this.btnAjouter.Location = new System.Drawing.Point(340, 199);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(150, 40);
            this.btnAjouter.TabIndex = 423;
            this.btnAjouter.Click += new System.EventHandler(this.btnAddGrade_Click);
            this.btnAjouter.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAjouter_Paint);
            this.btnAjouter.MouseEnter += new System.EventHandler(this.btnAjouter_MouseEnter);
            this.btnAjouter.MouseLeave += new System.EventHandler(this.btnAjouter_MouseLeave);
            // 
            // labelAjouter
            // 
            this.labelAjouter.AutoSize = true;
            this.labelAjouter.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelAjouter.Location = new System.Drawing.Point(95, 12);
            this.labelAjouter.Name = "labelAjouter";
            this.labelAjouter.Size = new System.Drawing.Size(49, 16);
            this.labelAjouter.TabIndex = 0;
            this.labelAjouter.Text = "Ajouter";
            this.labelAjouter.Click += new System.EventHandler(this.btnAddGrade_Click);
            this.labelAjouter.MouseEnter += new System.EventHandler(this.btnAjouter_MouseEnter);
            this.labelAjouter.MouseLeave += new System.EventHandler(this.btnAjouter_MouseLeave);
            // 
            // DGVGrade
            // 
            this.DGVGrade.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVGrade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVGrade.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVGrade.BackgroundColor = System.Drawing.Color.White;
            this.DGVGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVGrade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVGrade.ColumnHeadersHeight = 40;
            this.DGVGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date_Sout,
            this.Sujet,
            this.President,
            this.Rapporteur1,
            this.Rapporteur2,
            this.Examinateur1,
            this.Examinateur2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVGrade.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVGrade.EnableHeadersVisualStyles = false;
            this.DGVGrade.Location = new System.Drawing.Point(5, 6);
            this.DGVGrade.MultiSelect = false;
            this.DGVGrade.Name = "DGVGrade";
            this.DGVGrade.RowHeadersWidth = 25;
            this.DGVGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVGrade.Size = new System.Drawing.Size(821, 145);
            this.DGVGrade.TabIndex = 302;
            this.DGVGrade.Paint += new System.Windows.Forms.PaintEventHandler(this.DGVGrade_Paint);
            // 
            // Date_Sout
            // 
            this.Date_Sout.HeaderText = "Date Soutenance";
            this.Date_Sout.Name = "Date_Sout";
            // 
            // Sujet
            // 
            this.Sujet.HeaderText = "Sujet";
            this.Sujet.Name = "Sujet";
            // 
            // President
            // 
            this.President.HeaderText = "Président de Jury";
            this.President.Name = "President";
            // 
            // Rapporteur1
            // 
            this.Rapporteur1.HeaderText = "Rapporteur 1";
            this.Rapporteur1.Name = "Rapporteur1";
            // 
            // Rapporteur2
            // 
            this.Rapporteur2.HeaderText = "Rapporteur 2";
            this.Rapporteur2.Name = "Rapporteur2";
            // 
            // Examinateur1
            // 
            this.Examinateur1.HeaderText = "Examinateur 1";
            this.Examinateur1.Name = "Examinateur1";
            // 
            // Examinateur2
            // 
            this.Examinateur2.HeaderText = "Examinateur 2";
            this.Examinateur2.Name = "Examinateur2";
            // 
            // CalenderAffectation
            // 
            this.CalenderAffectation.CalendarForeColor = System.Drawing.Color.Black;
            this.CalenderAffectation.CalendarMonthBackground = System.Drawing.Color.White;
            this.CalenderAffectation.Location = new System.Drawing.Point(389, 14);
            this.CalenderAffectation.Name = "CalenderAffectation";
            this.CalenderAffectation.Size = new System.Drawing.Size(20, 20);
            this.CalenderAffectation.TabIndex = 417;
            this.CalenderAffectation.ValueChanged += new System.EventHandler(this.CalenderAffectation_ValueChanged);
            // 
            // ErreurDateAffectationFr
            // 
            this.ErreurDateAffectationFr.AutoSize = true;
            this.ErreurDateAffectationFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurDateAffectationFr.ForeColor = System.Drawing.Color.Red;
            this.ErreurDateAffectationFr.Location = new System.Drawing.Point(415, 17);
            this.ErreurDateAffectationFr.Name = "ErreurDateAffectationFr";
            this.ErreurDateAffectationFr.Size = new System.Drawing.Size(14, 16);
            this.ErreurDateAffectationFr.TabIndex = 416;
            this.ErreurDateAffectationFr.Text = "*";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblExam2);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.lblExam1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.lblRapporteur1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblPresidJury);
            this.panel1.Controls.Add(this.ErreurTypeDocument);
            this.panel1.Controls.Add(this.lblRapporteur2);
            this.panel1.Controls.Add(this.cmbTypeDocument);
            this.panel1.Controls.Add(this.txtDateAffectation);
            this.panel1.Controls.Add(this.panelEnregistrer);
            this.panel1.Controls.Add(this.panelAnnuler);
            this.panel1.Controls.Add(this.CalenderAffectation);
            this.panel1.Controls.Add(this.ErreurDateAffectationFr);
            this.panel1.Controls.Add(this.ErreurGradeFr);
            this.panel1.Controls.Add(this.labelDateSoutenance);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 254);
            this.panel1.TabIndex = 424;
            this.panel1.Visible = false;
            // 
            // lblExam2
            // 
            this.lblExam2.AutoSize = true;
            this.lblExam2.Location = new System.Drawing.Point(463, 73);
            this.lblExam2.Name = "lblExam2";
            this.lblExam2.Size = new System.Drawing.Size(74, 13);
            this.lblExam2.TabIndex = 449;
            this.lblExam2.Text = "Examinateur 2";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.White;
            this.comboBox4.ForeColor = System.Drawing.Color.Black;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(562, 66);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(231, 21);
            this.comboBox4.TabIndex = 448;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(415, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 447;
            this.label2.Text = "*";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.ForeColor = System.Drawing.Color.Black;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(130, 72);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(279, 21);
            this.comboBox3.TabIndex = 446;
            // 
            // lblExam1
            // 
            this.lblExam1.AutoSize = true;
            this.lblExam1.Location = new System.Drawing.Point(30, 75);
            this.lblExam1.Name = "lblExam1";
            this.lblExam1.Size = new System.Drawing.Size(74, 13);
            this.lblExam1.TabIndex = 445;
            this.lblExam1.Text = "Examinateur 1";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.ForeColor = System.Drawing.Color.Black;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(130, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(279, 21);
            this.comboBox2.TabIndex = 444;
            // 
            // lblRapporteur1
            // 
            this.lblRapporteur1.AutoSize = true;
            this.lblRapporteur1.Location = new System.Drawing.Point(30, 45);
            this.lblRapporteur1.Name = "lblRapporteur1";
            this.lblRapporteur1.Size = new System.Drawing.Size(69, 13);
            this.lblRapporteur1.TabIndex = 443;
            this.lblRapporteur1.Text = "Rapporteur 1";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(561, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 442;
            // 
            // lblPresidJury
            // 
            this.lblPresidJury.AutoSize = true;
            this.lblPresidJury.Location = new System.Drawing.Point(462, 18);
            this.lblPresidJury.Name = "lblPresidJury";
            this.lblPresidJury.Size = new System.Drawing.Size(94, 13);
            this.lblPresidJury.TabIndex = 439;
            this.lblPresidJury.Text = "Présiddent de Jury";
            // 
            // ErreurTypeDocument
            // 
            this.ErreurTypeDocument.AutoSize = true;
            this.ErreurTypeDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurTypeDocument.ForeColor = System.Drawing.Color.Red;
            this.ErreurTypeDocument.Location = new System.Drawing.Point(415, 40);
            this.ErreurTypeDocument.Name = "ErreurTypeDocument";
            this.ErreurTypeDocument.Size = new System.Drawing.Size(14, 16);
            this.ErreurTypeDocument.TabIndex = 438;
            this.ErreurTypeDocument.Text = "*";
            // 
            // lblRapporteur2
            // 
            this.lblRapporteur2.AutoSize = true;
            this.lblRapporteur2.Location = new System.Drawing.Point(463, 46);
            this.lblRapporteur2.Name = "lblRapporteur2";
            this.lblRapporteur2.Size = new System.Drawing.Size(69, 13);
            this.lblRapporteur2.TabIndex = 437;
            this.lblRapporteur2.Text = "Rapporteur 2";
            // 
            // cmbTypeDocument
            // 
            this.cmbTypeDocument.BackColor = System.Drawing.Color.White;
            this.cmbTypeDocument.ForeColor = System.Drawing.Color.Black;
            this.cmbTypeDocument.FormattingEnabled = true;
            this.cmbTypeDocument.Location = new System.Drawing.Point(562, 39);
            this.cmbTypeDocument.Name = "cmbTypeDocument";
            this.cmbTypeDocument.Size = new System.Drawing.Size(231, 21);
            this.cmbTypeDocument.TabIndex = 436;
            // 
            // txtDateAffectation
            // 
            this.txtDateAffectation.ForeColor = System.Drawing.Color.Black;
            this.txtDateAffectation.Location = new System.Drawing.Point(130, 14);
            this.txtDateAffectation.Name = "txtDateAffectation";
            this.txtDateAffectation.Size = new System.Drawing.Size(263, 20);
            this.txtDateAffectation.TabIndex = 426;
            // 
            // panelEnregistrer
            // 
            this.panelEnregistrer.BackColor = System.Drawing.Color.White;
            this.panelEnregistrer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnregistrer.BackgroundImage")));
            this.panelEnregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEnregistrer.Controls.Add(this.labelEnregistrer);
            this.panelEnregistrer.Location = new System.Drawing.Point(643, 186);
            this.panelEnregistrer.Name = "panelEnregistrer";
            this.panelEnregistrer.Size = new System.Drawing.Size(150, 40);
            this.panelEnregistrer.TabIndex = 419;
            this.panelEnregistrer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEnregistrer_Paint);
            this.panelEnregistrer.MouseEnter += new System.EventHandler(this.panelEnregistrer_MouseEnter);
            this.panelEnregistrer.MouseLeave += new System.EventHandler(this.panelEnregistrer_MouseLeave);
            // 
            // labelEnregistrer
            // 
            this.labelEnregistrer.AutoSize = true;
            this.labelEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnregistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.labelEnregistrer.Location = new System.Drawing.Point(68, 13);
            this.labelEnregistrer.Name = "labelEnregistrer";
            this.labelEnregistrer.Size = new System.Drawing.Size(73, 16);
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
            this.panelAnnuler.Location = new System.Drawing.Point(470, 186);
            this.panelAnnuler.Name = "panelAnnuler";
            this.panelAnnuler.Size = new System.Drawing.Size(150, 40);
            this.panelAnnuler.TabIndex = 418;
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
            this.labelAnnuler.Location = new System.Drawing.Point(74, 14);
            this.labelAnnuler.Name = "labelAnnuler";
            this.labelAnnuler.Size = new System.Drawing.Size(53, 16);
            this.labelAnnuler.TabIndex = 81;
            this.labelAnnuler.Text = "Annuler";
            this.labelAnnuler.Click += new System.EventHandler(this.panelAnnuler_Click);
            this.labelAnnuler.MouseEnter += new System.EventHandler(this.panelAnnuler_MouseEnter);
            this.labelAnnuler.MouseLeave += new System.EventHandler(this.panelAnnuler_MouseLeave);
            // 
            // ErreurGradeFr
            // 
            this.ErreurGradeFr.AutoSize = true;
            this.ErreurGradeFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurGradeFr.ForeColor = System.Drawing.Color.Red;
            this.ErreurGradeFr.Location = new System.Drawing.Point(799, 16);
            this.ErreurGradeFr.Name = "ErreurGradeFr";
            this.ErreurGradeFr.Size = new System.Drawing.Size(14, 16);
            this.ErreurGradeFr.TabIndex = 415;
            this.ErreurGradeFr.Text = "*";
            this.ErreurGradeFr.Click += new System.EventHandler(this.ErreurGradeFr_Click);
            // 
            // labelDateSoutenance
            // 
            this.labelDateSoutenance.AutoSize = true;
            this.labelDateSoutenance.Location = new System.Drawing.Point(30, 17);
            this.labelDateSoutenance.Name = "labelDateSoutenance";
            this.labelDateSoutenance.Size = new System.Drawing.Size(91, 13);
            this.labelDateSoutenance.TabIndex = 51;
            this.labelDateSoutenance.Text = "Date Soutenance";
            // 
            // GestSout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 298);
            this.Controls.Add(this.panelTitre);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestSout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoriqueGradeFr";
            this.Load += new System.EventHandler(this.HistoriqueGradeFr_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HistoriqueGradeFr_Paint);
            this.panelTitre.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.btnSupprimer.ResumeLayout(false);
            this.btnSupprimer.PerformLayout();
            this.btnModifier.ResumeLayout(false);
            this.btnModifier.PerformLayout();
            this.btnAjouter.ResumeLayout(false);
            this.btnAjouter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGrade)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEnregistrer.ResumeLayout(false);
            this.panelEnregistrer.PerformLayout();
            this.panelAnnuler.ResumeLayout(false);
            this.panelAnnuler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVGrade;
        private System.Windows.Forms.DateTimePicker CalenderAffectation;
        private System.Windows.Forms.Label ErreurDateAffectationFr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ErreurGradeFr;
        private System.Windows.Forms.Label labelDateSoutenance;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Panel panelEnregistrer;
        private System.Windows.Forms.Label labelEnregistrer;
        private System.Windows.Forms.Panel panelAnnuler;
        private System.Windows.Forms.Label labelAnnuler;
        private System.Windows.Forms.Panel btnSupprimer;
        private System.Windows.Forms.Label labelSupprimer;
        private System.Windows.Forms.Panel btnModifier;
        private System.Windows.Forms.Label labelModifier;
        private System.Windows.Forms.Panel btnAjouter;
        private System.Windows.Forms.Label labelAjouter;
        private System.Windows.Forms.TextBox txtDateAffectation;
        private System.Windows.Forms.Label lblRapporteur2;
        private System.Windows.Forms.ComboBox cmbTypeDocument;
        private System.Windows.Forms.Label ErreurTypeDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Sout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sujet;
        private System.Windows.Forms.DataGridViewTextBoxColumn President;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rapporteur1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rapporteur2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Examinateur1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Examinateur2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblRapporteur1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPresidJury;
        private System.Windows.Forms.Label lblExam2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblExam1;

    }
}