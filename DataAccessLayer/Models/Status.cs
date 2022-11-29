using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DBObject
{
    /// <summary>
    /// Specifies the Properties of the Status
    /// </summary>
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusDescription { get; set; }
    }
}
