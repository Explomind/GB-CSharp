// 42. Определить сколько чисел больше 0 введено с клавиатуры

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

int PositiveIntAmount(int[] intArray)
{
    int result = 0;
    for (int i=0;i<intArray.Length;i++)
    {
        if (intArray[i] > 0) result++;
    }
    return result;
}

Console.WriteLine("Определить сколько чисел больше 0 введено с клавиатуры");
int arrayLength = 10;
int[] numberArray = new int[arrayLength];
for (int i = 0; i < numberArray.Length; i++)
{
    numberArray[i] = ReadIntFromConsole($"Input {i + 1} number: ");
}
Console.WriteLine($"There are {PositiveIntAmount(numberArray)} numbers more than 0.");