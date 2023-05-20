// See https://aka.ms/new-console-template for more information
using Exceptions;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");


HandleException(() => {
	Find();
});

static void HandleException(Action action)
{
	try
	{
		action.Invoke();
	}
	catch (Exception exception)
	{
		Console.WriteLine(exception.Message);
	}
}

static void Find()
{
	List<string> student = new List<string>() { "test", "test2", "test3" };

	if (!student.Contains("test6"))
	{
		throw new RecordNotFoundException("Record Not Found!");
	}
	else
	{
		Console.WriteLine("Record Found!");
	}
}


void catchUse()
{
	try
	{
		string[] students = new string[] { "test", "test2", "test3" };
		students[3] = "test4";
	}
	catch (IndexOutOfRangeException ex)
	{
		Console.WriteLine(ex.Message);
	}
	catch (Exception ex)
	{
		Console.WriteLine(ex.Message);
	}
}


