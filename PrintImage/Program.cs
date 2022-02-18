int[,] star = new int[,]
{
    {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0},
    {1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0},
    {0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0},
    {0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0},
    {1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1},
    //{1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1}
};

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write(" ");
            else Console.Write("+");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (star[row, col] == 0)
    {
        star[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

PrintImage(star);
FillImage(4, 4);
//Console.WriteLine();
PrintImage(star);