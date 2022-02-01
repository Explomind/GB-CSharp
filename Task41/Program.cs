// 41. Выяснить являются ли три числа сторонами треугольника

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

bool SumIsMore(int number1, int number2, int number3)
{
    if (number1 + number2 > number3) return true;
    return false;
}

bool IsTriangle(int[] intArray)
{
    if((intArray[0]+intArray[1]>intArray[2])&&
    (intArray[1]+intArray[2]>intArray[0])&&
    (intArray[0]+intArray[2]>intArray[1])) return true;
    return false;
}

Console.WriteLine("Выяснить являются ли три числа сторонами треугольника");
// First variant
int AB = ReadIntFromConsole("Input first number: ");
int BC = ReadIntFromConsole("Input second number: ");
int AC = ReadIntFromConsole("Input third number: ");
if (SumIsMore(AB, BC, AC) && SumIsMore(BC, AC, AB) && SumIsMore(AC, AB, BC))
    Console.WriteLine($"Numbers {AB}, {BC} and {AC} are sides of a triangle.");
else Console.WriteLine($"Numbers {AB}, {BC} and {AC} are not sides of a triangle.");
// Second variant
int[] sides = new int[3];
for(int i=0;i<3;i++) sides[i]=ReadIntFromConsole($"Input side {i+1}: ");
if(IsTriangle(sides))Console.WriteLine("These numbers are sides of a triangle.");
else Console.WriteLine("These numbers are not sides of a triangle.");