using System;
class ReturnMinandMaxNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        int number;

        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());
            if (number > max)
            {
                max = number;
            }
            else if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine(max);
        Console.WriteLine(min);

    }
}

