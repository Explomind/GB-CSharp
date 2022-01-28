// 23. Показать таблицу квадратов чисел от 1 до N
// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А

// Read string from console and convert it to double
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

Console.WriteLine("Показать таблицу квадратов и кубов чисел от 1 до N");
double number = ReadDoubleFromConsole("Input number >1: ");
double sumN = 0;
for (int i = 1; i < number + 1; i++)
{
    Console.Write($"{i}^2 = {Math.Pow(i, 2)}   ");
    Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
    sumN = sumN + i;
}
Console.WriteLine($"Sum of numbers from 1 to {number}: {sumN}");