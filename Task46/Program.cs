// 46. Написать программу масштабирования фигуры

int[] ReadIntArrayFromConsole(string msg)
{
RepeatInput:
    Console.WriteLine(msg);
    string? strNumbers = Console.ReadLine();
    var strNumbersArray = strNumbers.Split(new char[] { ' ', '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[strNumbersArray.Length];
    try
    {
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = Convert.ToInt32(strNumbersArray[i]);
        }
        return result;
    }
    catch (FormatException)
    {
        Console.WriteLine("Incorrect input!");
        goto RepeatInput;
    }
}

void PrintIntArray(int[] array)
{
    foreach (var item in array) Console.Write($" {item} ");
    Console.WriteLine();
}

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

int[] ScalingIntArray(int[] array, int scaleFactor)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i] * scaleFactor;
    }
    return result;
}

int[] intCoordinatesArray = ReadIntArrayFromConsole("Input coordinates of the figure points:");
PrintIntArray(intCoordinatesArray);
int scaleFactor = ReadIntFromConsole("Input scaling factor: ");
int[] intScaledCoordinates = ScalingIntArray(intCoordinatesArray, scaleFactor);
Console.WriteLine($"New coordinates with scale factor {scaleFactor}:");
PrintIntArray(intScaledCoordinates);