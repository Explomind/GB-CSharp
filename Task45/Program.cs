// 45. Показать числа Фибоначчи

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

int[] FiboNumbers(int amount)
{
    int[] result = new int[amount];
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < amount; i++)
    {
        result[i] = result[i - 2] + result[i - 1];
    }
    return result;
}

void PrintIntArray(int[] array)
{
    foreach(int item in array) Console.Write($" {item} ");
    Console.WriteLine();
}

Console.WriteLine("Показать числа Фибоначчи");
IncorrectInput:
int amount = ReadIntFromConsole("Input amount of Fibo numbers: ");
if(amount<=0)
{
    Console.WriteLine("Amount should be more than 0!");
    goto IncorrectInput;
}
int[] fiboNumbers = FiboNumbers(amount);
PrintIntArray(fiboNumbers);