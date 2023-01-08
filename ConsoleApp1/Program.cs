Console.WriteLine("Hello, World!");

int number = 2;
int number2 = 9;
Console.WriteLine("Number : {0} ", number);
var result = Add3(ref number, number2);
Console.WriteLine("Number : {0} ", number);
Console.WriteLine("Result : {0} ", result);
Console.WriteLine("Variable : {0} ", number);


static void Add(int number1, int number2)
{
    Console.WriteLine(number1 + number2);
}

static int Add3(ref int number, int number2)
{
    number = 55;
    return number + number2;
}