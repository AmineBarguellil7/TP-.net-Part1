using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Person
    {
        public Person()
        {
        }

        public Person(int id, string nom, string prenom, string email, string password, DateTime dateNaissance)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Password = password;
            DateNaissance = dateNaissance;
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateNaissance { get; set; }

        public override string ToString()
        {
            return $"[{Id},{Nom},{Prenom},{Email}]";
        }

        public bool Login(string nom, string password,string email=null)
        {
                return nom == Nom && password == Password && (email==Email || email==null);
        }

        public virtual void GetMyType()
        {
            Console.WriteLine("I am a Person");
        }      
    }
}
