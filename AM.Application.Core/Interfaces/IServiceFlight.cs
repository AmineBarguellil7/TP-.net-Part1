using AM.Application.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Interfaces
{
    public interface IServiceFlight
    {
        List<DateTime> GetFlightDates(string destination);
        //List<Flight> GetFlights(string filterType, string filterValue);
        public void GetFlights(string filterValue, Func<string, Flight, Boolean> func);
        IEnumerable<DateTime> GettFlightDates(string destination);
        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        double DurationAverage(string destination);
        IList<Flight> OrderedDurationFlights();
        IList<Traveller> SeniorTravellers(Flight flight);

        IList<IGrouping<String, Flight>> DestinationGroupedFlights();
    }
}
