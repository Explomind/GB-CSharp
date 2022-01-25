// 9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа

Console.Write("Input 3-digit number: ");
string? strNumber = Console.ReadLine();
try
{
    int number = Convert.ToInt32(strNumber);
    if(strNumber.Length == 3)
    {
        int lastDigit = number % 10;
        Console.WriteLine($"The last digit is {lastDigit}");
        int secondDigit = number % 100;
        secondDigit = secondDigit / 10;
        Console.WriteLine($"The second digit is {secondDigit}");
    }
    else Console.WriteLine("This number is not 3-digit!");
}
catch
{
    Console.WriteLine("Incorrect input!");
}