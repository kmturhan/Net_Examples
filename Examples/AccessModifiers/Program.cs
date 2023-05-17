
Console.WriteLine("Hello, World!");

class Customer
{
	protected int Id { get; set; }
	public void Save()
	{
		
	}
}

class Student : Customer
{
	public void Save2()
	{
		Customer customer = new Customer();
		
	}
}


//Internal sadece ilgili proje içerisinde istendiği yerde çağırılabilir.
//Başka bir projeden ÇAĞIRILAMAZ!
public class Course
{

	private void test()
	{

	}
}