namespace GestionDesDoctorantsV2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelTitre = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPseudo = new System.Windows.Forms.Panel();
            this.panelLigne = new System.Windows.Forms.Panel();
            this.labelPseudo = new System.Windows.Forms.Label();
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.labelMDP = new System.Windows.Forms.Label();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.panelLigne2 = new System.Windows.Forms.Panel();
            this.checkBoxAffiche = new System.Windows.Forms.CheckBox();
            this.panelConnection = new System.Windows.Forms.Panel();
            this.labelConnection = new System.Windows.Forms.Label();
            this.labelErreur = new System.Windows.Forms.Label();
            this.panelpwd = new System.Windows.Forms.Panel();
            this.panelErreur = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitre.SuspendLayout();
            this.panelPseudo.SuspendLayout();
            this.panelConnection.SuspendLayout();
            this.panelpwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panelTitre.Controls.Add(this.panelClose);
            this.panelTitre.Controls.Add(this.label1);
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(400, 50);
            this.panelTitre.TabIndex = 41;
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.Transparent;
            this.panelClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelClose.BackgroundImage")));
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelClose.Location = new System.Drawing.Point(350, -1);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(50, 50);
            this.panelClose.TabIndex = 21;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(124, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "S\'identifier";
            // 
            // panelPseudo
            // 
            this.panelPseudo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPseudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPseudo.Controls.Add(this.panelLigne);
            this.panelPseudo.Controls.Add(this.labelPseudo);
            this.panelPseudo.Controls.Add(this.textBoxPseudo);
            this.panelPseudo.Location = new System.Drawing.Point(89, 82);
            this.panelPseudo.Name = "panelPseudo";
            this.panelPseudo.Size = new System.Drawing.Size(270, 50);
            this.panelPseudo.TabIndex = 40;
            this.panelPseudo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPseudo_Paint);
            // 
            // panelLigne
            // 
            this.panelLigne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panelLigne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLigne.Location = new System.Drawing.Point(25, 36);
            this.panelLigne.Name = "panelLigne";
            this.panelLigne.Size = new System.Drawing.Size(243, 1);
            this.panelLigne.TabIndex = 24;
            this.panelLigne.Visible = false;
            // 
            // labelPseudo
            // 
            this.labelPseudo.AutoSize = true;
            this.labelPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPseudo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.labelPseudo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPseudo.Location = new System.Drawing.Point(29, 15);
            this.labelPseudo.Name = "labelPseudo";
            this.labelPseudo.Size = new System.Drawing.Size(59, 18);
            this.labelPseudo.TabIndex = 1;
            this.labelPseudo.Text = "Pseudo";
            this.labelPseudo.Click += new System.EventHandler(this.labelPseudo_Click);
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPseudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPseudo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.textBoxPseudo.Location = new System.Drawing.Point(26, 16);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(241, 17);
            this.textBoxPseudo.TabIndex = 2;
            this.textBoxPseudo.Visible = false;
            this.textBoxPseudo.Click += new System.EventHandler(this.textBoxPseudo_Click);
            this.textBoxPseudo.TextChanged += new System.EventHandler(this.textBoxPseudo_TextChanged);
            // 
            // labelMDP
            // 
            this.labelMDP.AutoSize = true;
            this.labelMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.labelMDP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMDP.Location = new System.Drawing.Point(29, 15);
            this.labelMDP.Name = "labelMDP";
            this.labelMDP.Size = new System.Drawing.Size(98, 18);
            this.labelMDP.TabIndex = 2;
            this.labelMDP.Text = "Mot de passe";
            this.labelMDP.Click += new System.EventHandler(this.labelMDP_Click);
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMDP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.textBoxMDP.Location = new System.Drawing.Point(26, 16);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.Size = new System.Drawing.Size(241, 17);
            this.textBoxMDP.TabIndex = 3;
            this.textBoxMDP.UseSystemPasswordChar = true;
            this.textBoxMDP.Visible = false;
            this.textBoxMDP.Click += new System.EventHandler(this.textBoxMDP_Click);
            this.textBoxMDP.TextChanged += new System.EventHandler(this.textBoxMDP_TextChanged);
            // 
            // panelLigne2
            // 
            this.panelLigne2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panelLigne2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLigne2.Location = new System.Drawing.Point(26, 36);
            this.panelLigne2.Name = "panelLigne2";
            this.panelLigne2.Size = new System.Drawing.Size(243, 1);
            this.panelLigne2.TabIndex = 25;
            this.panelLigne2.Visible = false;
            // 
            // checkBoxAffiche
            // 
            this.checkBoxAffiche.AutoSize = true;
            this.checkBoxAffiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAffiche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.checkBoxAffiche.Location = new System.Drawing.Point(40, 209);
            this.checkBoxAffiche.Name = "checkBoxAffiche";
            this.checkBoxAffiche.Size = new System.Drawing.Size(139, 19);
            this.checkBoxAffiche.TabIndex = 46;
            this.checkBoxAffiche.Text = "Affiche Mot de passe";
            this.checkBoxAffiche.UseVisualStyleBackColor = true;
            this.checkBoxAffiche.CheckedChanged += new System.EventHandler(this.checkBoxAffiche_CheckedChanged);
            // 
            // panelConnection
            // 
            this.panelConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panelConnection.Controls.Add(this.labelConnection);
            this.panelConnection.Location = new System.Drawing.Point(38, 266);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Size = new System.Drawing.Size(321, 50);
            this.panelConnection.TabIndex = 42;
           // this.panelConnection.Click += new System.EventHandler(this.panelConnection_Click);
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnection.ForeColor = System.Drawing.Color.White;
            this.labelConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelConnection.Location = new System.Drawing.Point(102, 12);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(107, 25);
            this.labelConnection.TabIndex = 0;
            this.labelConnection.Text = "Connexion";
         //   this.labelConnection.Click += new System.EventHandler(this.panelConnection_Click);
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.BackColor = System.Drawing.Color.Transparent;
            this.labelErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErreur.ForeColor = System.Drawing.Color.Red;
            this.labelErreur.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelErreur.Location = new System.Drawing.Point(64, 240);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(235, 16);
            this.labelErreur.TabIndex = 39;
            this.labelErreur.Text = "   Pseudo ou mot de passe incorrecte  ";
            this.labelErreur.Visible = false;
            // 
            // panelpwd
            // 
            this.panelpwd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelpwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelpwd.Controls.Add(this.panelLigne2);
            this.panelpwd.Controls.Add(this.labelMDP);
            this.panelpwd.Controls.Add(this.textBoxMDP);
            this.panelpwd.Location = new System.Drawing.Point(77, 149);
            this.panelpwd.Name = "panelpwd";
            this.panelpwd.Size = new System.Drawing.Size(282, 50);
            this.panelpwd.TabIndex = 43;
            this.panelpwd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelpwd_Paint);
            // 
            // panelErreur
            // 
            this.panelErreur.BackColor = System.Drawing.Color.Transparent;
            this.panelErreur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelErreur.BackgroundImage")));
            this.panelErreur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelErreur.Location = new System.Drawing.Point(40, 232);
            this.panelErreur.Name = "panelErreur";
            this.panelErreur.Size = new System.Drawing.Size(27, 25);
            this.panelErreur.TabIndex = 47;
            this.panelErreur.Visible = false;
            this.panelErreur.Paint += new System.Windows.Forms.PaintEventHandler(this.panelErreur_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(40, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 50);
            this.panel4.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(40, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 44;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 345);
            this.Controls.Add(this.panelTitre);
            this.Controls.Add(this.panelPseudo);
            this.Controls.Add(this.checkBoxAffiche);
            this.Controls.Add(this.panelConnection);
            this.Controls.Add(this.panelErreur);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelpwd);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Click += new System.EventHandler(this.Login_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
            this.panelPseudo.ResumeLayout(false);
            this.panelPseudo.PerformLayout();
            this.panelConnection.ResumeLayout(false);
            this.panelConnection.PerformLayout();
            this.panelpwd.ResumeLayout(false);
            this.panelpwd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPseudo;
        private System.Windows.Forms.Panel panelLigne;
        private System.Windows.Forms.Label labelPseudo;
        private System.Windows.Forms.TextBox textBoxPseudo;
        private System.Windows.Forms.Label labelMDP;
        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.Panel panelLigne2;
        private System.Windows.Forms.CheckBox checkBoxAffiche;
        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.Panel panelErreur;
        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelpwd;
    }
}