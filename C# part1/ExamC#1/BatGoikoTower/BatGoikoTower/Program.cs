using System;
class Program
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int width = 2 * height;
        int center = width / 2;
        int add = 0;
        int a = 2;
        int b = 0;

        for (int j = 0; j < height; j++)
        {
            int elPos = 1;

            for (int i = 0; i < width; i++)
            {
                if (elPos < center - add || elPos > center + 1 + add)
                {
                    Console.Write(".");
                    elPos++;
                }
                else if (elPos == center - add)
                {
                    Console.Write("/");
                    elPos++;
                }
                else if (elPos == center + 1 + add)
                {
                    Console.Write("\\");
                    elPos++;
                }
                else
                {
                    if (j == a - 1)
                    {
                        Console.Write("-");
                        elPos++;
                    }
                    else
                    {
                        Console.Write(".");
                        elPos++;
                    }
                }
            }
            if (j == 1)
            {
                b = 1;
            }
            if (j == a - 1)
            {
                b++;
                a = a + b;
            }
            Console.WriteLine();
            add++;
        }
    }
}
