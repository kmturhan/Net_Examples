class Program
{
    static void Main(string[] args)
    {
        SqlServer sqlServer = new SqlServer();
sqlServer.Add();
        MysqlServer mysqlServer = new MysqlServer();
        mysqlServer.Add();
        Console.ReadLine();
    }
}

class Database
{
    public virtual void Add()
    {
        Console.WriteLine("Added by default");
    }
    public virtual void Delete()
    {
        Console.WriteLine("Delete by default");
    }
}

class SqlServer : Database
{
    public override void Add()
    {
        Console.WriteLine("private code");
    }
}
class MysqlServer : Database
{
    
}