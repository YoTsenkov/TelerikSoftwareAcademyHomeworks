using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static int? GetMajorant(List<int> collection)
    {
        int? majorant = null;
        List<int> checkedValues = new List<int>();        

        for (int i = 0; i <= collection.Count / 2 + collection.Count % 2; i++)
        {
            int currentNumber = collection[i];
            if (checkedValues.Any(value => value == currentNumber) == true)
            {
                continue;
            }

            int currentElementOccurences = collection.Count(number => number == currentNumber);
            if (currentElementOccurences > collection.Count / 2)
            {
                majorant = currentNumber;
                break;
            }            
            checkedValues.Add(currentNumber);
        }

        return majorant;
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

        var majorant = GetMajorant(numbers);
        if (majorant == null)
        {
            Console.WriteLine("These is no majorant");
        }
        else
        {
            Console.WriteLine("Majorant -> " + majorant);
        }
    }
}

