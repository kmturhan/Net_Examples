// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Utilities utilities = new Utilities();
List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");

List<Customer> customers = utilities.BuildList<Customer>(new Customer { Name = "test" }, new Customer { Name = "2" }, new Customer { Name = "3" });


foreach (var item in customers)
{
	Console.WriteLine(item.Name);
}

class Utilities
{
	public List<T> BuildList<T>(params T[] items)
	{
		return new List<T>(items);
	}
}
class Product : IEntity
{

}
interface IProductDal : IRepository<Product>
{

}


class Customer : IEntity
{
	public string Name { get; set; }
}

interface ICustomerDal : IRepository<Customer>
{

}
//interface IStudent : IRepository<CustomerDal>
//{

//}
interface IEntity
{

}
//T:class means reference type
//T:IEntity means database object or a class
//T:new() means must be something derived
//where T : struct refers to the value type (int,	...)
interface IRepository<T> where T : class, IEntity, new()
{
	List<T> GetAll();
	T Get(int id);
	void Add(T customer);
	void Update(T customer);
	void Delete(T customer);
}

class ProductDal : IProductDal
{
	public void Add(Product customer)
	{
		throw new NotImplementedException();
	}

	public void Delete(Product customer)
	{
		throw new NotImplementedException();
	}

	public Product Get(int id)
	{
		throw new NotImplementedException();
	}

	public List<Product> GetAll()
	{
		throw new NotImplementedException();
	}

	public void Update(Product customer)
	{
		throw new NotImplementedException();
	}
}

class CustomerDal : ICustomerDal
{
	public void Add(Customer customer)
	{
		throw new NotImplementedException();
	}

	public void Delete(Customer customer)
	{
		throw new NotImplementedException();
	}

	public Customer Get(int id)
	{
		throw new NotImplementedException();
	}

	public List<Customer> GetAll()
	{
		throw new NotImplementedException();
	}

	public void Update(Customer customer)
	{
		throw new NotImplementedException();
	}
}