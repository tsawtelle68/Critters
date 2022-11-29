using Dapper;
using DataAccessLayer.DBObject;
using System.Collections.Generic;
using System.Data;

namespace DataAccessLayer.DBObjects
{
    /// <summary>
    /// PetTypeDB is the Database Implementation of the PetType Class
    /// </summary>
    public class PetTypeDB
    {
        /// <summary>
        /// Retrieves a list of all PetTypes
        /// </summary>
        /// <returns>List of Pet Types</returns>
        public static List<PetType> GetPetTypeList()
        {
            string sqlQuery = "SELECT PetTypeId, PetTypeName " +
                "FROM PetType ORDER BY PetTypeName";
            IDbConnection connection = DBConnection.GetInstance();
            var petTypeList = connection.Query<PetType>(sqlQuery);
            return (List<PetType>)petTypeList;
        }
    }
}
