using System;
class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = x;
        int z = (x / 2) + 1;
        int height = (3 * x) - 2;
        int pointLeft = (height / 2) - (y - 2);
        int pointRight = height / 2 + y;
        int elPos = 1;
        int add = 1;
        //first line
        for (int a = 1; a <= height; a++)
        {
            if (elPos == pointLeft || elPos == pointRight)
            {
                Console.Write("*");
                elPos++;
            }
            else
            {
                Console.Write(".");
                elPos++;
            }
        }
        Console.WriteLine();
        //second part
        for (int i = 1; i <= y - 2; i++)
        {
            elPos = 1;

            for (int j = 1; j <= height; j++)
            {
                if (elPos == pointLeft + add || elPos == pointLeft - add || elPos == pointRight + add || elPos == pointRight - add)
                {
                    Console.Write("*");
                    elPos++;
                }
                else
                {
                    Console.Write(".");
                    elPos++;
                }
            }
            add++;
            Console.WriteLine();
        }

        //third part
        add = 0;

        for (int i = 1; i <= x; i++)
        {
            elPos = 1;
            for (int j = 1; j <= height; j++)
            {
                int center = (height / 2) + 1;

                if ((elPos == center + add || elPos == center - add) && (elPos >= pointLeft && elPos <= pointRight))
                {
                    Console.Write("*");
                    elPos++;
                }
                else
                {
                    Console.Write(".");
                    elPos++;
                }
            }
            add++;
            Console.WriteLine();
        }
        add = 1;
        //last part
        for (int i = 1; i <= x - 1; i++)
        {
            elPos = 1;

            for (int j = 1; j <= height; j++)
            {
                if (elPos == pointLeft + add || elPos == pointRight - add)
                {
                    Console.Write("*");
                    elPos++;
                }
                else
                {
                    Console.Write(".");
                    elPos++;
                }
            }
            add++;
            Console.WriteLine();
        }

    }
}

