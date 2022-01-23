// 0. Вывести квадрат числа
// 1. По двум заданным числам проверять является ли первое квадратом второго
// 2. Даны два числа. Показать большее и меньшее число

Console.Write("Input first number: ");
string? strFirstNumber = Console.ReadLine();
Console.Write("Input second number: ");
string? strSecondNumber = Console.ReadLine();
try
{
    int firstNumber = Convert.ToInt32(strFirstNumber);
    int secondNumber = Convert.ToInt32(strSecondNumber);
    Console.WriteLine($"Squared first number = {firstNumber*firstNumber}.");
    if(firstNumber / secondNumber == secondNumber)
    {
        Console.WriteLine($"First number is equal to squared second number.");
    }
    else 
    {
        Console.WriteLine($"First number is not equal to squared second number.");
    }
    if(firstNumber > secondNumber)
    {
        Console.WriteLine($"Max number is {firstNumber}");
        Console.WriteLine($"Min number is {secondNumber}");
    }
    else
    {
        if(firstNumber < secondNumber)
        {
            Console.WriteLine($"Max number is {secondNumber}.");
            Console.WriteLine($"Min number is {firstNumber}.");
        }
        else {Console.WriteLine($"First number = second number.");}
    }
}
catch
{
    Console.WriteLine("Incorrect input");
}