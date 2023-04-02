class Program
{
    static void Main(string[] args)
    {
        Database database = new SqlServer();
        database.Add();
        database.Delete();


        Database database2 = new OracleServer();
        database2.Add();
        database2.Delete();
        Console.ReadLine();
    }
}

abstract class Database
{
    public void Add()
    {
        Console.WriteLine("added by default");
    }

//abstract için "içi dolu olmayan virtual metod diyebiliriz"
//her class için ayrı ayrı implement etmek gerekiyor
    public abstract void Delete();
}

class SqlServer : Database
{
    public override void Delete()
    {
        Console.WriteLine("deleted by sql");
    }
}

class OracleServer : Database
{
    public override void Delete()
    {
        Console.WriteLine("deleted by oracle");
    }
}