using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
namespace GestionDesDoctorantsV2
{
    static class Program
    {
        public static string DBServerPath;
        public static string DataServerPath;
        public static Form MenuPrincipale;
        public static SqlConnection Connection;
        public static String StrConnection;
        public static SqlDataReader dr;

        public static void InitDBServerPath()
        {
            XmlTextReader reader = null;
            string AppPath = Application.StartupPath;
            try
            {
                reader = new XmlTextReader("ConfigFile.xml");
                XmlDocument ConfigFiledoc = new XmlDocument();
                ConfigFiledoc.Load(reader);
                reader.WhitespaceHandling = WhitespaceHandling.None;
                XmlNode root = ConfigFiledoc.DocumentElement;
                XmlNodeList liste = root.ChildNodes;
                XmlNode DBPathNode = liste.Item(0);
                DBServerPath = AppPath + DBPathNode.ChildNodes[0].InnerText.ToString();
                DataServerPath = AppPath + DBPathNode.ChildNodes[1].InnerText.ToString();
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program.StrConnection = @"Data Source=aymen-PC\SQLEXPRESS;Initial Catalog=phdDbFinal;Integrated Security=True";
            
            Program.Connection = new SqlConnection(Program.StrConnection);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}
