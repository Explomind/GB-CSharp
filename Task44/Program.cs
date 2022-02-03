// 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

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

(double, double) LinearEquation(double k1, double b1, double k2, double b2)
{
    double X = Math.Round((b2-b1)/(k1-k2), 2, MidpointRounding.AwayFromZero);
    double Y = Math.Round((k1*X + b1), 2, MidpointRounding.AwayFromZero);
    return (X,Y);
}

Console.WriteLine("Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы");
Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2");
double k1 = ReadDoubleFromConsole("Input coefficient k1: ");
double b1 = ReadDoubleFromConsole("Input coefficient b1: ");
double k2 = ReadDoubleFromConsole("Input coefficient k2: ");
double b2 = ReadDoubleFromConsole("Input coefficient b2: ");
(double X, double Y) = LinearEquation(k1, b1, k2, b2); 
Console.WriteLine($"Point of intersection of lines: X = {X}, Y = {Y}");