class Program
{
	static void Main(string[] args)
	{
		string[] list = new string[] { "test", "test2", "test3" };
		foreach (var item in list)
		{
			Console.WriteLine(item);
		}

		string[,] regions = new string[2, 3]
		{
			{ "istanbul", "kocaeli", "bursa" },
			{ "istanbul2", "kocaeli2", "bursa2" }
		};
		foreach (var row in regions)
		{
			Console.WriteLine(row);
			Console.WriteLine(regions[0, 1]);
		}

		string number = Console.ReadLine();
		Console.WriteLine("'{0}' Is Prime? : {1}", number, IsPrimeNumber(int.Parse(number)));


	}
	public static bool IsPrimeNumber(int number)
	{
		bool result = true;
		for (int i = 2; i < number - 1; i++)
		{
			if (number % i == 0)
			{
				result = false;
			}
		}
		return result;
	}
}