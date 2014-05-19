using System;
using System.Collections.Generic;
using System.Linq;

class SortIncreasingOrder
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter the numbers one per line followed by enter.");
        string input = Console.ReadLine();

        while (input != "")
        {
            int number = int.Parse(input);
            numbers.Add(number);
            input = Console.ReadLine();
        }

        numbers.Sort();

        Console.WriteLine("Sorted numbers:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

