// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10, 100);
Console.WriteLine($"Random number: {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
if (firstDigit > secondDigit) Console.WriteLine($"Max digit is {firstDigit}.");
if (firstDigit < secondDigit) Console.WriteLine($"Max digit is {secondDigit}.");
if (firstDigit == secondDigit) Console.WriteLine($"Digits are equal.");