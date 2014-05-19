using System;
class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int z = x / 2 - 1;
        int a = x / 2;
        int b = x / 2 + 2*x - 2;

        for (int i = 0; i <= z; i++)
        {
            for (int j = 0; j < 3*x - 2; j++)
            {
                if (j == a - i || j == a + i || j == b - i || j == b + i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

        for (int i = z + 1; i < 2 * x - 1; i++)
        {
            for (int j = 0; j < 3 * x - 2; j++)
            {
                if (j == a + i || j == b - i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

        for (int i = 2 * x; i <= 3 * x - 2; i++)
        {
            for (int j = 0; j < 3 * x - 2; j++)
            {
                if (j == a + i - 2*x + 1 || j == b - i + 2*x - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}

