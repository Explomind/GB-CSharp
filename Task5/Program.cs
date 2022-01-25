// 5. Написать программу вычисления значения функции y = f(a)

Console.Write("Input integer number: a = ");
string? strNumber = Console.ReadLine();
try
{
    int number = Convert.ToInt32(strNumber);
    Console.WriteLine($"a^2+3a+10={FunctionY(number)}");
}
catch
{
    Console.WriteLine("Incorrect input!");
}

int FunctionY(int a)
{
    int result = a*a+3*a+10;
    return result;
}
