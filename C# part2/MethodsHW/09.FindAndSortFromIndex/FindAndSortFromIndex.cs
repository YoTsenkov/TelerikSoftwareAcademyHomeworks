using System;
class FindAndSortFromIndex
{
    static int[] array = new int[] { 1, 6, 9, 8, 0, 7, 0, 8, 3, 2, 1, 4, 3 };
    static int startndex = int.Parse(Console.ReadLine());
    static int max = int.MinValue;
    static int min = int.MaxValue;
    static int buff;
    static int j;

    static void Sort(int[] array, string order)
    {
        //sorting in descending order
        if (order == "des")
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                max = array[i];

                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > max)
                    {
                        buff = array[i];
                        array[i] = array[j];
                        array[j] = buff;
                        max = array[i];
                    }
                }
            }
        }
            //sorting in ascending order
        else if (order == "asc")
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                min = array[i];

                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        buff = array[i];
                        array[i] = array[j];
                        array[j] = buff;           
                    }
                }
            }
        }
    }
    static void FindMax(int[] array, int index)
    {      
        max = array[index];

        for (j = index + 1; j < array.Length; j++)
        {
            if (array[j] > max)
            {
                max = array[j];
            }
        }        
    }
    static void Main()
    {
        //first method example
        FindMax(array, startndex);
        Console.WriteLine(max);
        //second method example
        Sort(array, "asc");       
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}

