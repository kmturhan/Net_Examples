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
/*
    Aynı işi farklı yapılarda yapmamız gerektiği zaman yani her metodu ayrı ayrı kodlamamız gerekiyorsa "interface" kullanılmalı.
    Aynı iş birkaç yerde aynı şekilde ama bir veya iki yerde farklılaşıyorsa yani aynı metodu ortak kullanacağımız ama bazı yerlerde ayrılan bi durum varsa "virtual method" kullanılmalı.
    
*/
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