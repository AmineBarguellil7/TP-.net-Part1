using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Passenger
    {
        public Passenger()
        {
        }

        public Passenger(DateTime birthDate, int passportNmber, string emailAddress, string firstName, string lastName, string telNumber, List<Flight> listFlight)
        {
            BirthDate = birthDate;
            PassportNmber = passportNmber;
            EmailAddress = emailAddress;
            FirstName = firstName;
            LastName = lastName;
            TelNumber = telNumber;
            ListFlight = listFlight;
        }

        public Passenger(int passportNmber, string firstName, string lastName)
        {
            PassportNmber = passportNmber;
            FirstName = firstName;
            LastName = lastName;
        }

        public DateTime BirthDate { get; set; }
        public int PassportNmber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public List<Flight> ListFlight { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
        ////public bool CheckProfile(string firstName, string lastName)
        ////{
        ////    return FirstName == firstName && LastName == lastName;
        ////}

        ////public bool CheckProfile(string firstName, string lastName, string email)
        ////{
        ////    return FirstName == firstName && LastName == lastName && EmailAddress == email;
        ////}

        public bool CheckProfile(string firstName, string lastName, string email = null)
        {
            if (email != null)
                return FirstName == firstName && LastName == lastName && EmailAddress == email;
            else
                return FirstName == firstName && LastName == lastName;
        }

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");
        }

    }
}
