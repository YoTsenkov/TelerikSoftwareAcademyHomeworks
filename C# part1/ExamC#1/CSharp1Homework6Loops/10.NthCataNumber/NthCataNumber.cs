using System;
using System.Numerics;
class NthCataNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger number;
        BigInteger fac = 1;
        BigInteger facOne = 1;
        BigInteger facTwo = 1;

        for (int i = 1; i <= 2 * (n - 1); i++)
        {
            fac *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            facOne *= i;
        }
        for (int i = 1; i <= n - 1; i++)
        {
            facTwo *= i;
        }
        number = fac / (facOne * facTwo);
        Console.WriteLine(number);
    }
}

