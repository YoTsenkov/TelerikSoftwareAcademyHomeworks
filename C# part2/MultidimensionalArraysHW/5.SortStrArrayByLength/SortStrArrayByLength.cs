using System;
class SortStrArrayByLength
{
    static string[] array = new string[] { "a", "abc", "ab", "b", "abcd" };
    static int min;
    static string buff;
    static int index = 0;
    static void SortStrArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            index = i;
            min = array[i].Length;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j].Length < array[i].Length)
                {
                    min = array[j].Length;
                    index = j;
                }
            }
            buff = array[i];
            array[i] = array[index];
            array[index] = buff;
        }
    }
    static void Main()
    {
        SortStrArray();

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}

