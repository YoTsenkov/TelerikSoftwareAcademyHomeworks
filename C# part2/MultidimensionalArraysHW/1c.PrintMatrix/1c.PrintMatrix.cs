using System;
class PrintMatrix
{
    static int[,] array = new int[4, 4];
    static int a = 1;
    static int b = 0;
    static int c = 0;

    static void FIll()
    {
        int row;
        int col;
        for (row = array.GetLength(0) - 1 - b, col = c; row < array.GetLength(0) && col < array.GetLength(1); row++, col++)
        {
            array[row, col] = a;
            a++;
        }
        if (b == array.GetLength(0) - 1)
        {
            c++;
        }
        if (b < array.GetLength(0) - 1)
        {
            b++;
        }
    }
    static void Main()
    {


        for (int i = 0; i < (array.GetLength(0) * 2) - 1; i++)
        {
            FIll();
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

