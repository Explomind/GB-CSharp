// 9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа

Console.Write("Input 3-digit number: ");
string? strNumber = Console.ReadLine();
try
{
    int number = Convert.ToInt32(strNumber);
    if(strNumber.Length == 3)
    {
        Console.WriteLine($"The last digit is {strNumber[2]}");
        Console.WriteLine($"The second digit is {strNumber[1]}");
    }
    else Console.WriteLine("This number is not 3-digit!");
}
catch
{
    Console.WriteLine("Incorrect input!");
}