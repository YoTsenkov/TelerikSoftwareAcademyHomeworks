using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int k = int.Parse(Console.ReadLine());
        int sum = 0;
        int maxSum = 0;
        int add = 0;

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 3; i++)
        {
            sum = array[i + add] + array[i + add + 1] + array[i + add + 2];
            add++;
            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }
        Console.WriteLine(maxSum);
    }
}

