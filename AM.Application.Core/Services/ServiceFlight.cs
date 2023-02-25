using AM.Application.Core.Domain;
using AM.Application.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Services
{
    public class ServiceFlight:IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        //public void GetFlights(string filterValue, Func<string, Flight, Boolean> func)
        //{
        //    Func<string, Flight, Boolean> Condition = func;
        //    foreach (var item in Flights)
        //    {
        //        if (Condition(filterValue, item))
        //        {
        //            Console.WriteLine(item);
        //        }
        //    }
        //}





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




        

        //LINQ

        public List<DateTime> GetFlightDates(string destination)
        {
            //IEnumerable<DateTime> query = (from f in Flights where f.Destination == "Paris" select f.FlightDate);
            //return query.ToList();
            var query=Flights.Where(f=>f.Destination == destination).Select(f=>f.FlightDate);
            return query.ToList();
        }

        

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            //var req = from f in Flights
            //          where (f.FlightDate > startDate && (f.FlightDate - startDate).TotalDays < 7)
            //          select f;
            //return req.Count();
            
            return Flights.Where(f => f.FlightDate > startDate && (f.FlightDate - startDate).TotalDays < 7).Count();

            //where (f.FlightDate > startDate && f.FlightDate<startDate.AddDays(7)) select f;
        }

        public double DurationAverage(string destination)
        {
            //var query = from f in Flights where f.Destination == destination select f;
            //return query.Average(f=>f.EstimateDuration);
            return Flights.Where(f => f.Destination == destination).Average(f => f.EstimateDuration);
        }

        public void ShowFlightDetails(Domain.Plane plane)
        {
            var req = from f in Flights where f.Plane == plane select new { f.FlightDate, f.Destination };
            foreach (var item in req)
            {
                Console.WriteLine(item.Destination + " " + item.FlightDate);
            }
            //var req = Flights.Where(f => f.Plane == plane).Select(f => new { f.FlightDate, f.Destination });
        }

        public IList<Flight> OrderedDurationFlights()
        {
            //var req = from f in Flights orderby f.EstimateDuration descending select f;
            //return req.ToList();
            return Flights.OrderBy(f => f.EstimateDuration).ToList();
        }

        public IList<Traveller> SeniorTravellers(Flight flight)
        {
            //var query=(from f in Flights where f.FlightId==flight.FlightId select f).Single();
            //return query.Passengers.OfType<Traveller>().OrderBy(p=>p.BirthDate).Take(3).ToList();
            return flight.Passengers.OfType<Traveller>().OrderBy(p => p.BirthDate).Take(3).ToList();
        }

        public IList<IGrouping<String,Flight>> DestinationGroupedFlights()
        {
            var req= Flights.GroupBy(f => f.Destination); 
            foreach (var item in req) {
                Console.WriteLine("Destination : "+ item.Key);
                foreach (var item1 in item) {
                    Console.WriteLine("Decollage: " +item1.FlightDate);
                }
            }
            return req.ToList();
        }



       

        public IEnumerable<DateTime> GettFlightDates1(string destination)
        {
            foreach (Flight flight in Flights)
            {
                if (flight.Destination == destination)
                {

                    yield return flight.FlightDate;
                }
            }
        }

        public List<DateTime> GetFlightDates2(string destination)
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

        public Action<Domain.Plane> FlightDetailsDel { get; set; }

        public Func<string, double> DurationAverageDel { get; set; }

        public ServiceFlight()
        {
            //FlightDetailsDel = ShowFlightDetails;
            //DurationAverageDel = DurationAverage;
            FlightDetailsDel = (plane) =>
            {
                ShowFlightDetails(plane);
            };
            DurationAverageDel = (destination) =>
            {
                return DurationAverage(destination);
            };
        }
    }



}


//query par defaut treturni hkaya barka ithakan nheb nraja3 akther men hkaya nbadal var query wa nbadel
//select new {f.Destination,f.FlightDate} 
//var query=Flights.where(f=>f.Destination=="Paris).select(f=>...)
