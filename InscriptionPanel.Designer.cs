namespace GestionDesDoctorantsV2
{
    partial class InscriptionPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelClotAnne = new System.Windows.Forms.Panel();
            this.panelExpInsc = new System.Windows.Forms.Panel();
            this.panelOuvertuAnne = new System.Windows.Forms.Panel();
            this.panelImpInsc = new System.Windows.Forms.Panel();
            this.panelConInsc = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelClotAnne);
            this.panel1.Controls.Add(this.panelExpInsc);
            this.panel1.Controls.Add(this.panelOuvertuAnne);
            this.panel1.Controls.Add(this.panelImpInsc);
            this.panel1.Controls.Add(this.panelConInsc);
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
            this.panel2.TabIndex = 4;
            // 
            // panelClotAnne
            // 
            this.panelClotAnne.BackColor = System.Drawing.Color.Transparent;
            this.panelClotAnne.BackgroundImage = global::GestionDesDoctorantsV2.Properties.Resources.clotureAnne;
            this.panelClotAnne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelClotAnne.Location = new System.Drawing.Point(400, 284);
            this.panelClotAnne.Name = "panelClotAnne";
            this.panelClotAnne.Size = new System.Drawing.Size(250, 175);
            this.panelClotAnne.TabIndex = 4;
            // 
            // panelExpInsc
            // 
            this.panelExpInsc.BackColor = System.Drawing.Color.Transparent;
            this.panelExpInsc.BackgroundImage = global::GestionDesDoctorantsV2.Properties.Resources.Exportnou;
            this.panelExpInsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelExpInsc.Location = new System.Drawing.Point(681, 79);
            this.panelExpInsc.Name = "panelExpInsc";
            this.panelExpInsc.Size = new System.Drawing.Size(250, 175);
            this.panelExpInsc.TabIndex = 7;
            // 
            // panelOuvertuAnne
            // 
            this.panelOuvertuAnne.BackgroundImage = global::GestionDesDoctorantsV2.Properties.Resources.MenuNew01;
            this.panelOuvertuAnne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelOuvertuAnne.Location = new System.Drawing.Point(121, 284);
            this.panelOuvertuAnne.Name = "panelOuvertuAnne";
            this.panelOuvertuAnne.Size = new System.Drawing.Size(250, 175);
            this.panelOuvertuAnne.TabIndex = 3;
            // 
            // panelImpInsc
            // 
            this.panelImpInsc.BackColor = System.Drawing.Color.Transparent;
            this.panelImpInsc.BackgroundImage = global::GestionDesDoctorantsV2.Properties.Resources.ImpInscnou;
            this.panelImpInsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImpInsc.Location = new System.Drawing.Point(400, 79);
            this.panelImpInsc.Name = "panelImpInsc";
            this.panelImpInsc.Size = new System.Drawing.Size(250, 175);
            this.panelImpInsc.TabIndex = 8;
            // 
            // panelConInsc
            // 
            this.panelConInsc.BackColor = System.Drawing.Color.Transparent;
            this.panelConInsc.BackgroundImage = global::GestionDesDoctorantsV2.Properties.Resources.ConsultInsc;
            this.panelConInsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelConInsc.Location = new System.Drawing.Point(121, 79);
            this.panelConInsc.Name = "panelConInsc";
            this.panelConInsc.Size = new System.Drawing.Size(250, 175);
            this.panelConInsc.TabIndex = 9;
            this.panelConInsc.Click += new System.EventHandler(this.panelConInsc_Click);
            // 
            // InscriptionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "InscriptionPanel";
            this.Size = new System.Drawing.Size(1076, 557);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelOuvertuAnne;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelClotAnne;
        private System.Windows.Forms.Panel panelExpInsc;
        private System.Windows.Forms.Panel panelImpInsc;
        private System.Windows.Forms.Panel panelConInsc;
    }
}
