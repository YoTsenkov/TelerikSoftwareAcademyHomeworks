using System;
class Program
{
    static void Main()
    {
       //string input = Console.ReadLine();
       //int a = int.Parse(input);
       //string b = Convert.ToString(a, 2);
       //int c = int.Parse(b);

        int one = int.Parse(Convert.ToString(int.Parse(Console.ReadLine()), 2));
        Console.WriteLine(one);
    }
}

