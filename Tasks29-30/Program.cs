// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру

double ReadDoubleFromConsole(string msg)
{
RepeatInput:
    Console.Write(msg);
    string? strResult = Console.ReadLine();
    try
    {
        double result = Convert.ToDouble(strResult);
        return result;
    }
    catch (FormatException)
    {
        Console.WriteLine("Incorrect input!");
        goto RepeatInput;
    }
}

double Multiplication(double range)
{
    if (range <= 1) return 1;
    else
    {
        return Multiplication(range - 1) * range;
    }
}

Console.WriteLine("Написать программу вычисления произведения чисел от 1 до N");
double number = ReadDoubleFromConsole("Input number N: ");
double product = 1;
if (number > 0)
{
    for (int i = 1; i < number + 1; i++)
    {
        product *= i;
    }
}
else product = 0;
Console.WriteLine($"Product of numbers from 1 to {number}: {product}");
Console.WriteLine($"Product of numbers from 1 to {number}: {Multiplication(number)}");
Console.WriteLine("Показать кубы чисел, заканчивающихся на четную цифру");
number = ReadDoubleFromConsole("Input number: ");
for (int i = 2; i < number + 1; i++)
{
    if (i % 2 == 0) Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
}