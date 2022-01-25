// 7. Показать числа от -N до N

Console.Write("Input integer positive number: ");
string? strNumber = Console.ReadLine();
try
{
    int N = Convert.ToInt32(strNumber);
    if (N > 0)
    {
        for (int i = 0; i < 2 * N + 1; i++) Console.Write($" {-N + i} ");
        Console.WriteLine();
    }
    else Console.WriteLine("Incorrect input!");
}
catch
{
    Console.WriteLine("Incorrect input!");
}