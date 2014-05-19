using System;
class Program
{
    static void Main()
    {
        int[] array = {4,1,1,4,2,3,4,4,1,2,4,9,3};
        int count;
        int countTwo = int.MinValue;
        int number = 0;

        for (int i = 0; i < array.Length; i++)
        {
            count = 1;
            for (int j = i + 1; j < array.Length; j++)
            {
                int el = array[i];
                if (el == array[j])
                {
                    count++;                  
                }
                if (count > countTwo)
                {
                    countTwo = count;
                    number = array[i];
                }
            }
        }
        Console.WriteLine(number);
    }
}

