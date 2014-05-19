using System;
class Program
{
    static void Main()
    {
        char[] array = { 'a', 'b', 'c' };
        char[] secondArray = { 'a', 'b', 'a' };
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < secondArray[i])
            {
                Console.WriteLine("array is first lexi");
            }
            else if (array[i] > secondArray[i])
            {
                Console.WriteLine("secondArray is first lexi");
            }
        }
    }
}


