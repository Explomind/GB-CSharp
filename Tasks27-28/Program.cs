// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе

Console.WriteLine("Определить количество цифр в числе, подсчитать сумму цифр в числе");
RepeatInput:
Console.Write("Input number: ");
string? strNumber = Console.ReadLine();
try
{
    int number = Convert.ToInt32(strNumber);
    int numberLength = 0;
    if (number < 0)
    {
        number = -number;
        numberLength = strNumber.Length - 1;
    }
    else numberLength = strNumber.Length;
    int digitsSum = 0;
    int[] digits = new int[numberLength];
    for (int i = 0; i < numberLength; i++)
    {
        digits[i] = number % 10;
        digitsSum = digitsSum + digits[i];
        number = number / 10;
    }
    Console.WriteLine($"The number has {numberLength} digits.");
    Console.WriteLine($"The sum of digits is {digitsSum}");
}
catch (FormatException)
{
    Console.WriteLine("Incorrect input!");
    goto RepeatInput;
}
