class Program
{
	static void Main(string[] args)
	{
		//.net 6.0 new feature
		List<string> testArray= new List<string>() { "test", "test2", "test3", "test4","test5", "test6", "test7","test8", "test9" };
		var testArray2 = testArray.Take(3..7);
		foreach (var item in testArray2)
		{
			Console.WriteLine(item);
		}
		/*
		 * Output : 
		test4
		test5
		test6
		test7
		 * 
		 * */
		Console.WriteLine("--------------------------------------");
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