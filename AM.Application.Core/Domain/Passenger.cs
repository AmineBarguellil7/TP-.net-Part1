using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Display(Name ="Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Key]
        [StringLength(7)]
        public int PassportNmber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Le prénom doit avoir entre 3 et 25 caractères.")]
        public FullName fullName { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "Le numéro de téléphone doit contenir 8 chiffres.")]
        public string TelNumber { get; set; }
        public virtual List<Flight> ListFlight { get; set; }

        public virtual IList<Ticket> tickets { get; set; }
        
        ////public bool CheckProfile(string firstName, string lastName)
        ////{
        ////    return FirstName == firstName && LastName == lastName;
        ////}

        ////public bool CheckProfile(string firstName, string lastName, string email)
        ////{
        ////    return FirstName == firstName && LastName == lastName && EmailAddress == email;
        ////}

        //public bool CheckProfile(string firstName, string lastName, string email = null)
        //{
        //    if (email != null)
        //        return FirstName == firstName && LastName == lastName && EmailAddress == email;
        //    else
        //        return FirstName == firstName && LastName == lastName;
        //}

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");
        }

    }
}
