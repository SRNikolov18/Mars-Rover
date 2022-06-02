using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marsRover.Models
{
    public abstract class Sensor:BaseEntity
    {
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public string Value { get; set; }
    }
}
