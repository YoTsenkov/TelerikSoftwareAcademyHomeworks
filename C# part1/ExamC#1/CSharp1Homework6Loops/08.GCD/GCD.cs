using System;
class GCD
{
    static void Main()
    {
        int numberOne = 14;
        int numberTwo = -4;
        int max = int.MinValue;
        int min = int.MaxValue;
        int reminder;

        if (numberOne > numberTwo)
        {
            max = numberOne;
            min = numberTwo;
        }
        else
        {
            max = numberTwo;
            min = numberOne;
        }

        while (true)
        {
            reminder = max % min;
            if (reminder == 0)
            {
                Console.WriteLine(min);
                break;
            }
            max = min;
            min = reminder;
        }
    }
}

