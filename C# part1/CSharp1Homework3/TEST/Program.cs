using System;
class Program
{
    static void Main()
    {
        int a = 154;
        string b = Convert.ToString(a, 2).PadLeft(32, '0');
        Console.WriteLine();
    }
}

