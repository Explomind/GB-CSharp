// 66. Показать натуральные числа от 1 до N, N задано
// 67. Показать натуральные числа от N до 1, N задано
// 68. Показать натуральные числа от M до N, N и M заданы
// 69. Найти сумму элементов от M до N, N и M заданы

string NumbersRange1NRec(int N)
{
    return N < 1 ? String.Empty : NumbersRange1NRec(N - 1) + $"{N} ";
}

string NumbersRangeN1Rec(int N)
{
    return N < 1 ? String.Empty : $"{N} " + NumbersRangeN1Rec(N - 1);
}

string NumbersRangeMNRec(int M, int N)
{
    return M > N ? String.Empty : $"{M} " + NumbersRangeMNRec(M + 1, N);
}

int SumRangeMNRec(int M, int N)
{
    return M > N ? 0 : M + SumRangeMNRec(M + 1, N);
}

Console.WriteLine("Показать натуральные числа от 1 до N, N задано");
Console.WriteLine(NumbersRange1NRec(10));
Console.WriteLine("Показать натуральные числа от N до 1, N задано");
Console.WriteLine(NumbersRangeN1Rec(10));
Console.WriteLine("Показать натуральные числа от M до N, N и M заданы");
Console.WriteLine(NumbersRangeMNRec(10, 20));
Console.WriteLine("Найти сумму элементов от M до N, N и M заданы");
Console.WriteLine(SumRangeMNRec(3, 7));