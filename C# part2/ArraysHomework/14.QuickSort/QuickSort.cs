using System;
using System.Collections.Generic;
class QuickSort
{
    static List<int> list = new List<int> { 5, 7, 1, 3, 2, 9, 0, 3, 7, 2, 4, 6 };
    static void QuickSort(List<int> array)
    {
        int pivot = 0;
        List<int> less = new List<int>();
        List<int> equal = new List<int>();
        List<int> greater = new List<int>();

        if (array.Count > 1)
        {
            pivot = array[array.Count / 2];
        }
        else
        {
            return;
        }

        foreach (var number in array)
        {
            if (number < pivot)
            {
                less.Add(number);
            }
            else if (number == pivot)
            {
                equal.Add(number);
            }
            else if (number > pivot)
            {
                greater.Add(number);
            }
        }

        QuickSort(less);
        QuickSort(greater);
        array.Clear();
        array.AddRange(less);
        array.AddRange(equal);
        array.AddRange(greater);
    }
    static void Main()
    {
        QuickSort(list);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}

