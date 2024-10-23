using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnectionDAL
    {
        private string connectionString;

        public ConnectionDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["EmpleadosConection"].ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
