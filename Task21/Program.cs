// 21. Программа проверяет пятизначное число на палиндром.

// Read string from console and convert it to integer
int ReadIntFromConsole(string msg)
{
    Console.Write(msg);
    string? strResult = Console.ReadLine();
    try
    {
        int result = Convert.ToInt32(strResult);
        return result;
    }
    catch (FormatException)
    {
        return 0;
    }
}

// Cheak if number is palindrome
bool NumberIsPalindrome(int number, int size)
{
    int[] digits = new int[size];
    for (int i = 0; i < digits.Length; i++)
    {
        digits[i] = number % 10;
        number = number / 10;
    }
    int j = 0;
    while (j < digits.Length / 2)
    {
        if (digits[j] == digits[size - j - 1]) j++;
        else return false;
    }
    return true;
}

Console.WriteLine("Программа проверяет пятизначное число на палиндром.");
RepeatInput:
int input = ReadIntFromConsole("Input 5-digit number: ");
if (input > 9999 && input < 100000)
{
    if (NumberIsPalindrome(input, 5)) Console.WriteLine("The number is palindrome.");
    else Console.WriteLine("The number is NOT palindrome.");
}
else
{
    Console.WriteLine("Incorrect input!");
    goto RepeatInput;
}