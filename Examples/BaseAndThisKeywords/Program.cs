// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");


public class BaseClass
{
    public BaseClass(int a)
    {

    }
    public BaseClass(string name, int c)
    {
        Console.WriteLine($"{name} : {c}");
    }
    public BaseClass(string name, int c, int d)
    {
        Console.WriteLine($"{name} : {c}");
    }
}

public class DerivedClass : BaseClass
{
    public DerivedClass() : base(5)
    {

    }
    public DerivedClass(string a) : base(a, 2)
    {

    }
}