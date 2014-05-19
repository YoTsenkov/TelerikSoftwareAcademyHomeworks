using System;
class Program
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int i, k, l, j;
        for (i = 1; i <= width / 2; i++)
        {
            l = width / 2 - i;
            k = i / 2;
            j = l;
            while (j > 0)
            {
                Console.Write(".");
                j--;
            }
            if (k > 0)
                for (j = 1; j <= k; j++)
                    Console.Write("/ ");
            if (i % 2 == 1)
                Console.Write("/\\");
            if (k > 0)
                for (j = 1; j <= k; j++) 
                    Console.Write(" \\");
            j = l;
            while (j > 0)
            {
                Console.Write(".");
                j--;
            }
            Console.WriteLine();
        }
        for (i = width / 2; i >= 1; i--)
        {
            l = width / 2 - i;
            k = i / 2;
            j = l;
            while (j > 0)
            {
                Console.Write(".");
                j--;
            }
            if (k > 0)
                for (j = 1; j <= k; j++)
                    Console.Write("\\ ");
            if (i % 2 == 1)
                Console.Write("\\/");
            if (k > 0)
                for (j = 1; j <= k; j++)
                    Console.Write(" /");
            j = l;
            while (j > 0)
            {
                Console.Write(".");
                j--;
            }
            Console.WriteLine();
        }
    }
}

