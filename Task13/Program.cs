// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

int dividend = new Random().Next(2, 101);
Console.WriteLine($"Dividend: {dividend}");
Console.Write("Input divider: ");
string? strDivider = Console.ReadLine();
try
{
    int divider = Convert.ToInt32(strDivider);
    if (dividend % divider == 0) Console.WriteLine($"{dividend} is multiple of {divider}");
    else Console.WriteLine($"Remainder of the division: {dividend % divider}");
}
catch
{
    Console.WriteLine("Incorrect input!");
}