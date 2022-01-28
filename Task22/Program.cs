// 22. Найти расстояние между точками в пространстве 2D/3D

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

// Calculate distance between 2 points with (x, y, z) coordinates
double Distance(double[,] points)
{
    double result = Math.Round(Math.Sqrt(Math.Pow((points[0, 0] - points[1, 0]), 2)
                    + Math.Pow((points[0, 1] - points[1, 1]), 2)
                    + Math.Pow((points[0, 2] - points[1, 2]), 2)), 2, MidpointRounding.ToEven);
    return result;
}

Console.WriteLine("Найти расстояние между точками в пространстве 2D/3D");
string[] strXYZ = {"X", "Y", "Z"};
string[] strPoints = {"first", "second"};
double[,] pointsArray = new double[2, 3];
for (int points = 0; points < pointsArray.GetLength(0); points++)
{
    for (int coordinates = 0; coordinates < pointsArray.GetLength(1); coordinates++)
    {
        pointsArray[points, coordinates] = ReadDoubleFromConsole($"Input coordinate {strXYZ[coordinates]} for the {strPoints[points]} point: ");
    }
}
for (int points = 0; points < pointsArray.GetLength(0); points++)
{
    Console.Write($"The {strPoints[points]} point: (");
    for (int coordinates = 0; coordinates < pointsArray.GetLength(1); coordinates++)
    {
        Console.Write($" {pointsArray[points, coordinates]} ");
    }
    Console.WriteLine(")");
}
Console.WriteLine($"Distance between two points is {Distance(pointsArray)}");