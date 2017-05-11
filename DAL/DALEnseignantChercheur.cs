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
    class DALEnseignantChercheur
    {

        public int Chechk_Enseignant_Chercheur_Unicity(string Nom,string Prenom)
        {
            string StrSql = "SELECT COUNT(Nom) FROM EnseignantChercheur WHERE Nom=@Nom and Prenom=@Prenom";
            SqlCommand cmd = new SqlCommand(StrSql, Program.Connection);
            cmd.Parameters.Add("@Nom", SqlDbType.NVarChar).Value = Nom;
            cmd.Parameters.Add("@Prenom", SqlDbType.NVarChar).Value = Prenom;
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

        public void InsertEnseignantChercheur(Entities.EnseignantChercheur Ensch)
        {
            String StrSQL = "INSERT INTO EnseignantChercheur(Nom,Prenom,Grade,Email,Telephone) VALUES (@Nom,@Prenom,@Grade,@Email,@Telephone)";
            SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);       
            cmd.Parameters.Add("@Nom", SqlDbType.NVarChar).Value = Ensch.Nom;
            cmd.Parameters.Add("@Prenom", SqlDbType.NVarChar).Value = Ensch.Prenom;
            cmd.Parameters.Add("@Grade", SqlDbType.NVarChar).Value = Ensch.Grade;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Ensch.Email;
            cmd.Parameters.Add("@Telephone", SqlDbType.NVarChar).Value = Ensch.Telephone;
        }
        public void UpdateEnseignantChercheur(int id, Entities.EnseignantChercheur Ensch)
        {
            string StrSQL = "UPDATE EnseignantChercheur set Nom=@Nom, Prenom=@Prenom, Grade=@Grade Email=@Email Telephone=@Telephone where  IdEnseignantChercheur=@IdEnseignantChercheur";
            SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);
            cmd.Parameters.Add("@Nom", SqlDbType.NVarChar).Value = Ensch.Nom;
            cmd.Parameters.Add("@Prenom", SqlDbType.NVarChar).Value = Ensch.Prenom;
            cmd.Parameters.Add("@Grade", SqlDbType.NVarChar).Value = Ensch.Grade;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Ensch.Email;
            cmd.Parameters.Add("@Telephone", SqlDbType.NVarChar).Value = Ensch.Telephone;
            cmd.Parameters.Add("@IdEnseignantChercheur", SqlDbType.Int).Value = id;

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

        public void DeleteEnseignantChercheur(int id)
        {
            string StrSQL = "Delete From EnseignantChercheur where IdEnseignantChercheur=@id";
            SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

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
        public DataTable SelectAllEnseignantChercheur()
        {
            DataTable dt = new DataTable();
            try
            {
                Program.Connection.Open();

                string StrSQL = "SELECT * FROM EnseignantChercheur";
                SqlDataAdapter da = new SqlDataAdapter(StrSQL, Program.Connection);
                da.Fill(dt);
                Program.Connection.Close();
                return dt;
            }
            catch (Exception e)
            {
                Program.Connection.Close();
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        public int SelectCount()
        {
            string StrSql = "SELECT COUNT(Nom) FROM EnseignantChercheur";
            SqlCommand cmd = new SqlCommand(StrSql, Program.Connection);
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

        public int ChechkUsing(int id)
        {
            string StrSql = "SELECT COUNT(IdEnseignantChercheur) FROM JurySoutenance where IdEnseignantChercheur=@id";
            SqlCommand cmd = new SqlCommand(StrSql, Program.Connection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
    }
}
