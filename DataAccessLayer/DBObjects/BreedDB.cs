using Dapper;
using DataAccessLayer.DBObject;
using System.Collections.Generic;
using System.Data;

namespace DataAccessLayer.DBObjects
{
    /// <summary>
    /// BreedDB is the Database Implementation of the BreedDB Class
    /// </summary>
    public class BreedDB
    {
        /// <summary>
        /// Retrieves a list of all Breeds
        /// </summary>
        /// <returns>List of Breeds</returns>
        public static List<Breed> GetBreedList()
        {
            string sqlQuery = "SELECT BreedId, BreedName FROM Breed ORDER BY BreedName";
            IDbConnection connection = DBConnection.GetInstance();
            var breedList = connection.Query<Breed>(sqlQuery);
            return (List<Breed>)breedList;
        }
    }
}
