// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArrayRandomInt(int[] intArray, int min, int max)
{
    Random randomInt = new Random();
    for (int i = 0; i < intArray.Length; i++)
    {
        intArray[i] = randomInt.Next(min, max + 1);
        // Console.Write($" {intArray[i]} ");
    }
    // Console.WriteLine();
}

int NumbersAmountInRange(int[] intArray, int start, int end)
{
    int amount = 0;
    for (int i = 0; i < intArray.Length; i++)
    {
        if (intArray[i] >= start && intArray[i] <= end) amount++;
    }
    return amount;
}

Console.WriteLine("В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]");
int[] numbersArray = new int[123];
FillArrayRandomInt(numbersArray, 0, 1000);
Console.WriteLine($"Amount of numbers in range [10, 99]: {NumbersAmountInRange(numbersArray, 10, 99)}");