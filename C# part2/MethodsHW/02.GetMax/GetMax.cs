using System;
class GetMax
{
    static int bigger = 0;
    static int GetMaxx(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return bigger = firstNumber;
        }
        else if (firstNumber < secondNumber)
        {
            return bigger = secondNumber;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        GetMaxx(a, b);
        GetMaxx(bigger, c);
        Console.WriteLine();
        Console.WriteLine(bigger);
    }
}

