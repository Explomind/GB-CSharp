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

bool IsUnique(int[,,] array, int item, int iPos, int jPos, int kPos)
{
    bool result = true;
    for (int i = iPos; i >= 0; i--)
    {
        for (int j = jPos; j >= 0; j--)
        {
            for (int k = kPos; k >= 0; k--)
            {
                if (item == array[i, j, k])
                {
                    result = false;
                    break;
                }
            }
        }
    }
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
                if (IsUnique(result, tmp, i, secondDim - 1, thirdDim - 1)) result[i, j, k] = tmp;
                else k--;
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
int randRange = firstDim * secondDim * thirdDim;
int[,,] int3dArray = Create3dArrayRandomUniqueInt(firstDim, secondDim, thirdDim, -randRange, randRange);
Print3dIntArray(int3dArray);
