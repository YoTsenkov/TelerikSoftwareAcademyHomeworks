using System;
class BinarySearch
{
    static void Main()
    {
        //declaring the array
        Console.WriteLine("number of array's elements : ");
        int input = int.Parse(Console.ReadLine());
        int[] array = new int[input];

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("enter the element with index {0} -> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        //rest variables
        Console.WriteLine("enter the value you want the number you are searching for to be lesser than :");
        int border = int.Parse(Console.ReadLine());
        int min;
        int buff;
        int maxNumber = 0;
        //sorting the array
        for (int i = 0; i < array.Length; i++)
        {
            min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }
            buff = array[i];
            array[i] = array[min];
            array[min] = buff;
        }
        //searching
        for (int i = 0; i < border; i++)
        {
            buff = Array.BinarySearch(array, i);

            if (buff >= 0)
            {
                maxNumber = array[buff];
            }
        }
        Console.WriteLine("the number you are searching for is : " + maxNumber);
    }
}

