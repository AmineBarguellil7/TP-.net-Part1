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
        List<Flight> GetFlights(string filterType, string filterValue);
        IEnumerable<DateTime> GettFlightDates(string destination);
    }
}
