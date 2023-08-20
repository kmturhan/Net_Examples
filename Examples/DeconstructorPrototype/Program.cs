
List<Person> list = new List<Person>();
list.Add(new Person
{
    Name = "Test1",
    Age = 10,
    City = "İstanbul"
});

list.Add(new Person
{
    Name = "Test2",
    Age = 20,
    City = "Kocaeli"
});

list.Add(new Person
{
    Name = "Test3",
    Age = 30,
    City = "Sakarya"
});


foreach (var item in list)
{

    var (itemName, itemAge) = item;
    Console.WriteLine($"{itemName} - {itemAge}");        
}
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City{ get; set; }

    /// <summary>
    /// Deconstruct Tuple tipinde sadece belirlediğin prop'ları dönmeni sağlayan bir araç.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="age"></param>
    public void Deconstruct(out string name, out int age)
    {
        name = Name;
        age = Age;
    }
}