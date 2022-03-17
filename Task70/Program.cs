// 70. Найти сумму цифр числа

int ReadIntFromConsole(string msg)
{
RepeatInput:
    Console.Write(msg);
    string? strResult = Console.ReadLine();
    try
    {
        int result = Convert.ToInt32(strResult);
        return result;
    }
    catch (FormatException)
    {
        Console.WriteLine("Incorrect input!");
        goto RepeatInput;
    }
}

int SumDigits(int number)
{
    return number == 0 ? 0 : number % 10 + SumDigits(number / 10);
}

Console.WriteLine("Найти сумму цифр числа");
int number = ReadIntFromConsole("Input number: ");
Console.WriteLine($"Sum of digits: {SumDigits(number)}");