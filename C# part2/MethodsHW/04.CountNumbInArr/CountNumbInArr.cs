using System;
class CountNumbInArr
{
    static int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 4, 2, 7, 5, 4, 7, 8, 9 };
    static int count = 0;
    static void Count(int number)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                count++;
            }
        }
        Console.WriteLine("The number you have entered appears {0} times in the array.", count);
    }
    static void Main()
    {
        Console.WriteLine("Enter the number you want to count.");
        int input = int.Parse(Console.ReadLine());
        Count(input);

    }
}

