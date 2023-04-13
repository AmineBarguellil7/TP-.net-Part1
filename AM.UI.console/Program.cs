

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
using System.Collections;
using System.Collections.Generic;
using AM.Application.Core.Services;
using AM.Infrastructure;

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

/*Console.WriteLine("************************************ Testing Signature Polymorphisme ****************************** ");
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

ArrayList List=new ArrayList(); 
List.Add(p1);
List.Add(12);
foreach (Object item in List)
{
    Console.WriteLine(item);
}
List<int> ints = new List<int>();
ints.Add(1);
ints.Add(2);
List<Plane> planes= new List<Plane>() { new Plane()  };*/



//ServiceFlight service = new ServiceFlight();
//service.Flights = TestData.ListFlights;
//string destination = "Paris";
//List<DateTime> dates = service.GetFlightDates(destination);

/*foreach (DateTime date in dates)
{
    Console.WriteLine(date);
}

List<Flight> flights = service.GetFlights("Destination","Paris");
foreach (Flight flight in flights)
{
    Console.WriteLine(flight);
}

IEnumerable<DateTime> dates1=service.GetFlightDates("Paris");
foreach (DateTime date in dates1)
{
    Console.WriteLine(date);
}*/

//Action<string, int> action;
//action = delegate (string a, int b) { Console.WriteLine(a + " " + b); };
//action("hello", 2);
//static void Test(string a, int v) { Console.WriteLine(a+" "+v); }; //meme principe que action
//Test("amine",2);
//static double Test2(Boolean a, string b) { return 0; };
//Console.WriteLine(Test2(true,"amine"));
//Func<Boolean, string, double> func;
//func = (Boolean a, string b) => 10;    //meme principe que func
//double a = func(true, "abc");
//Console.WriteLine(a);
//string a = "Paris";
//service.GetFlights("Paris",
/*delegate (string a, Flight flight)
{
    return flight.Destination == a;
});*/


/*foreach (DateTime date in service.GetFlightDates("Paris"))
{
    Console.WriteLine(date);
}*/

//service.FlightDetailsDel(service.Flights[0].Plane);
//Console.WriteLine(service.DurationAverageDel("Paris"));

/*foreach (Flight flight in service.GetFlights("Destination", "Paris"))
{
    Console.WriteLine(flight);
}*/

//PassengerExtension passenger = new PassengerExtension();
//Console.WriteLine(passenger.UpperFullName(service.Flights[0].Passengers[0]));


int x = 45;
Console.WriteLine(x.Add(4));
//Passenger passenger= service.Flights[0].Passengers[0];
//passenger.UpperFullName();

AmContext context=new AmContext();
context.Flights.Add(new Flight()
{
    EffectiveArrival = new DateTime(2024, 10, 12),
    Departure= "Tunis",
    Destination="France",
    EstimateDuration= 1,
    FlightDate= new DateTime(2024,04,15),
    Plane=new Plane()
    {
        Capacity= 20,
        ManufactureDate= new DateTime(2023,09,10),
        PlaneType=PlaneType.Boing
    }
}) ;

context.SaveChanges();


//foreach (var item in context.Flights.ToList())
//{
 //   Console.WriteLine(item.Departure+item.Destination+item.Plane.Capacity);
//}








//Par convention cle primaire ism le classe ba3d Id walla Id par defaut yakhothha cle primaire




//Amine Barguellil 4 twin 2

