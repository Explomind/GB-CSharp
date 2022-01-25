// 6. Выяснить является ли число чётным

Console.Write("Input number: ");
string? strNumber = Console.ReadLine();
try
{
    int number = Convert.ToInt32(strNumber);
    if(number % 2 == 0){Console.WriteLine($"Number {number} is even.");}
    else{Console.WriteLine($"Number {number} is odd.");}
}
catch
{
    Console.WriteLine("Incorrect input!");
}