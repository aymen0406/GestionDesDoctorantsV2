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
    class DALStructureRecherche
    {
         public int ChechkKeyUnicity(string NomStructRech)
        {
            string StrSql = "SELECT COUNT(NomStructRech) FROM StructureRecherche where NomStructRech=@NomStructRech";
            SqlCommand cmd = new SqlCommand(StrSql, Program.Connection);
            cmd.Parameters.Add("@NomStructRech", SqlDbType.NVarChar).Value = NomStructRech;
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
        public void InsertEtablissement(Entities.Etablissement Etab)
        {
            string StrSQL = "INSERT INTO Etablissement (NomEtablissement, Pays, Ville) VALUES(@NomEtablissement, @Pays, @Ville)";
            SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);
            
            cmd.Parameters.Add("@NomEtablissement", SqlDbType.NVarChar).Value = Etab.NomEtablissement;
            cmd.Parameters.Add("@Pays", SqlDbType.NVarChar).Value = Etab.Pays;
            cmd.Parameters.Add("@Ville", SqlDbType.NVarChar).Value = Etab.Ville;
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
        public void UpdateEtablissement(int id, Entities.Etablissement Etab)
        {
            string StrSQL = "update Etablissement set NomEtablissement=@NomEtablissement, Pays=@Pays, Ville=@Ville where  IdEtablissement=@IdEtablissement";
            SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);
            cmd.Parameters.Add("@NomEtablissement", SqlDbType.NVarChar).Value = Etab.NomEtablissement;
            cmd.Parameters.Add("@Pays", SqlDbType.NVarChar).Value = Etab.Pays;
            cmd.Parameters.Add("@Ville", SqlDbType.NVarChar).Value = Etab.Ville;
            cmd.Parameters.Add("@IdEtablissement", SqlDbType.Int).Value = id;

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

        public void DeleteEtablissement(int id)
        {
            string StrSQL = "Delete From Etablissement where IdEtablissement=@id";
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
        public DataTable SelectAllEtablissement()
        {
            DataTable dt = new DataTable();
            try
            {
                Program.Connection.Open();

                string StrSQL = "SELECT * FROM Etablissement";
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
            string StrSql = "SELECT COUNT(NomEtablissement) FROM Etablissement";
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
        public Entities.Etablissement SelectByNomEtablissement(int id)
        {
            DataTable dt = new DataTable();
            Entities.Etablissement Etab = new Entities.Etablissement();
            try
            {
                Program.Connection.Open();
                string StrSQL = "Select * from Etablissement where IdEtablissement='" + id + "'";
                SqlDataAdapter da = new SqlDataAdapter(StrSQL, Program.Connection);
                da.Fill(dt);
                
                Etab.NomEtablissement = dt.Rows[0][0].ToString();
                Etab.Pays = dt.Rows[0][1].ToString();
                Etab.Ville = dt.Rows[0][2].ToString();

                Program.Connection.Close();
                return Etab;
            }
            catch (Exception e)
            {
                Program.Connection.Close();
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return Etab;
        }
        public Entities.Etablissement SelectById(int id)
        {
            DataTable dt = new DataTable();
            Entities.Etablissement Etab = new Entities.Etablissement();
            try
            {
                Program.Connection.Open();
                string StrSQL = "Select * from Etablissement where IdEtablissement=" + id + "";
                SqlDataAdapter da = new SqlDataAdapter(StrSQL, Program.Connection);
                da.Fill(dt);
                Etab.IdEtablissement = int.Parse(dt.Rows[0][0].ToString());
                Etab.NomEtablissement = dt.Rows[0][1].ToString();
                Etab.Pays = dt.Rows[0][2].ToString();
                Etab.Ville = dt.Rows[0][3].ToString();

                Program.Connection.Close();
                return Etab;
            }
            catch (Exception e)
            {
                Program.Connection.Close();
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return Etab;
        }
        //public Entities.Etablissement SelectByNameAr(string s)
        //{
        //    DataTable dt = new DataTable();
        //    Entities.Etablissement Etab = new Entities.Etablissement();
        //    try
        //    {
        //        Program.Connection.Open();

        //        string StrSQL = "Select * from Etablissement where Pays='" + s + "'";
        //        SqlDataAdapter da = new SqlDataAdapter(StrSQL, Program.Connection);
        //        da.Fill(dt);
        //        Etab.IdEtablissement = int.Parse(dt.Rows[0][0].ToString());
        //        Etab.NomEtablissement = dt.Rows[0][1].ToString();
        //        Etab.Pays = dt.Rows[0][2].ToString();
        //        Etab.Ville = dt.Rows[0][3].ToString();

        //        Program.Connection.Close();
        //        return Etab;
        //    }
        //    catch (Exception e)
        //    {
        //        Program.Connection.Close();
        //        MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    return Etab;
        //}
        public int ChechkUsing(int id)
        {
            string StrSql = "SELECT COUNT(IdEtablissement) FROM StructureRecherche where IdEtablissement=@id";
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
