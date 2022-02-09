// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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
    Console.Write($"\t");
    for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{j}\t");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{i}\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

(int[,], int) SeekNumberInArray(int[,] array, int number)
{
    int[,] tmp = new int[array.GetLength(0) * array.GetLength(1), 2];
    int k = 0;
    int qnt = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                tmp[k, 0] = i;
                tmp[k, 1] = j;
                qnt++;
            }
            else
            {
                tmp[k, 0] = -1;
            }
            k++;
        }
    }
    int[,] result = new int[qnt, 2];
    k = 0;
    for (int i = 0; i < tmp.GetLength(0); i++)
    {
        if (tmp[i, 0] != -1)
        {
            result[k, 0] = tmp[i, 0];
            result[k, 1] = tmp[i, 1];
            k++;
        }
    }
    return (result, qnt);
}

Console.WriteLine("В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет");
int qntRows = ReadIntFromConsole("Input amount of rows: ");
int qntColumns = ReadIntFromConsole("Input amount of columns: ");
int[,] int2DArray = Create2DArrayRandomInt(qntRows, qntColumns, 0, 100);
Print2DIntArray(int2DArray);
int number = ReadIntFromConsole("Input desired number: ");
(int[,] coordinates, int amount) = SeekNumberInArray(int2DArray, number);
Console.WriteLine($"Number {number} appears in the array {amount} times.");
if (amount > 0)
{
    Console.WriteLine("Coordinates:");
    for (int i = 0; i < amount; i++)
    {
        Console.WriteLine($"({coordinates[i, 0]} , {coordinates[i, 1]})");
    }
}