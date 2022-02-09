// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

double[] MeansColumns(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result[j] += array[i, j];
        }
        result[j] =Math.Round(result[j] / array.GetLength(0), 2, MidpointRounding.AwayFromZero);
    }
    return result;
}

Console.WriteLine("Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.");
int qntRows = ReadIntFromConsole("Input amount of rows: ");
int qntColumns = ReadIntFromConsole("Input amount of columns: ");
int[,] int2DArray = Create2DArrayRandomInt(qntRows, qntColumns, 0, 10);
Print2DIntArray(int2DArray);
double[] columnsMeans= MeansColumns(int2DArray);
Console.WriteLine("Means of elements in columns:");
for(int i=0; i< columnsMeans.Length; i++)
{
    Console.Write($"{columnsMeans[i]}\t");
}
Console.WriteLine();