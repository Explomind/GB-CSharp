// 17. По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Input first number: ");
string? strFirstNumber = Console.ReadLine();
Console.Write("Input second number: ");
string? strSecondNumber = Console.ReadLine();
try
{
    int firstNumber = Convert.ToInt32(strFirstNumber);
    int secondNumber = Convert.ToInt32(strSecondNumber);
    if (firstNumber * firstNumber == secondNumber)
    {
        Console.WriteLine($"Number {secondNumber} is squared number {firstNumber}");
    }
    else
    {
        if (secondNumber * secondNumber == firstNumber)
        {
            Console.WriteLine($"Number {firstNumber} is squared number {secondNumber}");
        }
        else Console.WriteLine("One number is not squared of another.");
    }
}
catch
{
    Console.WriteLine("Incorrect input!");
}