using System;
class CheckIfLeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter an year.");
        int year = int.Parse(Console.ReadLine());
        bool leap = DateTime.IsLeapYear(year);
        Console.WriteLine("Is the year leap? -> " + leap);        
    }
}

