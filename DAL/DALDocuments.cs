using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionDesDoctorantsV2.DAL
{
    class DALDocuments
    {
         public void AjouterDocument(int Id, int IdTypeDocument, DateTime DateAjout, string NomFr, string NomAr, string Commentaire, string lien)
        {
            string StrSQL = "INSERT INTO Document (IdDoctorant, IdTypeDocument, DateAjout, NomFr, NomAr, Commentaire, Lien) VALUES(@IdDoctorant, @IdTypeDocument, @DateAjout, @NomFr, @NomAr, @Commentaire, @lien)";

            SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);
            cmd.Parameters.Add("@IdDoctorant", SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@IdTypeDocument", SqlDbType.Int).Value = IdTypeDocument;
            cmd.Parameters.Add("@DateAjout", SqlDbType.Date).Value = DateAjout;
            cmd.Parameters.Add("@NomFr", SqlDbType.NVarChar).Value = NomFr;
            cmd.Parameters.Add("@NomAr", SqlDbType.NVarChar).Value = NomAr;
            cmd.Parameters.Add("@Commentaire", SqlDbType.NVarChar).Value = Commentaire;
            cmd.Parameters.Add("@lien", SqlDbType.NVarChar).Value = lien;

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

        public int AjouterDocument1(int Id, int IdTypeDocument, DateTime DateAjout, string NomFr, string NomAr, string Commentaires, string lien)
        {
            string StrSQL = "INSERT INTO Document (IdDoctorant, DateAjout, IdTypeDocument, NomFr, NomAr, Commentaires, Lien) VALUES(@IdDoctorant, @DateAjout, @IdTypeDocument, @NomFr, @NomAr, @Commentaires, @lien)";

            SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);
            cmd.Parameters.Add("@IdDoctorant", SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@DateAjout", SqlDbType.Date).Value = DateAjout;
            cmd.Parameters.Add("@IdTypeDocument", SqlDbType.Int).Value = IdTypeDocument;
            cmd.Parameters.Add("@NomFr", SqlDbType.NVarChar).Value = NomFr;
            cmd.Parameters.Add("@NomAr", SqlDbType.NVarChar).Value = NomAr;
            cmd.Parameters.Add("@Commentaires", SqlDbType.NVarChar).Value = Commentaires;
            cmd.Parameters.Add("@lien", SqlDbType.NVarChar).Value = lien;

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
            DataTable dt2 = new DataTable();
            dt2=SelectIdDocInserted(lien);
            return (int.Parse(dt2.Rows[0][0].ToString()));
        }

        public DataTable SelectIdDocInserted(string lien)
        {
            DataTable dt = new DataTable();
            try
            {
                Program.Connection.Open();

                string StrSQL = "SELECT MAX(Id) FROM Document where Lien='" + @lien + "'";
                MessageBox.Show(StrSQL);
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

        public void UpdateDocument(int id, int IdTypeDocument, string NomFr, string NomAr, string Commentaires, string lien)
        {
            string StrSQL = "update Document set IdTypeDocument=@IdTypeDocument, NomFr=@NomFr, NomAr=@NomAr, Commentaires=@Commentaires, Lien=@Lien where Id=@Id";

            SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@IdTypeDocument", SqlDbType.Int).Value = IdTypeDocument;
            cmd.Parameters.Add("@NomFr", SqlDbType.NVarChar).Value = NomFr;
            cmd.Parameters.Add("@NomAr", SqlDbType.NVarChar).Value = NomAr;
            cmd.Parameters.Add("@Commentaires", SqlDbType.NVarChar).Value = Commentaires;
            cmd.Parameters.Add("@Lien", SqlDbType.NVarChar).Value =lien;

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

        public void DeleteDocument(int id)
        {
            string StrSQL = "Delete from Document where Id=@Id";

            SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

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

        public DataTable SelectAllDocument(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                Program.Connection.Open();

                string StrSQL = "Select * from Document where IdDoctorant=" + id;
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

        public DataTable SelectDocumentById(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                Program.Connection.Open();

                string StrSQL = "Select * from Document where Id=" + id;
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

        //public void DeleteDocumentFromConge(int id)
        //{
        //    string StrSQL = "update Conges set Document=0 where Document=@Id";

        //    SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);
        //    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

        //    try
        //    {
        //        Program.Connection.Open();
        //        cmd.ExecuteNonQuery();

        //        Program.Connection.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        Program.Connection.Close();
        //        MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        //public void DeleteDocumentFromGrade(int id)
        //{
        //    string StrSQL = "update Promotion set Document=0 where Document=@Id";

        //    SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);
        //    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

        //    try
        //    {
        //        Program.Connection.Open();
        //        cmd.ExecuteNonQuery();

        //        Program.Connection.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        Program.Connection.Close();
        //        MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

    }
    
}
