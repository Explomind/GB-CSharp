// 26. Возведите число А в натуральную степень B используя цикл

// Read string from console and convert it to double
double ReadDoubleFromConsole(string msg)
{
RepeatInput:
    Console.Write(msg);
    string? strResult = Console.ReadLine();
    try
    {
        double result = Convert.ToDouble(strResult);
        return result;
    }
    catch (FormatException)
    {
        Console.WriteLine("Incorrect input!");
        goto RepeatInput;
    }
}

// Возведение числа А в степень В

double Power(double degreeBase, double degreePower)
{
    double result=1;
    for(int i=0;i<degreePower;i++)
    {
        result = result*degreeBase;
    }
    return result;
}

Console.WriteLine("Возведите число А в натуральную степень B используя цикл");
double degreeBase = ReadDoubleFromConsole("Input base of degree: ");
double degreePower = ReadDoubleFromConsole("Input exponent: ");
Console.WriteLine($"{degreeBase}^{degreePower} = {Power(degreeBase, degreePower)}");