using System;
using System.Collections.Generic;
using System.Linq;

class CountOccurances
{
    private static List<string> GetEveryElementOccurances(List<int> collection)
    {
        List<string> result = new List<string>();
        List<int> checkedValues = new List<int>();
        collection.Sort();

        for (int i = 0; i < collection.Count; i++)
        {
            int currentNumber = collection[i];
            if (checkedValues.Any(value => value == currentNumber) == true)
            {
               continue; 
            }

            int currentElementOccurences = collection.Count(number => number == currentNumber);

            result.Add(currentNumber + " -> " + currentElementOccurences + "times");
            checkedValues.Add(currentNumber);
        }

        return result;
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

        var occurances = GetEveryElementOccurances(numbers);

        foreach (var occurance in occurances)
        {
            Console.WriteLine(occurance);
        }
    }
}

