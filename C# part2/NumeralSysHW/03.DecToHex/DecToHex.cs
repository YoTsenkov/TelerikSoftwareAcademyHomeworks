using System;
using System.Collections.Generic;
class DecToHex
{
    static void Convert(int dec)
    {
        int decLength = dec.ToString().Length;
        List<int> hex = new List<int>();
        while (dec != 0)
        {
            hex.Add(dec % 16);
            dec = dec / 16;
        }
        for (int i = hex.Count - 1; i >= 0; i--)
        {
            if (hex[i] == 10)
            {
                Console.Write("A");
            }
            else if (hex[i] == 11)
            {
                Console.Write("B");
            }
            else if (hex[i] == 12)
            {
                Console.Write("C");
            }
            else if (hex[i] == 13)
            {
                Console.Write("D");
            }
            else if (hex[i] == 14)
            {
                Console.Write("E");
            }
            else if (hex[i] == 15)
            {
                Console.Write("F");
            }
            else
            {
                Console.Write(hex[i]);
            }
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Convert(1234);
    }
}

