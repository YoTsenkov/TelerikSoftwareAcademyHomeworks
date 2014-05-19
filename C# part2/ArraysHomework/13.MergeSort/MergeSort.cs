using System;
using System.Collections.Generic;
class MergeSort
{
    static void Main()
    {
        List<int> array = new List<int> { 1, 6, 3, 8, 2, 4, 0, 5, 6, 4, 8, 3, 9, 8 };
        List<int> arrayOne = new List<int>();
        List<int> arrayTwo = new List<int>();
        int min;
        int buff;
        int length = array.Count;

        for (int i = 0; i < array.Count / 2; i++)
        {
            arrayOne.Add(array[i]);
        }

        for (int i = 0; i < array.Count / 2 + array.Count % 2; i++)
        {
            arrayTwo.Add(array[i + arrayOne.Count]);
        }

        array.Clear();
        //sorting arrayOne
        for (int i = 0; i < arrayOne.Count; i++)
        {
            min = i;
            for (int j = i + 1; j < arrayOne.Count; j++)
            {
                if (arrayOne[j] < arrayOne[min])
                {
                    min = j;
                }
            }
            buff = arrayOne[i];
            arrayOne[i] = arrayOne[min];
            arrayOne[min] = buff;
        }
        //sorting arrayTwo
        for (int i = 0; i < arrayTwo.Count; i++)
        {
            min = i;
            for (int j = i + 1; j < arrayTwo.Count; j++)
            {
                if (arrayTwo[j] < arrayTwo[min])
                {
                    min = j;
                }
            }
            buff = arrayTwo[i];
            arrayTwo[i] = arrayTwo[min];
            arrayTwo[min] = buff;
        }

        //merge sort both arrays
        for (int i = 0; i < length; i++)
        {
            if (arrayOne.Count == 0)
            {
                array.AddRange(arrayTwo);
                break;
            }
            else if (arrayTwo.Count == 0)
            {
                array.AddRange(arrayOne);
                break;
            }
            if (arrayOne[0] > arrayTwo[0])
            {
                array.Add(arrayTwo[0]);
                arrayTwo.RemoveAt(0);
            }
            else if (arrayOne[0] < arrayTwo[0])
            {
                array.Add(arrayOne[0]);
                arrayOne.RemoveAt(0);
            }
            else if (arrayOne[0] == arrayTwo[0])
            {
                array.Add(arrayOne[0]);
                arrayOne.RemoveAt(0);
                array.Add(arrayTwo[0]);
                arrayTwo.RemoveAt(0);
            }
        }

        foreach (var number in array)
        {
            Console.WriteLine(number);
        }
    }
}

