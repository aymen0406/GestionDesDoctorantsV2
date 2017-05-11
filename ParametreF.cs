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
    public partial class ParametreF : UserControl
    {
       

        public ParametreF(int w, int h)
        {
            InitializeComponent();
            this.Width = w;
            this.Height = h;
            int heightEtat = h / 13;
            panel2.Visible = false;
            //panel2.Visible = false;
          

            //panel Encadrant
            panelEncadrant.Width = heightEtat * 7;
            panelEncadrant.Height = heightEtat * 5;
            panelEncadrant.Location = new Point((w - (heightEtat * 21)) / 4, heightEtat);
           

            //panelInstitution
            panelinstitut.Width = heightEtat * 7;
            panelinstitut.Height = heightEtat * 5;
            panelinstitut.Location = new Point((((w - (heightEtat * 21)) / 4) * 2) + (heightEtat * 7), heightEtat);
  //          

            //panel StructureDe Rechecrche
            panelStructRech.Width = heightEtat * 7;
            panelStructRech.Height = heightEtat * 5;
            panelStructRech.Location = new Point((((w - (heightEtat * 21)) / 4) * 3) + ((heightEtat * 7) * 2), heightEtat);
//         

            //pane type de documents
            panelTypeDoc.Width = heightEtat * 7;
            panelTypeDoc.Height = heightEtat * 5;
            panelTypeDoc.Location = new Point((w - (heightEtat * 21)) / 4, heightEtat * 7);
   

        }

        //private void panelConge_Click(object sender, EventArgs e)
        //{
        //    ParametresConge paramConge = new ParametresConge( w,h);
        //    panel2.Visible = true;
        //    panel2.Controls.Add(pictureMenu);
        //    pictureMenu.Visible = true;
        //    pictureMenu.Location = new Point(w - pictureMenu.Width, h - pictureMenu.Height);
        //    panel2.Controls.Add(paramConge);
        //}

        //private void panelDepartement_Click(object sender, EventArgs e)
        //{
        //    ParametresTypeDocument paramDep = new ParametresTypeDocument(w, h);
        //    panel2.Visible = true;
        //    panel2.Controls.Add(pictureMenu);
        //    pictureMenu.Visible = true;
        //    pictureMenu.Location = new Point(panel2.Width - pictureMenu.Width, panel2.Height - pictureMenu.Height);
        //    panel2.Controls.Add(paramDep);
        //}

        //private void panelFonctionnalite_Click(object sender, EventArgs e)
        //{
        //    ParametresFonctionnalite paramFonc = new ParametresFonctionnalite(w, h);
        //    panel2.Visible = true;
        //    panel2.Controls.Add(pictureMenu);
        //    pictureMenu.Visible = true;
        //    pictureMenu.Location = new Point(panel2.Width - pictureMenu.Width, panel2.Height - pictureMenu.Height);
        //    panel2.Controls.Add(paramFonc);
        //}

        //private void panelGrade_Click(object sender, EventArgs e)
        //{
        //    ParametresGrade paramGr = new ParametresGrade(w, h);
        //    panel2.Visible = true;
        //    panel2.Controls.Add(pictureMenu);
        //    pictureMenu.Visible = true;
        //    pictureMenu.Location = new Point(panel2.Width - pictureMenu.Width, panel2.Height - pictureMenu.Height);
        //    panel2.Controls.Add(paramGr);
        //}

        //private void panelStatut_Click(object sender, EventArgs e)
        //{
        //    ParametresStatut paramStatut = new ParametresStatut(w, h);
        //    panel2.Visible = true;
        //    panel2.Controls.Add(pictureMenu);
        //    pictureMenu.Visible = true;
        //    pictureMenu.Location = new Point(panel2.Width - pictureMenu.Width, panel2.Height - pictureMenu.Height);
        //    panel2.Controls.Add(paramStatut);
        //}

        
     

        

        private void panelEncadrant_Click_1(object sender, EventArgs e)
        {
            //PanelAffEncadrant choix = new PanelAffEncadrant();
            //choix.Visible = true;
            panel2.Visible = true;
           // add_button_menu();
            EnseignantCherch Ensch = new EnseignantCherch(this.Width, this.Height);
           // interfaces.SallesFSM f = new interfaces.SallesFSM(this.Width, this.Height);
            panel2.Controls.Add(Ensch);
        }

        private void panelinstitut_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            institut inst = new institut(this.Width, this.Height);
            panel2.Controls.Add(inst);
        }

        private void panelStructRech_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            ParametresStructRech inst = new ParametresStructRech(this.Width, this.Height);
            panel2.Controls.Add(inst);
        }

        private void panelEncadrant_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTypeDoc_Click(object sender, EventArgs e)
        {
            ParametresTypeDocument paramDep = new ParametresTypeDocument(this.Width,this.Height);
            panel2.Visible = true;
            //panel2.Controls.Add(pictureMenu);
            //pictureMenu.Visible = true;
            //pictureMenu.Location = new Point(panel2.Width - pictureMenu.Width, panel2.Height - pictureMenu.Height);
            panel2.Controls.Add(paramDep);
        }

        

        //private void panelMotifDepart_Click(object sender, EventArgs e)
        //{
        //    FormFrançais.MotifDepartFr frm = new FormFrançais.MotifDepartFr(w, h);
        //    panel2.Visible = true;
        //    panel2.Controls.Add(pictureMenu);
        //    pictureMenu.Visible = true;
        //    pictureMenu.Location = new Point(panel2.Width - pictureMenu.Width, panel2.Height - pictureMenu.Height);
        //    panel2.Controls.Add(frm);
        //}
    }
}
