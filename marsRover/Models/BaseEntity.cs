using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marsRover.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
