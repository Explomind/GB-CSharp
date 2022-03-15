// 56. Написать программу, которая обменивает элементы первой строки и последней строки

// int ReadIntFromConsole(string msg)
// {
// RepeatInput:
//     Console.Write(msg);
//     string? strResult = Console.ReadLine();
//     try
//     {
//         int result = Convert.ToInt32(strResult);
//         return result;
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Incorrect input!");
//         goto RepeatInput;
//     }
// }

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

void ChangeFirstLastRows(int[,] array)
{
    int tmp;
    int lastRow = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        tmp = array[0, i];
        array[0, i] = array[lastRow, i];
        array[lastRow, i] = tmp;
    }
}

Console.WriteLine("Написать программу, которая обменивает элементы первой строки и последней строки");
// int qntRows = ReadIntFromConsole("Input amount of rows: ");
// int qntColumns = ReadIntFromConsole("Input amount of columns: ");
int[,] int2DArray = Create2DArrayRandomInt(5, 5, 0, 100);
Print2DIntArray(int2DArray);
ChangeFirstLastRows(int2DArray);
Console.WriteLine("New array:");
Print2DIntArray(int2DArray);