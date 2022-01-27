// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool[] value1 = { false, true };
bool[] value2 = { false, true };
for (int i = 0; i < value1.Length; i++)
{
    for (int j = 0; j < value2.Length; j++)
    {
        Console.Write($" {!(value1[i]||value2[j])} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < value1.Length; i++)
{
    for (int j = 0; j < value2.Length; j++)
    {
        Console.Write($" {!value1[i]&&!value2[j]} ");
    }
    Console.WriteLine();
}