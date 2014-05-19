using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];


        for (int row = 0; row < size; row++)
        {
            string[] line = Console.ReadLine().Split(' ');

            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = int.Parse(line[col]);
            }
        }

        //diagonal


        int diagonalSum = 0;

        for (int row = 0,col = 0; row < size; row++, col++)
        {
            diagonalSum += matrix[row, col];
        }



        //ok
        ////////
        int sum = 0;

        int maxSum = int.MinValue;

        
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                sum = 0;
                if (col < size - 4 && row < size - 2 && matrix[row, col] == matrix[row, col + 1] - 1 && matrix[row, col + 1] == matrix[row, col + 2] - 1)
                {
                    sum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];

                    if (matrix[row, col + 2] == matrix[row + 1, col + 2] - 1 && matrix[row + 1, col + 2] == matrix[row + 2, col + 2] - 1)
                    {
                        sum += matrix[row + 1, col + 2] + matrix[row + 2, col + 2];

                        if (matrix[row + 2, col + 2] == matrix[row + 2, col + 3] - 1 && matrix[row + 2, col + 3] == matrix[row + 2, col + 4] - 1)
                        {
                            sum += matrix[row + 2, col + 3] + matrix[row + 2, col + 4];

                            if (sum > maxSum)
                            {
                                maxSum = sum;
                            }
                        }
                    }
                }
            }
        }
        ////////
        if (maxSum == int.MinValue)
        {
            Console.WriteLine("NO " + diagonalSum);
        }
        else
        {
            Console.WriteLine("YES " + maxSum);
        }
    }
}

