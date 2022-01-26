// 15. Дано число. Проверить кратно ли оно 7 и 23

Console.Write("Input number: ");
string? strNumber = Console.ReadLine();
try
{
    int number = Convert.ToInt32(strNumber);
    if ((number % 7 == 0) && (number % 23 == 0)) Console.WriteLine($"Number {number} is multiple of 7 and 23.");
    else Console.WriteLine($"Number {number} is not multiple of 7 and 23.");
}
catch
{
    Console.WriteLine("Incorrect input!");
}