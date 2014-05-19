using System;
class SumOfTwoInt
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        decimal sum = 1;
        int fac = 1;

        for (int i = 1; i <= n; i++)
        {
            fac = 1;
            for (int j = 1; j <= i; j++)
            {
                fac *= j;
            }
            sum += fac / (decimal)Math.Pow(x, i);
        }
        Console.WriteLine(sum);
    }
}

