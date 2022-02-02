// 43. Написать программу преобразования десятичного числа в двоичное

int ReadIntFromConsole(string msg)
{
RepeatInput:
    Console.Write(msg);
    string? strResult = Console.ReadLine();
    try
    {
        int result = Convert.ToInt32(strResult);
        return result;
    }
    catch (FormatException)
    {
        Console.WriteLine("Incorrect input!");
        goto RepeatInput;
    }
}

string DecimalToBinary(int decimalNumber)
{
    int tempNumber = decimalNumber;
    int resultLength = 0;
    while (tempNumber > 0)
    {
        tempNumber /= 2;
        resultLength++;
    }
    int[] intResult = new int[resultLength];
    for (int i = 0; i < resultLength; i++)
    {
        intResult[i] = decimalNumber % 2;
        decimalNumber /= 2;
    }
    string result = "0";
    for (int i = 0; i < resultLength; i++)
    {
        result = result + Convert.ToString(intResult[resultLength - 1 - i]);
    }
    return result;
}

Console.WriteLine("Написать программу преобразования десятичного числа в двоичное");
IncorrectInput:
int numberDec = ReadIntFromConsole("Input positive number: ");
if (numberDec < 0)
{
    Console.WriteLine("Incorrect input!");
    goto IncorrectInput;
}
else Console.WriteLine($"Number {numberDec} in binary system: {DecimalToBinary(numberDec)}.");