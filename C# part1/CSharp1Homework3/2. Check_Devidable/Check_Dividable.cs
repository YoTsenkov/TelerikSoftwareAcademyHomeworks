using System;
class Check_Dividable
{
    static void Main()
    {
        int number = 105;
        Console.WriteLine(number % 35 == 0 && number > 34 ? "CAN be divided by 5 and 7 at the same time" : "CANNOT be divided by 5 and 7 at the same time");
    }
}

