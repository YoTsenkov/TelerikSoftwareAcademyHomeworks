using System;
class Program
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int height = width;
        int center = width / 2;
        int add = 0;

        for (int i = 1; i <= height / 2; i++)
        {
            int elPos = 1;
            for (int j = 0; j < width; j++)
            {
                if (elPos < center - add || elPos > center + add + 1)
                {
                    Console.Write(".");
                    elPos++;
                }
                else if (elPos >= center - add && elPos <= center)
                {
                    if (i % 2 == 1)
                    {
                        if (elPos % 2 == 0)
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
                    else
                    {
                        if (elPos % 2 != 0)
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
                else if (elPos <= center + add + 1 && elPos > center)
                {
                    if (i % 2 == 1)
                    {


                        if (elPos % 2 != 0)
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
                    else
                    {
                        if (elPos % 2 == 0)
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
                else
                {
                    Console.Write(" ");
                    elPos++;
                }
            }
            Console.WriteLine();
            add++;
        }

        //Second part
        add = height / 2 - 1;
        for (int i = (height / 2) + 1; i <= height; i++)
        {
            int elPos = 1;
            for (int j = 0; j < width; j++)
            {
                if (elPos >= center - add && elPos <= center)
                {
                    if (i % 2 != 0)
                    {
                        if (elPos % 2 != 0)
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
                    else
                    {
                        if (elPos % 2 == 0)
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
                else if (elPos <= center + add + 1 && elPos > center)
                {
                    if (i % 2 != 0)
                    {
                        if (elPos % 2 != 0)
                        {
                            Console.Write(" ");
                            elPos++;
                        }
                        else
                        {
                            Console.Write("/");
                            elPos++;
                        }
                    }
                    else
                    {
                        if (elPos % 2 == 0)
                        {
                            Console.Write(" ");
                            elPos++;
                        }
                        else
                        {
                            Console.Write("/");
                            elPos++;
                        }
                    }
                }
                else
                {
                    Console.Write(".");
                    elPos++;
                }
            }
            Console.WriteLine();
            add--;
        }
    }
}