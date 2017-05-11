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
    class DALTypeDocument
    {
        public int ChechkKeyUnicity(string code)
        {
            string StrSql = "SELECT COUNT(Code) FROM TypeDocument where Code=@Code";
            SqlCommand cmd = new SqlCommand(StrSql, Program.Connection);
            cmd.Parameters.Add("@Code", SqlDbType.NVarChar).Value = code;
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
        public DataTable SelectIdByCode(string code)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT IdTypeDocument FROM TypeDocument where Code='" + code + "'";
            try
            {
                Program.Connection.Open();
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
        public void InsertTypeDocumente(Entities.TypeDocument C)
        {
            string StrSQL = "INSERT INTO TypeDocument (Code, LibelleFr, LibelleAr) VALUES(@Code,@LibelleFr, @LibelleAr)";
            SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);
            cmd.Parameters.Add("@Code", SqlDbType.NVarChar).Value = C.Code;
            cmd.Parameters.Add("@LibelleFr", SqlDbType.NVarChar).Value = C.LibelleFr;
            cmd.Parameters.Add("@LibelleAr", SqlDbType.NVarChar).Value = C.LibelleAr;
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
        public void UpdateTypeDocumente(int id, Entities.TypeDocument C2)
        {
            string StrSQL = "update TypeDocument set LibelleFr=@LibelleFr, LibelleAr=@LibelleAr, Code=@Code1 where IdTypeDocument=@IdTypeTypeDocument";
            SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);
            cmd.Parameters.Add("@LibelleFr", SqlDbType.NVarChar).Value = C2.LibelleFr;
            cmd.Parameters.Add("@LibelleAr", SqlDbType.NVarChar).Value = C2.LibelleAr;
            cmd.Parameters.Add("@Code1", SqlDbType.NVarChar).Value = C2.Code;
            cmd.Parameters.Add("@IdTypeTypeDocument", SqlDbType.Int).Value = id;
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
        public void DeleteTypeDocumente(int id)
        {
            string StrSQL = "Delete From TypeDocument where IdTypeDocument=@IdTypeTypeDocument";
            SqlCommand cmd = new SqlCommand(StrSQL, Program.Connection);
            cmd.Parameters.Add("@IdTypeTypeDocument", SqlDbType.Int).Value = id;

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
        public DataTable SelectAllTypeDocument()
        {
            DataTable dt = new DataTable();
            try
            {
                string StrSQL = "Select * from TypeDocument";
                Program.Connection.Open();
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

        public Entities.TypeDocument SelectById(int id)
        {
            DataTable dt = new DataTable();
            Entities.TypeDocument C = new Entities.TypeDocument();
            try
            {
                Program.Connection.Open();
                string StrSQL = "Select * from TypeDocument where IdTypeDocument=" + id + "";
                SqlDataAdapter da = new SqlDataAdapter(StrSQL, Program.Connection);
                da.Fill(dt);
                C.IdTypeDocument = int.Parse(dt.Rows[0][0].ToString());
                C.Code = dt.Rows[0][1].ToString();
                C.LibelleFr = dt.Rows[0][2].ToString();
                C.LibelleAr = dt.Rows[0][3].ToString();

                Program.Connection.Close();
                return C;
            }
            catch (Exception e)
            {
                Program.Connection.Close();
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return C;
        }

        public int ChechkUsing(int id)
        {
            string StrSql = "SELECT COUNT(IdTypeDocument) FROM Document where IdTypeDocument=@id";
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