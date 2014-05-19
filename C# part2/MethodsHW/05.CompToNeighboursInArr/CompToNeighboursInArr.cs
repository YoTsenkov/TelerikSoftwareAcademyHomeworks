using System;
class CompToNeighboursInArr
{
    static void Check(int[] array, int index)
    {
        int number = array[index];

        if (index == 0)
        {
            if (number > array[index + 1])
            {
                Console.WriteLine("The number at position {0} IS bigger than its neighbours", index + 1);
                return;
            }
            else
            {
                Console.WriteLine("The number at position {0} is NOT bigger than its neighbours", index + 1);
                return;
            }
        }
        else if (index == array.Length - 1)
        {
            if (number > array[index - 1])
            {
                Console.WriteLine("The number at position {0} IS bigger than its neighbours", index + 1);
                return;
            }
            else
            {
                Console.WriteLine("The number at position {0} is NOT bigger than its neighbours", index + 1);
                return;
            }
        }
        else
        {
            if (number > array[index + 1] && number > array[index - 1])
            {
                Console.WriteLine("The number at position {0} IS bigger than its neighbours", index + 1);
                return;
            }
            else
            {
                Console.WriteLine("The number at position {0} is NOT bigger than its neighbours", index + 1);
                return;
            }
        }
    }
    static void Main()
    {
        int[] array = new int[] { 1, 2, 4, 5, 6, 2, 3, 4, 2 };
        Console.WriteLine("Enter the position you wish to check for.");
        int pos = int.Parse(Console.ReadLine());
        Check(array, (pos - 1));
    }
}

