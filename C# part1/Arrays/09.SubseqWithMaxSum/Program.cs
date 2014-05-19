using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        int maxSum = int.MinValue;
        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        for (int i = 0; i < array.Length; i++)
        {
            sum = array[i];
            if (maxSum < sum)
            {
                maxSum = sum;
            }
            for (int j = i + 1; j < array.Length; j++)
            {
                sum += array[j];

                if (maxSum < sum)
                {
                    maxSum = sum;
                }
            }
        }
        Console.WriteLine(maxSum);
    }
}

