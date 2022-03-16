// 65. Спирально заполнить двумерный массив:
// ```
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 
// ```

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

int[,] CreateSpiralIntArray(int qnt)
{
    int[,] result = new int[qnt, qnt];
    int amount = qnt * qnt;
    int i = 0;
    int j = 0;
    int count = 0;
    result[i, j] = 1;
    while (result[i, j] < amount)
    {
        while (j < qnt - 1 - count)
        {
            j++;
            result[i, j] = result[i, j - 1] + 1;           
        }
        while (i < qnt - 1 - count)
        {
            i++;
            result[i, j] = result[i - 1, j] + 1;
        }
        while (j > count)
        {
            j--;
            result[i, j] = result[i, j + 1] + 1;
        }
        while (i > count + 1)
        {
            i--;
            result[i, j] = result[i + 1, j] + 1;
        }
        count++;
    }
    return result;
}

Console.WriteLine("Спирально заполнить двумерный массив");
int qntRows = 0;
while (qntRows < 1)
{
    qntRows = ReadIntFromConsole("Input amount of rows (should be more than 0): ");
}
int[,] spiralArray = CreateSpiralIntArray(qntRows);
Print2DIntArray(spiralArray);