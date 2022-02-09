// 54. В матрице чисел найти сумму элементов главной диагонали

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

int SumMainDiag(int[,] array)
{
    int qnt = array.GetLength(0);
    if (array.GetLength(0) > array.GetLength(1)) qnt = array.GetLength(1);
    int result = 0;
    for (int i = 0; i < qnt; i++) result += array[i, i];
    return result;
}

Console.WriteLine("В матрице чисел найти сумму элементов главной диагонали");
int qntRows = ReadIntFromConsole("Input amount of rows: ");
int qntColumns = ReadIntFromConsole("Input amount of columns: ");
int[,] int2DArray = Create2DArrayRandomInt(qntRows, qntColumns, 0, 10);
Print2DIntArray(int2DArray);
Console.WriteLine($"Sum of elements on main diagonal: {SumMainDiag(int2DArray)}");