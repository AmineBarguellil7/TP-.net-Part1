using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public static class TestData
    {
        public static List<Plane> Planes { get; set; } = new List<Plane>() { new Plane { Capacity = 150, ManufactureDate = new DateTime(2015, 02, 03), PlaneType = PlaneType.Boing }, new Plane() { PlaneType = PlaneType.Airbus, Capacity = 250, ManufactureDate = new DateTime(2020, 11, 11) } };
        //public static List<Staff> Staffs { get; set; } = new List<Staff>() { new Staff { FirstName = "captain", LastName = "captain", EmailAddress = "captain.captain@gmail.com", BirthDate = new DateTime(1965, 01, 01), EmployementDate = new DateTime(1999, 01, 01), Salary = 99999 } };
        //public static List<Traveller> Travellers { get; set; } = new List<Traveller>() { new Traveller { FirstName = "amine", LastName = "barguellil", EmailAddress = "Traveller1.Traveller1@gmail.com", BirthDate = new DateTime(1980, 01, 01), HealthInformation = "No troubles", Nationality = "American" } };
        public static List<Flight> ListFlights { get; set; } = new List<Flight>()
        {
            //new Flight { FlightDate = new DateTime(2022, 01, 01, 15, 10, 10), Destination = "Paris", EffectiveArrival = new DateTime(2022, 01, 01, 17, 10, 10), Plane = Planes[1], EstimateDuration = 110, Passengers = new List<Passenger>(Travellers) },
            new Flight { FlightDate = new DateTime(2022, 02, 01, 21, 10, 10), Destination = "Paris", EffectiveArrival = new DateTime(2022, 02, 01, 23, 10, 10), Plane = Planes[1], EstimateDuration = 650 }
        };
    }
}
