// 21. Программа проверяет строку на палиндром.

// Cheak if number is palindrome
bool IsPalindrome(string value)
{
    value = value.ToLower();
    for (int i = 0; i < value.Length / 2; i++)
    {
        if (value[i] == value[value.Length - i - 1]) continue;
        return false;
    }
    return true;
}

Console.WriteLine("Программа проверяет строку на палиндром.");
Console.WriteLine();
RepeatInput:
Console.Write("Input something longer than one symbol: ");
string? input = Console.ReadLine();
if (input.Length > 1)
{
    if (IsPalindrome(input)) Console.WriteLine("This is palindrome.");
    else Console.WriteLine("This is NOT palindrome.");
}
else
{
    Console.WriteLine("Incorrect input!");
    goto RepeatInput;
}