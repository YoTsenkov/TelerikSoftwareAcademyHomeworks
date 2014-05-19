using System;

class PrintAscii
{
    static void Main()
    {
        int a;
        for (a = 0; a < 256; a++)
        {
            Console.WriteLine("{0} -> {1}", a, Convert.ToChar(a));
        }
    }
}

