using System;
class Factoriel
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int min = 0;
        int max = 0;
        int fac = 1;
        if (n > k)
        {
            max = n;
            min = k;
        }
        else if (n < k)
        {
            max = k;
            min = n;
        }

        for (int i = min + 1; i <= max; i++)
        {
            fac = fac * i;
        }
        Console.WriteLine(fac);
    }
}

