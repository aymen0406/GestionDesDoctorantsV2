using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDesDoctorantsV2
{
    public partial class InscriptionPanel : UserControl
    {
        
         
        public InscriptionPanel(int w ,int h)
        {
            InitializeComponent();
            this.Width = w;
            this.Height = h;
            int heightEtat = h / 13;
            panel2.Visible = false;
            //pnaelConsulterInscription
            panelConInsc.Width = heightEtat * 7;
            panelConInsc.Height = heightEtat * 5;
            panelConInsc.Location = new Point((w - (heightEtat * 21)) / 4, heightEtat);

            //PanelImporterInscription
            panelImpInsc.Width = heightEtat * 7;
            panelImpInsc.Height = heightEtat * 5;
            panelImpInsc.Location = new Point((((w - (heightEtat * 21)) / 4) * 2) + (heightEtat * 7), heightEtat);

            //PanelExporterInscription
            panelExpInsc.Width = heightEtat * 7;
            panelExpInsc.Height = heightEtat * 5;
            panelExpInsc.Location = new Point((((w - (heightEtat * 21)) / 4) * 3) + ((heightEtat * 7) * 2), heightEtat);

            //panelOuvertureAnne
            panelOuvertuAnne.Width = heightEtat * 7;
            panelOuvertuAnne.Height = heightEtat * 5;
            panelOuvertuAnne.Location = new Point((w - (heightEtat * 21)) / 4, heightEtat * 7);

            //panelClotureAnne
            panelClotAnne.Width = heightEtat * 7;
            panelClotAnne.Height = heightEtat * 5;
            panelClotAnne.Location = new Point((((w - (heightEtat * 21)) / 4) * 2) + (heightEtat * 7), heightEtat * 7);
        }

        //public InscriptionPanel(int w1, int h1)
        //{
        //    InitializeComponent();
        //    w = w1;
        //    h = h1;
        //    this.Height = h;
        //    this.Width = w;
        //    panel1.Height = h;
        //    panel1.Width = w;
        //    panel2.Height = h;
        //    panel2.Width = w;

        //    panel2.Visible = false;
           
        //    panel2.Visible = false;
            
        //}
       
       

       

        //private void panelConsulterInsc_Click(object sender, EventArgs e)
        //{

        //    panel1.Visible = false;
        //    panel2.Visible = true;
        //    InscriptionAffiche InscAffiche = new InscriptionAffiche(this.Width,this.Height);
        //    panel2.Controls.Add(InscAffiche);
        //}

        private void panelConInsc_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            InscriptionAffiche InscAffiche = new InscriptionAffiche(this.Width, this.Height);
            panel2.Controls.Add(InscAffiche);
        }
    }
}
