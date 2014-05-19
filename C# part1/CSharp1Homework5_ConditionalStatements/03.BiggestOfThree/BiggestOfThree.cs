using System;
class ProBiggestOfThreegram
{
    static void Main()
    {
        int numberOne = 1;
        int numberTwo = 2;
        int numberThree = 3;
        int biggestNumber = numberOne;

        if (numberTwo > biggestNumber)
        {
            biggestNumber = numberTwo;

            if (biggestNumber < numberThree)
            {
                biggestNumber = numberThree;
            }
        }
        else if (numberThree > biggestNumber)
        {
            biggestNumber = numberThree;

            if (biggestNumber < numberTwo)
            {
                biggestNumber = numberTwo;
            }
        }
        Console.WriteLine(biggestNumber);
    }
}

