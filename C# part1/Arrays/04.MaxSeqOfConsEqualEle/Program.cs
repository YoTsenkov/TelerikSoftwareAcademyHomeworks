using System;
class Program
{
    static void Main()
    {
        int[] array = { 1, 1, 1, 1, 1, 2, 3, 3, 3, 5, 5, 5, 5, 5, 5 };
        int max = 0;
        int count = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                count++;
                if (count > max)
                {
                    max = count;
                }

            }
            else if (array[i] != array[i - 1])
            {
                count = 1;
            }
        }
        Console.WriteLine(max);
    }
}

