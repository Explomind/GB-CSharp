// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void FillArrayRandomInt(int[] intArray, int min, int max)
{
    Random randomInt = new Random();
    for (int i = 0; i < intArray.Length; i++)
    {
        intArray[i] = randomInt.Next(min, max + 1);
        Console.Write($" {intArray[i]} ");
    }
    Console.WriteLine();
}

int SumOddPosElements(int[] intArray)
{
    int result = 0;
    for (int i = 1; i < intArray.Length; i += 2) result += intArray[i];
    return result;
}

int[] MultiPairsNumbers(int[] intArray)
{
    int resultLength = intArray.Length % 2 == 0 ? intArray.Length / 2 : intArray.Length / 2 + 1;
    int[] resultArray = new int[resultLength];
    for (int i = 0; i < resultLength; i++)
    {
        resultArray[i] = intArray[i] * intArray[intArray.Length - 1 - i];
    }
    return resultArray;
}

int MinMaxDelta(int[] intArray)
{
    int min = intArray[0];
    int max = intArray[0];
    for (int i = 1; i < intArray.Length; i++)
    {
        if (intArray[i] < min) min = intArray[i];
        if (intArray[i] > max) max = intArray[i];
    }
    return max - min;
}

Console.WriteLine("Найти сумму чисел одномерного массива стоящих на нечетной позиции");
int[] numbersArray = new int[11];
FillArrayRandomInt(numbersArray, -10, 10);
Console.WriteLine($"Sum of numbers in odd positions: {SumOddPosElements(numbersArray)}");

Console.WriteLine("Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.");
int[] multiArray = MultiPairsNumbers(numbersArray);
for(int i=0; i<multiArray.Length;i++) Console.Write($" {multiArray[i]} ");
Console.WriteLine();

Console.WriteLine("В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом");
Console.WriteLine($"Delta between max and min numbers: {MinMaxDelta(numbersArray)}");