using System;
class VariableNumbOfArguments
{
    static void Minimum(params int[] list)
    {
        int min = list[0];
        for (int j = 1; j < list.Length; j++)
        {
            if (list[j] < min)
            {
                min = list[j];
            }
        }
        Console.WriteLine("The minimum number is {0}", min);
    }

    static void Maximum(params int[] list)
    {
        int max = list[0];
        for (int j = 1; j < list.Length; j++)
        {
            if (list[j] > max)
            {
                max = list[j];
            }
        }
        Console.WriteLine("The maximum number is {0}", max);
    }

    static void Avarage(params int[] list)
    {
        int sum = 0;
        for (int i = 0; i < list.Length; i++)
        {
            sum += list[i];
        }
        double avarage = (double)sum / (double)list.Length;
        Console.WriteLine("The avarage is {0}", avarage);
    }

    static void Sum(params int[] list)
    {
        int sum = 0;
        for (int i = 0; i < list.Length; i++)
        {
            sum += list[i];
        }        
        Console.WriteLine("The sum is {0}", sum);
    }

    static void Product(params int[] list)
    {
        int pro = 0;
        for (int i = 0; i < list.Length; i++)
        {
            pro -= list[i];
        }
        Console.WriteLine("The product is {0}", pro);
    }
    static void Main()
    {
        Minimum(1, 2, 3, 4, 9, 6, 7, 0);
        Maximum(1, 2, 3, 4, 9, 6, 7, 0);
        Avarage(1, 2, 3, 4, 9, 6, 7, 0);
        Sum(1, 2, 3, 4, 9, 6, 7, 0);
        Product(1, 2, 3, 4, 9, 6, 7, 0);
    }
}

