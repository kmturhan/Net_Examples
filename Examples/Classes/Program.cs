using Classes;

class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        ProductManager productManager = new ProductManager();
        productManager.Update();

        Customer customer = new Customer();
        customer.City = "Kocaeli";
        customer.Id = 1;
        customer.FirstName = "Test";
        customer.LastName = "testlast";

        Customer customer2 = new Customer()
        {
            FirstName = "test2",
            City = "Kocalei2",
            Id = 2,
            LastName = "testlast2"
        };
        Console.WriteLine(customer.FirstName);
        Console.WriteLine(customer2.FirstName);
            
        Console.ReadLine();
    }
}