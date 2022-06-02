using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marsRover.Models
{
    public class Car:BaseEntity
    {
        public virtual User Owner { get; set; }
        public virtual Status Status{ get; set; }
        public string Course { get; set; }

    }
}
