using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace GestionDesDoctorantsV2
{

    public partial class FicheDoctorants : Form
    {
       public int id;
       DataTable dt2 = new DataTable();
       string cin;
       DataTable dt7 = new DataTable();
       int mode = 0;
       DataTable dt = new DataTable();
       DataTable dt1 = new DataTable();
       DAL.DALDoctorant doctdoc = new DAL.DALDoctorant();
       string chemain = "";
       string Paths = @"C:\Users\aymen\Documents\visual studio 2013\Projects\GestionDesDoctorantsV2\GestionDesDoctorantsV2\Documents\";
        public FicheDoctorants(int id1 )
        {
            InitializeComponent();
            id = id1;
            RemplirFiche(id);
            panelModDoc.Visible = true ;
           
            

           dt1 = doctdoc.SelectCINById(id);
          cin = dt1.Rows[0][0].ToString().Trim();

            RaffraichirGridDoc();

            //manque vider formulaire
        }

        public void RemplirFiche(int id)
        {
            DAL.DALDoctorant D = new DAL.DALDoctorant();
            dt2 = D.SelectDoctorant(id);
            lblConsCIN.Text = dt2.Rows[0][1].ToString().Trim();
            lblConsNumInsc.Text = dt2.Rows[0][2].ToString().Trim();
            lblConNomPrenom.Text = dt2.Rows[0][3].ToString().Trim() + " " + dt2.Rows[0][5].ToString().Trim();
            lblConNomPrAr.Text = dt2.Rows[0][4].ToString().Trim() + " " + dt2.Rows[0][6].ToString().Trim();
            lblConNomJeuFilFr.Text = dt2.Rows[0][7].ToString().Trim();
            lblConNomJeuFilAr.Text = dt2.Rows[0][8].ToString().Trim();
            lblConSexe.Text = dt2.Rows[0][10].ToString().Trim();
            lblConDatNaiss.Text = dt2.Rows[0][11].ToString().Trim();
            lblConLieuNaiss.Text = dt2.Rows[0][12].ToString().Trim();
            lblConNat.Text = dt2.Rows[0][13].ToString().Trim();
            lblConPaysOrig.Text = dt2.Rows[0][14].ToString().Trim();
            lblConCivilite.Text = dt2.Rows[0][15].ToString().Trim();
            lblConProfon.Text = dt2.Rows[0][16].ToString().Trim();
            lblConEmploy.Text = dt2.Rows[0][17].ToString().Trim();
            lblConEmail.Text = dt2.Rows[0][18].ToString().Trim();
            lblConTel.Text = dt2.Rows[0][19].ToString().Trim();
            lblConAdress.Text = dt2.Rows[0][20].ToString().Trim();
            lblConVill.Text = dt2.Rows[0][21].ToString().Trim();
            lblConGouv.Text = dt2.Rows[0][22].ToString().Trim();
            lblConPost.Text = dt2.Rows[0][23].ToString().Trim();
           
            lblConDerDip.Text = dt2.Rows[0][24].ToString().Trim();
            lblConDateDip.Text = dt2.Rows[0][25].ToString().Trim();
            lblConLieuDip.Text = dt2.Rows[0][26].ToString().Trim();
            lblConEcoDoct.Text=dt2.Rows[0][27].ToString().Trim();
            lblConsSpec.Text = dt2.Rows[0][28].ToString().Trim();
            lblConSujet.Text = dt2.Rows[0][29].ToString().Trim();
            lblConStatut.Text = dt2.Rows[0][30].ToString().Trim();
            
            lblConEtatPai.Text = dt2.Rows[0][31].ToString();

            

            
            
            
            
           
            
            //label20.Text = dt2.Rows[0][4].ToString().Trim() + " " + dt2.Rows[0][6].ToString().Trim();
            
            //TAlias.Text = dt2.Rows[0][12].ToString().Trim();
            //TSexe.Text = dt2.Rows[0][13].ToString().Trim();
            //TDateNaissance.Text = ((DateTime)dt2.Rows[0][14]).ToString("dd/M/yyyy");
            //TLieuNaissance.Text = dt2.Rows[0][15].ToString().Trim();
            //TNationnalite.Text = dt2.Rows[0][17].ToString().Trim();
            //txtCivilite.Text = dt2.Rows[0][19].ToString().Trim();
            //txtNbEnfant.Text = dt2.Rows[0][20].ToString().Trim();
            //TTel1.Text = dt2.Rows[0][21].ToString().Trim();
            //TTel2.Text = dt2.Rows[0][22].ToString().Trim();
            //TMail.Text = dt2.Rows[0][23].ToString().Trim();
            //TAdresse.Text = dt2.Rows[0][24].ToString().Trim();
            //TVille.Text = dt2.Rows[0][26].ToString().Trim();
            //TCodePostale.Text = dt2.Rows[0][28].ToString().Trim();

            //TDepartement.Text = d.NomFr.Trim();
            //TDiplome.Text = dt7.Rows[0][2].ToString().Trim();
            //DAL.DALTypePromotion TD = new DAL.DALTypePromotion();
            //Entitée.TypePromotion P = new Entitée.TypePromotion();
            //P = TD.SelectById(int.Parse(dt7.Rows[0][3].ToString().Trim()));
            //TGrade.Text = P.Code.Trim();
            //txtTypeAdmission.Text = dt7.Rows[0][5].ToString().Trim();
            //TPeriode.Text = dt7.Rows[0][7].ToString().Trim();
            //txtAnneeUniver.Text = dt7.Rows[0][6].ToString().Trim();
            if (dt2.Rows[0][9].ToString() != "")
            {
                byte[] img = (byte[])(dt2.Rows[0][9]);
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
            //TxtObs.Text = dt2.Rows[0][35].ToString().Trim();

        }
        
        private void FicheEnseignantPermanant_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(51, 122, 183), 2);
            e.Graphics.DrawRectangle(couleur, 1, 1, this.Width - 2, this.Height - 2);
        }
       

       
        //}

        private void panelAnnuler_Click(object sender, EventArgs e)
        {
            panelAffDoct.Visible = true;
            panelModDoc.Visible = false;

            //panel7.Visible = true;
            btnModifier.Visible = true;
            btnSupprimer.Visible = true;
          
            btnImprimer.Visible = true;
            
            //btnHistoriqueAdministrative.Visible = true;

            panelEnregistrer.Visible = false;
            panelAnnuler.Visible = false;
        }


        private void panelEnregistrer_MouseEnter(object sender, EventArgs e)
        {
            panelEnregistrer.BackColor = Color.FromArgb(133, 202, 255);
            labelEnregistrer.ForeColor = Color.White;
        }

        private void panelEnregistrer_MouseLeave(object sender, EventArgs e)
        {
            panelEnregistrer.BackColor = Color.White;
            labelEnregistrer.ForeColor = Color.FromArgb(10, 56, 84);
        }

        private void panelAnnuler_MouseEnter(object sender, EventArgs e)
        {
            panelAnnuler.BackColor = Color.FromArgb(133, 202, 255);
            labelAnnuler.ForeColor = Color.White;
        }

        private void panelAnnuler_MouseLeave(object sender, EventArgs e)
        {
            panelAnnuler.BackColor = Color.White;
            labelAnnuler.ForeColor = Color.FromArgb(10, 56, 84);
        }

        private void panelEnregistrer_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelEnregistrer.Width - 1, panelEnregistrer.Height - 1);
        }

        private void panelAnnuler_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelAnnuler.Width - 1, panelAnnuler.Height - 1);
        }

        ////////////////////////////////////////Modifier///////////////////////////////////////////////////

        private void btnModifier_MouseEnter(object sender, EventArgs e)
        {
            btnModifier.BackColor = Color.FromArgb(133, 202, 255);
            labelModifier.ForeColor = Color.White;
        }

        private void btnModifier_MouseLeave(object sender, EventArgs e)
        {
            btnModifier.BackColor = Color.White;
            labelModifier.ForeColor = Color.FromArgb(10, 56, 84);
        }

        private void btnModifier_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnModifier.Width - 1, btnModifier.Height - 1);
        }

        ////////////////////////////////////////Supprimer///////////////////////////////////////////////////

        private void btnSupprimer_MouseEnter(object sender, EventArgs e)
        {
            btnSupprimer.BackColor = Color.FromArgb(133, 202, 255);
            labelSupprimer.ForeColor = Color.White;
        }

        private void btnSupprimer_MouseLeave(object sender, EventArgs e)
        {
            btnSupprimer.BackColor = Color.White;
            labelSupprimer.ForeColor = Color.FromArgb(10, 56, 84);
        }

        private void btnSupprimer_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnSupprimer.Width - 1, btnSupprimer.Height - 1);
        }


      
       

        ////////////////////////////////////////Grade///////////////////////////////////////////////////

        ////////////////////////////////////////Imprimer///////////////////////////////////////////////////

        private void btnImprimer_MouseEnter(object sender, EventArgs e)
        {
            btnImprimer.BackColor = Color.FromArgb(133, 202, 255);
            labelImprimer.ForeColor = Color.White;
        }

        private void btnImprimer_MouseLeave(object sender, EventArgs e)
        {
            btnImprimer.BackColor = Color.White;
            labelImprimer.ForeColor = Color.FromArgb(10, 56, 84);
        }

        private void btnImprimer_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnImprimer.Width - 1, btnImprimer.Height - 1);
        }

        ////////////////////////////////////////Archiver///////////////////////////////////////////////////

       

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panel15.Width - 1, panel15.Height - 1);
        }


      

      
    
    

      

        

        //private void labelDocuments_Click(object sender, EventArgs e)
        //{
        //    GestionDocument frm = new GestionDocument(id);
        //   frm.ShowDialog();
        //}
        
       //000////document/////////
      
        public void RaffraichirGridDoc()
        {
            mode = 0;
            DAL.DALDocuments d = new DAL.DALDocuments();
            dt = d.SelectAllDocument(id);
            DGVDocument.Rows.Clear();

            DAL.DALTypeDocument TDOC = new DAL.DALTypeDocument();
            Entities.TypeDocument doc = new Entities.TypeDocument();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                doc = TDOC.SelectById(int.Parse(dt.Rows[i][2].ToString()));
                DGVDocument.Rows.Add(doc.LibelleFr.Trim(), dt.Rows[i][4].ToString().Trim(), "Voir");
            }

            DataTable dt200 = new DataTable();
            DAL.DALTypeDocument t = new DAL.DALTypeDocument();
            //dt200 = t.SelectAllTypeDocument();
            //cmbTypeDocument.DataSource = dt1;
            //cmbTypeDocument.ValueMember = "IdTypeDocument";
            //cmbTypeDocument.DisplayMember = "Code";
        }

        
        private void AddDoc_Click(object sender, EventArgs e)
        {
            mode = 0;

            GestionDocument frm = new GestionDocument(id, mode);
            frm.ShowDialog();
            RaffraichirGridDoc();

        }
        private void FicheDoctorants_Load(object sender, EventArgs e)
        {
            RaffraichirGridDoc();
           
        }

        //private void DGVDocument_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if(DGVDocument.Rows[e.RowIndex].Cells[e.ColumnIndex]is DataGridViewLinkCell)
        //    {
        //        int x = DGVDocument.CurrentRow.Index;
        //        string lien = @"C:\Users\SatelliteT\Documents\visual studio 2013\Projects\GestionEnseignant\GestionEnseignant\Documents\" + dt.Rows[x][7].ToString().Trim();
        //        MessageBox.Show(lien);
        //        //OpenFileDialog openFileDialog1 = new OpenFileDialog();
        //        //if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //        //{
        //            System.Diagnostics.Process.Start(lien);
        //        //}
        //        //int x = DGVDocument.CurrentRow.Index;
        //        //AfficherDocument frm = new AfficherDocument(int.Parse(dt.Rows[x][0].ToString()),Paths);
        //        //frm.ShowDialog();
        //    }
        //}
       
        private void ErreurNationnaliteArabe_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNbInscritsConsult_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            panelModDoc.Visible = true;
            panelAffDoct.Visible = false;
            btnModifier.Visible = false;
            btnSupprimer.Visible = false;
            
            btnImprimer.Visible = false;
           
            btnModifier.Visible = false;
           
            
            panelEnregistrer.Visible = true;
            panelAnnuler.Visible = true;
            
        }

        private void label64_Click_1(object sender, EventArgs e)
        {

        }

        private void panelAffNom_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelAffNom.Width - 1, panelAffNom.Height - 1);
        }

        

        

        
        private void panelContainTcInsc_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelContainTcInsc.Width - 1, panelContainTcInsc.Height - 1);
        }

       
        private void panelModNaiss_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelModNaiss.Width - 1, panelModNaiss.Height - 1);
        }

        private void PanelModDoct_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, PanelModDoct.Width - 1, PanelModDoct.Height - 1);
        }

        private void panelModEmp_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelModEmp.Width - 1, panelModEmp.Height - 1);
        }

        private void panelModContact_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelModContact.Width - 1, panelModContact.Height - 1);
        }

        private void panelModEcoDoct_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelModEcoDoct.Width - 1, panelModEcoDoct.Height - 1);
        }

    

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void txtConNomJeuFilleFr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void txtConNomJeuFilleAr_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelAffStatus_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelAffStatus.Width - 1, panelAffStatus.Height - 1);
        }

        private void panelAffContThese_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelAffContThese.Width - 1, panelAffContThese.Height - 1);
        }

        private void btnAddItem_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnAddInsc.Width - 1, btnAddInsc.Height - 1);
        }
        private void btnUpdateItem_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnUpdateInsc.Width - 1, btnUpdateInsc.Height - 1);
        }

        private void btnDelItem_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnDelInsc.Width - 1, btnDelInsc.Height - 1);
        }

        private void panelActionItem_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(221, 221, 221), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelActionItem.Width - 1, panelActionItem.Height - 1);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(221, 221, 221), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelActionItem.Width - 1, panelActionItem.Height - 1);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnAddCurs.Width - 1, btnAddCurs.Height - 1);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnUpadteCurs.Width - 1, btnUpadteCurs.Height - 1);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnDelCurs.Width - 1, btnDelCurs.Height - 1);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(221, 221, 221), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panel9.Width - 1, panel9.Height - 1);
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnAddSout.Width - 1, btnAddSout.Height - 1);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnUpdateSout.Width - 1, btnUpdateSout.Height - 1);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnDelSout.Width - 1, btnDelSout.Height - 1);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(221, 221, 221), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panel5.Width - 1, panel5.Height - 1);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnAddDoc.Width - 1, btnAddDoc.Height - 1);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnUpdateDoc.Width - 1, btnUpdateDoc.Height - 1);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnDelDoc.Width - 1, btnDelDoc.Height - 1);
        }

        private void UpdateDoc_Click(object sender, EventArgs e)
        {
            mode = 1;

            if (DGVDocument.Rows.Count > 0)
            {
                int x = DGVDocument.CurrentRow.Index;
                int id = int.Parse(dt.Rows[x][0].ToString());
                GestionDocument frm = new GestionDocument(id, mode);
                frm.ShowDialog();
                RaffraichirGridDoc();
            }
            else
            {
                MessageBox.Show("Aucun Etablissement sélectionné!!");
            }



           

            
           
            //mode = 1;
            //panel2.Visible = true;
            //button1.Enabled = false;
            //txtDocument.Enabled = false;
            //int x = DGVDocument.CurrentRow.Index;
            //int IdDoc = int.Parse(dt.Rows[x][0].ToString());
            //DataTable dt1 = new DataTable();
            //DAL.DALDocuments d = new DAL.DALDocuments();
            //dt1 = d.SelectDocumentById(IdDoc);
            //cmbTypeDocument.SelectedValue = int.Parse(dt1.Rows[0][3].ToString());
            //txtNomFr.Text = dt1.Rows[0][4].ToString().Trim();
            //txtNomAr.Text = dt1.Rows[0][5].ToString().Trim();
            //txtCommentaire.Text = dt1.Rows[0][6].ToString().Trim();
            //txtDocument.Text = dt1.Rows[0][7].ToString().Trim();
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panaffinfpers_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panaffinfpers.Width - 1, panaffinfpers.Height - 1);
        }

      

        private void panaffinfopro_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panaffinfopro.Width - 1, panaffinfopro.Height - 1);
        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void paneSoutInfo_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, paneSoutInfo.Width - 1, paneSoutInfo.Height - 1);
        }



       


        //private void panelStatut_Click(object sender, EventArgs e)
        //{
        //    ParametresStatut paramStatut = new ParametresStatut(w, h);
        //    panel2.Visible = true;
        //    panel2.Controls.Add(pictureMenu);
        //    pictureMenu.Visible = true;
        //    pictureMenu.Location = new Point(panel2.Width - pictureMenu.Width, panel2.Height - pictureMenu.Height);
        //    panel2.Controls.Add(paramStatut);
        //}
        

     

       
      

      

      
      

        
    }
}
