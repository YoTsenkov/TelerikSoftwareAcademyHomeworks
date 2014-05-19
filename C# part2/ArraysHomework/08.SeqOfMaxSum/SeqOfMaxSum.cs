using System;
class SeqOfMaxSum
{
    static void Main()
    {
        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int sum = 0;
        int beg = 0;
        int end = 0;
        int maxSum = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                sum += array[j];
                if (sum > maxSum)
                {
                    beg = i;
                    end = j;
                    maxSum = sum;
                }
            }
            sum = 0;
        }
        Console.WriteLine("the max sum is :" + maxSum);
        Console.WriteLine("the elements that make the max sum are :");
        for (int i = beg; i <= end; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

