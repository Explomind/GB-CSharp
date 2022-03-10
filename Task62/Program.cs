// 62. В двумерном массиве целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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

(int, int) SeekMin(int[,] array)
{
    int resultRowIndex = 0;
    int resultColumnIndex = 0;
    int minimum = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minimum)
            {
                minimum = array[i, j];
                resultRowIndex = i;
                resultColumnIndex = j;
            }
        }
    }
    return (resultRowIndex, resultColumnIndex);
}

int[,] DelRowColumnMinElement(int[,] array, int rowIndex, int columnIndex)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != rowIndex)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != columnIndex)
                {
                    result[k, l] = array[i, j];
                    l++;
                }
            }
            l = 0;
            k++;
        }
    }
    return result;
}

Console.WriteLine("В двумерном массиве целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.");
int qntRows = ReadIntFromConsole("Input amount of rows: ");
int qntColumns = ReadIntFromConsole("Input amount of columns: ");
int[,] int2DArray = Create2DArrayRandomInt(qntRows, qntColumns, 0, 100);
Print2DIntArray(int2DArray);
Console.WriteLine();
(int rowIndex, int columnIndex) = SeekMin(int2DArray);
Console.WriteLine($"Minimum element is on the {rowIndex + 1} row and {columnIndex + 1} column.");
int[,] newInt2dArray = DelRowColumnMinElement(int2DArray, rowIndex, columnIndex);
Print2DIntArray(newInt2dArray);