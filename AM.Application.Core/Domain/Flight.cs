using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Flight
    {
        public Flight()
        {
        }

        public Flight(string destination, string departure, DateTime flightDate, int flightId, DateTime effectiveArrival, int estimateDuration, Plane plane, List<Passenger> passengers)
        {
            Destination = destination;
            Departure = departure;
            FlightDate = flightDate;
            FlightId = flightId;
            EffectiveArrival = effectiveArrival;
            EstimateDuration = estimateDuration;
            Plane = plane;
            Passengers = passengers;
        }

        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimateDuration { get; set; }
        public Plane Plane { get; set; }
        public List<Passenger> Passengers { get; set; }
        public override string ToString()
        {
            return "destination: "+Destination+" flightDate: "+FlightDate+" effectiveArrival: "+EffectiveArrival+ " EstimateDuration: " + EstimateDuration;
        }
    }
}
