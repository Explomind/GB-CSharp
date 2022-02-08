// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

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

int[,] CreateIntArray(int qntRows, int qntColumns)
{
    int[,] result = new int[qntRows, qntColumns];
    for (int i = 0; i < qntRows; i++)
    {
        for (int j = 0; j < qntColumns; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

Console.WriteLine("Задать двумерный массив следующим правилом: Aₘₙ = m+n");
int qntRows = ReadIntFromConsole("Input amount of rows: ");
int qntColumns = ReadIntFromConsole("Input amount of columns: ");
int[,] intArray2D = CreateIntArray(qntRows, qntColumns);
Print2DIntArray(intArray2D);