// 49. Показать двумерный массив размером m×n заполненный вещественными числами

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

double[,] Create2DArrayRandomDouble(int qntRows, int qntColumns, int min, int max)
{
    double[,] result = new double[qntRows, qntColumns];
    Random rnd = new Random();
    for (int i = 0; i < qntRows; i++)
    {
        for (int j = 0; j < qntColumns; j++)
        {
            result[i, j] = rnd.NextDouble()*(max-min)+min;
        }
    }
    return result;
}

void Print2DDoubleArray(double[,] array)
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

Console.WriteLine("Показать двумерный массив размером mxn заполненный вещественными числами");
int qntRows = ReadIntFromConsole("Input amount of rows: ");
int qntColumns = ReadIntFromConsole("Input amount of columns: ");
double[,] double2DArray = Create2DArrayRandomDouble(qntRows, qntColumns, -10, 10);
Print2DDoubleArray(double2DArray);