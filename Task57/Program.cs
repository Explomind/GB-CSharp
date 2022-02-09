// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

void DescendingSort(int[,] array, int rowNumber)
{
    int tmp;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 1; j < array.GetLength(1) - i; j++)
        {
            if (array[rowNumber, j - 1] < array[rowNumber, j])
            {
                tmp = array[rowNumber, j];
                array[rowNumber, j] = array[rowNumber, j - 1];
                array[rowNumber, j - 1] = tmp;
            }
        }
    }
}

Console.WriteLine("Написать программу упорядочивания по убыванию элементов каждой строки двумерного массива.");
int[,] int2DArray = Create2DArrayRandomInt(3, 5, 0, 100);
Print2DIntArray(int2DArray);
for(int i=0; i< int2DArray.GetLength(0);i++)
{
    DescendingSort(int2DArray, i);
}
Console.WriteLine();
Print2DIntArray(int2DArray);
