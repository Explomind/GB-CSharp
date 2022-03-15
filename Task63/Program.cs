// 63. Сформировать трехмерный массив не повторяющимися двузначными числами, 
// показать его построчно на экран выводя индексы соответствующего элемента

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

// string[] Int3dToStringArray(int[,,] array)
// {
//     string[] result = new string[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
//     int l = 0;
//     foreach (int item in array)
//     {
//         result[l] = Convert.ToString(item);
//         l++;
//     }
//     return result;
// }

// void PrintStringArray(string[] array)
// {
//     foreach (string item in array) Console.Write($"{item}\t");
//     Console.WriteLine();
// }

bool IsUnique(int[,,] array, int item, int iPos, int jPos, int kPos)
{
    bool result = true;

    return result;
}

int[,,] Create3dArrayRandomUniqueInt(int firstDim, int secondDim, int thirdDim, int min, int max)
{
    int[,,] result = new int[firstDim, secondDim, thirdDim];
    Random rnd = new Random();
    int tmp = 0;
    for (int i = 0; i < firstDim; i++)
    {
        for (int j = 0; j < secondDim; j++)
        {
            for (int k = 0; k < thirdDim; k++)
            {
                tmp = rnd.Next(min, max + 1);
                if (IsUnique(result, tmp, i, j, k)) result[i, j, k] = tmp;
            }
        }
    }
    return result;
}

void Print3dIntArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"({i}, {j}, {k}) {array[i, j, k]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int firstDim = ReadIntFromConsole("Input the first dimension: ");
int secondDim = ReadIntFromConsole("Input the second dimension: ");
int thirdDim = ReadIntFromConsole("Input the third dimension: ");
int[,,] int3dArray = Create3dArrayRandomUniqueInt(firstDim, secondDim, thirdDim, 0, 10);
Print3dIntArray(int3dArray);
Console.WriteLine();
// string[] strArray = Int3dToStringArray(int3dArray);
// PrintStringArray(strArray);