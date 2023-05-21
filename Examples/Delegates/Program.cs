// See https://aka.ms/new-console-template for more information

using System;

namespace Delegates
{
	class Program
	{
		public delegate void MyDelegate();
		public delegate void MyDelegate2(string text);
		public delegate int MyDelegate3(int number1, int number2);
		static void Main(string[] args)
		{
			CustomerManager customerManager = new CustomerManager();
			
			//customerManager.SendMessage();
			//customerManager.ShowAlert();
			MyDelegate myDelegate = customerManager.SendMessage;
			myDelegate += customerManager.ShowAlert;
			myDelegate -= customerManager.SendMessage;
			myDelegate();
			MyDelegate2 myDelegate2 = customerManager.SendMessage2;
			myDelegate2 += customerManager.ShowAlert2;
			myDelegate2("Hellloo");
			Math math = new Math();

			MyDelegate3 myDelegate3 = math.Sum;
			Console.WriteLine(myDelegate3(3, 6));
		}
		public class CustomerManager
		{
			public void SendMessage()
			{
				Console.WriteLine("Hello!");
			}
			public void ShowAlert()
			{
				Console.WriteLine("Be Careful!!");
			}
			public void SendMessage2(string message)
			{
				Console.WriteLine(message);
			}
			public void ShowAlert2(string alert)
			{
				Console.WriteLine(alert);
			}
		}
		public class Math
		{
			public int Sum(int sayi1,int sayi2)
			{
				return sayi1 + sayi2;
			}
		}
	}
	
}



