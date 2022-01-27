// 20. Задать номер четверти, показать диапазоны для возможных координат

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

Console.WriteLine("Задать номер четверти, показать диапазоны для возможных координат");
string[] coordinates = { "X > 0, Y > 0", "X < 0, Y > 0", "X < 0, Y < 0", "X > 0, Y < 0" };
string[] quarters = {"first", "second", "third", "forth"};
ReapeatInput:
int quarterNumber = ReadIntFromConsole("Input quarter number (1-4): ");
if (quarterNumber > 0 && quarterNumber < 5)
{
    Console.WriteLine($"Possible coordinates for the {quarters[quarterNumber-1]} quarter are {coordinates[quarterNumber-1]}");
}
else
{
    Console.WriteLine("Incorrect input!");
    goto ReapeatInput;
}