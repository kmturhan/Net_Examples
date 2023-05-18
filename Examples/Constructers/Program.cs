// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
CustomerManager customer = new CustomerManager();
customer.List();

Product product = new Product() { Id = 2, Name = "test" };
Product product2 = new Product(4, "test2");


EmployeeManager newEmployee = new EmployeeManager(new DatabaseLogger());
newEmployee.Add();


PersonManager person = new PersonManager("Product");
person.Add();


Teacher.Number = 20;
Utilities.Validate();

Manager.DoSomething();
Manager manager = new Manager();
manager.DoSomething2();
Console.ReadLine();

class CustomerManager
{
	private int _count = 15;
	public CustomerManager(int count)
	{
		_count = count;
	}
	public CustomerManager()
	{

	}
	public void List()
	{
		Console.WriteLine("Listed! {0}", _count);
	}
	public void Add()
	{
		Console.WriteLine("Added!");
	}
}

class Product
{
	public Product()
	{

	}
	int _id;
	string _name;
	public Product(int id, string name)
	{
		_id = id;
		_name = name;
	}
	public int Id { get; set; }
	public string Name { get; set; }
}

interface ILogger
{
	void Log();
}

class DatabaseLogger : ILogger
{
	public void Log()
	{
		Console.WriteLine("Logged to database!");
	}
}
class FileLogger : ILogger
{
	public void Log()
	{
		Console.WriteLine("Logged to file!");
	}
}
class EmployeeManager
{
	private ILogger _logger;
	public EmployeeManager(ILogger logger)
	{
		_logger = logger;
	}
	public void Add()
	{
		Console.WriteLine("Added!");
	}
}

class BaseClass
{
	private string _entity;
	public BaseClass(string entity)
	{
		_entity = entity;
	}
	public void Message()
	{
		Console.WriteLine("{0} message", _entity);
	}
}

class PersonManager : BaseClass
{
	public PersonManager(string entity) : base(entity)
	{

	}

	public void Add()
	{
		Console.WriteLine("added");
		Message();
	}
}

static class Teacher
{
	public static int Number { get; set; }
}

static class Utilities
{
	static Utilities()
	{

	}
	public static void Validate()
	{
		Console.WriteLine("Validation is done!");
	}
}

class Manager
{
	public static void DoSomething()
	{
		Console.WriteLine("done!");
	}
	public void DoSomething2()
	{
		Console.WriteLine("Done 2");
	}
}