using System;
using System.Collections.Generic;
using System.IO;

class ReadNumberMethod
{
    static int[] numbers = new int[10];
    static void ReadNumber(int start, int end)
    {        
        Random rand = new Random();
        for (int i = 0; i < 10; i++)
        {
            try
            {
                numbers[i] = rand.Next(start, end - 9 + i);
            }
            catch (FormatException)
            {
                throw;                
            }
            catch (OverflowException)
            {
                throw;
            }
            
            start = numbers[i] + 1;
        }
    }
    static void Main()
    {
        ReadNumber(1, 15);
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}

