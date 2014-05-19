using System;
class PrintMatrix
{
    static void Main()
    {
        int[,] array = new int[4, 4];
        int a = 1;
        int b = 0;

        for (int j = 0; j < 4; j++)
        {
            for (int i = b; i < array.GetLength(0) - b; i++)
            {
                array[i, b] = a;
                a++;
            }
            for (int i = b + 1; i < array.GetLength(0) - b; i++)
            {
                array[array.GetLength(0) - b - 1, i] = a;
                a++;
            }
            for (int i = array.GetLength(0) - b - 2; i >= b; i--)
            {
                array[i, array.GetLength(0) - b - 1] = a;
                a++;
            }
            for (int i = array.GetLength(0) - b - 2; i > b; i--)
            {
                array[b, i] = a;
                a++;
            }
            b++;
        }

        //print
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write(array[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

