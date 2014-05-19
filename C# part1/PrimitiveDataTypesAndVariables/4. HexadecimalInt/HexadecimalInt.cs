using System;
class HexadecimalInt
{
    static void Main()
    {
        string hex = "FE";
        int a = Convert.ToInt32(hex, 16);
        Console.WriteLine(a);
    }
}

