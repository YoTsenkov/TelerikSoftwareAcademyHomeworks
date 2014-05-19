using System;
class Program
{
    static void Main()
    {
        int bin = 101010101;
        string hex = Convert.ToString(bin, 16);
        Console.WriteLine(hex);
    }
}

