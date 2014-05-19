using System;
class Program
{
    static void Main()
    {
        string hex = "123abf";
        int dec = Convert.ToInt32(hex, 16);
        Console.WriteLine(dec);
    }
}

