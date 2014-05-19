using System;
class Bool_Bit_Value
{
    static void Main()
    {
        int v = 5;
        int p = 1;
        int mask = 1 << p;
        int newNumber = mask & v;
        int bit = newNumber >> p;
        Console.WriteLine(bit == 1 ? "true" : "false");
    }
}

