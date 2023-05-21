// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");

Customer customer = new Customer
{
	Id = 1,
	LastName = "test",
	Age = 23
};
CustomerDal customerDal = new CustomerDal();
customerDal.Add(customer);

[ToTable("Customers")]
class Customer
{
	public int Id { get; set; }
	[RequiredProperty]
	[RequiredProperty]
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }
}

class CustomerDal
{
	[Obsolete("Don't use add, instead AddNew method")]
	public void Add(Customer customer)
	{
		Console.WriteLine("{0}-{1}-{2}-{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
	}
	public void AddNew(Customer customer)
	{
		Console.WriteLine("{0}-{1}-{2}-{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
	}
}

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
class RequiredPropertyAttribute : Attribute
{

}
[AttributeUsage(AttributeTargets.Class)]
class ToTableAttribute : Attribute
{
	private string _tableName;
	public ToTableAttribute(string tableName)
	{
		_tableName = tableName;
	}
}