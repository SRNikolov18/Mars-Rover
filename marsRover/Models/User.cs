using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marsRover.Models
{
    public class User:BaseEntity
    {
        public string UserName { get; set; }
        public virtual Roles UserRole { get; set; }
        public string ApiKey { get; set; }
    }
}
