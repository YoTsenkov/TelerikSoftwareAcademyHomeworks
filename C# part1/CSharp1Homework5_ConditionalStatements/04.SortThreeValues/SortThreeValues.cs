using System;
class ProgSortThreeValuesram
{
    static void Main()
    {
        int numberOne = 3;
        int numberTwo = 6;
        int numberThree = 5;

        if (numberOne > numberTwo && numberOne > numberThree)
        {
            Console.WriteLine(numberOne);
            if (numberTwo > numberThree)
            {
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberThree);
            }
            else
            {
                Console.WriteLine(numberThree);
                Console.WriteLine(numberTwo);
            }
        }
        else if (numberTwo > numberOne && numberTwo > numberThree)
        {
            Console.WriteLine(numberTwo);
            if (numberOne > numberThree)
            {
                Console.WriteLine(numberOne);
                Console.WriteLine(numberThree);
            }
            else
            {
                Console.WriteLine(numberThree);
                Console.WriteLine(numberOne);
            }
        }
        else if (numberThree > numberOne && numberThree > numberTwo)
        {
            Console.WriteLine(numberThree);
            if (numberOne > numberTwo)
            {
                Console.WriteLine(numberOne);
                Console.WriteLine(numberTwo);
            }
            else
            {
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberOne);
            }
        }
    }
}

