using System;
class ExchangeIntValues
{
    static void Main()
    {
        int numberOne = 4;
        int numberTwo = 3;
        int buff = 0;

        if (numberOne > numberTwo)
        {
            buff = numberOne;
            numberOne = numberTwo;
            numberTwo = buff;
        }
        Console.WriteLine(numberOne);
        Console.WriteLine(numberTwo);
    }
}

