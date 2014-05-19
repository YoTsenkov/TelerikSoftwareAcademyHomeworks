using System;
using System.Collections.Generic;
class Combinations
{
    static int[] array = new int[100];
    static int[] used = new int[100];
    static int size = int.Parse(Console.ReadLine());
    static int length = int.Parse(Console.ReadLine());
    static void Print()
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    static void Comb(int i)
    {
        if (i >= length)
        {
            Print();
            return;
        }

        int previous = 0;
        if (i > 0)
        {
            previous = array[i - 1];
        }

        if (previous == size)
        {
            return;
        }
        for (int a = previous; a < size; a++)
        {
            array[i] = a + 1;
            Comb(i + 1);
        }
    }
    static void Main()
    {
        Comb(0);
    }
}

