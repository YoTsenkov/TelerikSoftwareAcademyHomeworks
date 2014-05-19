using System;
class Carpet
{
    static void Main()
    {
        string input = Console.ReadLine();
        int lines = int.Parse(input);
        int elemntsOnline = lines;
        int center = lines / 2;
        for (int i = 1; i <= center; i++)
        {
            int elPos = 1;
            while (elPos <= lines)
            {
                if (elPos <= center - i || elPos > center + i)
                {
                    Console.Write(".");
                    elPos++;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("/");
                            elPos++;
                        }
                        else
                        {
                            Console.Write(" ");
                            elPos++;
                        }
                    }
                    for (int j = i; j > 0; j--)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("\\");
                            elPos++;
                        }
                        else
                        {
                            Console.Write(" ");
                            elPos++;
                        }
                    }
                }
            }
            Console.WriteLine();
        }

        for (int i = center; i > 0; i--)
        {
            int elPos = 1;
            while (elPos <= lines)
            {
                if (elPos <= center - i || elPos > center + i)
                {
                    Console.Write(".");
                    elPos++;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("\\");
                            elPos++;
                        }
                        else
                        {
                            Console.Write(" ");
                            elPos++;
                        }
                    }
                    for (int j = i; j > 0; j--)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("/");
                            elPos++;
                        }
                        else
                        {
                            Console.Write(" ");
                            elPos++;
                        }
                    }
                }               
            }
            Console.WriteLine();
        }
    }
}

