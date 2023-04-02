class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        Console.ReadLine();
    }
}

class CustomerManager
{
    public ILogger Logger { get; set; }
    public void Add()
    {
        Logger.Log();
        Console.WriteLine("Customer added!");
    }
}

class Logger: ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to database");
    }
}

class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to file");
    }
}
interface ILogger
{
    void Log();
}