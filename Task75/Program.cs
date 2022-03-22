// 75. Есть два массива info и data. 

// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей. 

// Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.

// Составить массив десятичных представлений чисел массива data с учётом информации из массива info. 

// Пример:
// ```
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }

// выходные данные:
// 1, 7, 0, 1
// ```

double ByteToDecimal(byte[] data, int start, int end)
{
    double result = 0;
    double power = 0;
    // Console.WriteLine($"start = {start} ");
    // Console.WriteLine($"end = {end} ");
    for (int i = end - 1; i >= start; i--)
    {
        result = result + data[i] * Math.Pow(2, power);
        power++;
    }
    return result;
}

void PrintDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}


byte[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = {2, 3, 3, 1 };
double[] decimalArray = new double[info.Length];
int start = 0;
for (int i = 0; i < info.Length; i++)
{
    decimalArray[i] = ByteToDecimal(data, start, start + info[i]);
    start += info[i];
}
PrintDoubleArray(decimalArray);