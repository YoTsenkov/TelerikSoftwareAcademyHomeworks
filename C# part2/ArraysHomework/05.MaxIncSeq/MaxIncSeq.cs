using System;
class MaxIncSeq
{
    static void Main()
    {
        int[] array = { 3, 2, 3, 4, 2, 2, 4 };
        int seq = 1;
        int maxSeq = int.MinValue;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1] + 1)
            {
                seq++;
                if (seq > maxSeq)
                {
                    maxSeq = seq;
                }
            }
            else
            {
                seq = 1;
            }
        }
        Console.WriteLine(maxSeq);
    }
}

