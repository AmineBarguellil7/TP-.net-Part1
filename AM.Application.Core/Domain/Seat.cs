using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Seat
    {
        public int SeatId { get; set; }
        public string Name { get; set;}

        public string SeatNumber { get; set;}
        public int Size { get; set;}

        public virtual Plane Plane { get; set;} 
    }
}
