using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.DBObjects
{
    public sealed class DBConnection
    {
        private static string connectionString;
        private static IDbConnection connection;

        /// <summary>
        /// Set the Database Connection Name according to the name property in the app.config file
        /// </summary>
        /// <param name="connectionName">Name property in app.config file</param>
        public static void SetConnectionName(String connectionName)
        {
            connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        /// <summary>
        /// Gets an instance of the database connection based on the connectionstring
        /// </summary>
        /// <returns>Database Connection</returns>
        public static IDbConnection GetInstance()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
            }
            if (connection.State != ConnectionState.Open)
                connection.Open();
            return connection;
        }

        /// <summary>
        /// Close the connection if it exists.
        /// </summary>
        public static void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
                connection = null;
            }
        }
    }
}
