using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;


namespace GestionDesDoctorantsV2
{
    public partial class Ajouter_Doctorants : Form
    {
        public string CIN_Passeport;
        int i = 0;
        DataTable dt10 = new DataTable();
        DataTable dt20 = new DataTable();
        public Ajouter_Doctorants()
        {
            InitializeComponent();
            
           // txtCin.Text = CIN_Passeport;
            
            CacherErreur();
            panelEnregistrer.Visible = true;
            panelAnnuler.Visible = true;
        }
        //public Ajouter_Doctorants(string CIN_Passeport1, int k)
        //{
        //    k = 1;
        //    InitializeComponent();
        //    CacherErreur();
        //    CIN_Passeport = CIN_Passeport1;
           
            
            
        //        panelEnregistrer.Visible = false;
        //        panelAnnuler.Visible = false;
            
        //}

        public void CacherErreur()
        {
            ErreurCin.Visible = false;
            ErreurNumInsc.Visible = false;
            ErreurNomFr.Visible = false;
            ErreurPrenomFr.Visible = false;
            ErreurNomAr.Visible = false;
            ErreurPrenomAr.Visible = false;
            ErreurDateNaiss.Visible = false;
            ErreurLieuNaiss.Visible = false;
            ErreurNational.Visible = false;
            ErreurPaysOrig.Visible = false;
            ErreurCivilite.Visible = false;
            ErreurSexe.Visible = false;
            ErreurMail.Visible = false;
            ErreurTel.Visible = false;
            ErreurGouvernorat.Visible = false;
            ErreurVille.Visible = false;
            ErreurCodePostal.Visible = false;
            ErreurAdresse.Visible = false;
            ErreurDerDiplome.Visible = false;
            ErreurEcoleDoct.Visible = false;
            ErreurSpecialite.Visible = false;
            ErreurSujet.Visible = false;
            ErreurEncadrant.Visible = false;
            ErreurStatut.Visible = false;
            ErreurEtatPaiAc.Visible = false;
        }

        public void AfficherErreur()
        {

            if ((txtCin.Text == ""))
            { ErreurCin.Visible = true; }
            else
            { ErreurCin.Visible = false; }
            
            if (txtNumInsc.Text == "")
            { ErreurNumInsc.Visible = true; }
            else
            { ErreurNumInsc.Visible = false; }

            if (txtNomFr.Text == "")
            { ErreurNomFr.Visible = true; }
            else
            { ErreurNomFr.Visible = false; }
           
            if (txtPrenomFr.Text == "")
            { ErreurPrenomFr.Visible = true; }
            else
            { ErreurPrenomFr.Visible = false; }
           
            if (txtNomAr.Text == "")
            { ErreurNomAr.Visible = true; }
            else
            { ErreurNomAr.Visible = false; }

            if (txtPrenomAr.Text == "")
            { ErreurPrenomAr.Visible = true; }
            else
            { ErreurPrenomAr.Visible = false; }

            if (DateTimePickerDateNaissance.Checked == true)
            { ErreurDateNaiss.Visible = false; }
            else
            { ErreurDateNaiss.Visible = true; }

            if (txtLieuNaiss.Text == "")
            { ErreurLieuNaiss.Visible = true; }
            else
            { ErreurLieuNaiss.Visible = false; }

            if (cmbxNationalite.Text == "")
            { ErreurNational.Visible = true; }
            else
            { ErreurNational.Visible = false; }

            if (cmbxPaysOrig.Text == "")
            { ErreurPaysOrig.Visible = true; }
            else
            { ErreurPaysOrig.Visible = false; }

            if (cmbxCivilite.Text == "")
            { ErreurCivilite.Visible = true; }
            else
            { ErreurCivilite.Visible = false; }

            if (cmbxSexe.Text == "")
            { ErreurSexe.Visible = true; }
            else
            { ErreurSexe.Visible = false; }

            if ((txtMail.Text == "") || (IsValidMail(txtMail.Text) == false))
            { ErreurMail.Visible = true; }
            else
            { ErreurMail.Visible = false; }

            if (txtTel.Text == "")
            { ErreurTel.Visible = true; }
            else
            { ErreurTel.Visible = false; }

            if (txtGouvernat.Text == "")
            { ErreurGouvernorat.Visible = true; }
            else
            { ErreurGouvernorat.Visible = false; }

            if (txtVille.Text == "")
            { ErreurVille.Visible = true; }
            else
            { ErreurVille.Visible = false; }

            if (txtCodePost.Text == "")
            { ErreurCodePostal.Visible = true; }
            else
            { ErreurCodePostal.Visible = false; }

            if (txtAdresse.Text == "")
            { ErreurAdresse.Visible = true; }
            else
            { ErreurAdresse.Visible = false; }

            if (cmbxDerDiplome.Text == "")
            { ErreurDerDiplome.Visible = true; }
            else
            { ErreurDerDiplome.Visible = false; }
        
            if (cmbxEcoleDoctoral.Text=="")
            { ErreurEcoleDoct.Visible = true; }
            else
            { ErreurEcoleDoct.Visible = false; }
 
            if (cmbxSpecialite.Text == "")
            { ErreurSpecialite.Visible = true; }
            else
            { ErreurSpecialite.Visible = false; }

            if (txtSujet.Text == "")
            { ErreurSujet.Visible = true; }
            else
            { ErreurSujet.Visible = false; }

            if (cmbxEncadrant.Text == "")
            { ErreurEncadrant.Visible = true; }
            else
            { ErreurEncadrant.Visible = false; }
            
            if (cmbxEtatPaiAc.Text == "")
            { ErreurEtatPaiAc.Visible = true; }
            else { ErreurEtatPaiAc.Visible = false; }

            if (cmbxStatut.Text=="")
            { ErreurStatut.Visible = true; }
            else { ErreurStatut.Visible = false; }

        }
        private void Ajouter_Doctorants_Load(object sender, EventArgs e)
        {
            panelClose.Height = panelTitre.Height;
            panelClose.Width = panelTitre.Height;
            panelClose.Location = new Point(panelTitre.Width - panelTitre.Height, 0);
            DataTable dt = new DataTable();

            DAL.DALEnseignantChercheur Ens = new DAL.DALEnseignantChercheur();
            //dt=Ens
           
        }
        public void RemplirFiche()
        {
            DAL.DALDoctorant E = new DAL.DALDoctorant();
            dt10 = E.SelectByCIN_Passeport(CIN_Passeport);

            if ((CIN_Passeport != "") && (E.ChechkCIN_PasseportUnicity(CIN_Passeport) == 1))
            {
                txtCin.Text = dt10.Rows[0][1].ToString().Trim();
               
            }
            
            txtNumInsc.Text = dt10.Rows[0][2].ToString().Trim();
            txtNomFr.Text = dt10.Rows[0][3].ToString().Trim();
            txtNomAr.Text = dt10.Rows[0][4].ToString().Trim();
            txtPrenomFr.Text = dt10.Rows[0][5].ToString().Trim();
            txtPrenomAr.Text = dt10.Rows[0][6].ToString().Trim();
            txtNomJeuFilleFr.Text = dt10.Rows[0][7].ToString().Trim();
            txtNomJeuFilleAr.Text = dt10.Rows[0][8].ToString().Trim();
            
            cmbxSexe.Text = dt10.Rows[0][10].ToString().Trim();
            
            DateTimePickerDateNaissance.Value = (DateTime)(dt10.Rows[0][11]);
            txtLieuNaiss.Text = dt10.Rows[0][12].ToString().Trim();
            cmbxNationalite.Text=dt10.Rows[0][13].ToString().Trim();
            cmbxPaysOrig.Text = dt10.Rows[0][14].ToString().Trim();
            cmbxCivilite.Text = dt10.Rows[0][15].ToString().Trim();
            txtProfession.Text = dt10.Rows[0][16].ToString().Trim();
            txtEmployeur.Text=dt10.Rows[0][17].ToString().Trim();
            
            txtMail.Text = dt10.Rows[0][18].ToString().Trim();
            txtTel.Text = dt10.Rows[0][19].ToString().Trim();
            txtAdresse.Text = dt10.Rows[0][20].ToString().Trim();
            
            txtVille.Text = dt10.Rows[0][21].ToString().Trim();
            txtGouvernat.Text = dt10.Rows[0][22].ToString().Trim();
            txtCodePost.Text = dt10.Rows[0][23].ToString().Trim();
            
            cmbxDerDiplome.Text = dt10.Rows[0][24].ToString().Trim();
            dateTimePickerDateObt.Value = (DateTime)(dt10.Rows[0][25]);
            txtLieuObtention.Text = dt10.Rows[0][26].ToString().Trim();
            
            cmbxEcoleDoctoral.Text = dt10.Rows[0][27].ToString().Trim();
            cmbxSpecialite.Text = dt10.Rows[0][28].ToString().Trim();
            txtSujet.Text = dt10.Rows[0][29].ToString().Trim();
            cmbxStatut.Text = dt10.Rows[0][30].ToString().Trim();
            cmbxEtatPaiAc.Text = dt10.Rows[0][31].ToString().Trim();
            //cmbxEncadrant.SelectedValue =int.Parse( dt10.Rows[0][30].ToString()); //averifier
            //cmbxCoEncadrant.SelectedValue =int.Parse( dt10.Rows[0][31].ToString());
            TxtObs.Text = dt10.Rows[0][39].ToString().Trim();
            if (dt10.Rows[0][9].ToString() != "")
            {
                byte[] img = (byte[])(dt10.Rows[0][9]);
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }

            //DAL.DALDossierAffectation DA = new DAL.DALDossierAffectation();
            //dt20 = DA.SelectDossierAffectation(int.Parse(dt10.Rows[0][0].ToString()));
            //cmbDiplomeFr.Text = dt20.Rows[0][2].ToString().Trim();
            //cmbGradeFr.SelectedValue = int.Parse(dt20.Rows[0][3].ToString());
            //txtNiveau.Text = dt20.Rows[0][3].ToString();
        }


        public static bool IsValidMail(string mail_address)
        {
            Regex myRegex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.IgnoreCase);
            return myRegex.IsMatch(mail_address);
        }
          
      
        private void EnseignantPermanent_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(51, 122, 183), 1);
            e.Graphics.DrawRectangle(couleur, 1, 1, this.Width - 2, this.Height - 2);
        }
        private void panelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string chemain = "";
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Choisissez une photo";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = of.FileName;
                chemain = of.FileName;
            }
        }

        private void panelClose_MouseEnter(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(228, 17, 41);
        }

        private void panelClose_MouseLeave(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.Transparent;
        }

        

        private void panelAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void txtTel1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) || !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true; // Set l'evenement comme etant completement fini
                return;
            }
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void panelAjNom_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelAjNom.Width - 1, panelAjNom.Height - 1);
        }

        private void panelAjNaiss_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelAjNaiss.Width - 1, panelAjNaiss.Height - 1);
        }

        private void panelAjEmp_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelAjEmp.Width - 1, panelAjEmp.Height - 1);
        }

        private void panelAjContact_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelAjContact.Width - 1, panelAjContact.Height - 1);
        }

        private void panelAjDip_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelAjDip.Width - 1, panelAjDip.Height - 1);
        }

        private void panelAjEcoleDoct_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelAjEcoleDoct.Width - 1, panelAjEcoleDoct.Height - 1);
        }

        private void panelAjEncadrant_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelAjEncadrant.Width - 1, panelAjEncadrant.Height - 1);
        }

        private void panelAjObserv_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelAjObserv.Width - 1, panelAjObserv.Height - 1);
        }

        private void panelCommande_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelCommande.Width - 1, panelCommande.Height - 1);
        }

       


        //void BindEnseignantToInterface(Entities.Doctorant Doct)
        //{
        //    txtCinFr.Text = Ens.CIN;
        //    txtRibFr.Text = Ens.RIB;
        //    txtNomFr.Text = Ens.NomFr;
        //    txtNomAr.Text = Ens.NomAr;
        //    txtNomFr.Text = Ens.PrenomFr;
        //    txtNomPrenomPereFr.Text = Ens.NomPrenomPereFr;
        //    txtNomPrenomPereAr.Text = Ens.NomPrenomPereAr;
        //    txtNomPrenomMereFr.Text = Ens.NomPrenomMereFr;
        //    txtNomPrenomMereAr.Text = Ens.NomPrenomMereAr;
        //    txtPrenomAr.Text = Ens.PrenomAr;
        //    txtAliasFr.Text = Ens.Alias;
        //    cmbSexeFr.Text = Ens.Sexe;
        //    DateTimePickerDateNaissance.Value = Ens.DateNaissance;
        //    txtLieuNaissanceFr.Text = Ens.LieuNaissanceFr;
        //    txtLieuNaissanceAr.Text = Ens.LieuNaissanceAr;
        //    txtNationnaliteFr.Text = Ens.NationnaliteFr;
        //    txtNationnaliteAr.Text = Ens.NationnaliteAr;
        //    cmbCivilite.Text = Ens.Civilite;
        //    txtNbEnfant.Text = "" + Ens.NbEnfant;
        //    txtTel1.Text = Ens.Telephone1.ToString();
        //    txtTel2.Text = Ens.Telephone2.ToString();
        //    txtMailFr.Text = Ens.EMail;
        //    txtAdresseFr.Text = Ens.AdresseFr;
        //    txtAdresseAr.Text = Ens.AdresseAr;
        //    cmbVilleFr.Text = Ens.VilleFr;
        //    cmbVilleAr.Text = Ens.VilleAr;
        //    txtCodePostaleFr.Text = Ens.CodePostale.ToString();
        //}

        Entities.Doctorant GetDoctorantFromInterface()
        {
            Entities.Doctorant Doct = new Entities.Doctorant();

            
            Doct.CIN_Passeport = txtCin.Text;
            Doct.NumInscription = txtNumInsc.Text;
            Doct.NomFr = txtNomFr.Text;
            Doct.NomAr = txtNomAr.Text;
            Doct.PrenomFr = txtPrenomFr.Text;
            Doct.PrenomAr = txtPrenomAr.Text;
            Doct.NomJeuneFilleFr = txtNomJeuFilleFr.Text;
            Doct.NomJeuneFilleAr = txtNomJeuFilleAr.Text;
            Doct.Sexe = cmbxSexe.Text;
            Doct.DateNaissance = (DateTime)DateTimePickerDateNaissance.Value;
            Doct.LieuNaissance = txtLieuNaiss.Text;
            Doct.Nationalite = cmbxNationalite.Text;
            Doct.PaysOrigine = cmbxPaysOrig.Text;
            Doct.Civilite = cmbxCivilite.Text;
            Doct.Profession = txtProfession.Text;
            Doct.Employeur = txtEmployeur.Text;
            Doct.Email = txtMail.Text;
            try { Doct.Telephone= int.Parse(txtTel.Text); }
            catch { Doct.Telephone= 0; }
            try { Doct.CodePostal = int.Parse(txtCodePost.Text); }
            catch { Doct.CodePostal = 0; }
            Doct.Email = txtMail.Text;
            Doct.Gouvernorat = txtGouvernat.Text;
            Doct.Ville = txtVille.Text;
            Doct.Adresse = txtAdresse.Text;
            Doct.DernierDiplome = cmbxDerDiplome.Text;
            Doct.LieuObtention = txtLieuObtention.Text;
            Doct.DateObtention = (DateTime)dateTimePickerDateObt.Value;
            Doct.EcoleDoctorale = cmbxEcoleDoctoral.Text;
            Doct.Specialite = cmbxSpecialite.Text;
            Doct.Sujet = txtSujet.Text;
           
            //byte[] img = null;
            //FileStream fs = new FileStream(chemain, FileMode.Open);
            //BinaryReader br = new BinaryReader(fs);
            //img = br.ReadBytes((int)fs.Length);
            //fs.Close();
            //Doct.Photo = img;
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] img = stream.ToArray();
            Doct.Photo = img;
            Doct.DateDepot = new DateTime(2008, 12, 25);
            Doct.DateSoutenance = new DateTime(2008, 12, 25); ;
            Doct.TitreSoutenance = "sdfsdf";
            Doct.EtatDossierInscription = "null";
            Doct.EtatThese = "null";
           
            Doct.Observations = TxtObs.Text;
            return Doct;
        }

        private void panelEnregistrer_Click_1(object sender, EventArgs e)
        {
            bool res = ExistErreur();
            Entities.Doctorant Doct = new Entities.Doctorant();
            //Entitée.DossierAffectation DA = new Entitée.DossierAffectation();

            DataTable dt1 = new DataTable();
            if (res == true)
            {
                AfficherErreur();
            }
            else
            {
                Doct = GetDoctorantFromInterface();
                // DA = GetDossierFromInterface();


                //try
                //{
                DAL.DALDoctorant D = new DAL.DALDoctorant();
                D.InsertDoctorant(Doct);
                dt1 = D.SelectIdByCIN(Doct.CIN_Passeport);
                int IdDoct = int.Parse(dt1.Rows[0][0].ToString());
                
                MessageBox.Show("Opération d'ajout bien éffectuée");
                this.Close();
            }
        }

        public bool ExistErreur()
        {
            
            
                DAL.DALDoctorant D = new DAL.DALDoctorant();
                int x = D.ChechkCIN_PasseportUnicity(txtCin.Text);

                if ((txtCin.Text == "") || (txtCin.Text.Length < 8) || (txtNumInsc.Text == "") || (txtNomFr.Text == "") || (txtPrenomFr.Text == "")
                    || (txtNomAr.Text == "") || (txtPrenomAr.Text == "") || (x != 0) ||
                    (cmbxSexe.Text == "") || (txtLieuNaiss.Text == "") ||(cmbxNationalite.Text=="")||(cmbxCivilite.Text=="")
                    || (txtMail.Text == "") || (IsValidMail(txtMail.Text) == false) || (txtTel.Text == "")
                  || (txtGouvernat.Text == "") || (txtVille.Text == "") || (txtCodePost.Text == "")||(txtAdresse.Text == "")
                    
                || (cmbxDerDiplome.Text == "")  ||(cmbxEcoleDoctoral.Text=="")||(txtSujet.Text=="")
            //|| (cmbVilleFr.Text == "") ||  || (txtAdresseAr.Text == "")
            //|| (txtCodePostaleFr.Text == "") || (cmbGradeFr.Text == "") || (cmbStatutFr.Text == "") || (cmbAffiliationFr.Text == "")
            //|| (txtRibFr.Text == "") || (txtIdentifiantUnique.Text == "") || (cmbDiplomeFr.Text == "") || (cmbDiplomeFr.Text == "")
            //|| (txtAliasFr.Text == "") || (cmbVilleAr.Text == "")  
                    )
                    return true;
                else
                    return false;
            
           

        }

        private void labelEnregistrer_Click(object sender, EventArgs e)
        {

        }
        
    }
}
