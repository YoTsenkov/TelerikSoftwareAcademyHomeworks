using System;
class Program
{
    static void Main()
    {
        int[,] array = new int [4,4];
        int a = 1;

        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                array[j, i] = a;
                if (i % 2 == 0 && j < 3)
                {
                    a++;
                }
                else if (i % 2 == 1 && j < 3)
                {
                    a--;
                }
            }
            a += 4;
        }
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write(array[row, col]);
            }
            Console.WriteLine();
        }
    }
}

