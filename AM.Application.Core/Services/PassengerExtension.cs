using AM.Application.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Services
{
    public  class PassengerExtension : Passenger
    {
        public string UpperFullName(Passenger passenger)
        {
            string firstName = passenger.FirstName;
            string lastName = passenger.LastName;
            firstName = char.ToUpper(firstName[0]) + firstName.Substring(1);
            lastName = char.ToUpper(lastName[0]) + lastName.Substring(1);
            return firstName+" "+lastName;
        }
    }
}