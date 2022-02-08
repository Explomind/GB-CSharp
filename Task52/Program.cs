// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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

void ChangeElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j % 2 == 0) array[i, j] *= array[i, j];
            }
        }
    }
}

Console.WriteLine("В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты");
// int qntRows = ReadIntFromConsole("Input amount of rows: ");
// int qntColumns = ReadIntFromConsole("Input amount of columns: ");
int[,] int2DArray = Create2DArrayRandomInt(3, 3, 0, 10);
Print2DIntArray(int2DArray);
ChangeElements(int2DArray);
Console.WriteLine("New array:");
Print2DIntArray(int2DArray);