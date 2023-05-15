using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp11
{
    internal class DataBase
    {
        public string connection = ConfigurationManager.ConnectionStrings["WindowsFormsApp11.Properties.Settings.AAConnectionString"].ConnectionString;
        public SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp11.Properties.Settings.AAConnectionString"].ConnectionString);
        
        public void openConnection()
        {
            conn.Open();
        }
        public void closeConnection()
        {
            conn.Close();
        }

        public SqlConnection getConnection()
        {
            return conn;
        }
    }
}
