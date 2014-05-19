using System;
class ProductSign
{
    static void Main()
    {
        int numberOne = 1;
        int numberTwo = -1;
        int numberThree = -6;

        if (numberOne > 0 && numberTwo > 0 && numberThree > 0)
        {
            Console.WriteLine("+");
        }
        else if (numberOne < 0 && numberTwo > 0 && numberThree > 0)
        {
            Console.WriteLine("-");
        }
        else if (numberOne < 0 && numberTwo < 0 && numberThree > 0)
        {
            Console.WriteLine("+");
        }
        else if (numberOne < 0 && numberTwo > 0 && numberThree < 0)
        {
            Console.WriteLine("+");
        }
        else if (numberOne > 0 && numberTwo < 0 && numberThree < 0)
        {
            Console.WriteLine("+");
        }
        else if (numberOne > 0 && numberTwo < 0 && numberThree > 0)
        {
            Console.WriteLine("-");
        }
        else if (numberOne > 0 && numberTwo > 0 && numberThree < 0)
        {
            Console.WriteLine("-");
        }
        else if (numberOne < 0 && numberTwo < 0 && numberThree < 0)
        {
            Console.WriteLine("-");
        }
        else if (numberOne == 0 || numberTwo == 0 || numberThree == 0)
        {
            Console.WriteLine("+");
        }
    }
}
