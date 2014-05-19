using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter starting number");
        int startingNumber = int.Parse(Console.ReadLine());
        List<int> result = new List<int>();
        result.Add(startingNumber);   
        Queue<int> numbers = new Queue<int>();
        numbers.Enqueue(startingNumber);
        
        while (result.Count < 48)
        {
            startingNumber = numbers.Dequeue();
            numbers.Enqueue(startingNumber + 1);
            numbers.Enqueue(2 * startingNumber + 1);
            numbers.Enqueue(startingNumber + 2);
            result.Add(startingNumber + 1);
            result.Add(2 * startingNumber + 1);
            result.Add(startingNumber + 2);
        }

        Console.WriteLine("result :");
        foreach (var number in result)
        {
            Console.WriteLine(number);
        }

    }
}

