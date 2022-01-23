int number = new Random().Next(10, 1000);
Console.WriteLine($"Number: {number}");

int firstDigit = number / 100;
Console.WriteLine($"First digit: {firstDigit}");

int lastDigit = number % 10;
Console.WriteLine($"Last digit: {lastDigit}");

Console.WriteLine($"Maximum digit: {Max(firstDigit, lastDigit)}");

int Max(int a, int b)
{
    if (a > b) return a;
    return b;
}

