using Dapper;
using DataAccessLayer.DBObject;
using System.Collections.Generic;
using System.Data;

namespace DataAccessLayer.DBObjects
{
    /// <summary>
    /// StatusDB is the Database Implementation of the Status Class
    /// </summary>
    public class StatusDB
    {
        /// <summary>
        /// Retrieves a list of all Status Values
        /// </summary>
        /// <returns>List of Status</returns>
        public static List<Status> GetStatusList()
        {
            string sqlQuery = "SELECT * FROM Status ORDER BY StatusDescription";
            IDbConnection connection = DBConnection.GetInstance();
            var statusList = connection.Query<Status>(sqlQuery);
            return (List<Status>)statusList;
        }
    }
}
