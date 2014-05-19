using System;
using System.Collections.Generic;
class PrintVariations
{
    static int[] array = new int[100];
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

    static void Variations(int i)
    {   
        if (i >= length)
        {
            Print();
            return;
        }
        for (int a = 0; a < size; a++)
        {
            array[i] = a + 1;
            Variations(i + 1);
        }
    }
    static void Main()
    {
        Variations(0);
    }
}

