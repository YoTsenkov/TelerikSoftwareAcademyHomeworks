using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string[][] rawNumbers = new string[int.Parse(Console.ReadLine())][];

        for (int i = 0; i < rawNumbers.Length; i++)
        {
            rawNumbers[i] = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        }

        int[][] numbers = new int[rawNumbers.Length][];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new int[rawNumbers[i].Length];

            for (int j = 0; j < rawNumbers[i].Length; j++)
            {
                numbers[i][j] = int.Parse(rawNumbers[i][j]);
            }
        }

        bool[][] visited = new bool[numbers.Length][];

        for (int i = 0; i < numbers.Length; i++)
        {
            visited[i] = new bool[numbers[i].Length];
        }

        int maxSum = int.MinValue;

        //input ends

        int buff;

        int nextPosition;

        int previousposition;

        int specialSum;

        int steps;


        for (int position = 0; position < numbers[0].Length; position++)
        {
            buff = 0;

            nextPosition = 0;

            previousposition = 0;

            specialSum = 0;

            steps = 1;

            if (numbers[0][position] < 0)
            {
                specialSum = steps + Math.Abs(numbers[0][position]);

                if (specialSum > maxSum)
                {
                    maxSum = specialSum;
                }

                continue;
            }

            visited[0][position] = true;

            nextPosition = numbers[0][position];

            previousposition = position;

            for (int i = 1; i < numbers.Length; i++)
            {
                int k = i;

                if (i == 0)
                {
                    k = numbers.Length - 1;
                }

                if (numbers[i][nextPosition] < numbers[k - 1][previousposition] && numbers[i][nextPosition] >= 0 && visited[i][nextPosition] == false)
                {
                    steps++;

                    visited[i][nextPosition] = true;

                    buff = nextPosition;

                    nextPosition = numbers[i][nextPosition];

                    previousposition = buff;

                }
                else if (numbers[i][nextPosition] < 0)
                {
                    steps++;

                    specialSum = steps + Math.Abs(numbers[i][nextPosition]);

                    if (specialSum > maxSum)
                    {
                        maxSum = specialSum;
                    }

                    break;
                }
                else
                {
                    break;
                }

                if (i == numbers.Length - 1)
                {
                    i = 0;
                }
            }
        }

        Console.WriteLine(maxSum);
    }
}

