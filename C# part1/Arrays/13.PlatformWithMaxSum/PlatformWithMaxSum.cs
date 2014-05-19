using System;
class PlatformWithMaxSum
{
    static void Main()
    {
        int bestRow = 0;
        int bestCol = 0;
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        int[,] array = new int[row, col];
        int sum = 0;
        int maxSum = int.MinValue;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int z = 0; z < array.GetLength(0) - 2; z++)
        {
            for (int i = 0; i < array.GetLength(1) - 2; i++)
            {
                for (int j = i; j < i + 3; j++)
                {
                    for (int k = z; k < z + 3; k++)
                    {
                        sum += array[k, j];
                        if (maxSum < sum)
                        {
                            maxSum = sum;
                            bestRow = k;
                            bestCol = j;
                        }
                    }
                }
                sum = 0;
            }
        }
        Console.WriteLine("max sum = " + maxSum);

        for (int i = bestRow - 2; i <= bestRow; i++)
        {
            for (int j = bestCol - 2; j <= bestCol; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

