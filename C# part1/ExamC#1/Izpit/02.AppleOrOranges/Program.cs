using System;
class Program
{
    static void Main()
    {
        long odd = 0;
        long even = 0;
        long number = Math.Abs(long.Parse(Console.ReadLine()));

        for (int i = 0; i < 20; i++)
        {
            if (((number / (long)Math.Pow(10, i) % 10) % 2 == 0))
            {
                even += (number / (long)Math.Pow(10, i) % 10);
            }
            else if (((number / (long)Math.Pow(10, i) % 10) % 2 == 1))
            {
                odd += (number / (long)Math.Pow(10, i) % 10);
            }
        }
        if (even > odd)
        {
            Console.Write("apples {0}", even);
        }
        else if (odd > even)
        {
            Console.Write("oranges {0}", odd);
        }
        else if (odd == even)
        {
            Console.Write("both {0}", even);
        }
    }
}

