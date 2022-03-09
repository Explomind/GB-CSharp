// 61. Найти произведение двух матриц

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

int[,] MatrixScalarMulti(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
}

Console.WriteLine("Найти произведение двух матриц");
IncorrectInput:
Console.WriteLine("Number of rows of the first matrix should be equal to number of columns of the second one.");
int qntRows1 = ReadIntFromConsole("First matrix. Input amount of rows: ");
int qntColumns1 = ReadIntFromConsole("First matrix. Input amount of columns: ");
int qntRows2 = ReadIntFromConsole("Second matrix. Input amount of rows: ");
int qntColumns2 = ReadIntFromConsole("Second matrix. Input amount of columns: ");
if (qntColumns1 == qntRows2)
{
    int[,] int2DArray1 = Create2DArrayRandomInt(qntRows1, qntColumns1, 0, 10);
    Print2DIntArray(int2DArray1);
    Console.WriteLine();
    int[,] int2DArray2 = Create2DArrayRandomInt(qntRows2, qntColumns2, 0, 10);
    Print2DIntArray(int2DArray2);
    Console.WriteLine();
    int[,] int2dArrayMulti = MatrixScalarMulti(int2DArray1, int2DArray2);
    Print2DIntArray(int2dArrayMulti);
}
else
{
    Console.WriteLine("Incorrect input!");
    goto IncorrectInput;
}