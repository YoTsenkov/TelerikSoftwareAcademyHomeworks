using System;
using System.Collections.Generic;
class VariableNumbOfArguments
{
    
    static void Minimum<T>(params T[] list)
    {
        T min = list[0];
        
        for (int j = 1; j < list.Length; j++)
        {
            if (Comparer<T>.Default.Compare(list[j],min) < 0)
            {
                min = list[j];
            }
        }
        Console.WriteLine("The minimum number is {0}", min);
    }

    static void Maximum<T>(params T[] list)
    {
        T max = list[0];
        for (int j = 1; j < list.Length; j++)
        {
            if (Comparer<T>.Default.Compare(list[j], max) > 0)
            {
                max = list[j];
            }
        }
        Console.WriteLine("The maximum number is {0}", max);
    }

    static void Avarage<T>(params T[] list)
    {
        T sum = (dynamic)list[0];
        dynamic listLength = list.Length;
        for (int i = 1; i < list.Length; i++)
        {
            sum += (dynamic)list[i];
        }
        T avarage = sum / listLength;
        Console.WriteLine("The avarage is {0}", avarage);
    }

    static void Sum<T>(params T[] list)
    {
        T sum = (dynamic)list[0];
        for (int i = 1; i < list.Length; i++)
        {
            sum += (dynamic)list[i];
        }
        Console.WriteLine("The sum is {0}", sum);
    }

    static void Product<T>(params T[] list)
    {
        T pro = -(dynamic)list[0];
        for (int i = 1; i < list.Length; i++)
        {
            pro -= (dynamic)list[i];
        }
        Console.WriteLine("The product is {0}", pro);
    }
    static void Main()
    {
        Minimum<byte>(1, 2, 3, 4, 9, 6, 7, 0);
        Maximum<float>(1.4f, 2.6f, 3.1f, 4, 9.0435f, 6, 7, 0);
        Avarage<int>(1, 2, 3, 4, 9, 6, 7, 0);
        Sum<decimal>(1, 2.896537820m, 3, 4, 9.7907m, 6, 7, 0);
        Product<int>(1, 2, 3, 4, 9, 6, 7, 0);
    }
}

