using System;
class CalcString
{
    static int sum = 0;
    static void SumOfString(string numbers)
    {
        string[] split = numbers.Split(' ');
        for (int i = 0; i < split.Length; i++)
        {
            sum += int.Parse(split[i]);
        }
        Console.WriteLine("The sum of the numbers is " + sum);
    }
    static void Main()
    {
        Console.WriteLine("Enter the string of numbers on a single line separated by a single space.");
        string numStr = Console.ReadLine();
        SumOfString(numStr);
    }
}

