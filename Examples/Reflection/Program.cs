// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//DortIslem dortIslem = new DortIslem(2,3);
//Console.WriteLine(dortIslem.Topla2());
//Console.WriteLine(dortIslem.Topla(3,4));

using System.Reflection;

var type = typeof(DortIslem);
DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,7,8);
Console.WriteLine(dortIslem.Topla(4, 5));
Console.WriteLine(dortIslem.Topla2());

//Method Info
Console.WriteLine("---------------");
var tip = typeof(DortIslem);
var instance = Activator.CreateInstance(tip,8,9);
MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

Console.WriteLine(methodInfo.Invoke(instance, null));

//Method Detail
var metod = tip.GetMethods();
foreach (var info in metod)
{
	Console.WriteLine("Metod Adı : {0}", info.Name);
	foreach (var infoParameter in info.GetParameters())
	{
		Console.WriteLine(infoParameter.Name);
	}

	foreach (var attribute in info.GetCustomAttributes())
	{
		Console.WriteLine(attribute.GetType().Name);
	}
}
public class DortIslem
{
	private int _sayi1;
	private int _sayi2;
	public DortIslem(int sayi1, int sayi2)
	{
		_sayi1 = sayi1;
		_sayi2 = sayi2;
	}
	public DortIslem()
	{
	}
	public int Topla(int sayi1,int sayi2)
	{
		return sayi1 + sayi2;
	}
	public int Carp(int sayi1, int sayi2)
	{
		return sayi1 * sayi2;
	}
	public int Topla2()
	{
		return _sayi1 + _sayi2;
	}
	[MethodName("Carpma")]
	public int Carp2()
	{
		return _sayi1 * _sayi2;
	}
}

class MethodNameAttribute : Attribute
{
	public MethodNameAttribute(string name)
	{

	}
}