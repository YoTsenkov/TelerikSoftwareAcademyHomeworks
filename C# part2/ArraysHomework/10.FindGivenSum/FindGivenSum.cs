using System;
class FindGivenSum
{
    static void Main()
    {
        int[] array = { 4, 3, 1, 4, 2, 5, 8 };
        int sum = int.Parse(Console.ReadLine());
        int tempSum = 0;
        int beg = 0;
        int end = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                tempSum += array[j];
                if (tempSum == sum)
                {
                    beg = i;
                    end = j;
                }
            }
            tempSum = 0;
        }

        Console.WriteLine("the elements that make the given sum are : ");
        for (int i = beg; i <= end; i++)
        {

            Console.WriteLine(array[i]);
        }
    }
}

