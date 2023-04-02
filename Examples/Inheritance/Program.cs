using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        List<Person> persons = new List<Person>()
        {
            new Customer { FirstName = "Customer Name" },
            new Person { FirstName = "Person Name" },
            new Student { FirstName = "Student Name" }
        };

        foreach (var person in persons)
        {
            Console.WriteLine(JsonSerializer.Serialize(person));
        }

        Console.ReadLine();
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    interface IPerson
    {
    }

    interface IPerson2
    {
    }

    //Birden fazla class eklenemez 
    //interface'ler sonda olacak şekilde eklenebilir.
    class Customer : Person, IPerson, IPerson2
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string City { get; set; }
    }
}