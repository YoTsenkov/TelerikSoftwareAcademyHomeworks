using System;
using System.Collections.Generic;

class Program
{
    private static List<int> GetMinOperations(int start, int end)
    {
        int number;
        List<int> result = new List<int>();
        Queue<int> numbers = new Queue<int>();
        numbers.Enqueue(start);

        if (start < end / 2)
        {
            if ((end / 2 - start) % 2 == 1)
            {
                number = numbers.Dequeue();
                result.Add(number);
                numbers.Enqueue(number + 1);                
            }

            if (numbers.Peek() < end / 2)
            {
                while (numbers.Peek() != end / 2)
                {
                    number = numbers.Dequeue();
                    result.Add(number);
                    numbers.Enqueue(number + 2);
                }
            }

            number = numbers.Dequeue();
            result.Add(number);
            numbers.Enqueue(number * 2);

            if (end % 2 == 1)
            {
                number = numbers.Dequeue();
                result.Add(number);
                numbers.Enqueue(number + 1);
                result.Add(numbers.Peek());
            }
            else
            {
                result.Add(numbers.Peek());
            }

            return result;
        }
        else
        {
            if ((end - start) % 2 == 1)
            {
                number = numbers.Dequeue();
                result.Add(number);
                numbers.Enqueue(number + 1);
            }

            if (numbers.Peek() == end)
            {
                result.Add(numbers.Peek());
            }

            while (numbers.Peek() != end)
            {
                number = numbers.Dequeue();
                result.Add(number);
                numbers.Enqueue(number + 2);
                result.Add(numbers.Peek());
            }

            return result;
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter starting number");
        int startNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter ending number");
        int endNumber = int.Parse(Console.ReadLine());

        var output = GetMinOperations(startNumber, endNumber);

        Console.WriteLine("Minimum steps:");
        foreach (var number in output)
        {
            Console.WriteLine(number);
        }
    }
}

