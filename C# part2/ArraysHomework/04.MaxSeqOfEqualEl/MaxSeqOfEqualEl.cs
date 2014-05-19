using System;
class MaxSeqOfEqualEl
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 4, 4, 5, 6, 7, 7 };
        int seq = 1;
        int maxSeq = int.MinValue;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i-1])
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

