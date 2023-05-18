// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Value Type
int number1 = 10;
int number2 = 20;

number2 = number1;
number1 = 30;

Console.WriteLine(number2);

//Array is Reference Type
string[] cities = new string[] { "Ankara", "İstanbul", "Kocaeli" };
string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };

cities2 = cities;
cities[0] = "İstanbul";

foreach (var item in cities2)
{
	Console.WriteLine(item);
}
