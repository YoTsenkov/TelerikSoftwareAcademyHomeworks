using System;
class Extract_Bit_Value
{
    static void Main()
    {
        int i = 5;
        int pos = 2;
        int mask = 1 << pos;
        int newNumber = mask & i;
        int bit = newNumber >> pos;
        Console.WriteLine(bit);
    }
}

