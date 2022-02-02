// 42. Определить сколько чисел больше 0 введено с клавиатуры

int[] ReadIntArrayFromConsole(string msg)
{
RepeatInput:
    Console.WriteLine(msg);
    string? strResult = Console.ReadLine();
    string[] strTemp = strResult.Split(" ");
    int[] intResult = new int[strTemp.Length];
    try
    {
        for (int i = 0; i < intResult.Length; i++)
        {
            intResult[i] = Convert.ToInt32(strTemp[i]);
        }
        return intResult;
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
    for (int i = 0; i < intArray.Length; i++)
    {
        if (intArray[i] > 0) result++;
    }
    return result;
}

Console.WriteLine("Определить сколько чисел больше 0 введено с клавиатуры");
int[] numberArray = ReadIntArrayFromConsole("Input numbers separated by spaces:");
Console.WriteLine($"There are {PositiveIntAmount(numberArray)} numbers more than 0.");