using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegativeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter numbers one per line followed by enter and empty line for end.");
        List<int> numbers = new List<int>();
        string input = Console.ReadLine();

        while (input != "")
        {
            int number = int.Parse(input);
            numbers.Add(number);
            input = Console.ReadLine();
        }

        numbers.RemoveAll(number => number.CompareTo(0) < 0);

        Console.WriteLine("The result sequence is:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

