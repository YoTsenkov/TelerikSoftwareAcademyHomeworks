using System;
class GreatestOfFive
{
    static void Main()
    {
        int numberOne = int.Parse(Console.ReadLine());
        int biggest = numberOne;
        int number;
        for (int i = 0; i < 4; i++)
        {
            number = int.Parse(Console.ReadLine());
            if (biggest < number)
            {
                biggest = number;
            }
        }
        Console.WriteLine(biggest);
    }
}

