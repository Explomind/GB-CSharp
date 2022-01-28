// 23. Показать таблицу квадратов чисел от 1 до N

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

Console.WriteLine("Показать таблицу квадратов чисел от 1 до N");
double number = ReadDoubleFromConsole("Input number >1: ");
for (int i = 1; i < number + 1; i++)
{
    Console.WriteLine($"{i}^2 = {i * i}");
}