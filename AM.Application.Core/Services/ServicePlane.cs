using AM.Application.Core.Domain;
using AM.Application.Core.Interfaces;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;



namespace AM.Application.Core.Services
{
    public class ServicePlane : Service<Plane>, IServicePlane
    {
        public ServicePlane(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IList<Passenger> GetPassengers(Plane plane) { 
        return GetById(plane.PlaneId).Flights.SelectMany(f=>f.Passengers).ToList();
                }

        public IList<Flight> GetFlights(int n)
        {
            return GetAll().OrderByDescending(p=>p.PlaneId).Take(n).SelectMany(p=>p.Flights).OrderBy(f=>f.FlightDate).ToList();
        }

        public bool IsAvailablePlane(Flight flight, int n)
        {
            int capacity = Get(p => p.Flights.Contains(flight) == true).Capacity;
            int nbPassengers = flight.Tickets.Count();
            //return ;
            return capacity >= (nbPassengers + n);

            //var plane=GetAll().Where(plane=>plane.Flights.Contains(flight)==true).Single();
            //var tickets=plane.Flights.Where(f=>f.FlighId==flight.FlighId).Single().Tickets.Count;

        }
        public void DeletePlanes()
        {
            foreach (var plane in GetAll().Where(p => (DateTime.Now - p.ManufactureDate).TotalDays > 365 * 10).ToList())
            {
                Delete(plane);
            }
            Commit();
        }

        IList<IGrouping<int, Flight>> IServicePlane.GetFlights(int n)
        {
            throw new NotImplementedException();
        }
    }
}
