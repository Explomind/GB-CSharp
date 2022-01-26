// 17. По двум заданным числам проверять является ли одно квадратом другого

int ReadIntFromConsole(string msg)
{
    Console.Write(msg);
    string? strNumber = Console.ReadLine();
    try
    {
        int number = Convert.ToInt32(strNumber);
        return number;
    }
    catch (FormatException)
    {
        return 0;
    }
}

RepeatInput1:
int firstNumber = ReadIntFromConsole($"Input first number (except 0): ");
if (firstNumber == 0)
{
    Console.WriteLine("Incorrect input!");
    goto RepeatInput1;
}
RepeatInput2:
int secondNumber = ReadIntFromConsole("Input second number (except 0): ");
if (secondNumber == 0)
{
    Console.WriteLine("Incorrect input!");
    goto RepeatInput2;
}


// Console.Write("Input first number: ");
// string? strFirstNumber = Console.ReadLine();
// Console.Write("Input second number: ");
// string? strSecondNumber = Console.ReadLine();
// try
// {
//     int firstNumber = Convert.ToInt32(strFirstNumber);
//     int secondNumber = Convert.ToInt32(strSecondNumber);
if ((firstNumber * firstNumber == secondNumber) || (secondNumber * secondNumber == firstNumber))
{
    Console.WriteLine("One number is squared of other number.");
}
else
{
    Console.WriteLine("One number is not squared of another.");
}
// }
// catch
// {
//     Console.WriteLine("Incorrect input!");
// }