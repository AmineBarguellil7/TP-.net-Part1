using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Ticket
    {
        public bool VIP { get; set; }
        public string Siege { get; set; } 
        public double prix { get; set; }
        public virtual Passenger passenger { get; set;}
        public virtual Flight flight { get; set; }
        [ForeignKey(nameof(flight))]
        public int FlightFK { get; set; }

        [ForeignKey(nameof(passenger))]

        public int PassengerFK { get; set; }
    }
}
