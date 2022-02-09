// 47. Написать программу копирования массива

int[] CreateArrayRandomInt(int arraySize, int min, int max)
{
    int[] result = new int[arraySize];
    Random rnd = new Random();
    for (int i = 0; i < arraySize; i++)
    {
        result[i] = rnd.Next(min, max + 1);
    }
    return result;
}

void PrintIntArray(int[] array)
{
    foreach (var item in array) Console.Write($" {item} ");
    Console.WriteLine();
}

int[] CopyIntArray(int[] arrayToCopy)
{
    int[] result = new int[arrayToCopy.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = arrayToCopy[i];
    }
    return result;
}

Console.WriteLine("Написать программу копирования массива");
int[] array = CreateArrayRandomInt(10, 0, 100);
Console.WriteLine("New random array:");
PrintIntArray(array);
int[] newArray = CopyIntArray(array);
Console.WriteLine("Copy of the array:");
PrintIntArray(newArray);