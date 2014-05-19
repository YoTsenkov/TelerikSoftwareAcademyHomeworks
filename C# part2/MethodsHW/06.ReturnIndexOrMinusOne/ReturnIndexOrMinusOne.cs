using System;
class ReturnIndexOrMinusOne
{
    static int Check(int[] array)
    {
        for (int index = 0; index < array.Length; index++)
        {
            int number = array[index];

            if (index == 0)
            {
                if (number > array[index + 1])
                {
                    return index;
                }
            }
            else if (index == array.Length - 1)
            {
                if (number > array[index - 1])
                {
                    return index;
                }
            }
            else
            {
                if (number > array[index + 1] && number > array[index - 1])
                {
                    return index;
                }
            }
        }
        return -1;
    }
    static void Main()
    {
        int[] array = new int[] { 1, 2, 4, 5, 6, 7, 7, 8, 8 };
        Console.WriteLine(Check(array));
    }
}

