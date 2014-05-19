using System;
class BinarySearch
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };        
        int beg = 0;
        int end = array.Length;
        int mid = (beg + end) / 2;
        int number = int.Parse(Console.ReadLine());

        for (int i = beg; i < end; i++)
        {
            mid = (beg + end) / 2;

            if (array[i] < number)
            {
                beg = mid + 1;
            }
            else if (array[i] > number)
            {
                end = mid - 1;
            }
            else if (array[i] == number)
            {
                Console.WriteLine("index -> {0}", i);
                break;
            }
        }
    }
}

