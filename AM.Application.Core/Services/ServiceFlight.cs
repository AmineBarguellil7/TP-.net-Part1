using AM.Application.Core.Domain;
using AM.Application.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Services
{
    public class ServiceFlight:IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination == destination)
                {
                    dates.Add(Flights[i].FlightDate);
                }
            };
            return dates;
        }




        public List<Flight> GetFlights(string filterType, string filterValue)
        {
            List<Flight> filteredFlights = new List<Flight>();

            switch (filterType)
            {
                case "Destination":
                    filteredFlights = Flights.Where(f => f.Destination == filterValue).ToList();
                    break;
                case "FlightDate":
                    if (DateTime.TryParse(filterValue, out DateTime flightDate))
                    {
                        filteredFlights = Flights.Where(f => f.FlightDate == flightDate).ToList();
                    }
                    break;
                case "EffectiveArrival":
                    if (DateTime.TryParse(filterValue, out DateTime effectiveArrival))
                    {
                        filteredFlights = Flights.Where(f => f.EffectiveArrival == effectiveArrival).ToList();
                    }
                    break;
                case "PlaneType":
                    if (Enum.TryParse(filterValue, out PlaneType planeType))
                    {
                        filteredFlights = Flights.Where(f => f.Plane.PlaneType == planeType).ToList();
                    }
                    break;
                default:
                    break;
            }

            return filteredFlights;
        }

        public IEnumerable<DateTime> GettFlightDates(string destination)
        {
            foreach (Flight flight in Flights)
            {
                if (flight.Destination == destination)
                {

                    yield return flight.FlightDate;
                }
            }
        }
    }
}
