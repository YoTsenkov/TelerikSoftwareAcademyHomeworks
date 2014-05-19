using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("vuvedete broi elementi za purviq masiv");
        int numberOfElements = int.Parse(Console.ReadLine());
        int[] array = new int[numberOfElements];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("vuvedete broi elementi za vtoriq masiv");
        numberOfElements = int.Parse(Console.ReadLine());
        int[] secondArray = new int[numberOfElements];
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        if (array.Length != secondArray.Length)
        {
            Console.WriteLine("the arrays are NOT equal");
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != secondArray[i])
                {
                    Console.WriteLine("the arrays are NOT equal");
                    break;
                }          
            }
        }
    }
}

