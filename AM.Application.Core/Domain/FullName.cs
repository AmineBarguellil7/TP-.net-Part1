using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    [Owned]
    public  class FullName
    {
        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        [Display(Name ="firstname")]

        public string FirstName { get; set; }
        [Display(Name = "lastname")]
        public string LastName { get; set; }
    }


}
