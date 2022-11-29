using Dapper;
using Dapper.Contrib.Extensions;
using DataAccessLayer.DBObject;
using System.Collections.Generic;
using System.Data;

namespace DataAccessLayer.DBObjects
{
    /// <summary>
    /// PetDB is the Database Implementation of the Pet Class
    /// </summary>
    public class PetDB
    {
        /// <summary>
        /// Retrieves a list of all Pets with the specified PetTypeId
        /// </summary>
        /// <returns>List of Applicable Pets</returns>
        public static List<Pet> GetPetListByPetTypeId(int petTypeId)
        {
            string sqlQuery = "SELECT PetId, PetTypeId, PetName, PetAge, BreedId, Price, StatusId, Picture FROM Pet WHERE PetTypeId = @id ORDER BY BreedId, PetAge";
            IDbConnection connection = DBConnection.GetInstance();
            var petList = connection.Query<Pet>(sqlQuery,
                param: new { id = petTypeId });
            return (List<Pet>)petList;
        }

        /// <summary>
        /// Retrieves a Pet based on the current petId value
        /// </summary>
        /// <returns>List of Applicable Pets</returns>
        public static Pet GetPetListByPetId(int petId)
        {
            string sqlQuery = "SELECT PetId, PetTypeId, PetName, PetAge, BreedId, Price, StatusId, PictureFile, Picture FROM Pet WHERE PetId = @id";
            IDbConnection connection = DBConnection.GetInstance();
            var pets = connection.Query<Pet>(sqlQuery,
                param: new { id = petId });
            List<Pet> list = (List<Pet>)pets;
            Pet pet = null;
            if (list.Count > 0) pet = list[0];
            return pet;
        }

        /// <summary>
        /// Inserts a New Pet
        /// </summary>
        /// <returns>Updated Pet Object</returns>
        public static Pet InsertPet(Pet pet)
        {
            IDbConnection connection = DBConnection.GetInstance();
            var identity = connection.Insert<Pet>(pet);
            pet.PetID = (int)identity;
            return pet;
        }

        /// <summary>
        /// Updates a Pet based on the specified table key
        /// </summary>
        /// <returns>boolean value indicating if pet was updated</returns>
        public static bool UpdatePet(Pet pet)
        {
            IDbConnection connection = DBConnection.GetInstance();
            bool updated = connection.Update<Pet>(pet);
            return updated;
        }

        /// <summary>
        /// Deletes a Pet based on the specified table key
        /// </summary>
        /// <returns>boolean value indicating if pet was removed</returns>
        public static bool DeletePet(Pet pet)
        {
            IDbConnection connection = DBConnection.GetInstance();
            bool deleted = connection.Delete<Pet>(pet);
            return deleted;
        }

    }
}
