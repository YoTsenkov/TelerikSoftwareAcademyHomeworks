using System;
using System.Collections.Generic;
using System.IO;

class MaxSumOFMatrix
{
    static int size;
    static StreamReader reader = new StreamReader("matrix.txt");
    static int row = 0;
    static int[,] matrix = new int[,] { };

    static void FillFromFile()
    {
        for (int i = 0; i < size; i++)
        {
            string line = reader.ReadLine();
            string[] lineSplit = line.Split(' ');
            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = int.Parse(lineSplit[col]);
            }
            row++;
        }
    }
    static void Main()
    {
        using (reader)
        {
            size = int.Parse(reader.ReadLine());
            matrix = new int[size, size];
            FillFromFile();
            int sum = 0;
            int maxSum = int.MinValue;
            for (int row = 0; row < size - 1; row++)
            {
                for (int col = 0; col < size - 1; col++)
                {
                    for (int searchRow = row; searchRow < row + 2; searchRow++)
                    {
                        for (int searchCol = col; searchCol < col + 2; searchCol++)
                        {
                            sum += matrix[searchRow, searchCol];
                            if (sum > maxSum)
                            {
                                maxSum = sum;
                            }
                        }
                    }
                    sum = 0;
                }
            }
            Console.WriteLine("The max sum is {0} and it is written in maxSum.txt", maxSum);
            string[] result = new string[1];
            result[0] = maxSum.ToString();
            File.WriteAllLines("maxSum.txt", result);
        }
    }
}

