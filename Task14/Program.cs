Console.WriteLine("Enter integer number:");
string? strNumber = Console.ReadLine();
try
{
    Convert.ToInt32(strNumber);
    int length = strNumber.Length;
    if (length > 2)
    {
        Console.WriteLine($"The third digit: {strNumber[2]}");
    }
    else
    {
        Console.WriteLine("No third digit");
    }
}
catch
{
    Console.WriteLine("Incorrect input");
}