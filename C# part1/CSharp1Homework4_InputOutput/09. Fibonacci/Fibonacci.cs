using System;
class Fibonacci
{
    static void Main()
    {
        ulong first = 0;
        ulong second = 1;
        ulong number;
        Console.WriteLine(first);
        Console.WriteLine(second);
        for (int i = 0; i < 98; i++)
        {
            number = first + second;
            Console.WriteLine(number);
            first = second;
            second = number;

        }
    }
}

