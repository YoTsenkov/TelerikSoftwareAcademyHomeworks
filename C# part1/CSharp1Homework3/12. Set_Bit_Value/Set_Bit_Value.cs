using System;
class Set_Bit_Value
{
    static void Main()
    {
        int n = 5;
        int v = 0;
        int p = 0;
        Console.WriteLine(Convert.ToString(n, 2));
        int mask1 = 1 << p;
        int mask2 = ~(1 << p);
        int mask = v == 0 ? mask2 : mask1;
        int result1 = n & mask;
        int result2 = n | mask;
        int result = v == 0 ? result1 : result2;
        Console.WriteLine(Convert.ToString(result, 2));
    }
}

