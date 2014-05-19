using System;
using System.Collections.Generic;
class DecToBin
{
    static void Convert(int decNumber)
    {
        List<int> binNumber = new List<int>();
        Console.Write("The binary representation of {0} is ", decNumber);
        while (decNumber != 0)
        {
            binNumber.Add(decNumber % 2);
            decNumber = decNumber / 2;
        }
        for (int i = binNumber.Count - 1; i >= 0; i--)
        {
            Console.Write(binNumber[i]);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Convert(16);
    }
}

