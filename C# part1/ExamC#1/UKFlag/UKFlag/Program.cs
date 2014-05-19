using System;
class Program
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int height = width;
        int add = width / 2;
        int center = (width / 2) + 1;
        //first part
        for (int i = 1; i <= height / 2; i++)
        {
            int elPos = 1;

            for (int j = 1; j <= width; j++)
            {
                if (elPos == center - add)
                {
                    Console.Write("\\");
                    elPos++;
                }
                else if (elPos == center + add)
                {
                    Console.Write("/");
                    elPos++;
                }
                else if (elPos == center)
                {
                    Console.Write("|");
                    elPos++;
                }
                else
                {
                    Console.Write(".");
                    elPos++;
                }
            }
            add--;
            Console.WriteLine();
        }
        //middle line
        
        for (int i = 1; i <= width; i++)
        {
            if (i == center)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write("-");
            }
        }
        Console.WriteLine();
        //second part
        add = 1;
        for (int i = 1; i <= height / 2; i++)
        {
            int elPos = 1;

            for (int j = 1; j <= width; j++)
            {
                if (elPos == center - add)
                {
                    Console.Write("/");
                    elPos++;
                }
                else if (elPos == center + add)
                {
                    Console.Write("\\");
                    elPos++;
                }
                else if (elPos == center)
                {
                    Console.Write("|");
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

