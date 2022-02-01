// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива
// 34. Написать программу замену элементов массива на противоположные
// 35. Определить, присутствует ли в заданном массиве, некоторое число

void FillPrintArrayRandomInt(int[] intArray, int min, int max)
{
    Random randomInt = new Random();
    for (int i = 0; i < intArray.Length; i++)
    {
        intArray[i] = randomInt.Next(min, max + 1);
        Console.Write($" {intArray[i]} ");
    }
    Console.WriteLine();
}

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

void SumPositNegat(int[] intArray)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < intArray.Length; i++)
    {
        if (intArray[i] > 0) sumPositive += intArray[i];
        else sumNegative += intArray[i];
    }
    Console.WriteLine($"Sum of positive elements: {sumPositive}");
    Console.WriteLine($"Sum of negative elements: {sumNegative}");
}

int SeekPosIntNumber(int[] intArray, int number)
{
    for (int i = 0; i < intArray.Length; i++)
    {
        if (intArray[i] == number) return i;
    }
    return -1;
}

Console.WriteLine("Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива");
int[] numbersArray = new int[12];
FillPrintArrayRandomInt(numbersArray, -9, 9);
SumPositNegat(numbersArray);

Console.WriteLine("Написать программу замену элементов массива на противоположные");
for (int i = 0; i < numbersArray.Length; i++)
{
    numbersArray[i] *= -1;
    Console.Write($" {numbersArray[i]} ");
}
Console.WriteLine();

Console.WriteLine("Определить, присутствует ли в заданном массиве, некоторое число");
int number = ReadIntFromConsole("Input number: ");
if (SeekPosIntNumber(numbersArray, number) == -1) Console.WriteLine($"Number {number} is not present in the array.");
else Console.WriteLine($"Number {number} is element {SeekPosIntNumber(numbersArray, number)} of the array.");
