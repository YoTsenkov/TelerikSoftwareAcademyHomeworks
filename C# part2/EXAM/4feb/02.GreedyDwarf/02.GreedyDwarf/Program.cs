using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main()
    {

        //valley
        string input;
        string[] valley = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        //valley end



        //patterns
        int patNum = int.Parse(Console.ReadLine());
        string[][] patterns = new string[patNum][];

        for (int i = 0; i < patNum; i++)
        {
            input = Console.ReadLine();
            patterns[i] = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        }
        //patterns end


        int coinsCollected = 0;

        int maxCoins = int.MinValue;

        for (int i = 0; i < patNum; i++)
        {
            
            bool[] visited = new bool[valley.Length];
           
            coinsCollected = int.Parse(valley[0]);
            
            int position = 0;
            
            visited[position] = true;
            
            for (int j = 0; j < patterns[i].Length; j++)
            {
                position += int.Parse(patterns[i][j]);

                if (position > valley.Length - 1 || position < 0 || visited[position] == true)
                {
                    break;
                }              
                else
                {
                    coinsCollected += int.Parse(valley[position]);
                    if (j < patterns[i].Length - 1)
                    {
                        visited[position] = true;
                    }
                }
                if (j == patterns[i].Length - 1)
                {
                    j = -1;                    
                }
            }

            if (coinsCollected > maxCoins)
            {
                maxCoins = coinsCollected;
            }
        }
        Console.WriteLine(maxCoins);
    }
}

