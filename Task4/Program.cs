// 4. Найти максимальное из трех чисел

int[] numArray = {5, 8, 15};
int max = numArray[0];
for(int i = 0; i < numArray.Length; i++)
{
    Console.Write($"{numArray[i]} ");
    if(numArray[i] > max) max = numArray[i];
}
Console.WriteLine();
Console.WriteLine($"Maximum value is {max}");