using System;
class CalcWorkingDays
{
    static int total = 0;
    static string[] holidays = new string[] { "25.1.2014", "3.2.2014", "13.3.2014" };
    static int GetRegularWorkingDays(DateTime startDate, DateTime endDate)
    {
        
        if (startDate < endDate)
        {
            var days = endDate - startDate;

            for (; startDate < endDate; startDate = startDate.AddDays(1))
            {
                switch (startDate.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                    case DayOfWeek.Sunday:
                        break;
                    default:
                        total++;
                        break;
                }
            }
        }
        DateTime holiday;
        for (int i = 0; i < holidays.Length; i++)
        {
            holiday = DateTime.Parse(holidays[i]);
            switch (holiday.DayOfWeek)
            {
                case DayOfWeek.Friday:                    
                case DayOfWeek.Monday:                                    
                case DayOfWeek.Thursday:                  
                case DayOfWeek.Tuesday:                   
                case DayOfWeek.Wednesday:
                    total--;
                    break;
                default:
                    break;
            }
        }
        return total;
    }
    static void Main()
    {
        Console.WriteLine("The starting date is today so enter the date at the end of the period you want to check the working days for.");
        Console.WriteLine("Example : dd.mm.yyyy");
        DateTime end = DateTime.Parse(Console.ReadLine());
        GetRegularWorkingDays(DateTime.Now, end);
        Console.WriteLine("The working days between {0} and {1} EXCLUSIVELY are {2}.", DateTime.Now, end, total);
    }
}

