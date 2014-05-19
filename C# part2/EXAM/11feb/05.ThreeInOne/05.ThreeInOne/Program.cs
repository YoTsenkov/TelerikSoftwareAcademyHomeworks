using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void TaskOne()
    {
        string[] rawPoints = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] points = new int[rawPoints.Length];
        for (int i = 0; i < rawPoints.Length; i++)
        {
            points[i] = int.Parse(rawPoints[i]);
        }


        int maxPoints = points[0];
        int counter = 0;
        int index = 0;

        for (int i = 1; i < points.Length; i++)
        {
            if (points[i] <= 21 && points[i] > maxPoints)
            {
                maxPoints = points[i];
                index = i;
            }
            if (points[i] == maxPoints)
            {
                counter = 1;
            }
        }

        if (counter == 1)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(index);
        }
    }


    static void TaskTwo()
    {
        string[] cakes = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int friends = int.Parse(Console.ReadLine());
        int[] bites = new int[cakes.Length];
        int yourBites = 0;
        for (int i = 0; i < cakes.Length; i++)
        {
            bites[i] = int.Parse(cakes[i]);
        }
        Array.Sort(bites);
        Array.Reverse(bites);

        for (int i = 0; i < bites.Length; i++)
        {
            if (i % 3 == 0)
            {
                yourBites += bites[i];
            }
        }

        Console.WriteLine(yourBites);

    }


    static void TaskThree()
    {
        string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int G1 = int.Parse(input[0]);
        int S1 = int.Parse(input[1]);
        int B1 = int.Parse(input[2]);
        int G2 = int.Parse(input[3]);
        int S2 = int.Parse(input[4]);
        int B2 = int.Parse(input[5]);

        int neededMoney = B2 + S2 * 9 + G2 * 81;
        int availableMoney = B1 + S1 * 9 + G1 * 81;

        if (neededMoney > availableMoney)
        {
            Console.WriteLine(-1);
        }
        else
        {
            while (true)
            {
                
            }
        }
    }
    static void Main()
    {
        TaskOne();
        TaskTwo();
    }
}

