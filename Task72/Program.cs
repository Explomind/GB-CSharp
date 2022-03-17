// 72. Написать программу возведения числа А в целую степень B

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

int Power(int powerBase, int exponent)
{
    return exponent == 0 ? 1 : powerBase * Power(powerBase, exponent - 1);
}

Console.WriteLine("Написать программу возведения числа А в целую степень B");
int powerBase = ReadIntFromConsole("Input the base of power: ");
int exponent = ReadIntFromConsole("Input exponent: ");
Console.WriteLine($"{powerBase}^{exponent} = {Power(powerBase, exponent)}");