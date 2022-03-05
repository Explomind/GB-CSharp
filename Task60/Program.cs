// 60. Составить частотный словарь элементов двумерного массива

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

int[,] Create2DArrayRandomInt(int qntRows, int qntColumns, int min, int max)
{
    int[,] result = new int[qntRows, qntColumns];
    Random rnd = new Random();
    for (int i = 0; i < qntRows; i++)
    {
        for (int j = 0; j < qntColumns; j++)
        {
            result[i, j] = rnd.Next(min, max + 1);
        }
    }
    return result;
}

void Print2DIntArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}\t");
    Console.WriteLine();
}

string[] Int2DArrayToStringArray(int[,] array)
{
    int amount = array.GetLength(0) * array.GetLength(1);
    string[] result = new string[amount];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[k] = Convert.ToString(array[i, j]);
            k++;
        }
    }
    return result;
}

string[] ArrayUniqueElements(string[] array)
{
    string[] result = new string[array.Length];
    result[0] = array[0];
    int k = 0;
    for (int i = 1; i < array.Length; i++)
    {
        bool isUnique = true;
        for (int j = k; j >= 0; j--)
        {
            if (array[i] == result[j])
            {
                isUnique = false;
                break;
            }
        }
        if (isUnique)
        {
            k++;
            result[k] = array[i];
        }
    }
    return result;
}

int Amount(string item, string[] array)
{
    int result = 0;
    foreach (string element in array)
    {
        if (element == item) result++;
    }
    return result;
}

Console.WriteLine("Составить частотный словарь элементов двумерного массива");
int qntRows = ReadIntFromConsole("Input amount of rows: ");
int qntColumns = ReadIntFromConsole("Input amount of columns: ");
int[,] int2DArray = Create2DArrayRandomInt(qntRows, qntColumns, 0, 10);
Print2DIntArray(int2DArray);
Console.WriteLine();
string[] tempStringArray = Int2DArrayToStringArray(int2DArray);
// PrintStringArray(tempStringArray);
// Console.WriteLine();
string[] strArrayUniqueElements = ArrayUniqueElements(tempStringArray);
// PrintStringArray(strArrayUniqueElements);
int i = 0;
while (!String.IsNullOrEmpty(strArrayUniqueElements[i]))
{
    double amount = Amount(strArrayUniqueElements[i], tempStringArray);
    double fullAmount = tempStringArray.Length;
    double frequency = amount * 100 / fullAmount;
    frequency = Math.Round(frequency, 1, MidpointRounding.ToEven);
    Console.WriteLine($"Element {strArrayUniqueElements[i]} occurs {amount} times. Frequency: {frequency}%.");
    i++;
}

