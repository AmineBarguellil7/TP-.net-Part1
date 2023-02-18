using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Traveller:Passenger
    {
        public Traveller()
        {
        }

        public Traveller(string healthInformation, string nationality)
        {
            HealthInformation = healthInformation;
            Nationality = nationality;
        }

        public string HealthInformation { get; set; }
        public string Nationality
        {
            get; set;
        }

        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am a passenger I am a traveller");
        }
    }
}
