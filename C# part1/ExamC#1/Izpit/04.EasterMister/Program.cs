using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = 2 * n;
        int width = 3 * n + 1;
        int center = width / 2 + 1;
        int add = 2;
        //purvi red
        for (int i = 1; i <= width; i++)
        {
            if (i <= center + (n - 1) / 2 && i >= center - (n - 1) / 2)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
        //1va polovina
        for (int i = 1; i <= n - 2; i++)
        {
            for (int j = 1; j <= width; j++)
            {
                if (j == center - (n - 1) / 2 - add || j == center + (n - 1) / 2 + add)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            if (center - (n - 1) / 2 - add > 3)
            {
                add = add + 2;
            }

            Console.WriteLine();
        }
        //sreda red 1

        for (int j = 1; j <= width; j++)
        {
            if (j == 2 || j == width - 1)
            {
                Console.Write("*");
            }
            else if ((j > 3 && j < width - 2) && j % 2 == 0)
            {
                Console.Write("#");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
        //sreda red 2
        for (int j = 1; j <= width; j++)
        {
            if (j == 2 || j == width - 1)
            {
                Console.Write("*");
            }
            else if ((j > 2 && j < width - 1) && j % 2 == 1)
            {
                Console.Write("#");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
        // dolna polovina
        add = 0;
        for (int i = 1; i <= n / 2 - 1; i++)
        {
            for (int j = 1; j <= width; j++)
            {
                if (j == width - 1 || j == 2)
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

        for (int i = 1; i <= (n -2) - ( n / 2 - 1); i++)
        {
            for (int j = 1; j <= width; j++)
            {
                if (j == width - 3 - add || j == 4 + add)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }

            }
            add = add + 2;
            Console.WriteLine();
        }
        //posleden red
        for (int i = 1; i <= width; i++)
        {
            if (i <= center + (n - 1) / 2 && i >= center - (n - 1) / 2)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(".");
            }
        }
    }
}


