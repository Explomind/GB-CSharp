// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

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

void EvenOddAmount(int[] intArray)
{
    int evenAmount = 0;
    int oddAmount = 0;
    for(int i=0;i<intArray.Length;i++)
    {
        if(intArray[i]%2==0) evenAmount++;
        else oddAmount++;
    }
    Console.WriteLine($"Amount of even elements of the array: {evenAmount}");
    Console.WriteLine($"Amount of odd elements of the array: {oddAmount}");
}

Console.WriteLine("Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных/четных чисел");
int[] numbersArray = new int[25];
FillPrintArrayRandomInt(numbersArray, 100, 999);
EvenOddAmount(numbersArray);