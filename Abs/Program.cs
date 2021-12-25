int value = ReadIntFromConsole("Enter integer number");
Console.WriteLine($"Absolute value = {Absolute(value)}");

int ReadIntFromConsole(string prompt)
{
    Console.WriteLine(prompt);
    string result = Console.ReadLine();
    return Convert.ToInt32(result);
}

int Absolute(int argument)
{
    if (argument >= 0) return argument;
    return -argument;
}