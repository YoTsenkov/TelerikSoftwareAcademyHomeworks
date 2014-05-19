using System;
class Print_Sum
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number = int.Parse(str);
        str = Console.ReadLine();
        int numberTwo = int.Parse(str);
        str = Console.ReadLine();
        int numberThree = int.Parse(str);
        Console.WriteLine("Sum = {0}", number + numberTwo + numberThree);
    }
}

