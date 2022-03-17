// 71. Написать программу вычисления функции Аккермана

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

int CheckRange(int number, int min, int max)
{
    if (number > max)
    {
        number = max;
        Console.WriteLine($"Value = {max}");
    }
    if (number < min)
    {
        number = min;
        Console.WriteLine($"Value = {min}");
    }
    return number;
}

int AkkermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return AkkermanFunc(m - 1, 1);
    else return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

Console.WriteLine("Написать программу вычисления функции Аккермана");
int m = ReadIntFromConsole("Input number m [0, 3]: ");
m = CheckRange(m, 0, 3);
int n = ReadIntFromConsole("Input number n [0, 5]: ");
n = CheckRange(n, 0, 5);
Console.WriteLine($"A({m}, {n}) = {AkkermanFunc(m, n)}");