using System;
using System.Linq;
using System.Collections.Generic;

public class GetSumAndAvarage
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        string input = Console.ReadLine();

        while (input != "")
        {
            int number = int.Parse(input);
            numbers.Add(number);
            input = Console.ReadLine();
        }

        int sum = numbers.Sum();
        double avarage = numbers.Average();

        Console.WriteLine("Sum " + sum);
        Console.WriteLine("Avarage " + avarage);
    }
}

