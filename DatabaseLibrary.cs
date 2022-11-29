using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Critters
{
    public class DatabaseLibrary
    {
        public static SqlConnection DBConnection { get; private set; }

        public static SqlConnection GetConnection()
        {
            if (DBConnection == null)
            {
                var connectionString = ConfigurationManager.ConnectionStrings["PetStoreDB"].ConnectionString;
                DBConnection = new SqlConnection(connectionString);
                DBConnection.Open();
            }
            return DBConnection;
        }

        public static void CloseConnection()
        {
            DBConnection.Dispose();
        }

        public static void LoadUser(string tempUser)
        {
            DataTable dt = new DataTable();
            string sqlStatement = @"SELECT UserId, UserLastName, UserFirstName, UserLogin, UserPassword, UserAdmin FROM User WHERE UserLogin = @1";

            try
            {
                SqlConnection connection = PetStoreDB.GetConnection();
                SqlCommand cmd = new SqlCommand(sqlStatement, connection);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);

                }
            }
        }

    }
}
