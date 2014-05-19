using System;
class Program
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        DateTime b = new DateTime(year, month, day);
        DateTime result = b.AddDays(1);
        Console.WriteLine("{0}.{1}.{2}", result.Day, result.Month, result.Year);
    }
}

