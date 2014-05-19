using System;
class Program
{
    static void Main()
    {
        char firstElement = char.Parse(Console.ReadLine());
        char secondElement = char.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());
        int nextElementCode;
        char nextElementSymbol;

        if ((int)firstElement - 64 + (int)secondElement - 64 > 26)
        {
            nextElementCode = (((int)firstElement - 64) + ((int)secondElement - 64)) % 26 + 64;
            nextElementSymbol = (char)nextElementCode;
        }
        else
        {
            nextElementCode = ((int)firstElement - 64) + ((int)secondElement - 64) + 64;
            nextElementSymbol = (char)nextElementCode;
        }

        if (lines == 1)
        {
            Console.WriteLine(firstElement);
        }
        else if (lines == 2)
        {
            Console.WriteLine(firstElement);
            Console.WriteLine(secondElement + "" + nextElementSymbol);
        }
        else
        {
            Console.WriteLine(firstElement);
            Console.WriteLine(secondElement + "" + nextElementSymbol);
            for (int i = 3; i <= lines; i++)
            {            
                for (int j = 0; j < 2; j++)
                {
                    firstElement = secondElement;
                    secondElement = nextElementSymbol;
                    if ((int)firstElement - 64 + (int)secondElement - 64 > 26)
                    {

                        nextElementCode = (((int)firstElement - 64) + ((int)secondElement - 64)) % 26 + 64;
                        nextElementSymbol = (char)nextElementCode;
                    }
                    else
                    {
                        nextElementCode = ((int)firstElement - 64) + ((int)secondElement - 64) + 64;
                        nextElementSymbol = (char)nextElementCode;
                    }
                    Console.Write(nextElementSymbol);
                    for (int a = 0; a < i - 2; a++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}

