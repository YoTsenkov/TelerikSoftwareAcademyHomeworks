﻿//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2004 
//Distance: 4 days - wrong answer 

using System;
using System.Globalization;

class NumberOfDaysBetwenDates
{
    static void Main()
    {
        string start = "27.02.2006";  // i love time travel :)
        string end = "3.03.2004";     // Back to the Future :D

        DateTime startDate = DateTime.ParseExact(start, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(end, "d.MM.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine((endDate - startDate).TotalDays);
    }
}

