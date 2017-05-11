using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
namespace GestionDesDoctorantsV2.DAL
{
    class DALDoctorant
    {
        //Check Unicity for Unique Keys (CIN_Passeport)
        public int ChechkCIN_PasseportUnicity(string CIN_Passeport)
        {
            string StrSql = "SELECT COUNT(CIN_Passeport) FROM Doctorant where CIN_Passeport=@CIN_Passeport";
            SqlCommand cmd = new SqlCommand(StrSql, Program.Connection);
            cmd.Parameters.Add("@CIN_Passeport", SqlDbType.NVarChar).Value = CIN_Passeport;
            int count;
            try
            {
                Program.Connection.Open();
                count = (int)cmd.ExecuteScalar();
                Program.Connection.Close();
                return count;
            }
            catch (Exception e)
            {
                Program.Connection.Close();
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return (-1);
            }
        }

        //Ajouter un nouveau Doctorant
        public void InsertDoctorant(Entities.Doctorant Doct)
        {
            string StrSQL = "INSERT INTO Doctorant (CIN_Passeport, NumInscription, NomFr, NomAr, PrenomFr, PrenomAr,"+
                " NomJeuneFilleFr, NomJeuneFilleAr, Photo, Sexe, DateNaissance, LieuNaissance, Nationalite, PaysOrigine,"+
                " Civilite, Profession, Employeur, Email, Telephone, Adresse, Ville, Gouvernorat, CodePostal,"+
                " DernierDiplome, DateObtention, LieuObtention, EcoleDoctorale, Specialite, Sujet, Statut,EtatPayementAc,DateDepot,"+
                " DateSoutenance, TitreSoutenance, EtatThese, EtatDossierInscription, Observations) "+
                "VALUES(@CIN_Passeport, @NumInscription, @NomFr, @NomAr, @PrenomFr, @PrenomAr, @NomJeuneFilleFr, "+ 
                "@NomJeuneFilleAr, @Photo, @Sexe, @DateNaissance, @LieuNaissance, @Nationalite, @PaysOrigine, @Civilite, "+ 
                "@Profession, @Employeur, @Email, @Telephone, @Adresse, @Ville, @Gouvernorat, @CodePostal, "+
                "@DernierDiplome, @DateObtention, @LieuObtention, @EcoleDoctorale, @Specialite, @Sujet, "+
                "@DateDepot, @DateSoutenance, @TitreSoutenance, @EtatThese, @EtatDossierInscription, @Observations)";

            SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);
            cmd.Parameters.Add("@CIN_Passeport", SqlDbType.NVarChar).Value = Doct.CIN_Passeport;
            cmd.Parameters.Add("@NumInscription", SqlDbType.NVarChar).Value = Doct.NumInscription;
            cmd.Parameters.Add("@NomFr", SqlDbType.NVarChar).Value = Doct.NomFr;
            cmd.Parameters.Add("@NomAr", SqlDbType.NVarChar).Value = Doct.NomAr;
            cmd.Parameters.Add("@PrenomFr", SqlDbType.NVarChar).Value = Doct.PrenomFr;
            cmd.Parameters.Add("@PrenomAr", SqlDbType.NVarChar).Value = Doct.PrenomAr;
            cmd.Parameters.Add("@NomJeuneFilleFr", SqlDbType.NVarChar).Value = Doct.NomJeuneFilleFr;
            cmd.Parameters.Add("@NomJeuneFilleAr", SqlDbType.NVarChar).Value = Doct.NomJeuneFilleAr;
            cmd.Parameters.Add("@Photo", SqlDbType.Binary).Value = Doct.Photo;
            cmd.Parameters.Add("@Sexe", SqlDbType.NVarChar).Value = Doct.Sexe;
            cmd.Parameters.Add("@DateNaissance", SqlDbType.Date).Value = Doct.DateNaissance;
            cmd.Parameters.Add("@LieuNaissance", SqlDbType.NVarChar).Value = Doct.LieuNaissance;
            cmd.Parameters.Add("@Nationalite", SqlDbType.NVarChar).Value = Doct.Nationalite;
            cmd.Parameters.Add("@PaysOrigine", SqlDbType.NVarChar).Value = Doct.PaysOrigine;
            cmd.Parameters.Add("@Civilite", SqlDbType.NVarChar).Value = Doct.Civilite;
            cmd.Parameters.Add("@Profession", SqlDbType.NVarChar).Value = Doct.Profession;
            cmd.Parameters.Add("@Employeur", SqlDbType.NVarChar).Value = Doct.Employeur;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Doct.Email;
            cmd.Parameters.Add("@Telephone", SqlDbType.Int).Value = Doct.Telephone;
            cmd.Parameters.Add("@Adresse", SqlDbType.NVarChar).Value = Doct.Adresse;
            cmd.Parameters.Add("@Ville", SqlDbType.NVarChar).Value = Doct.Ville;
            cmd.Parameters.Add("@Gouvernorat", SqlDbType.NVarChar).Value = Doct.Gouvernorat;
            cmd.Parameters.Add("@CodePostal", SqlDbType.Int).Value = Doct.CodePostal;
            cmd.Parameters.Add("@DernierDiplome", SqlDbType.NVarChar).Value = Doct.DernierDiplome;
            cmd.Parameters.Add("@DateObtention", SqlDbType.Date).Value = Doct.DateObtention;
            cmd.Parameters.Add("@LieuObtention", SqlDbType.NVarChar).Value = Doct.LieuObtention;
            cmd.Parameters.Add("@EcoleDoctorale", SqlDbType.NVarChar).Value = Doct.EcoleDoctorale;
            cmd.Parameters.Add("@Specialite", SqlDbType.NVarChar).Value = Doct.Specialite;
            cmd.Parameters.Add("@Sujet", SqlDbType.NVarChar).Value = Doct.Sujet;
            cmd.Parameters.Add("@DateDepot", SqlDbType.Date).Value = Doct.DateDepot;
            cmd.Parameters.Add("@DateSoutenance", SqlDbType.Date).Value = Doct.DateSoutenance;
            cmd.Parameters.Add("@TitreSoutenance", SqlDbType.NVarChar).Value = Doct.TitreSoutenance;
            cmd.Parameters.Add("@EtatThese", SqlDbType.NVarChar).Value = Doct.EtatThese;
            cmd.Parameters.Add("@EtatDossierInscription", SqlDbType.NVarChar).Value = Doct.EtatDossierInscription;
            cmd.Parameters.Add("@Observations", SqlDbType.NVarChar).Value = Doct.Observations;
            try
            {
                Program.Connection.Open();
                cmd.ExecuteNonQuery();
                Directory.CreateDirectory(@"C:\Users\aymen\Documents\Visual Studio 2013\Projects\GestionDesDoctorantsV2\Documents\" + Doct.CIN_Passeport.Trim());
                Program.Connection.Close();
            }
            catch (Exception e)
            {
                Program.Connection.Close();
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //Modifier un doctorant
        public void UpdateDoctorant(Entities.Doctorant Doct)
        {
            string StrSQL = "UPDATE Doctorant SET CIN_Passeport=@CIN_Passeport, NumInscription=@NumInscription, NomFr=@NomFr, "+
            "NomAr=@NomAr, PrenomFr=@PrenomFr, PrenomAr=@PrenomAr, NomJeuneFilleFr=@NomJeuneFilleFr, NomJeuneFilleAr=@NomJeuneFilleAr, " +
            "Photo=@Photo, Sexe=@Sexe, DateNaissance=@DateNaissance, LieuNaissance=@LieuNaissance, " +
            "Nationalite=@Nationalite, PaysOrigine=@PaysOrigine, Civilite=@Civilite, Profession=@Profession, " +
            "Employeur=@Employeur, Email=@EMail, Telephone=@Telephone, Adresse=@Adresse, " +
            "Ville=@Ville, Gouvernorat=@Gouvernorat, CodePostal=@CodePostal, DernierDiplome=@DernierDiplome, " +
            "DateObtention=@DateObtention, LieuObtention=@LieuObtention, EcoleDoctorale=@EcoleDoctorale, Specialite=@Specialite, " +
            "Sujet=@Sujet, DateDepot=@DateDepot, DateSoutenance=@DateSoutenance, TitreSoutenance=@TitreSoutenance, " +
            "EtatThese=@EtatThese, EtatDossierInscription=@EtatDossierInscription, "+
            "Observations=@Observations WHERE Doctorant.IdDoctorant=@IdDoctorant;";
            SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);
            cmd.Parameters.Add("@CIN_Passeport", SqlDbType.NVarChar).Value = Doct.CIN_Passeport;
            cmd.Parameters.Add("@NumInscription", SqlDbType.NVarChar).Value = Doct.NumInscription;
            cmd.Parameters.Add("@NomFr", SqlDbType.NVarChar).Value = Doct.NomFr;
            cmd.Parameters.Add("@NomAr", SqlDbType.NVarChar).Value = Doct.NomAr;
            cmd.Parameters.Add("@PrenomFr", SqlDbType.NVarChar).Value = Doct.PrenomFr;
            cmd.Parameters.Add("@PrenomAr", SqlDbType.NVarChar).Value = Doct.PrenomAr;
            cmd.Parameters.Add("@NomJeuneFilleFr", SqlDbType.NVarChar).Value = Doct.NomJeuneFilleFr;
            cmd.Parameters.Add("@NomJeuneFilleAr", SqlDbType.NVarChar).Value = Doct.NomJeuneFilleAr;
            cmd.Parameters.Add("@Photo", SqlDbType.Binary).Value = Doct.Photo;
            cmd.Parameters.Add("@Sexe", SqlDbType.NVarChar).Value = Doct.Sexe;
            cmd.Parameters.Add("@DateNaissance", SqlDbType.Date).Value = Doct.DateNaissance;
            cmd.Parameters.Add("@LieuNaissance", SqlDbType.NVarChar).Value = Doct.LieuNaissance;
            cmd.Parameters.Add("@Nationalite", SqlDbType.NVarChar).Value = Doct.Nationalite;
            cmd.Parameters.Add("@PaysOrigine", SqlDbType.NVarChar).Value = Doct.PaysOrigine;
            cmd.Parameters.Add("@Civilite", SqlDbType.NVarChar).Value = Doct.Civilite;
            cmd.Parameters.Add("@Profession", SqlDbType.NVarChar).Value = Doct.Profession;
            cmd.Parameters.Add("@Employeur", SqlDbType.NVarChar).Value = Doct.Employeur;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Doct.Email;
            cmd.Parameters.Add("@Telephone", SqlDbType.Int).Value = Doct.Telephone;
            cmd.Parameters.Add("@Adresse", SqlDbType.NVarChar).Value = Doct.Adresse;
            cmd.Parameters.Add("@Ville", SqlDbType.NVarChar).Value = Doct.Ville;
            cmd.Parameters.Add("@Gouvernorat", SqlDbType.NVarChar).Value = Doct.Gouvernorat;
            cmd.Parameters.Add("@CodePostal", SqlDbType.Int).Value = Doct.CodePostal;
            cmd.Parameters.Add("@DernierDiplome", SqlDbType.NVarChar).Value = Doct.DernierDiplome;
            cmd.Parameters.Add("@DateObtention", SqlDbType.Date).Value = Doct.DateObtention;
            cmd.Parameters.Add("@LieuObtention", SqlDbType.NVarChar).Value = Doct.LieuObtention;
            cmd.Parameters.Add("@EcoleDoctorale", SqlDbType.NVarChar).Value = Doct.EcoleDoctorale;
            cmd.Parameters.Add("@Specialite", SqlDbType.NVarChar).Value = Doct.Specialite;
            cmd.Parameters.Add("@Sujet", SqlDbType.NVarChar).Value = Doct.Sujet;
            cmd.Parameters.Add("@DateDepot", SqlDbType.Date).Value = Doct.DateDepot;
            cmd.Parameters.Add("@DateSoutenance", SqlDbType.Date).Value = Doct.DateSoutenance;
            cmd.Parameters.Add("@TitreSoutenance", SqlDbType.NVarChar).Value = Doct.TitreSoutenance;
            cmd.Parameters.Add("@EtatThese", SqlDbType.NVarChar).Value = Doct.EtatThese;
            cmd.Parameters.Add("@EtatDossierInscription", SqlDbType.NVarChar).Value = Doct.EtatDossierInscription;
            cmd.Parameters.Add("@Observations", SqlDbType.NVarChar).Value = Doct.Observations;
            try
            {
                Program.Connection.Open();
                cmd.ExecuteNonQuery();
                Program.Connection.Close();
            }
            catch (Exception e)
            {
                Program.Connection.Close();
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //supprimer un doctorant
        public void DeleteDoctorant(int id)
        {
            string StrSQL = "DELETE FROM Doctorant WHERE Doctorant.IdDoctorant=@IdDoctorant;";

            SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);

            cmd.Parameters.Add("@IdDoctorant", SqlDbType.Int).Value = id;

            try
            {
                Program.Connection.Open();
                cmd.ExecuteNonQuery();
                Program.Connection.Close();
            }
            catch (Exception e)
            {
                Program.Connection.Close();
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

//        public DataTable SelectAllDoctorant()
//        {
//            DataTable dt = new DataTable();
//            try
//            {
//                Program.Connection.Open();
////MAZALET MEchrak7a
//                string StrSQL = "SELECT distinct Doctorant.IdDoctorant, CIN_Passeport, NomFr, PrenomFr, " +
//                "EtatDossierInscription FROM Doctorant" +
//                "Where Doctorant.IdDoctorant= ";
//                SqlDataAdapter da = new SqlDataAdapter(StrSQL, Program.Connection);
//                da.Fill(dt);

//                Program.Connection.Close();
//                return dt;
//            }
//            catch (Exception e)
//            {
//                Program.Connection.Close();
//                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            }
//            return dt;
//        }


        //selecct by critere de recherche mazalet
 
        //public DataTable SelectByCritere(string Critere, string Valeur)
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        Program.Connection.Open();
        //        string StrSQL = "SELECT distinct Doctorant.IdDoctorant,  CIN_Passeport, Doctorant.NomFr, PrenomFr,Doctorant.NomAr,PrenomAr," +

        //        "Departement.Code As Departement, Departement.NomFr As DepartementFr, Departement.NomAr As DepartementAr, " +

        //        "PositionActuelle, TypeSituationAdministrative.Code As Situation ," +

        //        "TypeSituationAdministrative.IntituleFr As SituationFr ,TypeSituationAdministrative.IntituleAr As SituationAr , " +

        //        "TypePromotion.Code As Promotion, TypePromotion.IntituleFr As PromotionFr, TypePromotion.IntituleAr As PromotionAr, " +
        //        "DossierAffectation.TypeAdmission,DossierAffectation.TypeAdmissionAr " +

        //        "FROM Enseignant, DossierAffectation , Departement, TypePromotion,TypeSituationAdministrative " +
        //        "Where Enseignant.IdEnseignant=DossierAffectation.IdEnseignant and  EtatActuel='Actif' and  EtatDossier='Courant' " +
        //        "and Enseignant.IdDepartement=Departement.IdDepartement " +
        //        "and Enseignant.SituationActuelle= TypeSituationAdministrative.IdTypeSituationAdmin " +
        //        "and DossierAffectation.IdTypePromotion=TypePromotion.IdTypePromotion " +
        //        "and (" + Critere + ")='" + Valeur.Trim() + "'";
        //        SqlDataAdapter da = new SqlDataAdapter(StrSQL, Program.Connection);
        //        da.Fill(dt);
        //        Program.Connection.Close();
        //        return dt;

        //    }
        //    catch (Exception e)
        //    {
        //        Program.Connection.Close();
        //        MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    return dt;
        //}

        //select doctorant par Cin
        public DataTable SelectByCIN_Passeport(string CIN_Passeport)
        {
            DataTable dt = new DataTable();
            try
            {
                Program.Connection.Open();
                string StrSQL = "Select * from Doctorant where Doctorant.CIN_Passeport='" + CIN_Passeport + "';";
                SqlDataAdapter da = new SqlDataAdapter(StrSQL, Program.Connection);
                da.Fill(dt);
                Program.Connection.Close();
                return dt;

            }
            catch (Exception e)
            {
                Program.Connection.Close();
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dt;
        }

        //select Id Doctorant par cin
        public DataTable SelectIdByCIN(String CIN_Passeport)
        {
            DataTable dt = new DataTable();
            try
            {
                Program.Connection.Open();
                string StrSQL = "Select IdDoctorant from Doctorant where Doctorant.CIN_Passeport='" + CIN_Passeport + "'";
                SqlDataAdapter da = new SqlDataAdapter(StrSQL, Program.Connection);
                da.Fill(dt);
                Program.Connection.Close();
                return dt;
            }
            catch (Exception e)
            {
                Program.Connection.Close();
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dt;
        }
        
        public DataTable SelectCINById(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                Program.Connection.Open();
                string StrSQL = "Select CIN_Passeport from Doctorant where Doctorant.IdDoctorant = " + id;
                SqlDataAdapter da = new SqlDataAdapter(StrSQL, Program.Connection);
                da.Fill(dt);
                Program.Connection.Close();
                return dt;
            }
            catch (Exception e)
            {
                Program.Connection.Close();
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dt;
        }
        
        public DataTable NewSelect()
        {
            DataTable dt = new DataTable();
            try
            {
                Program.Connection.Open();

                string StrSQL = "SELECT Doctorant.IdDoctorant,CIN_Passeport, NomFr, PrenomFr, Specialite, EtatThese ,EtatDossierInscription FROM Doctorant  "; 


                

                SqlDataAdapter da = new SqlDataAdapter(StrSQL, Program.Connection);
                da.Fill(dt);
                Program.Connection.Close();
                return dt;
            }
            catch (Exception e)
            {
                Program.Connection.Close();
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return dt;
        }


        public DataTable SelectValue(string Critere, string table)
        {
            DataTable dt = new DataTable();
            try
            {
                Program.Connection.Open();
                string StrSQL = "Select distinct(" + Critere + ") from " + table;
                SqlDataAdapter da = new SqlDataAdapter(StrSQL, Program.Connection);
                da.Fill(dt);
                Program.Connection.Close();
                return dt;

            }
            catch (Exception e)
            {
                Program.Connection.Close();
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dt;
        }

        public DataTable SelectDoctorant(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                Program.Connection.Open();

                string StrSQL = "SELECT * FROM Doctorant Where IdDoctorant=" + id + "";

                SqlDataAdapter da = new SqlDataAdapter(StrSQL, Program.Connection);
                da.Fill(dt);
                Program.Connection.Close();
                return dt;
            }
            catch (Exception e)
            {
                Program.Connection.Close();
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dt;
        }      
    }
}
