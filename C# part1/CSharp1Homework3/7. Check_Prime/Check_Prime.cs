using System;
class Check_Prime
{
    static void Main()
    {
        uint n = 3;
        string result = (n == 2 || n == 3 || n == 5 || n == 7 && (n / 2) * 2 != n && (n / 3) * 3 != n && (n / 5) * 5 != n && (n / 7) * 7 != n ? "PRIME" : "NOT PRIME");
        Console.WriteLine(result);
    }
}

