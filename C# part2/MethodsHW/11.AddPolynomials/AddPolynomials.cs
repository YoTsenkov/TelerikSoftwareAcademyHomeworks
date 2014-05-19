using System;
using System.Collections.Generic;
class AddPolynomials
{
    static void Add(List<int> first, List<int> second)
    {
        List<int> result = new List<int>();
        
        if (first.Count > second.Count)
        {       
            for (int i = 0; i < second.Count; i++)
            {
                result.Add(first[i] + second[i]);
            }
            for (int j = 0; j < second.Count - 1; j++)
            {
                first.RemoveAt(0);
            }
            result.AddRange(first);
        }
        else
        {
            for (int i = 0; i < first.Count; i++)
            {
                result.Add(first[i] + second[i]);
            }
            for (int j = 0; j < first.Count; j++)
            {
                second.RemoveAt(0);
            }
            result.AddRange(second);
        }

        for (int i = result.Count - 1; i >= 0; i--)
        {
            Console.Write(result[i] + "x^{0} + ", i);
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter the highest power of the first polynimial.");
        int highestPower = int.Parse(Console.ReadLine());
        List<int> first = new List<int>();
        for (int i = 0; i < highestPower + 1; i++)
        {
            first.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Enter the highest power of the second polynimial.");
        highestPower = int.Parse(Console.ReadLine());
        List<int> second = new List<int>();
        for (int i = 0; i < highestPower + 1; i++)
        {
            second.Add(int.Parse(Console.ReadLine()));
        }

        Add(first, second);
    }
}

