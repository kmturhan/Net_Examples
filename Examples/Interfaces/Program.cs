using Interfaces;

class Program
{
    static void Main(string[] args)
    {
        //InterfacesIntro();
        //Demo();
        List<ICustomerDal> customerDals = new List<ICustomerDal>
        {
            new SqlServerCustomerDal(),
            new OracleCustomerDal()
        };
        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }
        Console.ReadLine();
    }

    private static void Demo()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new OracleCustomerDal());
    }

    private static void InterfacesIntro()
    {
        PersonManager manager = new PersonManager();
        manager.Add(new Customer { Id = 1, FirstName = "test first", LastName = "testlast", Address = "test address" });
        manager.Add(new Student
            { Id = 2, FirstName = "test student", LastName = "test student last", Department = "department" });
    }
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }
}

class PersonManager
{
    public void Add(IPerson customer)
    {
        
        Console.WriteLine(customer.FirstName + " Added!");
    }
}