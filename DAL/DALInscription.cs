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
    class DALInscription
    {
        public DataTable NewSelect()
        {
            DataTable dt = new DataTable();
            try
            {
                Program.Connection.Open();

                string StrSQL = "Select * from ViewConsulterInscription";
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
