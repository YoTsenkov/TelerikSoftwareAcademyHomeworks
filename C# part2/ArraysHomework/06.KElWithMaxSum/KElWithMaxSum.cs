using System;

class KElWithMaxSum
{
    static void Main()
    {
         
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int sum = 0;
        int beg = 0;
        int end = 0;
        int maxSum = int.MinValue;
        for (int i = 0; i < array.Length; i++)
			{
			 array[i] = int.Parse(Console.ReadLine());
			}

        for (int i = 0; i < array.Length - 2; i++)
        {
            for (int j = i; j < i + k; j++)
            {
                sum += array[j];
                if (sum > maxSum)
                {
                    end = j;
                    beg = j - 2;
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

