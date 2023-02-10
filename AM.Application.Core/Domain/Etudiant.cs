using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Etudiant :Person
    {
        public int Matricule
        {
            get; set;
        }
        public string Specialite { get; set; }
        public Etudiant() { }

        public override void GetMyType()
        {
            Console.WriteLine("I am a student");
        }
    }
}
