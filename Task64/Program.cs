// 64. Показать треугольник Паскаля
// *Сделать вывод в виде равнобедренного треугольника

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
            if (array[i, j] != 0) Console.Write($"{array[i, j]}\t");
            else Console.Write($" \t");
        }
        Console.WriteLine();
    }
}

int[,] CreatePascalTriangle(int qntRows)
{
    if (qntRows < 3) qntRows = 3;
    int qntColumns = qntRows * 2 + 1;
    int[,] result = new int[qntRows, qntColumns];
    result[0, qntColumns / 2] = 1;
    for (int i = 1; i < qntRows; i++)
    {
        for (int j = 1; j < qntColumns - 1; j++)
        {
            result[i, j] = result[i - 1, j - 1] + result[i - 1, j + 1];
        }
    }
    return result;
}

Console.WriteLine("Показать треугольник Паскаля в виде равнобедренного треугольника");
int qntRows = ReadIntFromConsole("Input amount of rows (minimum 3): ");
int[,] PascalTriangle = CreatePascalTriangle(qntRows);
Print2DIntArray(PascalTriangle);