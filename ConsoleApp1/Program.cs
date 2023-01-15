namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int number = 2;
            int number2 = 9;
            Console.WriteLine("Number : {0} ", number);
            var result = Add3(ref number, number2);
            Console.WriteLine("Number : {0} ", number);
            Console.WriteLine("Result : {0} ", result);
            Console.WriteLine("Variable : {0} ", number);
            Console.WriteLine("Method Overload Multiply2 :{0} Multiply3 : {1}", Multiply(4,2),Multiply(2,4,6));
            Console.WriteLine("Method Params : {0}", ParamsKeyword(2,4,6,8,4,2,34,5));
            Console.ReadLine();
        }
        static void Add(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        static int Add3(ref int number, int number2)
        {
            number = 55;
            return number + number2;
        }
        static int Multiply(int number, int number2)
        {
            return number + number2;
        }

        static int Multiply(int number, int number2, int number3)
        {
            return number * number2 * number3;
        }

        static int ParamsKeyword(params int[] numberList)
        {
            return numberList.Sum();
        }
    }
}

    


