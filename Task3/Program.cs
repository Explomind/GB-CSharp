//3. По заданному номеру дня недели вывести его название
string[] weekdays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
Console.Write("Input number of day of week: ");
string? strNumber = Console.ReadLine();
try
{
    int number = Convert.ToInt32(strNumber);
    if(number > 0 && number <8) Console.WriteLine(weekdays[number-1]);
    else Console.WriteLine("There are 7 days of week.");
}
catch
{
    Console.WriteLine("Incorrect input!");
}