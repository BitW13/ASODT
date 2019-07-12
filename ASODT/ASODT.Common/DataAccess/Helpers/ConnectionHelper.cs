using System.Data.SqlClient;

namespace ASODT.Common.DataAccess.Helpers
{
    public static class ConnectionHelper
    {
        private static readonly string connectionString;

        static ConnectionHelper()
        {
            //connectionString = ConfigurationManager.ConnectionStrings["ShopDB"].ConnectionString;
        }

        public static SqlConnection ConnectionFactory()
        {
            return new SqlConnection(connectionString);
        } 
    }
}
