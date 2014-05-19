using System;
using System.Collections.Generic;
using System.Linq;

class MaxSubsequence
{

    private static List<int> GetMaxSubsequence(IList<int> numbers)
    {
        int bestStartIndex = 0;
        int bestEndIndex = 0;
        int sequnceLength = 1;
        int maxSequenceLength = 0;
        List<int> result = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            int startIndex = i;

            for (int k = startIndex + 1; k < numbers.Count; k++)
            {
                if (numbers[startIndex] == numbers[k])
                {
                    sequnceLength++;
                }
                else
                {
                    int endIndex = k;
                    if (sequnceLength > maxSequenceLength)
                    {
                        maxSequenceLength = sequnceLength;
                        bestStartIndex = startIndex;
                        bestEndIndex = endIndex;
                    }
                    sequnceLength = 1;

                    break;
                }
            }
        }

        for (int i = bestStartIndex; i < bestEndIndex; i++)
        {
            result.Add(numbers[i]);
        }

        return result;
    }

    static void Main()
    {
        List<int> numbers = new List<int>() { 1, 2, 2, 2, 2, 2, 3, 3, 4, 4, 4, 5, 7, 0 };

        var maxSubsequence = GetMaxSubsequence(numbers);

        Console.Write(string.Join(", ", maxSubsequence));
    }

}

