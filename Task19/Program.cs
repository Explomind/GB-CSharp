// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int ReadIntFromConsole(string msg)
{
    Console.Write(msg);
    string? strNumber = Console.ReadLine();
    try
    {
        int number = Convert.ToInt32(strNumber);
        return number;
    }
    catch (FormatException)
    {
        return 0;
    }
}

Console.WriteLine("Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0");
ReapeatInput1:
int coordX = ReadIntFromConsole("Input X coordinate (except 0): ");
if (coordX == 0)
{
    Console.WriteLine("Incorrect input!");
    goto ReapeatInput1;
}
RepeatInput2:
int coordY = ReadIntFromConsole("Input Y coordinate (except 0): ");
if (coordY == 0)
{
    Console.WriteLine("Incorrect input!");
    goto RepeatInput2;
}
if ((coordX > 0) && (coordY > 0)) Console.WriteLine("The point is in the first quarter.");
else
{
    if ((coordX < 0) && (coordY > 0)) Console.WriteLine("The point is in the second quarter.");
    else
    {
        if ((coordX < 0) && (coordY < 0)) Console.WriteLine("The point is in the third quarter.");
        else Console.WriteLine("The point is in the forth quarter.");
    }
}