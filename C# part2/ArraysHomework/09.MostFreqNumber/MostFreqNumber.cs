using System;
class MostFreqNumber
{
    static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int number = 0;
        int count = 1;
        int maxCount = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        number = array[i];
                    }
                }               
            }
            count = 1;
        }
        Console.WriteLine(number + " (" + maxCount + " times" + ")");
    }
}

