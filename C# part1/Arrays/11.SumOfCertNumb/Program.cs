using System;
class Program
{
    static void Main()
    {
        int[] array = { 4, 3, 1, 4, 2, 5, 8 };
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                sum += array[j];

                if (sum == 11)
                {
                    for (int k = i; k <= j; k++)
                    {
                        Console.WriteLine(array[k]);
                    }
                }
            }
        }
    }
}

