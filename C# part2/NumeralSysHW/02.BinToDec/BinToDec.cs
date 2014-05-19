using System;
using System.Collections.Generic;
class BinToDec
{
    static void Convert(int binNum)
    {      
        int dec = (binNum % 10);     
        int binNumLength = binNum.ToString().Length;

        for (int i = 1; i < binNumLength; i++)
        {
            dec += (((binNum / (int)Math.Pow(10, i)) % 10) * (int)Math.Pow(2, i));
        }
        Console.WriteLine(dec);
    }
    static void Main()
    {
        Convert(10000);
    }
}

