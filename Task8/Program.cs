// 8. Показать четные числа от 1 до N

Console.Write("Input integer positive number: ");
string? strNumber = Console.ReadLine();
try
{
    int N = Convert.ToInt32(strNumber);
    if (N > 0)
    {
        Console.WriteLine($"Even numbers between 1 and {N}:");
        for (int i = 1; i < N + 1; i++)
        {
            if (i % 2 == 0) Console.Write($" {i} ");
        }
        Console.WriteLine();
    }
    else throw new FormatException();
}
catch (FormatException)
{
    Console.WriteLine("Incorrect input!");
}