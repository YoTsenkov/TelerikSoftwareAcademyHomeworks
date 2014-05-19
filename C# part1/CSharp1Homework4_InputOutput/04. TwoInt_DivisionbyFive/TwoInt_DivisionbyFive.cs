using System;
class TwoInt_DivisionbyFive
{
    static void Main()
    {
        int count = 0;
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        for (int i = numberOne; i < numberTwo + 1; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

