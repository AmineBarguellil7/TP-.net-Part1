using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Plane
    {
        public Plane()
        {
        }

        public Plane(int capacity, DateTime manufactureDate, PlaneType planeType)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            PlaneType = planeType;
        }
        [Range(0, int.MaxValue)]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; } 

        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public List<Flight> Flights { get; set; }
        public override string ToString()
        {
            return $"[{PlaneId},{ManufactureDate},{Capacity},{PlaneType}]";
        }
    }
}
