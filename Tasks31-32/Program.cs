// 31. Задать массив из 8 элементов и вывести их на экран 
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void FillPrintArrayRandomInt(int[] intArray, int min, int max)
{
    Random randomInt = new Random();
    for (int i = 0; i < intArray.Length; i++)
    {
        intArray[i] = randomInt.Next(min, max+1);
        Console.Write($" {intArray[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Задать массив из 8 элементов и вывести их на экран");
int[] numbers = new int[8];
FillPrintArrayRandomInt(numbers, 1, 100);
Console.WriteLine("Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран");
FillPrintArrayRandomInt(numbers, 0, 1);