using System;
using System.Linq;
using System.Collections.Generic;


class RemoveOddNumberOfOccurances
{
    private static List<int> RemoveOddOccurances(List<int> collection)
    {
        for (int i = 0; i < collection.Count; i++)
        {
            int currentNumber = collection[i];
            int currentElementOccurences = collection.Count(number => number == currentNumber);

            if (currentElementOccurences % 2 == 1)
            {
                collection.RemoveAll(number => number == currentNumber);
            }
        }

        return collection;
    }

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

        RemoveOddOccurances(numbers);

        Console.WriteLine("Result list:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

