using System;
class Print_GreaterNumber
{
    static void Main()
    {
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is {0}", Math.Max(numberOne, numberTwo));
    }
}

