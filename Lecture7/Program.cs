string NumbersRecIncr(int a, int b)
{
    if (a < b) return $"{a} " + NumbersRecIncr(a + 1, b);
    else return $"{b}";
}

string NumbersRecDecr(int a, int b)
{
    if (a < b) return NumbersRecDecr(a + 1, b) + $"{a} ";
    else return $"{b} ";
}

int SumRec(int n)
{
    if (n == 1) return 1;
    else return n + SumRec(n - 1);
}

int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

int PowerRec(int a, int n)
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else return (n % 2 == 0) ? PowerRecMath(a * a, n / 2) : PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(NumbersRecIncr(1, 10));
Console.WriteLine(NumbersRecDecr(1, 10));
Console.WriteLine($"Sum 1 to 10 = {SumRec(10)}");
Console.WriteLine($"10! = {FactorialRec(10)}");
Console.WriteLine($"2^10 = {PowerRec(2, 10)}");
Console.WriteLine($"2^10 = {PowerRecMath(2, 10)}");