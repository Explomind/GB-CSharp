// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Input day of the week number: ");
string? strDayNumber = Console.ReadLine();
try
{
    int dayNumber = Convert.ToInt32(strDayNumber);
    if(dayNumber > 0 && dayNumber < 6) Console.WriteLine("This is weekday. Work hard!");
    else
    {
        if(dayNumber > 5 && dayNumber < 8) Console.WriteLine("This is weekend. Keep calm and enjoy!");
        else Console.WriteLine($"There is no day of the week with number {dayNumber}, dumbass!");
    }    
}
catch
{
    Console.WriteLine("Incorrect input!");
}