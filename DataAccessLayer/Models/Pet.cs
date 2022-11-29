using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace DataAccessLayer.DBObject
{

    /// <summary>
    /// Specifies the Properties for a Pet
    /// </summary>
    [Table("Pet")]
    public class Pet
    {
        /// <summary>
        /// Pet ID - unique identifier for the Pet table
        /// </summary>
        [Key]
        public int PetID { get; set; }
        public int PetTypeId { get; set; }
        public string PetName { get; set; }
        public int PetAge { get; set; }
        public int BreedId { get; set; }
        public decimal Price { get; set; }
        public int StatusId { get; set; }
        public byte[] Picture { get; set; }
        public string PictureFile { get; set; }
    }
}
