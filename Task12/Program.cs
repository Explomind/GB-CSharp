// 12. Удалить вторую цифру трёхзначного числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"Random 3-digit number: {number}");
number = number / 100 * 10 + number % 10;
Console.WriteLine($"Number without second digit: {number}");