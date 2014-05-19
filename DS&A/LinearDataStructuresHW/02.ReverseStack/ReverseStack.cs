using System;
using System.Collections;
using System.Collections.Generic;

class ReverseStack
{
    static void Main()
    {
        Stack<int> numbers = new Stack<int>();
        Console.WriteLine("Enter the count of the numbers you will enter.");
        int numbersCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the numbers one per line followed by enter.");
        for (int i = 0; i < numbersCount; i++)
        {
            int number = int.Parse(Console.ReadLine());

            numbers.Push(number);
        }

        Console.WriteLine("Reversed numbers:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

