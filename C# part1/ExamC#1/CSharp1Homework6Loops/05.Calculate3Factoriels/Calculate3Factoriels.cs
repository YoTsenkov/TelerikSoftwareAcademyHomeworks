using System;
using System.Numerics;
class Calculate3Factoriels
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger facN = 1;
        BigInteger facK = 1;
        BigInteger fac = 1;
        BigInteger result;

        for (int i = 1; i <= n; i++)
        {
            facN *= i;
        }
        for (int i = 1; i <= k; i++)
        {
            facK *= i;
        }
        for (int i = 1; i < Math.Abs(k - n); i++)
        {
            fac *= i;
        }
        result = (facN * facK) / fac;
        Console.WriteLine(result);
    }
}

