// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

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

string NumberSeries(int number1, int number2, int N)
{
    if (N == 1) return String.Empty;
    else return $"{number2} " + NumberSeries(number2, number1 + number2, N - 1);
}

Console.WriteLine("Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих");
int number1 = ReadIntFromConsole("Input the first number of the series: ");
int number2 = ReadIntFromConsole("Input the second number of the series: ");
int amount = ReadIntFromConsole("Input amount of numbers: ");
Console.WriteLine($"{number1} " + NumberSeries(number1, number2, amount));