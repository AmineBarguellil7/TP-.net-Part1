

////declaration variable;

//int nb = int.Parse(Console.ReadLine());

//for (int i = 0; i < nb; i++)
//{
//    string chaine = null;
//    float? age = null;
//    //do {
//    while (age <= 0)
//    {
//        try
//        {
//            age = float.Parse(Console.ReadLine());
//        }
//        catch
//        {
//            Console.WriteLine("Erreur");
//        }
//    }
//    //} while (age<=0);

//    Console.WriteLine("Hello " + chaine + " Age =" + (age + 1));
//}

using AM.Application.Core.Domain;
using System.Net.Mail;
using System.Security.Cryptography;

//Person personne = new Person();
//personne.Id = 0;
//personne.Nom = "bar";
//personne.Prenom = "amine";
//personne.DateNaissance = new DateTime(2022, 12, 31, 15, 45, 54);
//Person personne1 = new Person(0,"foulen","am","am@gmail.com","000", DateTime.Now); ;
//Console.WriteLine(personne.ToString());
//Person etudiant= new Etudiant();
//personne.GetMyType();
//etudiant.GetMyType();



////TP1-Q7: Créer un objet de type Plane en utilisant le constructeur non paramétré
//Plane plane1 = new Plane();
//plane1.PlaneType = PlaneType.Airbus;
//plane1.Capacity = 200;
//plane1.ManufactureDate = new DateTime(2018, 11, 10);

////TP1-Q8: Créer un objet de type Plane en utilisant le constructeur paramétré
//Plane plane2 = new Plane(PlaneType.Boing, 300, DateTime.Now);

////TP1-Q9: Créer un objet de type Plane en utilisant l'initialiseur d'objet
//Plane plane3 = new Plane
//{
//    PlaneType = PlaneType.Airbus,
//    Capacity = 150,
//    ManufactureDate = new DateTime(2015, 02, 03)
//};

Console.WriteLine("************************************ Testing Signature Polymorphisme ****************************** ");
Passenger p1 = new Passenger { FirstName = "steave", LastName = "jobs", EmailAddress = "steeve.jobs@gmail.com", BirthDate = new DateTime(1955, 01, 01) };
Console.WriteLine("La méthode CheckProfile:");
Console.WriteLine(p1.CheckProfile("steave", "jobs"));
Console.WriteLine(p1.CheckProfile("steave", "jobs", "steeve.jobs@gmail.com"));

Console.WriteLine("************************************ Testing Inheritance Polymorphisme ****************************** ");
Staff s1 = new Staff { FirstName = "Bill", LastName = "Gates", EmailAddress = "Bill.gates@gmail.com", BirthDate = new DateTime(1945, 01, 01), EmployementDate = new DateTime(1990, 01, 01), Salary = 99999 };
Traveller t1 = new Traveller { FirstName = "Mark", LastName = "Zuckerburg", EmailAddress = "Mark.Zuckerburg@gmail.com", BirthDate = new DateTime(1980, 01, 01), HealthInformation = "Some troubles", Nationality = "American" };
Console.WriteLine("La méthode PassengerType p1:");
p1.PassengerType();
Console.WriteLine("La méthode PassengerType s1:");
s1.PassengerType();
Console.WriteLine("La méthode PassengerType t1:");
t1.PassengerType();




//Amine Barguellil 4 twin 2

