using System;
using System.Collections.Generic;
class SubMultPolynomials
{
    static void Multiply(List<int> first, List<int> second)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < (first.Count - 1) * (second.Count - 1); i++)
        {
            result.Add(0);
        }

        for (int i = 0; i < first.Count; i++)
        {
            for (int j = 0; j < second.Count; j++)
            {
                result[i + j] += first[i] * second[j];
            }
        }
        //printing
        for (int i = result.Count - 1; i >= 1; i--)
        {
            Console.Write(result[i] + "(x^{0}) + ", i);
        }
        Console.Write(result[0] + "(x^{0})", 0);

    }
    static void Sub(List<int> first, List<int> second)
    {
        List<int> result = new List<int>();

        if (first.Count > second.Count)
        {
            ;
            for (int i = 0; i < second.Count; i++)
            {
                result.Add(first[i] - second[i]);
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
                result.Add(first[i] - second[i]);
            }
            for (int j = 0; j < first.Count; j++)
            {
                second.RemoveAt(0);
            }
            result.AddRange(second);
        }
        //printing
        for (int i = result.Count - 1; i >= 1; i--)
        {
            Console.Write(result[i] + "(x^{0}) + ", i);
        }
        Console.Write(result[0] + "(x^{0})", 0);
    }
    static void Main()
    {
        //Delete the commented sections and the default values for the lists' elements if you want to enter your own polynomials

        //Console.WriteLine("Enter the highest power of the first polynimial.");
        //int highestPower = int.Parse(Console.ReadLine());
        List<int> first = new List<int>() { 5, 0, 1 };
        //for (int i = 0; i < highestPower + 1; i++)
        //{
        //    first.Add(int.Parse(Console.ReadLine()));
        //}
        
        //Console.WriteLine("Enter the highest power of the second polynimial.");
        //highestPower = int.Parse(Console.ReadLine());
        List<int> second = new List<int>() { 2, 1, 4, 3 };
        // for (int i = 0; i < highestPower + 1; i++)
        // {
        //     second.Add(int.Parse(Console.ReadLine()));
        // }
        Sub(first, second);
        Console.WriteLine();
        first = new List<int>() { 5, 0, 1 };
        second = new List<int>() { 2, 1, 4, 3 };
        Multiply(first, second);
        Console.WriteLine();
    }
}

