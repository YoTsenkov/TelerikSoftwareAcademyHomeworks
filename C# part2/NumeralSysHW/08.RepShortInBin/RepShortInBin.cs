using System;
using System.Collections.Generic;
class RepShortInBin
{
    static void Convert(ushort number)
    {
        List<int> binNumber = new List<int>();
        List<int> represent = new List<int>();
        Console.Write("The binary representation of {0} is ", number);
        while (number != 0)
        {
            binNumber.Add(number % 2);
            number = (ushort)(number / 2);
        }

        for (int i = 0; i < 16 - binNumber.Count; i++)
        {
            represent.Add(0);
        }
        represent.AddRange(binNumber);
        for (int i = 0; i < represent.Count; i++)
        {
            Console.Write(represent[i]);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("Enter the 16-bit signed integer number (the C# type short) you want to see the binary representation of.");
        ushort number = ushort.Parse(Console.ReadLine());
        Convert(number);
    }
}

